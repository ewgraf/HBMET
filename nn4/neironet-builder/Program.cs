using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using AForge.Neuro;
using AForge.Neuro.Learning;
using Neural;

using Mono.Options;

namespace neironet_builder
{
    static class Program
    {
        private static string[] txtFiles = null;

        [STAThread]
        static void Main(string[] args)
        {
            string path = string.Empty;
            string filesPattern = string.Empty; // Ex: "[automated]ходы.txt-*.txt"
            if(args.Count() == 0)
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                        filesPattern = "[automated]ходы.txt-*.txt";
                    }
                    else
                    {
                        Console.WriteLine("[Error] fbd.ShowDialog() != DialogResult.OK —> Working path was not specified.");
                        return;
                    }
                }
            }                
            else if(args.Count() != 0)
            {
                OptionSet options = new OptionSet()
                    .Add("p=", p => path = p)
                    .Add("f=", f => filesPattern = f);
                options.Parse(args);
                if(path == string.Empty)
                {
                    throw new Exception();
                }
            }
            Console.WriteLine("path=" + path);
            Console.WriteLine("pattern=" + "[automated]ходы.txt-" + filesPattern + ".txt");
            txtFiles = Directory.GetFiles(path, "[automated]ходы.txt-" + filesPattern + ".txt", SearchOption.AllDirectories);

            foreach (var txtFile in txtFiles)
            {
                // Файл с полной обучающей выборкой
                string[] file = File.ReadAllLines(txtFile);

                // Делим на обучающую (~80%) и проверочную (~20%) выборки
                string[] validation = file.Where((value, index) => index % 5 == 0).ToArray();
                string[] education  = file.Where((value, index) => index % 5 != 0).ToArray();

                // Директория, в которой лежит txtFile, используется для сохранения в неё обученной нейросети и валидационной выборки
                string parentDirectory = Directory.GetParent(txtFile).ToString();

                // Определить число в имени файла
                // "[automated]ходы.txt-0|90|180|270.txt" => "0", "90", "180", "270"
                string angle = Regex.Match(Regex.Match(Path.GetFileName(txtFile), @"\[automated\]ходы.txt-\d+.txt$").Value, @"\d+").Value;

                Directory.CreateDirectory(Path.Combine(parentDirectory, "сети"));
                File.WriteAllLines(Path.Combine(parentDirectory, string.Format("сети\\network-{0}-validation.txt", angle)), validation);

                double[][] training = education.Select(n => n.Split(';').Select(m => Double.Parse(m)).ToArray()).Where(n => n.Length == 251).ToArray();
                
                double[][] input  = new double[training.Length][];// Входная выборка
                double[][] output = new double[training.Length][];// Классификация

                double[] trainClasses = new double[training.Length];// Массив классов по порядку в файле

                // Список всех встречаемых классов классификации, для каждого файла свой
                List<int> classes = new List<int>(2) { -1 }; // Первый класс всегда "-1" - не тот что распознает нейросеть

                // Заполнаяем input, output, classes и trainClasses из training (из файла)
                #region Filling
                for (int i = 0; i < input.Length; i++)
                {
                    // Все кроме последнего
                    input[i] = training[i].Take(training[i].Count() - 1).ToArray();

                    // Если classes не содержит последний элемент строки (который является классом) то добавить такой класс в classes
                    if (!classes.Contains((int)training[i].Last()))
                         classes.Add(     (int)training[i].Last());

                    output[i] = new double[2];
                    output[i][classes.IndexOf((int)training[i].Last())] = 1d;

                    trainClasses[i] = training[i].Last();
                }
                #endregion

                Neural.ActivationNetwork network = new Neural.ActivationNetwork(
                    new Neural.SigmoidFunction(2d),
                    input[0].Length,
                    new int[] { 250, 25, 2, 2 }
                );

                NguyenWidrow initializer = new NguyenWidrow(network);
                initializer.Randomize();
                ParallelResilientBackpropagationLearning teacher = new ParallelResilientBackpropagationLearning(network);

                // Процесс обучения сети с выводом результатов
                #region Learning

                // Номер итерации
                int iteration = 0;

                // Значение ошики
                double error = 0d;

                // Значение валидации по модулю
                double absValidError = 0d;

                StringBuilder log = new StringBuilder();

                bool needToStop = false;
                Stopwatch interval = Stopwatch.StartNew();
                Stopwatch learningTime = Stopwatch.StartNew();

                while (!needToStop)
                {
                    interval.Restart();

                    // run epoch of learning procedure
                    error = (1 - (teacher.RunEpoch(input, output) / input.GetLength(0))) * 100;
                    //absValidError = Common.AbsValidation(network, input, trainClasses, classes);

                    interval.Stop();

                    //-DEBUG----------------------------------------------------
                    Console.Clear();
                    Console.WriteLine(string.Format("File {0}", txtFile));
                    Console.WriteLine("Iteration " + iteration);
                    Console.WriteLine("Error " + error);
                    //Console.WriteLine("Abs Validation Error " + absValidError);
                    Console.WriteLine("Iteration time " + interval.Elapsed.TotalSeconds);
                    for (int i = 0; i < 6; i++)
                    {
                        var a = network.Compute(input[i]);
                        var b = classes[Common.Max(a)];
                        Console.WriteLine("[0]" + network.Compute(input[i])[0]);
                        Console.WriteLine("[1]" + network.Compute(input[i])[1]);
                        Console.WriteLine("   " + output[i][1] + " -> " + b);
                    }
                    //----------------------------------------------------------
                    //-LOG------------------------------------------------------
                    log.AppendLine(string.Format("File {0}", txtFile));
                    log.AppendLine("Iteration " + iteration);
                    log.AppendLine("Error " + error);
                    //log.AppendLine("Abs Validation Error " + absValidError);
                    for (int i = 0; i < 7; i++)
                    {
                        var a = network.Compute(input[i]);
                        var b = classes[Common.Max(a)];
                        log.AppendLine("[0]" + network.Compute(input[i])[0]);
                        log.AppendLine("[1]" + network.Compute(input[i])[1]);
                        log.AppendLine("   " + output[i][1] + " -> " + b);
                    }
                    log.AppendLine("Iteration time " + interval.Elapsed.TotalSeconds);
                    //----------------------------------------------------------
                    // check error value to see if we need to stop
                    // ...
                    iteration++;
                    if (iteration > 50 || absValidError > 95 || error > 90)
                        needToStop = true;
                }
                absValidError = Common.AbsValidation(network, input, trainClasses, classes);
                learningTime.Stop();
                log.AppendLine("Learning time " + learningTime.Elapsed.TotalSeconds);
                log.AppendLine("Total iterations " + iteration);
                log.AppendLine("Final Error " + error);
                log.AppendLine("Final Abs Validation Error " + absValidError);
                #endregion
                
                #region Validation
                training = validation.Select(n => n.Split(';').Select(m => Double.Parse(m)).ToArray()).Where(n => n.Length == 251).ToArray();
                input = new double[training.Length][];
                output = new double[training.Length][];
                trainClasses = new double[training.Length];
                classes = new List<int>(2) { -1 };
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = training[i].Take(training[i].Count() - 1).ToArray();

                    if (!classes.Contains((int)training[i].Last()))
                        classes.Add((int)training[i].Last());

                    output[i] = new double[2];
                    output[i][classes.IndexOf((int)training[i].Last())] = 1d;

                    trainClasses[i] = training[i].Last();
                }
                int result = Common.Validate(network, trainClasses, classes, input, output);
                log.AppendLine(string.Format(@"{0}/{1} ~{2}%", result, training.Length, result * 100 / training.Length));
                #endregion

                network.Save(     Path.Combine(parentDirectory,    Path.Combine("сети", string.Format("network-{0}.nn",       angle))   ));
                File.WriteAllText(Path.Combine(parentDirectory,    Path.Combine("сети", string.Format("network-{0}-info.txt", angle))   ), log.ToString());
            }
        }

        static IEnumerable<T> WithoutLast<T>(this IEnumerable<T> source)
        {
            using (var e = source.GetEnumerator())
            {
                if (e.MoveNext())
                {
                    for (var value = e.Current; e.MoveNext(); value = e.Current)
                    {
                        yield return value;
                    }
                }
            }
        }
    }
}
// create neural network
//AForge.Neuro.ActivationNetwork network = new AForge.Neuro.ActivationNetwork(
//    new AForge.Neuro.SigmoidFunction(2),
//    input[0].Length, // two inputs in the network
//    249, // two neurons in the first layer
//    25,
//    2,
//    2); // one neuron in the second layer

// create teacher
//BackPropagationLearning teacher =
//    new BackPropagationLearning(network);

//EvolutionaryLearning teacher = new EvolutionaryLearning(network, 10); // number of chromosomes in genetic population

//Neural.BackPropagationLearning teacher = new Neural.BackPropagationLearning(network);