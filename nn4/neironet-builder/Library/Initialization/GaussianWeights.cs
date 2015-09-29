
namespace Neural{
    using AForge.Math.Random;
    //using AForge.Neuro;

    /// <summary>
    ///   Gaussian weight initialization.
    /// </summary>
    /// 
    public class GaussianWeights
    {
        private ActivationNetwork network;
        private GaussianGenerator random;

        /// <summary>
        ///   Gets ors sets whether the initialization
        ///   should update neurons thresholds (biases)
        /// </summary>
        /// 
        public bool UpdateThresholds { get; set; }

        /// <summary>
        ///   Constructs a new Gaussian Weight initialization.
        /// </summary>
        /// 
        /// <param name="network">The activation network whose weights will be initialized.</param>
        /// <param name="stdDev">The standard deviation to be used. Common values lie in the 0.001-
        /// 0.1 range. Default is 0.1.</param>
        /// 
        public GaussianWeights(ActivationNetwork network, double stdDev = 0.1)
        {
            this.network = network;

            this.random = new GaussianGenerator(0f, (float)stdDev, Accord.Math.Tools.Random.Next());

            this.UpdateThresholds = false;
        }

        /// <summary>
        ///   Randomizes (initializes) the weights of
        ///   the network using a Gaussian distribution.
        /// </summary>
        /// 
        public void Randomize()
        {
            foreach (ActivationLayer layer in network.Layers)
            {
                foreach (ActivationNeuron neuron in layer.Neurons)
                {
                    for (int i = 0; i < neuron.Weights.Length; i++)
                        neuron.Weights[i] = random.Next();
                    if (UpdateThresholds)
                        neuron.Threshold = random.Next();
                }
            }
        }

        /// <summary>
        ///   Randomizes (initializes) the weights of
        ///   the network using a Gaussian distribution.
        /// </summary>
        /// 
        public void Randomize(int layerIndex)
        {
            var layer = network.Layers[layerIndex] as ActivationLayer;

            foreach (ActivationNeuron neuron in layer.Neurons)
            {
                for (int i = 0; i < neuron.Weights.Length; i++)
                    neuron.Weights[i] = random.Next();
                if (UpdateThresholds)
                    neuron.Threshold = random.Next();
            }
        }

    }
}
