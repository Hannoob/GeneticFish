using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fish
{
    public class Fish
    {
        public static List<Fish> population = new List<Fish>();
        private Bitmap map;
        public static Random random = new Random(55215);
        public static int HungerRate = 75;
        public static int ReproductionCost = 2;
        public static double MovementCost = 0;//%
        public static int MaxPopulation = 500;
        public static double DeathSpawnProb = 100;
        public static double DeathSpawnVal = 90;

        public Genome Gene;
        public int viewAngle { get; set; }
        public int viewDistance { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public Color color { get; set; }
        public int Generation { get; set; }
        public Brain Brain;
        
        public Guid id { get; set; }
        public int Direction { get; set; }
        public Point Position { get; set; }
        public double Life { get; set; }
        public int Age { get; set; }

        public Fish(int x, int y, int life, Genome genome, int gen = 0)
        {
            Life = life;
            Direction = random.Next(0,360);
            Age = 0;
            Position = new Point(x, y);

            Gene = genome;
            Brain = new Brain(Gene);
            Speed = (int)Math.Round(Gene.extractSpeed());
            Size = 1 + (int)Math.Round(Gene.extractSize());
            viewAngle = (int)Math.Round(Gene.extractAngled());
            viewDistance = (int)Math.Round(Gene.extractDist());
            color = Gene.extractColor();
            Generation = gen;
        }

        public Fish() : this(50,50,500,new Genome()){}

        public void Move(int roundNumber)
        {
            Age++;//Age

            if (roundNumber % HungerRate == 0)//Hunger
                Life = Life-Size;

            var vision = new List<Color>(); 
            vision = Observe();

            var result = Brain.nextMove(Age, Life, vision);
            //Move, Rotate, Spawn,
            //Move
            Forward(result[0]);

            //Turn
            Turn((int)(360*result[1]));

            //Spawn
            if ((result[2] > 0) && (result[2] < 1))//
                Spawn((int)(result[2]*Life));

            Eat();
        }

        public List<Color> Observe(int count = 10)
        {
            var result = new List<Color>();
            double step = (double)(viewAngle * 2) / count;
            for (double i = -viewAngle; i < viewAngle; i += step)
            {
                var x = Position.X + viewDistance * Math.Cos(toGrad(Direction + i));
                var y = Position.Y + viewDistance * Math.Sin(toGrad(Direction + i));
                var buff = 5;
                var w = map.Width;
                var h = map.Height;
                //x = (x <= buff || x >= w - buff) ? (x + 2*w) % w : x;
                //y = (y <= buff || y >= h - buff) ? (x + 2*h) % h : y;
                x = (x < buff) ? buff : x;
                x = (x > w - buff) ? w - buff : x;
                y = (y < buff) ? buff : y;
                y = (y > h - buff) ? h - buff : y;
                result.Add(map.GetPixel((int)x, (int)y));
            }
            
            return result.Take(count).ToList();
        }

        public void Forward(double power = 1)
        {
            var x = Position.X + (int)(power * Speed * Math.Cos(toGrad(Direction)));
            var y = Position.Y + (int)(power * Speed * Math.Sin(toGrad(Direction)));

            Life = Life - Math.Abs((double)(Size) * (MovementCost/100) * power * Speed);
            Position = new Point(x, y);
        }

        public void Turn(int angle)
        {
            while (Direction < 0)
            {
                Direction += 360;
            }
            Direction = (Direction + 360 + angle) % 360;
        }

        private double toGrad(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        private void Spawn(int lifeGift = 20)//Spawn a child fish
        {
            //It costs life to spawn children
            if ((Life - (Size*(ReproductionCost/100) + lifeGift) > 0)&& (population.Count < MaxPopulation))
            {
                //Generate new Chromosome
                var chrom = new Genome(Gene);

                //lifeGift = lifeGift;
                Life = Life - (lifeGift + ((int)chrom.extractSize()*(ReproductionCost/100)));

                var x = random.Next(-1, +1);
                var y = random.Next(-1, +1);
                //Give birth to new child
                var child = new Fish(Position.X + Size*x, Position.Y + Size*y, lifeGift + (int)chrom.extractSize(), chrom, Generation + 1);
                child.map = (Bitmap)this.map.Clone();
            
                population.Add(child);
            }
        }

        private void Eat()
        {
            var prox = Food.food.Where(bite =>
                (bite.Position.X <= Position.X + Size) && (bite.Position.X >= Position.X - Size) &&
                (bite.Position.Y <= Position.Y + Size) && (bite.Position.Y >= Position.Y - Size))
                .ToList();

            Life = Life + prox.Sum(bite => bite.Nutrition);

            prox.ToList().ForEach(f => Food.food.Remove(f));
        }

        public bool Die()
        {
            if (Life < 1)
            {
                if((random.Next(0, 100) < DeathSpawnProb) && (Size > 1))
                    Food.food.Add(
                        new Food(Position.X, Position.Y, (int)(Size*(DeathSpawnVal/100)))
                    );//Making this bigger creates bigger cells
                return true;
            }
            return false;
        }

        public void setMap(Bitmap Map)
        {
            this.map = (Bitmap)Map.Clone();
        }
    }
}
