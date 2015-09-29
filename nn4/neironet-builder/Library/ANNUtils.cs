using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neural
{
    class ANNUtils
    {
        //получение всех доступных связей для подсоединения(входы)   
        public static List<String> getAvailableWeights(Network net)
        {
            List<string> availableNeurons = new List<String>();

            //add neurons for available neurons, for connected subnet inputs
            for (int layer = 0; layer < net.Layers.Length; layer++)
            {
                for (int neuron = 0; neuron < net.Layers[layer].Neurons.Length; neuron++)
                {
                    for (int weight = 0; weight < net.Layers[layer].Neurons[neuron].Weights.Length; weight++)
                    {
                        availableNeurons.Add(layer.ToString() + ":" + neuron.ToString() + ":" + weight.ToString());
                    }
                }
            }

            return availableNeurons;
        }

        //normalization data for learning
        public static double[,] normalization(double[,] data, double[] min, double[] max, int rowCountData, int colCountData)
        {
            for (int row = 0; row < rowCountData; row++)
            {
                for (int column = 0; column < colCountData - 1; column++)
                {
                    data[row, column] = (((data[row, column] - min[column]) * 1 / (max[column] - min[column])));

                }
            }
            return data;
        }
        
        //Кол-во связей в сети
        public static int getCountOfWeights(Network network)
        {
            int i = 0;
            for (int layer = 0; layer < network.Layers.Length; layer++)
            {
                for (int neuron = 0; neuron < network.Layers[layer].Neurons.Length; neuron++)
                {
                    for (int weight = 0; weight < network.Layers[layer].Neurons[neuron].Weights.Length; weight++)
                    {
                        i++;
                    }
                }
            }
            return i;
        }

        //коэффициент вариации для каждой позиции веса
        public static double[] coefficientVariations(double[] mediumWeights, double[] deviations)
        {
            double[] coefficients = new double[ deviations.Length ];

            for (int i = 0; i < deviations.Length; i++ )
            {
                coefficients[i] = deviations[i] / mediumWeights[i];
            }
            return coefficients;
        }

        //средние значения для каждой позиции веса
        public static double[] mediums(List<Subnet> subnets)
        {
            double[] mediumWeights = new double[ANNUtils.getCountOfWeights(subnets[0].Network)];

            int iWeight = 0;
            for (int layer = 0; layer < subnets[0].Network.Layers.Length; layer++)
            {
                for (int neuron = 0; neuron < subnets[0].Network.Layers[layer].Neurons.Length; neuron++)
                {
                    for (int weight = 0; weight < subnets[0].Network.Layers[layer].Neurons[neuron].Weights.Length; weight++)
                    {
                        double summ = 0.0;
                        for (int network = 0; network < subnets.Count; network++)
                        {
                            summ += subnets[network].Network.Layers[layer].Neurons[neuron].Weights[weight];
                        }
                        mediumWeights[iWeight] = summ / subnets.Count;
                        iWeight++;
                    }
                }

            }

            return mediumWeights;
        }

        //среднеквадратичное отклонение
        public static double[] standartDeviation(double[] mediumWeights, List<Subnet> subnets)
        {
            double[] standartDeviation = new double[ANNUtils.getCountOfWeights(subnets[0].Network)];
            //calculate standart deviation
            int iWeight = 0;
            for (int layer = 0; layer < subnets[0].Network.Layers.Length; layer++)
            {
                for (int neuron = 0; neuron < subnets[0].Network.Layers[layer].Neurons.Length; neuron++)
                {
                    for (int weight = 0; weight < subnets[0].Network.Layers[layer].Neurons[neuron].Weights.Length; weight++)
                    {
                        double summ = 0.0;
                        for (int network = 0; network < subnets.Count; network++)
                        {
                            summ += (subnets[network].Network.Layers[layer].Neurons[neuron].Weights[weight] - mediumWeights[iWeight]) * (subnets[network].Network.Layers[layer].Neurons[neuron].Weights[weight] - mediumWeights[iWeight]);
                        }
                        
                        standartDeviation[iWeight] =  Math.Sqrt(summ / (subnets.Count - 1));
                        iWeight++;
                    }
                }

            }
            return standartDeviation;
        }

        //удаление заданного кол-ва сетей по возрастанию
        public static List<Subnet> dropBadSubnets(List<Subnet> subnets, int count)
        {
            //сортировка по убыванию
            subnets = subnets.OrderByDescending(net => net.ID).ToList();
            subnets = subnets.OrderByDescending(net => net.quality).ToList();

            for (int i = 0; i < count; i++)
            {
                //удаление худших с конца
                subnets.RemoveAt(subnets.Count - 1);
            }

            return subnets;
        }
   
        //подсчитывает количество нейронов заданной сети
        public static int getNeuronsCount(Network network)
        {
            int i = 0;
            for (int layer = 0; layer < network.Layers.Length; layer++)
            {
                for (int neuron = 0; neuron < network.Layers[layer].Neurons.Length; neuron++)
                {
                    i++;
                }
            }
            return i;
        }

        //инициализация временного массива для поддержки отключения и включения нейронов и связей
        public static double[][][][] emptyWeightsArray(Network network)
        {   
            double[][][][] tempWeights = new double[network.Layers.Length][][][];
            for (int i = 0; i < network.Layers.Length; i++)
            {
                tempWeights[i] = new double[network.Layers[i].Neurons.Length][][];
                for (int j = 0; j < network.Layers[i].Neurons.Length; j++)
                {
                    tempWeights[i][j] = new double[network.Layers[i].Neurons[j].Weights.Length][];
                    for (int k = 0; k < network.Layers[i].Neurons[j].Weights.Length; k++)
                    {
                        tempWeights[i][j][k] = new double[1];
                    }
                }
            }
            return tempWeights;
        }

        //поиск наиболее вероятного класса
        public static int max(double[] mass)
        {
            int classificator = 0;
            double tempValue = 0.0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (tempValue < mass[i])
                {
                    tempValue = mass[i];
                    classificator = i;
                }
            }
            return classificator;
        }

        //запуск тестирования сети с желаемым классом
        public static double testing(Network network, double[,] data, int[] classes, List<int> classesList)
        {
            double[] res;
            int colCountData = network.InputsCount;
            double[] input = new double[colCountData];
            double validate = 0.0;
            double testQuality = 0.0;


            for (int count = 0; count < data.GetLength(0) - 1; count++)
            {
                try
                {
                    //gather inputs for compute, n-1 inputs
                    for (int i = 0; i < colCountData ; i++)
                    {
                        input[i] = data[count, i];
                    }
                    res = network.Compute(input);
                    double output = classesList[ANNUtils.max(res)];
                    double value = Math.Abs(classes[count] - output);

                    validate += value;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ошибка тестирования сети." + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
            testQuality = (1 - (validate / data.GetLength(0))) * 100;

            return testQuality;
        }
    }
}
