using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    //0..3 = Speed, Size, Dist, Angle
    public class Genome
    {
        public static double MutationProb = 5;
        public static double MutationRate = 10;

        private List<double> genome;

        public Genome()
        {
            var total = Brain.defaultBrainStructure.Skip(1).ToList().Aggregate(Brain.defaultBrainStructure[0], (mem,next) => mem * next);
            var length = total + 4;
            genome = Enumerable.Range(0, length).Select(i => (double)Fish.random.Next(-5,5)).ToList();
        }
        //Genome
        public Genome(Genome parent) : this()
        {
            var len = Math.Min(parent.genome.Count(), genome.Count());
            Enumerable.Range(0, len).ToList().ForEach(i => genome[i] = parent.genome[i]);

            if (Fish.random.Next(100) < MutationProb)
            {
                //HillClimbing
                for (int i = 0; i < Fish.random.Next(0,genome.Count()*(int)(MutationRate/100)); i++)
                {
                    var t = Fish.random.Next(genome.Count());
                    genome[t] = genome[t] + Fish.random.Next(-1, 1) * Fish.random.NextDouble();
                }
                //Random
                /*for (int i = 0; i < Fish.random.Next(0, genome.Count() * (int)(MutationRate / 200)); i++)
                {
                    var t = Fish.random.Next(genome.Count());
                    genome[t] = Fish.random.Next(-5, 5) * Fish.random.NextDouble();
                }*/
            }

        }

        public Color extractColor()
        {
            var counter = genome.Count() / 3;
            var r = Math.Abs(Enumerable.Range(0, (int)counter).Select(i => genome[i]).Sum()) % 255;
            var g = Math.Abs(Enumerable.Range((int)counter, (int)counter).Select(i => genome[i]).Sum()) % 255;
            var b = Math.Abs(Enumerable.Range((int)counter*2, (int)counter).Select(i => genome[i]).Sum()) % 255;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }

        public double extractSpeed()
        {
            return genome[0];
        }

        public double extractSize()
        {
            return 1 + Math.Abs(genome[1]);
        }

        public double extractDist()
        {
            return extractSize() + genome[2];
        }

        public double extractAngled()
        {
            return 5 + Math.Abs(genome[3])*5;
        }

        public List<List<List<double>>> extractBrain()
        {
            List<double> brainList;
            brainList = genome.Skip(4).ToList();

            var LayerList = Enumerable.Range(1, Brain.defaultBrainStructure.Count - 1)//For each layer
                .Select(layer =>
                    Enumerable.Range(0,Brain.defaultBrainStructure[layer])//For each perceptron in that layer
                    //Take your weigths from the list
                    .Select(perceptron =>
                        {
                            var count = Brain.defaultBrainStructure[layer - 1];
                            var start = perceptron * count;
                            return Enumerable.Range(start, count).Select(i => brainList[i]).ToList();
                        } 
                    ).ToList()
                ).ToList();

            return LayerList;
        }
    }
}
