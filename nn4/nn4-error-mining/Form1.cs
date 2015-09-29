using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Neural;
using System.Linq;

namespace nn4_error_mining
{
    public partial class Form1 : Form
    {
        private string WorkingPath = string.Empty;
        public Form1(string[] args)
        {
            InitializeComponent();
            if (args.Count() == 0)
                return;
            else
            {
                Parse(args[0], args[1]);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //Network network = Network.Load(@"D:\network-0.nn");
            //string[] file = File.ReadAllLines(@"D:\network-0-validation.txt");
            //double[][] training = file.Select(n => n.Split(';').Select(m => Double.Parse(m)).ToArray()).Where(n => n.Length == 251).ToArray();
            //double[][] input = new double[training.Length][];// Входная выборка
            //double[][] output = new double[training.Length][];// Классификация
            //double[] trainClasses = new double[training.Length];// Массив классов по порядку в файле
            //// Список всех встречаемых классов классификации, для каждого файла свой
            //List<int> classes = new List<int>(2) { -1 }; // Первый класс всегда "-1" - не тот что распознает нейросеть
            //// Заполнаяем input, output, classes и trainClasses из training (из файла)
            //#region Filling
            //for (int i = 0; i < input.Length; i++)
            //{
            //    // Все кроме последнего
            //    input[i] = training[i].Take(training[i].Count() - 1).ToArray();

            //    // Если classes не содержит последний элемент строки (который является классом) то добавить такой класс в classes
            //    if (!classes.Contains((int)training[i].Last()))
            //        classes.Add((int)training[i].Last());

            //    output[i] = new double[2];
            //    output[i][classes.IndexOf((int)training[i].Last())] = 1d;

            //    trainClasses[i] = training[i].Last();
            //}
            //#endregion

            //int result = Common.Validate(network, trainClasses, classes, input, output);

            //MessageBox.Show(string.Format(@"{0}/{1}", result, training.Length));

            //return;
            //Classic();
            //Neiro();

            //buttonGetNNStat_Click();

            //ParseStatFilesToGetTopRightEtc();

            //AbsoluteAlghoritmPath();
        }

        private void AbsoluteAlghoritmPath()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<string> result = new List<string>();
                string[] rabbits = Directory.GetDirectories(f.SelectedPath);
                foreach (var rabbit in rabbits)
                {
                    string[] statFiles = Directory.GetFiles(rabbit + "\\ходы", "*.txt");
                    Dictionary<int, int> goods = new Dictionary<int, int>();
                    Dictionary<int, int[]> _ways = new Dictionary<int, int[]>();
                    Dictionary<int, int> _bonuses = new Dictionary<int, int>();

                    int experimentIndex = -1;
                    foreach (var statFile in statFiles)
                    {
                        experimentIndex++;
                        goods.Add(experimentIndex, 0);
                        _ways.Add(experimentIndex, new int[4]);
                        _bonuses.Add(experimentIndex, 0);
                        string[] strings = File.ReadAllLines(statFile);
                        Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
                        int map_line = -1;
                        foreach (var s in strings)
                        {
                            map_line++;
                            if (s.StartsWith("[map]"))
                                break;
                            configs.Add(s.Split(':')[0], s.Split(':')[1]);
                        }
                        int start_x = Int32.Parse(configs["start"].Split(',')[0]);
                        int start_y = Int32.Parse(configs["start"].Split(',')[1]);

                        // Считываем карту что после [map]
                        string[] current_map = new string[15];
                        for (int i = ++map_line; i < strings.Length; i++)
                        {
                            current_map[i - map_line] = strings[i];
                        }
                        int[,] map = new int[15, 15];
                        for (int j = 0; j < 15; j++)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                map[i, j] = Int32.Parse(current_map[j][i].ToString());
                            }
                        }

                        int x = start_x;
                        int y = start_y;

                        int gathered_bonuses = 0;

                        int[] ways = new int[4];
                        map[x, y] = 3;

                        string[] memory = new string[15 * 15];
                        string[] vision = new string[24];
                        int[,] memoryMap = new int[15, 15];
                        Common.Initialize(ref memoryMap, 8);

                        for (int step = 0; step < 42; step++)
                        {
                            for (int j = y - 2; j <= y + 2; j++)
                            {
                                for (int i = x - 2; i <= x + 2; i++)
                                {
                                    if (i < 0 || i >= 15 || j < 0 || j >= 15)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        memoryMap[i, j] = map[i, j];
                                    }
                                }
                            }

                            int theoryBestWayGoing = Common.GetBestDirection(memoryMap, x, y, "");

                            //var a = Common.ParseArray(memoryMap);
                            if (theoryBestWayGoing == -1)
                            {
                                //errors.Remove(experimentIndex);
                                continue;
                            }
                            goods[experimentIndex]++;
                            ways[theoryBestWayGoing - 1]++;

                            map[x, y] = 1;

                            switch (theoryBestWayGoing)
                            {
                                case 1:
                                    Map_staff.go_up(ref x, ref y, map);
                                    break;
                                case 2:
                                    Map_staff.go_right(ref x, ref y, map);
                                    break;
                                case 3:
                                    Map_staff.go_down(ref x, ref y, map);
                                    break;
                                case 4:
                                    Map_staff.go_left(ref x, ref y, map);
                                    break;
                                default:
                                    return;
                            }

                            if (map[x, y] == 2)
                            {
                                gathered_bonuses++;
                            }
                            map[x, y] = 3;
                        }/* for step 0 -> 42 */
                        _ways[experimentIndex] = ways;
                        _bonuses[experimentIndex] = gathered_bonuses;
                    }
                    
