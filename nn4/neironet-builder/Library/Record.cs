using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    [Serializable]
    public class Record
    {
        public int numberLayer;
        public int numberNeuron;
        public int numberWeight;
        public double min;
        public double max;
        public double value;

        public Record(int layer, int neuron)
        {
            numberLayer = layer;
            numberNeuron = neuron;
        }
        public Record(int layer, int neuron, int weight)
        {
            numberLayer = layer;
            numberNeuron = neuron;
            numberWeight = weight;
        }
        public Record()
        {

        }
    }
}
