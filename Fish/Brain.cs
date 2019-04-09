using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    //A brain has 32 inputs : Life + view(10) + constant 1 + age
    public class Brain
    {
        public NeuralNet brain { get; set; }

        public static List<int> defaultBrainStructure = new List<int>() {33, 8, 5, 3 };

        public Brain()
        {
            var weights = defaultBrainStructure.Select(layer =>
                Enumerable.Range(0, layer).Select(neuron =>
                     Enumerable.Range(0, layer).Select(w => (double)Fish.random.Next(-5,5)).ToList()
                    ).ToList()
                ).ToList();

            brain = new NeuralNet(weights);
        }

        public Brain(Genome genome)
        {
            var weights = genome.extractBrain();
            brain = new NeuralNet(weights);
        }

        public List<double> nextMove(int age, double life, List<Color> vision)
        {
            var rgb = vision.SelectMany(col => new List<double> { Convert.ToInt32(col.R), Convert.ToInt32(col.R), Convert.ToInt32(col.R) }).ToList();
            var inputs = rgb;
            inputs.Add(life);
            inputs.Add(age);
            inputs.Add(1);
            var result = brain.activate(inputs.Select(i => (double)i).ToList());
            return result;
        }
    }
}
