using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using nn4;

namespace parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[,] GetSquareArrayFromString(string splitted_step)
        {
            int sqrt = (int)Math.Sqrt(splitted_step.Length);
            int[,] _out = new int[sqrt, sqrt];
            int index = 0;
            for (int y = 0; y < sqrt; y++)
            {
                for (int x = 0; x < sqrt; x++)
                {
                    _out[x, y] = Int32.Parse(splitted_step[index++].ToString());
                }
            }
            return _out;
        }

        private string GetStringMap(int[,] map, string s)
        {
            string _out = string.Empty;
            for (int y = 0; y < map.GetLength(0); y++)
                for (int x = 0; x < map.GetLength(0); x++)
                    _out += map[x, y];
            return _out;
        }

        private string[] GetStringMap(int[,] int_map)
        {
            string[] _out = new string[int_map.GetLength(0)];
            for (int y = 0; y < int_map.GetLength(0); y++)
                for (int x = 0; x < int_map.GetLength(0); x++)
                    _out[y] += int_map[x, y];
            return _out;
        }

        private int[,] GetIntMap(string[] map)
        {
            int[,] _out = new int[15, 15];
            int x = 0, y = 0;
            foreach(var line in map)
            {
                foreach(var c in line)
                {
                    _out[x, y] = Int32.Parse(c.ToString());
                    x++;
                }
                y++;
                x = 0;
            }
            return _out;
        }

        private string GetMapFileName(string[] array)
        {
            string _out = string.Empty;
            foreach(var s in array)
            {
                if(s.StartsWith("Карты"))
                {
                    _out = s;
                }
            }
            return _out;
        }

        private void Initialize(ref int[,] MemoryMap, int value)
        {
            for (int i = 0; i < MemoryMap.GetLength(0); i++)
                for (int j = 0; j < MemoryMap.GetLength(1); j++)
                    MemoryMap[i, j] = value;
        }

        private void UpdateMemoryMap(ref int[,] MemoryMap, int[,] vision, int x, int y)
        {
            int max_i = 15;
            int max_j = 15;
            // Поле зрения - 5х5
            // , и если ходим по краю карты, то за пределами карты мы должны видеть стены
            // Проходим по видимой в данный момент области 5х5, и сохраняем все в int[25] template
            for (int j = y - 2; j <= y + 2; j++)
                for (int i = x - 2; i <= x + 2; i++)
                {
                    if (i < 0 || i >= max_i || j < 0 || j >= max_j)
                    {
                    }
                    else
                    {
                        MemoryMap[i, j] = vision[i - (x - 2), j - (y - 2)];   // Обновляем глобальную карту в памяти
                    }
                }
        }

        //=
        // Основаная функция
        //=
        private void button3_Click(object sender, EventArgs e)
        {
            int[,] MemoryMap = new int[15, 15];  // Хардкод, в данном исследовании используютсятолько карты 15х15
            // Инициализируем её восьмерками

            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            o.Filter = "Файл эксперимента (*.csv)|*.csv|Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder(o.FileNames.Length);
                string first_file = o.FileNames[0];
                string last_file = o.FileNames[o.FileNames.Length - 1];

                int patient_index = 0;

                foreach (var file in o.FileNames)               // For each selected file ...
                {
                    Initialize(ref MemoryMap, 8);
                    //===================================================================================
                    string stat_file = file.Replace("Ходы", "Статистика ходов").Replace(".csv", ".txt");
                    string[] strings = null;
                    try
                    {
                        strings = File.ReadAllLines(stat_file);
                    }
                    catch
                    {
                        continue;
                    }
                    Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
                    int map_line = -1;
                    foreach (var s in strings)
                    {
                        map_line++;

                        if (s.StartsWith("[map]"))
                            break;

                        configs.Add(s.Split(':')[0], s.Split(':')[1]);
                    }
                    /*
                        map_ip:Карты\карта-15x15_19.txt
                        start:1,10
                        bonuses:10
                        up:13
                        right:17
                        down:7
                        left:5
                        */
                    int x = Int32.Parse(configs["start"].Split(',')[0]);
                    int y = Int32.Parse(configs["start"].Split(',')[1]);
                    //===================================================================================
                    var lines = File.ReadAllLines(file);        // ... read all lines from current file
                    foreach (var line in lines)                 // For each line in lines array ...
                    {
                        string[] newlines = line.Split(' ');    // Split line by "space" character

                        string header = string.Empty;           // Name of patient and map (as usual)
                        for (int i = 0; i < newlines.Length - 1; i++)
                        {
                            header += newlines[i] + " ";
                        }

                        string steps = newlines[newlines.Length - 1];   // Last thing is steps sequence
                        string[] splitted_steps = steps.Split(';');     // Split steps by ";" character

                        List<string> bonuses_at_step = new List<string>();
                        List<string> vision_at_step = new List<string>();
                        List<string> memory_at_step = new List<string>();

                        string tmp = string.Empty;
                        string tmp1 = string.Empty;
                        string tmp2 = string.Empty;
                        foreach (string splitted_step in splitted_steps)
                        {
                            tmp = string.Empty;
                            tmp1 = string.Empty;
                            tmp2 = string.Empty;
                            if (splitted_step.Length < 3)
                            {
                                bonuses_at_step.Add(splitted_step);
                            }
                            else
                            {
                                //=========================================================================================
                                int[,] tmpVision = null;
                                if (splitted_step.Length == 26)
                                {
                                    tmpVision = this.GetIntVision(splitted_step.Substring(0, splitted_step.Length - 1));
                                }
                                else
                                {
                                    tmpVision = this.GetIntVision(splitted_step.Substring(0, splitted_step.Length));
                                }                                    
                                this.UpdateMemoryMap(ref MemoryMap, tmpVision, x, y);
                                tmp1 = this.GetStringMap(MemoryMap, "string");
                                for (int i = 0; i < tmp1.Length; i++)
                                {
                                    tmp2 += tmp1[i] + " ";
                                }
                                tmp2 = tmp2.Remove(tmp2.Length - 1);
                                memory_at_step.Add(tmp2);
                                if (splitted_step.Length == 26)
                                {
                                    this.UpdateCoordinates(ref x, ref y, splitted_step.Last());
                                }                                
                                var debug = GetStringMap(MemoryMap);
                                //=========================================================================================
                                for (int i = 0; i < splitted_step.Length; i++)
                                {
                                    tmp += splitted_step[i] + " ";
                                }
                                tmp = tmp.Remove(tmp.Length - 1);
                                vision_at_step.Add(tmp);
                                //=========================================================================================
                            }
                        }

                        int step_num = 0;
                        foreach (var vision in vision_at_step)
                        {
                            sb.Append(patient_index + " ");
                            sb.Append(header);
                            sb.Append(step_num + " ");
                            sb.Append(bonuses_at_step[step_num] + " ");
                            sb.Append(memory_at_step[step_num] + " ");
                            sb.Append(vision);
                            sb.AppendLine();
                            step_num++;
                        }
                    } /* foreach (var line in lines)*/
                    patient_index++;
                } /* foreach (var file in o.FileNames) */

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(first_file) + " - " + Path.GetFileNameWithoutExtension(last_file) + ".csv";
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.ShowDialog();
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());

                this.SplitOneIntoFour(saveFileDialog1.FileName);

            }
        }

        private void UpdateCoordinates(ref int x, ref int y, char p)
        {
            switch(p){
                case '1':
                    y--;
                    break;
                case '2':
                    x++;
                    break;
                case '3':
                    y++;
                    break;
                case '4':
                    x--;
                    break;
                default:
                    throw new Exception("Ввод нештатных параметров.");
            }
        }

        private int[,] GetIntVision(string splitted_step)
        {
            int[,] vision = new int[5, 5];
            int index = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    vision[i, j] = int.Parse(splitted_step[index++].ToString());
                }
            }
            return vision;
        }

        private void SplitOneIntoFour(string filePath)
        {
            //var text = File.ReadAllText(filePath).Split('\n').ToList();
            var allText = File.ReadAllLines(filePath);
            StringBuilder newText = new StringBuilder();
            char[] chars = new char[4] { '1', '2', '3', '4' };
            for (int i = 0; i < 4; i++)
            {
                foreach (var line in allText)
                {
                    var a = line.Last();
                    if (a != chars[i])
                    {
                        var b = line.Substring(0, line.Length - 2);
                        newText.AppendLine(b + " 0");
                        continue;
                    }
                    newText.AppendLine(line);
                }
                File.WriteAllText(filePath + "-" + chars[i] + ".txt", newText.ToString());
                newText.Clear();
            }
        }

        internal static void SplitIntoAngles(string filename, string type)
        {
            var allText = File.ReadAllLines(filename);
            StringBuilder newText = new StringBuilder();
            string[] chars = new string[0];
            if(type == "angle")
                chars = new string[4] { "0", "90", "180", "270" };
            else if (type == "way")
                chars = new string[4] { "1", "2", "3", "4" };
            for (int i = 0; i < 4; i++)
            {
                foreach (var line in allText)
                {
                    List<string> split = line.Split(';').ToList();
                    if (split.Last().ToString() != chars[i])
                    {
                        split.RemoveAt(split.Count - 1);
                        split.Add("-1");
                        newText.AppendLine(string.Join(";", split));
                        continue;
                    }
                    newText.AppendLine(line);
                }
                File.WriteAllText(filename + "-" + chars[i] + ".txt", newText.ToString());
                newText.Clear();
            }
        }
        public static int GetOptimalWay(int[,] _MemoryMap, int _x, int _y)
        {
            Point _currentTargetPoint = new Point();
            List<Point> _currentTargetPath = new List<Point>();

            Common.FindBestWayAndTarget(ref _MemoryMap, ref _x, ref _y, ref _currentTargetPoint, ref _currentTargetPath);

            Point way;
            if (_currentTargetPath.Count != 0)
                way = _currentTargetPath[0];
            else
                throw new Exception();
            //====
            if (way.X > _x)
            {
                return 2;
            }
            else if (way.X < _x)
            {
                return 4;
            }
            else if (way.Y > _y)
            {
                return 3;
            }
            else if (way.Y < _y)
            {
                return 1;
            }
            else
            {
                throw new Exception();
            }
        }

        //===========
        // Статистика
        //===========
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            o.Filter = "Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder(o.FileNames.Length);

                int id = 0;
                
                sb.AppendLine("id patient map_id bonuses up right down left");
                foreach (var file in o.FileNames)               // For each selected file ...
                {
                    var lines = File.ReadAllLines(file);        // ... read all lines from current file
                    Dictionary<string, string> configs = new Dictionary<string, string>(lines.Length);
                    foreach (var s in lines)
                    {
                        if (s == "[map]")
                            break;
                        configs.Add(s.Split(':')[0], s.Split(':')[1]);
                    }
                    //patient        =             configs["patient"       ];
                    string patient = configs["patient"];
                    string map_id = configs["map_id"];
                    int bonuses = Int32.Parse(configs["bonuses"]);
                    int up = Int32.Parse(configs["up"]);
                    int right = Int32.Parse(configs["right"]);
                    int down = Int32.Parse(configs["down"]);
                    int left = Int32.Parse(configs["left"]);

                    sb.AppendLine(id + " " + patient + " " + map_id + " " + bonuses + " " + up + " " + right + " " + down + " " + left);

                    id++;

                } /* foreach (var file in o.FileNames) */

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "stat" + ".txt";
                sfd.RestoreDirectory = true;
                sfd.ShowDialog();
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
            }
        }

        //============
        // Анализ карт
        //============
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            o.Filter = "Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder(o.FileNames.Length);

                int id = 0;

                sb.AppendLine("id map_id up right down left free");
                foreach (var file in o.FileNames)               // For each selected file ...
                {
                    var lines = File.ReadAllLines(file);        // ... read all lines from current file

                    int up      = 0;
                    int right   = 0;
                    int down    = 0;
                    int left    = 0;
                    int free    = 0;

                    int steppable_cell  = 0;
                    var tstr            = "";

                    int[,] map = new int[15, 15];
                    for (int i = 0; i < 15; i++ )
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            steppable_cell = Int32.Parse(lines[i][j].ToString());

                            if (steppable_cell == 1)
                            {
                                free++;

                                /* up *//* right *//* down *//* left */
                                if (i - 1 >= 0 && lines[i - 1][j].ToString() == "1") up++;
                                if (j + 1 < 15 && lines[i][j + 1].ToString() == "1") right++;
                                if (i + 1 < 15 && lines[i + 1][j].ToString() == "1") down++;
                                if (j - 1 >= 0 && lines[i][j - 1].ToString() == "1") left++;

                            } /* if unit == 1 */
                        }
                    }
                    sb.AppendLine(id + " " + file + " " + up + " " + right + " " + down + " " + left + " " + free);

                    id++;

                } /* foreach (var file in o.FileNames) */

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "map_stat" + ".txt";
                sfd.RestoreDirectory = true;
                sfd.ShowDialog();
                System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
            }
        }

        //=====================
        // Кто видит и не видит
        //=====================
        private void button6_Click(object sender, EventArgs e)
        {
            /* 0 Sanchez Карты\карта-15х15_18.txt 0 0 0 0 1 1 1 0 0 0 0 1 0 0 3 1 1 0 0 0 0 0 0 0 1 1 1 2 
               0 Sanchez Карты\карта-15х15_18.txt 1 0 0 1 1 1 1 0 0 0 1 0 0 1 3 1 0 0 0 0 0 0 0 1 1 1 1 2 
               0 Sanchez Карты\карта-15х15_18.txt 2 0 1 1 1 1 2 0 0 1 0 1 1 1 3 0 1 0 0 0 0 1 1 1 1 1 1 1 
               0 Sanchez Карты\карта-15х15_18.txt 3 0 0 0 0 0 0 1 1 1 1 2 0 0 3 0 1 1 1 1 0 1 0 0 0 0 1 1 
               0 Sanchez Карты\карта-15х15_18.txt 4 0 1 1 1 1 1 0 0 0 0 0 1 1 3 1 2 0 0 1 0 1 1 1 1 0 1 2  */
            int top = 0, right = 0, bottom = 0, left = 0, prev = 1;
            int[,] map = new int[4, 4];
            OpenFileDialog o = new OpenFileDialog();
            o.Multiselect = true;
            //o.Filter = "Файлы эксперимента (*.csv)|*.csv|Все файлы (*.*)|*.*";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                List<string> vision_sees_bonuses = new List<string>();
                List<string> vision_doesnt_see_bonuses = new List<string>();

                int patient_index = 0;
                var lines = File.ReadAllLines(o.FileName);        // ... read all lines from current file
                foreach (var line in lines)                 // For each line in lines array ...
                {
                    string vision = line.Split(new string[] { ".txt " }, StringSplitOptions.None)[1];    // Split line by "space" character

                    // Если чувак видит бонус
                    string substring = vision.Substring(4, vision.Length - 7);
                    if (substring.Contains("2"))
                        vision_sees_bonuses.Add(vision);
                    else
                        vision_doesnt_see_bonuses.Add(vision);
                } /* foreach (var line in lines)*/

                //sb.AppendLine("\tup\tright\tdown\tleft");
                //sb.AppendLine("up\t" + map[0, 0] + "\t" + map[0, 1] + "\t" + map[0, 2] + "\t" + map[0, 3]);
                //sb.AppendLine("right\t" + map[1, 0] + "\t" + map[1, 1] + "\t" + map[1, 2] + "\t" + map[1, 3]);
                //sb.AppendLine("bottom\t" + map[2, 0] + "\t" + map[2, 1] + "\t" + map[2, 2] + "\t" + map[2, 3]);
                //sb.AppendLine("left\t" + map[3, 0] + "\t" + map[3, 1] + "\t" + map[3, 2] + "\t" + map[3, 3]);

                foreach(var v in vision_sees_bonuses)
                {
                    sb.AppendLine(v);
                }

                using (SaveFileDialog s = new SaveFileDialog())
                {
                    s.FileName = Path.GetFileNameWithoutExtension(o.FileName)+"-Видит.txt";
                    s.RestoreDirectory = true;
                    s.ShowDialog();
                    System.IO.File.WriteAllText(s.FileName, sb.ToString());
                }

                sb.Clear();
                
                foreach (var v in vision_doesnt_see_bonuses)
                {
                    sb.AppendLine(v);
                }

                using (SaveFileDialog s = new SaveFileDialog())
                {
                    s.FileName = Path.GetFileNameWithoutExtension(o.FileName) + "-НеВидит.txt";
                    s.RestoreDirectory = true;
                    s.ShowDialog();
                    System.IO.File.WriteAllText(s.FileName, sb.ToString());
                }
                
            } // if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetSteps("angle");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetSteps("way");
        }

        void GetSteps(string type)
        {
            string[] folders = null;
            string[] csvFiles = null;
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    folders = Directory.GetDirectories(fbd.SelectedPath, "*ходы", SearchOption.AllDirectories);
                }
                else
                {
                    return;
                }
            }

            int[,] MemoryMap = new int[15, 15];  // Хардкод, в данном исследовании используютсятолько карты 15х15

            foreach (var folder in folders)
            {
                csvFiles = Directory.GetFiles(folder, "*.csv", SearchOption.AllDirectories);
                //}
                StringBuilder sb = new StringBuilder(csvFiles.Length);
                string first_file = csvFiles[0];
                string last_file = csvFiles[csvFiles.Length - 1];

                int patient_index = 0;

                foreach (var file in csvFiles)               // For each selected file ...
                {
                    // Инициализируем её восьмерками
                    Initialize(ref MemoryMap, 8);
                    //===================================================================================
                    string stat_file = file.Replace("Ходы", "Статистика ходов").Replace(".csv", ".txt");
                    string[] strings = null;
                    try
                    {
                        strings = File.ReadAllLines(stat_file);
                    }
                    catch
                    {
                        continue;
                    }
                    Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
                    int map_line = -1;
                    foreach (var s in strings)
                    {
                        map_line++;

                        if (s.StartsWith("[map]"))
                            break;

                        configs.Add(s.Split(':')[0], s.Split(':')[1]);
                    }
                    /*
                        map_ip:Карты\карта-15x15_19.txt
                        start:1,10
                        bonuses:10
                        up:13
                        right:17
                        down:7
                        left:5
                        */
                    int x = Int32.Parse(configs["start"].Split(',')[0]);
                    int y = Int32.Parse(configs["start"].Split(',')[1]);
                    //===================================================================================
                    var lines = File.ReadAllLines(file);        // ... read all lines from current file
                    foreach (var line in lines)                 // For each line in lines array ...
                    {
                        string[] newlines = line.Split(' ');    // Split line by "space" character
                        var debug0 = GetStringMap(MemoryMap);
                        string header = string.Empty;           // Name of patient and map (as usual)
                        for (int i = 0; i < newlines.Length - 1; i++)
                        {
                            header += newlines[i] + " ";
                        }

                        string steps = newlines[newlines.Length - 1];   // Last thing is steps sequence
                        string[] splitted_steps = steps.Split(';');     // Split steps by ";" character

                        List<string> bonuses_at_step = new List<string>();
                        List<string> vision_at_step = new List<string>();
                        List<string> memory_at_step = new List<string>();

                        string tmp = string.Empty;
                        string tmp1 = string.Empty;
                        string tmp2 = string.Empty;
                        int index = 0;
                        foreach (string splitted_step in splitted_steps)
                        {
                            if (splitted_step == "")
                                continue;
                            if (index == 0)
                            {
                                index++;
                                continue;
                            }
                            else
                            {
                                index = 0;
                            }

                            tmp = string.Empty;
                            tmp1 = string.Empty;
                            tmp2 = string.Empty;
                            //if (splitted_step.Length < 3)
                            //{
                            //    bonuses_at_step.Add(splitted_step);
                            //}
                            //else
                            //{
                            //=========================================================================================
                            int[,] tmpVision = null;
                            if (splitted_step.Length == 26)
                            {
                                tmpVision = this.GetIntVision(splitted_step.Substring(0, splitted_step.Length - 1));
                            }
                            else
                            {
                                if (splitted_step.Length == 1)
                                {
                                    switch (Int32.Parse(splitted_step))
                                    {
                                        case 1:
                                            y--;
                                            break;
                                        case 2:
                                            x++;
                                            break;
                                        case 3:
                                            y++;
                                            break;
                                        case 4:
                                            x--;
                                            break;

                                    }
                                    continue;
                                }
                                tmpVision = this.GetIntVision(splitted_step.Substring(0, splitted_step.Length));
                            }
                            this.UpdateMemoryMap(ref MemoryMap, tmpVision, x, y);

                            var debug1 = GetStringMap(MemoryMap);
                            tmp1 = this.GetStringMap(MemoryMap, "string");
                            for (int i = 0; i < tmp1.Length; i++)
                            {
                                tmp2 += tmp1[i] + " ";
                            }
                            tmp2 = tmp2.Remove(tmp2.Length - 1);
                            memory_at_step.Add(tmp2);
                            var debug = GetStringMap(MemoryMap);
                            if (splitted_step.Length == 26)
                            {
                                this.UpdateCoordinates(ref x, ref y, splitted_step.Last());
                            }
                            //=========================================================================================
                            for (int i = 0; i < splitted_step.Length; i++)
                            {
                                tmp += splitted_step[i] + " ";
                            }
                            tmp = tmp.Remove(tmp.Length - 1);
                            //=========================================================================================
                            int practicalWay = Int32.Parse(splitted_step.Last().ToString());
                            if (x < 0 || y < 0 || x >= 15 || y >= 15)
                            {
                                var debug2 = GetStringMap(MemoryMap);
                                var debug3 = GetStringMap(tmpVision);
                                var a = file;
                                throw new Exception();
                            }

                            string fin = string.Empty;
                            if(type == "angle")
                            {
                                int optimalWay = GetOptimalWay(MemoryMap, x, y);
                                /*    1
                                 * 4     2
                                 * 	  3
                                 * 1-1 =  0 = 0
                                 * 1-2 = -1 = 90
                                 * 1-3 = -2 = 180
                                 * 1-4 = -3 = 270
                                 * 
                                 * 2-1 =  1 = 270
                                 * 2-2 =  0 = 0
                                 * 2-3 = -1 = 90
                                 * 2-4 = -2 = 180
                                 * 
                                 * 3-1 =  2 = 180
                                 * 3-2 =  1 = 270
                                 * 3-3 =  0 - 0
                                 * 3-4 = -1 = 90 
                                 * 
                                 * 4-1 =  3 = 90
                                 * 4-2 =  2 = 180
                                 * 4-3 =  1 = 270
                                 * 4-4 =  0 = 0  */
                                string angle = string.Empty;
                                switch (practicalWay - optimalWay)
                                {
                                    case 0:
                                        angle = "0";
                                        break;
                                    case -1:
                                    case 3:
                                        angle = "90";
                                        break;
                                    case 2:
                                    case -2:
                                        angle = "180";
                                        break;
                                    case 1:
                                    case -3:
                                        angle = "270";
                                        break;
                                }
                                fin = angle;
                            } else if (type == "way")
                            {
                                fin = practicalWay.ToString();
                            }
                            
                            tmp = tmp.Substring(0, tmp.Length - 1) + fin;
                            vision_at_step.Add(tmp);
                            //}/*else*/
                        }/*foreach*/

                        int step_num = 0;
                        foreach (var vision in vision_at_step)
                        {
                            //sb.Append(patient_index + ";");
                            //sb.Append(header);
                            //sb.Append(step_num + ";");
                            //sb.Append(bonuses_at_step[step_num] + " ");
                            sb.Append(memory_at_step[step_num].Replace(" ", ";") + ";");
                            sb.Append(vision).Replace(" ", ";");
                            sb.AppendLine();
                            step_num++;
                        }
                    } /* foreach (var line in lines)*/
                    patient_index++;
                } /* foreach (var file in o.FileNames) */


                //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(first_file) + " - " + Path.GetFileNameWithoutExtension(last_file) + ".csv";
                //saveFileDialog1.RestoreDirectory = true;
                //saveFileDialog1.ShowDialog();

                string filename = Directory.GetParent(folder) + "\\[automated]ходы.txt";
                System.IO.File.WriteAllText(filename, sb.ToString());

                //this.SplitOneIntoFour(filename);
                SplitIntoAngles(filename, type);

            }/*foreach (var folder in folders)*/
            MessageBox.Show("Done");
        }


    }
}
