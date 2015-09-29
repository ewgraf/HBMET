using Neural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neironet_builder
{
    class Common
    {
        public static int Max(double[] mass)
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
        //private double moduleValidation(double[] input, )
        //{
        //    double testQuality = 0.0;
        //    double validate = 0.0;
        //    double[] res;
        //    for (int count = 0; count < input.Length; count++)
        //    {
        //        res = network.Compute(input[count]);
        //        double value = Math.Abs(trainClasses[count] - classesList[ANNUtils.max(res)]);

        //        validate += value;
        //    }
        //    testQuality = (1 - (validate / input.Length)) * 100;
        //    return testQuality;
        //}

        //валидация по модулю
        internal static double AbsValidation(Neural.ActivationNetwork network, double[][] input, double[] trainClasses, List<int> classes)
        {
            double testQuality = 0.0;
            double validate = 0.0;
            double[] res;
            for (int count = 0; count < input.Length; count++)
            {
                res = network.Compute(input[count]);
                var a = Common.Max(res);
                var b = classes[Common.Max(res)];
                var c = trainClasses[count];
                double value = Math.Abs(trainClasses[count] - classes[Common.Max(res)]);

                validate += value;       
            }
            testQuality = (1 - (validate / input.Length)) * 100;
            return testQuality;
        }

        internal static int Validate(Network network, double[] trainClasses, List<int> classes, double[][] input, double[][] output)
        {
            int result = 0;
            double[] tmp;
            for (int i = 0; i < input.Length; i++)
            {
                tmp = network.Compute(input[i]);
                if (trainClasses[i] == classes[Common.Max(tmp)])
                    result++;
            }
            return result;
        }
    }
}