                    StringBuilder sb = new StringBuilder();
                    int totalGoods = 0;
                    foreach (var item in goods)
                    {
                        totalGoods += item.Value;
                    }
                    int totalBonuses = 0;
                    foreach (var item in _bonuses)
                    {
                        totalBonuses += item.Value;
                    }
                    int[] totalWays = new int[4];
                    foreach (var item in _ways)
                    {
                        totalWays[0] += item.Value[0];
                        totalWays[1] += item.Value[1];
                        totalWays[2] += item.Value[2];
                        totalWays[3] += item.Value[3];
                    }
                    result.Add(totalBonuses + "\t" + totalWays[0] + "\t" + totalWays[1] + "\t" + totalWays[2] + "\t" + totalWays[3]+"\t"+totalGoods);
                }
                foreach (var r in result)
                {
                    File.AppendAllText(f.SelectedPath+"\\abs.txt", r + Environment.NewLine);
                }
            }
        }

        private void ParseStatFilesToGetTopRightEtc()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<int[]> _ways = new List<int[]>();
                string[] rabbits = Directory.GetDirectories(f.SelectedPath);
                foreach (var rabbit in rabbits)
                {
                    string[] statFiles = Directory.GetFiles(rabbit+"\\ходы", "*.txt");
                    int[] ways = new int[6];
                    foreach (var statFile in statFiles)
                    {
                        string[] lines = File.ReadAllLines(statFile);
                        Dictionary<string, string> configs = new Dictionary<string, string>(lines.Length);
                        foreach (var l in lines)
                        {
                            if (l == "[map]")
                                break;
                            configs.Add(l.Split(new char[] { ':' })[0], l.Split(new char[] { ':' })[1]);
                        }
                        //patient        =             configs["patient"       ];
                        ways[0] += Int32.Parse(configs["bonuses"]);
                        ways[1] += Int32.Parse(configs["up"]);
                        ways[2] += Int32.Parse(configs["right"]);
                        ways[3] += Int32.Parse(configs["down"]);
                        ways[4] += Int32.Parse(configs["left"]);
                    }
                    ways[5] = statFiles.Length;
                    _ways.Add(ways);
                }
                //File.Create(f.SelectedPath + "\\ways.txt");
                foreach (var line in _ways)
                {
                    File.AppendAllText(f.SelectedPath + "\\ways.txt", line[0] + "\t" + line[1] + "\t" + line[2] + "\t" + line[3] + "\t" + line[4] + "\t" + line[5] + "\n");
                }
            }
        }

        // Хранит папки исследуемых
        string[] rabbits = null;

        // Хранит папки с статистик подопытных, например Батчаев Роберт\ходы\Статистика ходов*.txt
        string[] stats = null;

        private string rabbitsPath = string.Empty;

        // Сохраняет список дочерних директорий выбранной папки в "string[] rabbits"
        private void LoadStatFiles(string path)
        {
            if(path == string.Empty)
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                f.SelectedPath = @"C:\Users\Lenovo\Desktop\наука";
                if (f.ShowDialog() == DialogResult.OK/* && o.FileNames.Length > 0*/)
                {
                    rabbitsPath = f.SelectedPath;
                    rabbits = Directory.GetDirectories(f.SelectedPath);
                }
                f.Dispose();
            }else if(path != string.Empty)
            {
                rabbits = Directory.GetDirectories(path);
            }
        }

        private void GetNNStat(string type)
        {            
            // По каждой папке изучаемого ...
            foreach (var rabbit in rabbits)
            {
                // Path.GetFileName(rabbit) возвращает название папки кролика
                // ...//Батчаев Роберт -> Батчаев Роберт

                string nn_path = Path.Combine(rabbit, "сети");
                Network[] networks = new Network[0];
                if(type == "way")
                {
                    networks = new Network[4]{
                        Network.Load(Path.Combine(nn_path,"network-1.nn")),
                        Network.Load(Path.Combine(nn_path,"network-2.nn")),
                        Network.Load(Path.Combine(nn_path,"network-3.nn")),
                        Network.Load(Path.Combine(nn_path,"network-4.nn"))
                    };
                } else if(type == "angle")
                {
                    networks = new Network[4]{
                        Network.Load(Path.Combine(nn_path,"network-0.nn")),
                        Network.Load(Path.Combine(nn_path,"network-90.nn")),
                        Network.Load(Path.Combine(nn_path,"network-180.nn")),
                        Network.Load(Path.Combine(nn_path,"network-270.nn"))
                    };
                }

                Rabbit _rabbit = new Rabbit(networks);

                // Пути к файлам статистик ходов исследуемых
                stats = Directory.GetFiles(Path.Combine(rabbit, "ходы"), "*.txt");
                Dictionary<string, NNWalkingStat> walks = new Dictionary<string, NNWalkingStat>();
                Dictionary<string, NNWalkingStat> walks_rage = new Dictionary<string, NNWalkingStat>();

                foreach (var stat in stats)
                {
                    walks.Add(     stat, _rabbit.GetSteps(stat, false));
                    walks_rage.Add(stat, _rabbit.GetSteps(stat, true));
                }

                NNWalkingStat totalWalk = NNWalkingStat.Sum(walks);
                NNWalkingStat totalWalkRage = NNWalkingStat.Sum(walks_rage);

                StringBuilder sb = new StringBuilder();
                string path = string.Empty;

                sb.AppendLine("totalErrors\tbonuses\tup\tright\tdown\tleft\ttotalGoods");
                sb.AppendLine(
                    totalWalk.totalErrors + "\t" +
                    totalWalk.totalBonuses + "\t" +
                    totalWalk.totalWays[0] + "\t" +
                    totalWalk.totalWays[1] + "\t" +
                    totalWalk.totalWays[2] + "\t" +
                    totalWalk.totalWays[3] + "\t" +
                    totalWalk.totalGoods
                );
                path = "\\[automated]ошибки-без-встряхивания.txt";
                System.IO.File.WriteAllText(rabbit + path, sb.ToString());

                sb.Clear();

                sb.AppendLine("totalErrors\tbonuses\tup\tright\tdown\tleft\ttotalGoods");
                sb.AppendLine(
                    totalWalkRage.totalErrors + "\t" +
                    totalWalkRage.totalBonuses + "\t" +
                    totalWalkRage.totalWays[0] + "\t" +
                    totalWalkRage.totalWays[1] + "\t" +
                    totalWalkRage.totalWays[2] + "\t" +
                    totalWalkRage.totalWays[3] + "\t" +
                    totalWalkRage.totalGoods
                );
                path = "\\[automated]ошибки-со-встряхиванием.txt";
                System.IO.File.WriteAllText(rabbit + path, sb.ToString());

            }//foreach (var rabbit in rabbits)
            MessageBox.Show("");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parse("way", string.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parse("angle", string.Empty);
        }

        private void Parse(string path, string type)
        {
            LoadStatFiles(path);
            GetNNStat(type);
        }

        [Obsolete]
        private void buttonGetNNStat_Click()
        {

            Random r = new Random();

            // По каждой папке изучаемого ...
            foreach (var rabbit in rabbits)
            {
                // Запоминаем пути к файлам статистик ходов исследуемых
                stats = Directory.GetFiles(Path.Combine(rabbit, "ходы"), "*.txt");

                string nn_path = Path.Combine(rabbit, "сети");
                Network[] networks = new Network[4]{
                        Network.Load(Path.Combine(nn_path,"network-0.nn")),
                        Network.Load(Path.Combine(nn_path,"network-90.nn")),
                        Network.Load(Path.Combine(nn_path,"network-180.nn")),
                        Network.Load(Path.Combine(nn_path,"network-270.nn"))
                    };

                bool rageMode = false;
                for (int it = 0; it < 2; it++)
                {
                    int experimentIndex = 0;
                    Dictionary<int, int[]> _ways = new Dictionary<int, int[]>();
                    Dictionary<int, int> _errors = new Dictionary<int, int>();
                    Dictionary<int, int> _goods = new Dictionary<int, int>();
                    Dictionary<int, int> _bonuses = new Dictionary<int, int>();

                    #region _foreach_stat_
                    // По каждому файлу статистики ...
                    foreach (var stat in stats)
                    {
                        experimentIndex++;
                        _errors.Add(experimentIndex, 0);
                        _goods.Add(experimentIndex, 0);
                        _bonuses.Add(experimentIndex, 0);
                        _ways.Add(experimentIndex, new int[4]);
                        string[] strings = File.ReadAllLines(stat);
                        Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);

                        #region Parsing
                        int map_line = -1;
                        foreach (var s in strings)
                        {
                            map_line++;

                            // Обнаружили [map], выходим из цикла, дальше только карта
                            if (s.StartsWith("[map]"))
                                break;

                            configs.Add(s.Split(':')[0], s.Split(':')[1]);
                        }
                        /*  map_ip:Карты\карта-15x15_19.txt
                            start:1,10
                            bonuses:10
                            up:13
                            right:17
                            down:7
                            left:5                          */
                        int start_x = Int32.Parse(configs["start"].Split(',')[0]);
                        int start_y = Int32.Parse(configs["start"].Split(',')[1]);

                        // Считываем карту что после [map]
                        string[] current_map = new string[15];
                        for (int i = ++map_line; i < strings.Length; i++)
                        {
                            current_map[i - map_line] = strings[i];
                        }
                        int[,] map = new int[15, 15];
                        for (int j = 0; j < 15; j++)
                        {
                            for (int i = 0; i < 15; i++)
                            {
                                map[i, j] = Int32.Parse(current_map[j][i].ToString());
                            }
                        }
                        #endregion

                        int x = start_x;
                        int y = start_y;
                        int gathered_bonuses = 0;
                        int[] ways = new int[4];
                        map[x, y] = 3;

                        int[,] memoryMap = new int[15, 15];
                        Common.Initialize(ref memoryMap, 8);

                        bool rage = false;
                        int rageValue = 4;
                        int rageWay = 0;
                        List<string> _rageWays = new List<string>();

                        for (int step = 0; step < 42; step++)
                        {
                            string[] vision = new string[25];
                            string[] memory = new string[15 * 15];

                            vision = Common.GenerateVision(x, y, map);

                            //int index = 0;
                            for (int j = y - 2; j <= y + 2; j++)
                            {
                                for (int i = x - 2; i <= x + 2; i++)
                                {
                                    if (i < 0 || i >= 15 || j < 0 || j >= 15)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        memoryMap[i, j] = map[i, j];
                                        //memory[index] = map[i, j].ToString();
                                    }
                                }
                            }

                            memory = Common.GenerateMemory(memoryMap);
                            var tmp = new List<string>(memory);
                            tmp.AddRange(vision);
                            double[] double_tmp = tmp.Select(n => Double.Parse(n)).ToArray();

                            //string nnWay = Common.RecognisePath(networks, double_tmp);
                            string nnAngle = Common.RecognisePath(networks, double_tmp);
                            int practiceWayOfGOing = 0;
                            int theoryBestWayGoing = Common.GetBestDirection(memoryMap, x, y, "");
                            if (theoryBestWayGoing == -1)
                            {
                                continue;
                            }


                            var tmp2 = Common.ParseStringArrayVision(memory, 15);
                            var tmp3 = tmp2;

                            /*    1
                             * 4     2
                             * 	  3    */
                            switch (nnAngle)
                            {
                                case "0":
                                    practiceWayOfGOing = theoryBestWayGoing;
                                    break;
                                case "90":
                                    practiceWayOfGOing = theoryBestWayGoing == 4 ? 1 : ++theoryBestWayGoing;
                                    break;
                                case "180":
                                    switch (theoryBestWayGoing)
                                    {
                                        case 1:
                                        case 2:
                                            practiceWayOfGOing = theoryBestWayGoing + 2;
                                            break;
                                        case 3:
                                            practiceWayOfGOing = 1;
                                            break;
                                        case 4:
                                            practiceWayOfGOing = 2;
                                            break;
                                    }
                                    break;
                                case "270":// 1 + 270/90
                                    practiceWayOfGOing = theoryBestWayGoing == 1 ? 4 : --theoryBestWayGoing;
                                    break;
                            }




                            if (rageMode)
                            {
                                _rageWays.Add(practiceWayOfGOing.ToString());
                                if (Common.ChechRage(_rageWays) == true)
                                    rage = true;

                                //if (!rage)
                                //    practiceWayOfGOing = Int32.Parse(nnWay);
                                if (rage)
                                {
                                    //if (rageWay == 0)
                                    //    rageWay = r.Next(1, 5);
                                    practiceWayOfGOing = r.Next(1, 5);
                                    if (rageValue-- > 0)
                                    {
                                    }
                                    else
                                    {
                                        rage = false;
                                        rageValue = 4;
                                        rageWay = 0;
                                    }
                                }
                            }




                            ways[practiceWayOfGOing - 1]++;
                            if (practiceWayOfGOing != theoryBestWayGoing && _errors.ContainsKey(experimentIndex))
                                _errors[experimentIndex]++;
                            else
                                _goods[experimentIndex]++;

                            map[x, y] = 1;
                            switch (practiceWayOfGOing)
                            {
                                case 1:
                                    Map_staff.go_up(ref x, ref y, map);
                                    break;
                                case 2:
                                    Map_staff.go_right(ref x, ref y, map);
                                    break;
                                case 3:
                                    Map_staff.go_down(ref x, ref y, map);
                                    break;
                                case 4:
                                    Map_staff.go_left(ref x, ref y, map);
                                    break;
                                default:
                                    return;
                            }
                            if (map[x, y] == 2)
                            {
                                gathered_bonuses++;
                            }
                            map[x, y] = 3;

                        }/* for step 0 -> 42 */
                        _ways[experimentIndex] = ways;
                        _bonuses[experimentIndex] = gathered_bonuses;
                    }/* foreach stat in stats*/
                    #endregion

                    StringBuilder sb = new StringBuilder();
                    int totalErrors = 0;
                    foreach (var key in _errors.Keys)
                    {
                        totalErrors += _errors[key];
                    }
                    int totalGoods = 0;
                    foreach (var key in _goods.Keys)
                    {
                        totalGoods += _goods[key];
                    }
                    int totalBonuses = 0;
                    foreach (var key in _bonuses.Keys)
                    {
                        totalBonuses += _bonuses[key];
                    }
                    int[] totalWays = new int[4];
                    foreach (var key in _ways.Keys)
                    {
                        totalWays[0] += _ways[key][0];
                        totalWays[1] += _ways[key][1];
                        totalWays[2] += _ways[key][2];
                        totalWays[3] += _ways[key][3];
                    }

                    sb.AppendLine("totalErrors\tbonuses\tup\tright\tdown\tleft\ttotalGoods");
                    sb.AppendLine(totalErrors + "\t" + totalBonuses + "\t" + totalWays[0] + "\t" + totalWays[1] + "\t" + totalWays[2] + "\t" + totalWays[3] + "\t" + totalGoods);

                    string path = string.Empty;
                    if (rageMode)
                        path = "\\[automated]ошибки-со-встряхиванием.txt";
                    else
                        path = "\\[automated]ошибки-без-встряхивания.txt";
                    System.IO.File.WriteAllText(rabbit + path, sb.ToString());
                    
                    rageMode = true;
                }// for 2
            }
            Application.Exit();
        }

        [Obsolete]
        private void Neiro()
        {
            int[] ways = new int[4];
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = false;
            o.Filter = "Файл эксперимента (*.csv)|*.csv|Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Dictionary<int, int> errors = new Dictionary<int, int>();
                var lines = File.ReadAllLines(o.FileName);
                foreach (var line in lines)
                {
                    var inte = Int32.Parse(line.Split(' ')[0].ToString());
                    if (!errors.ContainsKey(inte))
                        errors.Add(inte, 0);
                }


                foreach (var line in lines)
                {
                    string[] newlines = line.Split(' ');    // Split line by "space" character

                    // Куда пошел пацан
                    int practiceWayOfGOing = 0;

                    // Оптимальный путь
                    int theoryBestWayGoing = 0;


                    int experimentIndex = Int32.Parse(newlines[0]);

                    int index = 0;
                    while (!newlines[index++].EndsWith(".txt")) ;

                    string stepIndex = newlines[index];

                    if (stepIndex == "40")
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    string vision = line.Substring(line.Length - 1 - 25 * 2, 25 * 2 - 1);
                    string memory = line.Substring(line.Length - 1 - 25 * 2 - 15 * 15 * 2, 15 * 15 * 2 - 1);

                    if (!memory.Contains("3"))
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    var tmp = Common.ParseStringVision(memory, 15);

                    vision = vision.Replace(" 3 ", " ");

                    // Da memory
                    //string nnWay = Common.RecognisePath((memory + " " + vision).Split(' '));
                    // No memory
                    //string nnWay = Common.RecognisePath((vision).Split(' '));
                    //string[] str_vision = Common.ParseStringVision(vision, 5);
                    //string[] str_memory = Common.ParseStringVision(memory, 15);

                    int[,] MemoryMap = Common.ConstructArray(memory, line);

                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (MemoryMap[i, j] == 3)
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }

                    practiceWayOfGOing = 0;//Int32.Parse(nnWay);

                    ways[practiceWayOfGOing - 1]++;

                    theoryBestWayGoing = Common.GetBestDirection(MemoryMap, x, y, line);

                    if (theoryBestWayGoing == -1)
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    if (practiceWayOfGOing != theoryBestWayGoing && errors.ContainsKey(experimentIndex))
                        errors[experimentIndex]++;
                }

                //} /* foreach (var file in o.FileNames) */

                StringBuilder sb = new StringBuilder();
                int totalErrors = 0;
                foreach (var item in errors)
                {
                    sb.AppendLine(item.Key + "\t" + item.Value);
                    totalErrors += item.Value;
                }

                sb.AppendLine("total:" + "\t" + totalErrors);
                sb.AppendLine("up\tright\tdown\tleft");
                sb.AppendLine(ways[0] + "\t" + ways[1] + "\t" + ways[2] + "\t" + ways[3]);
                string first_file = o.FileNames[0];
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "[nnErr]" + Path.GetFileNameWithoutExtension(first_file) + ".txt";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
                //MessageBox.Show(totalErrors.ToString());
                Clipboard.SetText(totalErrors.ToString());
                Application.Exit();
            }
        }
        
        [Obsolete]
        private void Classic()
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = false;
            o.Filter = "Файл эксперимента (*.csv)|*.csv|Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Dictionary<int, int> errors = new Dictionary<int, int>();
                var lines = File.ReadAllLines(o.FileName);
                foreach (var line in lines)
                {
                    var inte = Int32.Parse(line.Split(' ')[0].ToString());
                    if (!errors.ContainsKey(inte))
                        errors.Add(inte, 0);
                }


                foreach (var line in lines)
                {
                    string[] newlines = line.Split(' ');    // Split line by "space" character

                    // Куда пошел пацан
                    int practiceWayOfGOing = 0;

                    // Оптимальный путь
                    int theoryBestWayGoing = 0;


                    int experimentIndex = Int32.Parse(newlines[0]);

                    int index = 0;
                    while (!newlines[index++].EndsWith(".txt")) ;

                    string stepIndex = newlines[index];

                    if (stepIndex == "40")
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    string way = newlines[newlines.Length - 1];   // Last thing is steps sequence
                    string vision = line.Substring(line.Length - 1 - 25 * 2, 25 * 2 - 1);
                    string memory = line.Substring(line.Length - 1 - 25 * 2 - 15 * 15 * 2, 15 * 15 * 2 - 1);

                    //Predict249252901.Main();


                    // Classic
                    continue;


                    if (!memory.Contains("3"))
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    //string[] str_vision = Common.ParseStringVision(vision, 5);
                    //string[] str_memory = Common.ParseStringVision(memory, 15);

                    int[,] MemoryMap = Common.ConstructArray(memory, line);

                    int x = 0;
                    int y = 0;
                    for (int i = 0; i < 15; i++)
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (MemoryMap[i, j] == 3)
                            {
                                x = i;
                                y = j;
                            }
                        }
                    }

                    practiceWayOfGOing = Int32.Parse(way);

                    theoryBestWayGoing = Common.GetBestDirection(MemoryMap, x, y, line);

                    if (theoryBestWayGoing == -1)
                    {
                        //errors.Remove(experimentIndex);
                        continue;
                    }

                    if (practiceWayOfGOing != theoryBestWayGoing && errors.ContainsKey(experimentIndex))
                        errors[experimentIndex]++;
                }

                //} /* foreach (var file in o.FileNames) */

                StringBuilder sb = new StringBuilder();
                int totalErrors = 0;
                foreach (var item in errors)
                {
                    sb.AppendLine(item.Key + "\t" + item.Value);
                    totalErrors += item.Value;
                }

                sb.AppendLine("total:" + "\t" + totalErrors);
                string first_file = o.FileNames[0];
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "[err]" + Path.GetFileNameWithoutExtension(first_file) + ".txt";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
                //MessageBox.Show(totalErrors.ToString());
                Clipboard.SetText(totalErrors.ToString());
                Application.Exit();
            }
        }


    }
}
