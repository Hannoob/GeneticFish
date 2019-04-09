using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Fish
{
    public partial class Form1 : Form
    {
        private Random random = new Random(55454);
        public static int roundNumber = 0;
        private Image backgroundImage;

        private Fish watchedFish;

        private bool paused = false;
        private double FoodSpawnProb = 100;
        private int FoodSpawnRate = 2;
        private int MaxFood = 200;
        private double FoodSpeedX = 1;
        private double FoodSpeedY = 1;

        private int MinPopulation = 20;
        private int MaxPopulation = 500;
        private int PopSpawnRate = 2;
        private double PopSpawnProb = 1;

        private double MutationProb = 1;
        private int MutationRate = 5;

        private int InitialLife = 50;
        private int HungerRate = 10;
        private int ReproductionCost = 2;

        private int Eyes = 10;

        public Form1()
        {
            InitializeComponent();

            backgroundImage = Image.FromFile(@"assets/background.png");

            //Draw initial map
            var output = new Bitmap(pbBowl.Width, pbBowl.Height);
            using (Graphics g = Graphics.FromImage(output))
            {
                g.Clear(Color.FromArgb(255, 35, 29, 122));
            }

            InitialLife = (int)spnInitialLife.Value;
            Fish.population = new List<Fish>();
            for (int i = 0; i < 250; i++)
            {
                var fish = new Fish(random.Next(pbBowl.Width), random.Next(pbBowl.Height), InitialLife, new Genome());
                fish.setMap((Bitmap)output.Clone());
                Fish.population.Add(fish);
                Food.Spawn(pbBowl.Width, pbBowl.Height);
            }

            Food.SpawnRate = (int)spnFoodSpawnRate.Value;
            Food.SpawnProb = (int)spnFoodProb.Value;
            Food.MaxFood = (int)spnMaxFood.Value;
            FoodSpeedX = (double)spnFoodSpeedX.Value;
            FoodSpeedY = (double)spnFoodSpeedY.Value;

            MinPopulation = (int)spnMinPopulation.Value;
            Fish.ReproductionCost = (int)spnReproductionCost.Value;
            Fish.MovementCost = (int)spnMovementCost.Value;
            Fish.DeathSpawnProb = (double)spnDeathSpawnProb.Value;
            Fish.DeathSpawnVal = (double)spnDeathSpawnVal.Value;
            Fish.HungerRate = (int)spnHungerRate.Value;
            Fish.MaxPopulation = (int)spnMaxPopulation.Value;

            PopSpawnProb = (double)spnPopSpawnProb.Value;
            Genome.MutationProb = (double)spnMutationProb.Value;
            Genome.MutationRate = (int)spnMutationRate.Value;

            timer1.Interval = 1;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void updateBowl()
        {
            var output = drawBowl();

            Food.Spawn(pbBowl.Width, pbBowl.Height);

            //Move fish
            var count = Fish.population.Count;
            for (int i = 0; i < count; i++)
            {
                var fish = Fish.population[i];
                fish.Move(roundNumber);
                fish.Position = correct(fish.Position);
            }
            Fish.population.RemoveAll(fish => fish.Die());//Destroy all dead fish
            Fish.population.ForEach(fish => fish.setMap((Bitmap)output.Clone()));

            //Improve drift
            Food.Drift(FoodSpeedX,FoodSpeedY);

            Food.food.ForEach(f => f.Position = correct(f.Position));

            if (Fish.population.Count < MinPopulation)
            {
                //roundNumber = 0;
                for (int i = 0; i < PopSpawnRate; i++)
                {
                    var fish = new Fish(random.Next(pbBowl.Width), random.Next(pbBowl.Height), InitialLife, new Genome());
                    fish.setMap((Bitmap)output.Clone());
                    Fish.population.Add(fish);
                }
            }
            if (random.Next(100) < PopSpawnProb)
            {
                var fish = new Fish(random.Next(pbBowl.Width), random.Next(pbBowl.Height), InitialLife, new Genome());
                fish.setMap((Bitmap)output.Clone());
                Fish.population.Add(fish);
            }
        }

        private Bitmap drawBowl()
        {
            var output = new Bitmap(pbBowl.Width, pbBowl.Height);
            using (Graphics g = Graphics.FromImage(output))
            {
                //g.Clear(Color.FromArgb(255, 35, 29, 122));
                g.DrawImage(backgroundImage, 0, 0, pbBowl.Width, pbBowl.Height);
                //Draw Fish
                Fish.population.ForEach(fish =>
                {
                    var alpha = (int)Math.Min(Math.Abs(fish.Life), 255);
                    var border = new Pen(Color.FromArgb(alpha, Color.Yellow));
                    var body = new SolidBrush(Color.FromArgb(128, fish.color));

                    g.DrawEllipse(border, fish.Position.X - fish.Size, fish.Position.Y - fish.Size, fish.Size * 2, fish.Size * 2);
                    g.FillEllipse(body, fish.Position.X - fish.Size, fish.Position.Y - fish.Size, fish.Size * 2, fish.Size * 2);

                    var eyes = new Pen(Color.FromArgb(128, Color.Green));
                    double step = (double)(fish.viewAngle * 2) / 10;
                    for (double i = -fish.viewAngle; i < fish.viewAngle; i += step)
                    {
                        var x = fish.Position.X + fish.viewDistance * Math.Cos(toGrad(fish.Direction + i));
                        var y = fish.Position.Y + fish.viewDistance * Math.Sin(toGrad(fish.Direction + i));
                        g.DrawLine(eyes, fish.Position, new Point((int)x, (int)y));
                    }
                });
                //Draw Food
                var edge = new Pen(Color.FromArgb(32,Color.LightBlue));
                var flesh = new SolidBrush(Color.FromArgb(64, Color.LightBlue));
                Food.food.ForEach(bite =>
                {
                    g.FillEllipse(flesh, bite.Position.X - bite.Nutrition, bite.Position.Y - bite.Nutrition, (int)(bite.Nutrition * 2), (int)(bite.Nutrition * 2));
                    g.DrawEllipse(edge, bite.Position.X - bite.Nutrition, bite.Position.Y - bite.Nutrition, (int)(bite.Nutrition * 2), (int)(bite.Nutrition * 2));
                });

                //Draw stats
                if (roundNumber++ > 10000000)
                    roundNumber = 0;
                var maxGen = Fish.population.Max(f => f.Generation);
                var s = "Population Size: " + Fish.population.Count() + "\n" + "Round Number: " + roundNumber + "\nMax Gen: " + maxGen;
                g.DrawString(s, new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.White), new Point(0, 0));
            }

            pbBowl.BackgroundImage = (Bitmap)output.Clone();
            return output;
        }

        private void drawFish()
        {
            pbFishDetail.Parent = pbBowl;
            pbFishDetail.BackColor = Color.Transparent;
            var image = new Bitmap(pbFishDetail.Width, pbFishDetail.Height);
            using (var g = Graphics.FromImage(image))
            {
                g.Clear(Color.FromArgb(0,Color.Black));

                if (watchedFish != null)
                {
                    g.Clear(Color.FromArgb(200, Color.Black));

                    var layerDist = pbFishDetail.Width / (watchedFish.Brain.brain.layers.Count() + 2);
                    var neuronSize = 3;
                    
                    #region DrawInputLayer
                    var inputLayerCount = watchedFish.Brain.brain.layers[0].perceptrons[0].Weights.Count();
                    var neuronDist = pbFishDetail.Height / (inputLayerCount + 1);
                    for (int n = 0; n < inputLayerCount; n++)
                    {
                        var y = neuronDist * (n + 1);
                        g.DrawEllipse(new Pen(Color.Crimson), new Rectangle(layerDist, y, neuronSize, neuronSize));
                    }

                    #endregion

                    for (int l = 0; l < watchedFish.Brain.brain.layers.Count(); l++)
                    {
                        var layer = watchedFish.Brain.brain.layers[l];
                        var x = layerDist * (l + 2);
                        neuronDist = pbFishDetail.Height / (layer.perceptrons.Count() + 1);
                        for (int n = 0; n < layer.perceptrons.Count; n++)
                        {
                            var perceptron = layer.perceptrons[n];
                            var y = neuronDist * (n + 1);
                            g.DrawEllipse(new Pen(Color.Crimson),new Rectangle(x,y, neuronSize, neuronSize));

                            #region drawInputs
                            var inputDist = pbFishDetail.Height / (perceptron.Weights.Count() + 1);
                            var xi = layerDist * (l + 1);
                            var maxW = perceptron.Weights.Max(w => Math.Abs(w));
                            for (int i = 0; i < perceptron.Weights.Count(); i++)
                            {
                                var W = perceptron.Weights[i];
                                var yi = inputDist * (i + 1);

                                var alpha = (int)((W / maxW) * 255);
                                var col = (alpha > 0) ? Color.FromArgb(alpha, Color.Blue) : Color.FromArgb((int)Math.Abs(alpha), Color.Red);
                                
                                var pen = new Pen(col);
                                g.DrawLine(pen, x, y, xi, yi);
                            }

                            #endregion
                        }
                    }

                    var s = "Gen: " + watchedFish.Generation + "\nHealth: " + watchedFish.Life + "\nAge: " + watchedFish.Age;
                    g.DrawString(s, new Font(FontFamily.GenericSansSerif, 10), new SolidBrush(Color.White), new Point(0, 0));
                }
            }
            pbFishDetail.BackgroundImage = image;
        }

        private Point correct(Point point)
        {
            var buff = 0;
            var x = point.X;
            var y = point.Y;
            x = (x <= buff || x >= pbBowl.Width - buff) ? (x + pbBowl.Width) % pbBowl.Width : x;
            y = (y <= buff || y >= pbBowl.Height - buff) ? (y + pbBowl.Height) % pbBowl.Height : y;

            return new Point(x, y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateBowl();
            pbBowl.Refresh();
            //drawFish();
        }

        #region Properties
        private void btnPause_Click(object sender, EventArgs e)
        {
            paused = !paused;
            if (paused)
                timer1.Stop();
            else
                timer1.Start();

        }

        private void spnSpeed_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)spnSpeed.Value;
        }

        private void spnFoodProb_ValueChanged(object sender, EventArgs e)
        {
            Food.SpawnProb = (int)spnFoodProb.Value;
        }

        private void spnFoodSpawnRate_ValueChanged(object sender, EventArgs e)
        {
            Food.SpawnRate = (int)spnFoodSpawnRate.Value;
        }

        private void spnMaxFood_ValueChanged(object sender, EventArgs e)
        {
            Food.MaxFood = (int)spnMaxFood.Value;
        }

        private void spnMinPopulation_ValueChanged(object sender, EventArgs e)
        {
            MinPopulation = (int)spnMinPopulation.Value;
        }

        private void spnMaxPopulation_ValueChanged(object sender, EventArgs e)
        {
            MaxPopulation = (int)spnMaxPopulation.Value;
            Fish.MaxPopulation = MaxPopulation;
        }

        private void spnPopSpawnProb_ValueChanged(object sender, EventArgs e)
        {
            PopSpawnProb = (double)spnPopSpawnProb.Value;
        }

        private void spnMutationProb_ValueChanged(object sender, EventArgs e)
        {
            Genome.MutationProb = (double)spnMutationProb.Value;
        }

        private void spnMutationRate_ValueChanged(object sender, EventArgs e)
        {
            Genome.MutationRate = (int)spnMutationRate.Value;
        }

        private void spnReproductionCost_ValueChanged(object sender, EventArgs e)
        {
            Fish.ReproductionCost = (int)spnReproductionCost.Value;
        }

        private void propMovementCost_ValueChanged(object sender, EventArgs e)
        {
            Fish.MovementCost = (int)spnMovementCost.Value;
        }

        private void spnDeathSpawnProb_ValueChanged(object sender, EventArgs e)
        {
            Fish.DeathSpawnProb = (double)spnDeathSpawnProb.Value;
        }

        private void spnDeathSpawnVal_ValueChanged(object sender, EventArgs e)
        {
            Fish.DeathSpawnVal = (double)spnDeathSpawnVal.Value;
        }

        private void spnFoodSpeedX_ValueChanged(object sender, EventArgs e)
        {
            FoodSpeedX = (double)spnFoodSpeedX.Value;
        }

        private void spnFoodSpeedY_ValueChanged(object sender, EventArgs e)
        {
            FoodSpeedY = (double)spnFoodSpeedY.Value;
        }

        private void spnHungerRate_ValueChanged(object sender, EventArgs e)
        {
            Fish.HungerRate = (int)spnHungerRate.Value;
        }

        private void spnInitialLife_ValueChanged(object sender, EventArgs e)
        {
            InitialLife = (int)spnInitialLife.Value;
        }
        #endregion

        private void pbBowl_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            var possible = Fish.population.Where(f =>
                (f.Position.X - f.Size < coordinates.X)&&
                (f.Position.X + f.Size > coordinates.X)&&
                (f.Position.Y - f.Size < coordinates.Y)&&
                (f.Position.Y + f.Size > coordinates.Y)
            ).ToList();

            if (possible.Count() > 0)
                watchedFish = possible[random.Next(possible.Count() - 1)];
            else
                watchedFish = null;
            drawFish();
        }

        private double toGrad(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
