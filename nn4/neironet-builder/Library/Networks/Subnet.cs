using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Neural
{
    public class Subnet
    {
        private Network network;
        public List<String> inputAssosiated;
        public List<String> outputAssosiated;
        public List<double> res;
        public double quality = 0.0;
        public double probabilistic = 0.0;
        public int[] topology;
        public static int _ID = 0;
        public int ID;

        public Subnet(Network network)
        {
            _ID++;
            this.ID = _ID;
            this.network = network;
            this.topology = new int[this.network.Layers.Length];

            for (int layer = 0; layer < this.network.Layers.Length; layer++)
            {
                topology[layer] = this.network.Layers[layer].Neurons.Length;
            }
            

        }

        public void Compute(double[] input)
        {
            res = this.network.Compute(input).ToList();
        }


        public Network Network 
        {
            get { return this.network; }
        }



    }
}
