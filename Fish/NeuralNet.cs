using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish
{
    public class NeuralNet
    {
        public List<Layer> layers = new List<Layer>();

        public NeuralNet(List<List<List<double>>> weights)
        {
            Enumerable.Range(0, weights.Count()).ToList().ForEach(i => layers.Add(new Layer(weights[i])));

            Enumerable.Range(0, layers.Count() - 1).ToList().ForEach(i =>
                 layers[i].perceptrons.ForEach(perc =>
                     perc.Children = layers[i + 1].perceptrons
                )
            );
        }

        public List<double> activate(List<double> inputs)
        {
            //Input Layer
            layers[0].perceptrons.ForEach(p => p.Inputs.AddRange(inputs));
            
            //Hidden
            layers.ForEach(layer => layer.activate());

            //Output
            var output = layers.Last().perceptrons
                            .Select(perceptron => perceptron.output)
                            .ToList();

            return output;
        }
    }

    public class Layer
    {
        public List<Perceptron> perceptrons = new List<Perceptron>();

        public Layer(List<List<double>> weights)
        {
            weights.ForEach(perceptronWeightList => 
                perceptrons.Add(new Perceptron(perceptronWeightList))
            );
        }

        public void activate()
        {
            perceptrons.ForEach(p => p.Activate());
        }
    }

    public class Perceptron
    {
        public List<double> Inputs = new List<double>();
        public List<double> Weights = new List<double>();
        public List<Perceptron> Children = new List<Perceptron>();
        public double output = 0;

        public Perceptron(List<double> weigths)
        {
            Weights = weigths;
        }

        public void Activate()
        {
            var input = Enumerable.Range(0, Inputs.Count() - 1)
                        .Select(i => Inputs[i] * Weights[i])
                        .Sum();

            //Linear
            //output = input;
            //Sigmoid
            output = Math.Tanh(input);

            Children.ForEach(child => child.Inputs.Add(output));

            Inputs.Clear();
        }
    }
}
