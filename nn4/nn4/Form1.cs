using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace nn4
{
    enum Way
    {
        NoWay   = 0,
        Up      = 1,
        Right   = 2,
        Down    = 3,
        Left    = 4
    }

    public partial class Form1 : Form
    {
        #region Fields
        string[] maps;
        int map_id;
        int[,] map;
        Map_staff.map_generation_info m_g_i = new Map_staff.map_generation_info();
        int x = 0;
        int y = 0;
        int x1, y1;
        string[,] memory;

        int rememberSteps = 0;
        int gathered_bonuses = 0;
        int[,] bonuses;
        Way step_way = Way.NoWay; //Направление - куда пошел, 1 - Север, 2 - Восток, 3 - Юг, 4 - Запад

        string patient = "";
        int targets = 0;
        int max_steps = 0;
        int remember_steps = 0;

        int saved_experiments = 0;

        static Statistica global_stat_object;
        
        int iterator = 0;

        // Contains current map with bonuses on it
        string[] global_current_map;

        bool is_in_painting = false;
        private static int StepsTaken = 0;
        
        string map_name;
        #endregion

        //=============================================
        // Карта в память чувака, для оценивания ошибки
        //=============================================
        private static int[,] MemoryMap;

        #region Events
        public Form1()
        {
            InitializeComponent();
        }
        
        private void открытьКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
            //
            // Задача функции - сохранить пути к выбранным файлам в массив "maps"
            //
            //OpenFileDialog o = new OpenFileDialog();

            //o.Filter = "Карты|карта-*.txt";
            //o.Multiselect = true;
            //o.RestoreDirectory = true;
            
            //int iterator = 0;

            //if (o.ShowDialog() == DialogResult.OK && o.FileNames.Length > 0)
            //{
            //    maps = new string[o.FileNames.Length];
            //    foreach (var file in o.FileNames)
            //    {
            //        maps[iterator++] = file;
            //    }
            //}
            //o.Dispose();
        }

        //========================
        // Кнопка "Получить карту"
        //========================
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            pictureBox1.Focus();
            buttonGenerate.Enabled = false;
            //buttonGenerate.Focus();            
            if(maps == null)
            {
                MessageBox.Show("Загрузите карты!");
                открытьКартыToolStripMenuItem_Click(new Object(), new EventArgs());
                return;
            }
            Random r = new Random();
            map_id = r.Next(0, maps.Length);
            m_g_i.max_steps = max_steps;
            m_g_i.things = targets;
            this.Text = "Лабиринт, " + maps[map_id];
            string[] current_map = System.IO.File.ReadAllLines(maps[map_id]);
            m_g_i.map_width = (int)current_map[0].Length;
            m_g_i.map_heigth = (int)current_map.Length;
            // Инициализация большой расширяемой памяти-карты чувака
            MemoryMap = new int[m_g_i.map_width, m_g_i.map_heigth];
            Initialize(ref MemoryMap, 8);
            map = ParseStringArrayToInt(current_map);
            x = 0; y = 0;
            int destination = -1;
            if(checkBox3.Checked)
                destination = r.Next(1, m_g_i.map_width * m_g_i.map_heigth / 2);

            //===========================
            // Распределяем цели по карте
            //===========================
            map = CoverMapWithBonusesAndSelectStartPoint(m_g_i.things, map, destination, r);
            global_current_map = ParseIntArrayToString(map);

            m_g_i.things = targets;
            #region Statistic-staff
            // При каждом пуске инициализируем обект, хранящий статитику эксперимента
            global_stat_object = new Statistica();

            // Запоминаем начальные координаты оператора в начале эксперимента
            global_stat_object.X = x;
            global_stat_object.Y = y;
            #endregion
            map[x, y] = 3;            
            labelSteps.Text = "0";
            labelGathered.Text = "0";
            gathered_bonuses = 0;
            rememberSteps = remember_steps;

            //=======================================
            // Память о видимой области на i-том шагу
            //=======================================
            memory = new string[rememberSteps, 25 + 1];

            bonuses = new int[rememberSteps, 1];
            
            //===================================================
            // Сохраняем видимую область в memory на нулевом шаге
            // при генерации карты
            //===================================================
            memory = SaveVisibleAreaAtStep(map, 0, memory);
            string[] tmp = ParseIntArrayToString(MemoryMap);
            pictureBox1.Invalidate();


            Common.FindBestWayAndTarget(ref MemoryMap, ref x, ref y, ref currentTargetPoint, ref currentTargetPath);
            

            this.KeyPreview = true;
            this.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //==================================
            // Загружаем конфиги из "config.ini"
            //==================================
            string[] strings = File.ReadAllLines("config.ini");
            Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
            foreach (var s in strings)
            {
                configs.Add(s.Split(new char[] { ':' })[0], s.Split(new char[] { ':' })[1]);
            }
            //patient        =             configs["patient"       ];
            patient = textBox1.Text;
            targets = Int32.Parse(configs["targets"]);
            max_steps = Int32.Parse(configs["max_steps"]);
            remember_steps = Int32.Parse(configs["remember_steps"]);
            OpenMaps();
            //toolStripStatusLabel1.Text = string.Format("Загружено {0} карт", maps.Length);
            toolStripStatusLabel1.Text = string.Format("Сохранено экспериментов: 0");
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            is_in_painting = true;
            //pictureBox1.BackColor = Color.WhiteSmoke;
            if (map == null)
                return;
            int numOfCells = map.Length;
            int cellSize = pictureBox1.Width / map.GetLength(0);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);  //  рамка
            for (int y = 0; y < numOfCells; y++)    // ячейки
            {
                e.Graphics.DrawLine(Pens.Black, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }
            for (int x = 0; x < numOfCells; x++)
            {
                e.Graphics.DrawLine(Pens.Black, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }
            DrawMemory(e, 255, map, true, false);
            if (checkBox1.Checked)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (!((Math.Abs(x - i) <= 2) && (Math.Abs(y - j) <= 2)))
                        {
                            e.Graphics.FillRectangle(Brushes.Gray, i * cellSize, j * cellSize, cellSize, cellSize);
                        }
                    }
                }
            }
            //DrawMemory(e, 64, MemoryMap, false, true);
            is_in_painting = false;

            ////Отображаем цель
            Brush greenBrush = new SolidBrush(Color.FromArgb(128, 0, 255, 0));
            e.Graphics.FillRectangle(greenBrush, currentTargetPoint.X * cellSize, currentTargetPoint.Y * cellSize, cellSize, cellSize);

            Pen pen = new Pen(Color.Black, 5);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, currentTargetPoint.X * cellSize + cellSize / 2, currentTargetPoint.Y * cellSize + cellSize / 2, x * cellSize + cellSize / 2, y * cellSize + cellSize / 2);

            Point from = new Point(x * cellSize + cellSize / 2, y * cellSize + cellSize / 2);
            Point to = new Point(0, 0);
            for (int i = 0; i < currentTargetPath.Count; i++)
            {
                to = new Point(currentTargetPath[i].X * cellSize + cellSize / 2, currentTargetPath[i].Y * cellSize + cellSize / 2);
                e.Graphics.DrawLine(Pens.Brown, from, to);
                from = to;
            }

        }

        private void DrawMemory(PaintEventArgs e, int alpha, int[,] iMap, bool drawPlayer, bool drawSpaces)
        {
            int numOfCells = iMap.Length;
            int cellSize = pictureBox1.Width / iMap.GetLength(0);

            Brush blackBrush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0));
            Brush whiteBrush = new SolidBrush(Color.FromArgb(alpha, 255, 255, 255));
            Brush goldBrush = new SolidBrush(Color.FromArgb(alpha, 255, 215, 0));
            // Рисуем поверх всего то что у нас в памяти
            for (int i = 0; i < iMap.GetLength(0); i++)
            {
                for (int j = 0; j < iMap.GetLength(1); j++)
                {
                    if (iMap[i, j] == 0) // wall
                    {
                        //_out = "█";
                        e.Graphics.FillRectangle(blackBrush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                    if (drawSpaces && iMap[i, j] == 1) // space
                    {
                        e.Graphics.FillRectangle(whiteBrush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                    if (iMap[i, j] == 2) // gold
                    {
                        e.Graphics.FillEllipse(goldBrush, i * cellSize, j * cellSize, cellSize, cellSize);
                    }
                    if(drawPlayer && iMap[i, j] == 3) // player
                    {
                        Brush burlyWoodBrush = new SolidBrush(Color.FromArgb(alpha, 222, 184, 135));
                        e.Graphics.FillPie(burlyWoodBrush, i * cellSize, j * cellSize, cellSize, cellSize, 30, 300);
                    }
                }
            }
        }

        private static Point currentTargetPoint = new Point(0, 0);
        private static List<Point> currentTargetPath = new List<Point>();

        // KEY-PRESS
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (is_in_painting)
                return;
            StepsTaken++;
            x1 = x; y1 = y;
            map[x, y] = 1;
            switch (e.KeyChar)
            {
                case 'w':
                case 'ц':
                    step_way = Way.Up;
                    global_stat_object.AddUp();
                    Map_staff.go_up(ref x, ref y, map);
                    break;
                case 's':
                case 'ы':
                    step_way = Way.Down;
                    global_stat_object.AddDown();
                    Map_staff.go_down(ref x, ref y, map);
                    break;
                case 'a':
                case 'ф':
                    step_way = Way.Left;
                    global_stat_object.AddLeft();
                    Map_staff.go_left(ref x, ref y, map);
                    break;
                case 'd':
                case 'в':
                    step_way = Way.Right;
                    global_stat_object.AddRight();
                    Map_staff.go_right(ref x, ref y, map);
                    break;
                default:
                    return;
            }

            if (x == x1 && y == y1)
                return;

            //labelSteps.Text = (Int32.Parse(labelSteps.Text) + 1).ToString();
            if (map[x, y] == 2)
            {
                m_g_i.things--;
                gathered_bonuses++;
                //labelGathered.Text = gathered_bonuses.ToString();
            }
            map[x, y] = 3;
            //
            // Добавляем видимую область на очередном шаге StepsTaken
            //
            if (StepsTaken < rememberSteps)
            {
                bonuses[StepsTaken, 0] = gathered_bonuses;
                memory = SaveVisibleAreaAtStep(map, StepsTaken, memory);
                // В последнюю ячейку предыдущего хода пишем куда пошли
                memory[StepsTaken - 1, 25] = ((int)step_way).ToString();
                string[] tmp = ParseIntArrayToString(MemoryMap);
            }
            //
            // Если сделали больше либо столько же,
            // то сдвигаем все ячейки влево на одну в memory и в посленюю освободившуюся
            // записываем что видим в данный ход
            //
            if (StepsTaken >= rememberSteps)
            {
                for (int i = 0; i < rememberSteps - 1; i++)
                {
                    bonuses[i, 0] = bonuses[i + 1, 0];
                }
                bonuses[rememberSteps - 1, 0] = gathered_bonuses;
                string[,] temp = memory;
                int block = 0;
                //
                // Сдвигаем
                //
                for (int step = 0; step <= rememberSteps - 2; step++)
                {
                    for (block = 0; block < 25 + 1; block++)
                    {
                        memory[step, block] = temp[step + 1, block];
                    }
                }
                //
                // Пишем
                //
                memory = SaveVisibleAreaAtStep(map, rememberSteps - 1, memory);
                memory[rememberSteps - 2, 25] = ((int)step_way).ToString();
            }
            var tmp1 = ParseIntArrayToString(MemoryMap);

            Common.FindBestWayAndTarget(ref MemoryMap, ref x, ref y, ref currentTargetPoint, ref currentTargetPath);

            //tmp1 = ParseIntArrayToString(MemoryMap);
            pictureBox1.Invalidate();
            m_g_i.max_steps--;
            if (m_g_i.things == 0 || m_g_i.max_steps == 0)
            {
                //MessageBox.Show("Победа!\nНажмике ОК чтобы сохранить эксперимент...");
                SaveExperiment();
                buttonGenerate_Click(null, null);
            }
        }        

        

        

        

        
        
        private void buttonSaveExperiment_Click(object sender, EventArgs e)
        {
            if (memory == null)
            {
                MessageBox.Show("Память пуста.");
                return;
            }

            SaveExperiment();
            return;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Ходы " + DateTime.Now.ToString("dd.MM.yyyy HH.mm") + ".csv";
            saveFileDialog1.Filter = "Файл эксперимента (*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();
            toolStripStatusLabel1.Text = "Сохраняем...";

            //Microsoft.Office.Interop.Excel._Application ExcelApp = null;
            //Microsoft.Office.Interop.Excel._Workbook book = null;
            //Microsoft.Office.Interop.Excel.Worksheet sheet = null;

            try
            {

                //ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                //book = ExcelApp.Application.Workbooks.Add();
                //sheet = book.Worksheets[1];

                ////Range range = sheet.get_Range("A1");
                ////range.Columns.ColumnWidth = 22.34;
                ////range = sheet.get_Range("B1");
                ////range.Columns.ColumnWidth = 22.34;
                ////sheet.get_Range("A1", "B1").Font.Bold = true;

                //sheet = book.ActiveSheet;
                StringBuilder sb = new StringBuilder();
                int steps = memory.GetLength(0);
                int size = memory.GetLength(1);
                //sheet.Cells[1, 1] = "#!";
                //sheet.Cells.ColumnWidth = 2;
                int step = 1;
                int stage = 0;
                for (int i = 0; i < steps; i++)
                {
                    //sheet.Cells[2, step++] = bonuses[stage++, 0].ToString();   // Пишим бонус
                    sb.Append(bonuses[stage++, 0].ToString());
                    sb.Append(";");
                    for (int j = 0; j < size; j++)
                    {
                        sb.Append(memory[i, j]);
                    }
                    sb.Append(";");
                }
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());

                //
                // Чистим
                //
                //book.SaveAs(thisFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                //book.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Marshal.ReleaseComObject(ExcelApp);
                //Marshal.ReleaseComObject(book);
                toolStripStatusLabel1.Text = "Эксперимент сохранен";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            patient = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonGenerate_Click(new Object(), new EventArgs());
        }

        static uint[,] neironet_steps;
        static bool rush = false;
        static int nogo_way = -1;
        static int togo_way = -1;
        private void buttonPrepareNeironet_Click(object sender, EventArgs e)
        {
            string[] strings = File.ReadAllLines(stats[0]);
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
            map_name = configs["map_id"];
            int start_x = Int32.Parse(configs["start"].Split(',')[0]);
            int start_y = Int32.Parse(configs["start"].Split(',')[1]);

            string[] current_map = new string[15];

            for (int i = ++map_line; i < strings.Length; i++)
            {
                current_map[i - map_line] = strings[i];
            }

            m_g_i.max_steps = max_steps;
            m_g_i.things = targets;

            m_g_i.map_width = (int)current_map[0].Length;
            m_g_i.map_heigth = (int)current_map.Length;

            map = new int[m_g_i.map_width, m_g_i.map_heigth];
            #region String-map-to-int-map
            for (int j = 0; j < m_g_i.map_heigth; j++)
            {
                for (int i = 0; i < m_g_i.map_width; i++)
                {
                    map[i, j] = Int32.Parse(current_map[j][i].ToString());
                }
            }
            #endregion

            x = start_x; y = start_y;
            m_g_i.things = targets;

            #region Statistic-staff
            // При каждом пуске инициализируем обект, хранящий статитику эксперимента
            global_stat_object = new Statistica();

            // Запоминаем начальные координаты оператора в начале эксперимента
            global_stat_object.X = x;
            global_stat_object.Y = y;
            #endregion

            map[x, y] = 3;

            gathered_bonuses = 0;
            rememberSteps = remember_steps;
            memory = new string[rememberSteps, 1 + 5 * 5 + 1];
            bonuses = new int[rememberSteps, 1];

            int block = 0;
            int[] template = new int[25];
            for (int i = 0; i < template.Length; i++) { template[i] = 0; }  // Заполняем стенами
            //
            // Сохраняем видимую область в memory на нулевом шаге
            // при генерации карты
            //
            // Поле зрения - 5х5
            // , и если ходим по краю карты, то за пределами карты мы должны видеть стены
            #region Save-vision-to-memory[0, i]
            for (int j = y - 2; j <= y + 2; j++)
            {
                for (int i = x - 2; i <= x + 2; i++)
                {
                    try
                    {
                        template[block] = map[i, j];  // Если отрицателен один из координат
                    }
                    catch
                    {
                        template[block] = 0;          // То пишем стену
                    }
                    block++;
                }
            }
            for (int i = 0; i < template.Length; i++)
            {
                memory[0, i] = template[i].ToString();
            }
            #endregion

            global_stat_object = new Statistica();

            pictureBox1.Invalidate();
            this.KeyPreview = true;
            this.Focus();
            neironet_steps = new uint[15, 15];
            //this.buttonGenerate_Click(new Object(), new EventArgs());
            //this.buttonNextStep.Focus();
        }

        int global_step = 0;

        Point nn_preprev_step = new Point(-1, -1);
        Point nn_curr_step = new Point(-1, -1);
        int rem_step = 1;
        Way prev_step_way = Way.NoWay;
        Way curr_step_way = Way.NoWay;
        
        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            return;
            /*
            buttonNextStep.Enabled = false;
            if (global_step > 43)
                return;
            //nn_preprev_step.X = nn_curr_step.X;
            //nn_preprev_step.Y = nn_curr_step.Y;

            int max_i = 15;
            int max_j = 15;

            int visionIndex = 0;
            string[] vision = new string[1 + 1 + 24];
            vision[visionIndex++] = global_step.ToString();
            vision[visionIndex++] = gathered_bonuses.ToString();
            global_step++;
            labelSteps.Text = global_step.ToString();

            int from_y = y - 2;
            int to_y = y + 2;

            int from_x = x - 2;
            int to_x = x + 2;

            #region Get-vision-area-into-string[] vision
            for (int j = from_y; j <= to_y; j++)
            {
                for (int i = from_x; i <= to_x; i++)
                {
                    if (i < 0 || i >= max_i || j < 0 || j >= max_j)
                    {
                        vision[visionIndex] = "0";      // Если отрицателен один из координат
                    }                                   // то пишем стену
                    else
                    {
                        if (i == x && j == y || map[i, j] == 3) continue;
                        vision[visionIndex] = map[i, j].ToString();    // Иначе пишем то что на карте
                    }
                    visionIndex++;
                }
            }
            #endregion

            string[] _top_see = nn_top_see.Main(vision);
            string[] _right_see = nn_right_see.Main(vision);
            string[] _bottom_see = nn_bottom_see.Main(vision);
            string[] _left_see = nn_left_see.Main(vision);
            string[] _top_saw = nn_top_see.Main(vision);
            string[] _right_saw = nn_right_see.Main(vision);
            string[] _bottom_saw = nn_bottom_see.Main(vision);
            string[] _left_saw = nn_left_see.Main(vision);

            List<double> predictions = new List<double>(4) { 0, 0, 0, 0 };
            List<string[]> results = null;
            string tmp = String.Join("", vision);
            if (tmp.Substring(2, 24).Contains('2'))
            {
                results = new List<string[]>() { _top_see, _right_see, _bottom_see, _left_see };
            }
            else
            {
                results = new List<string[]>() { _top_saw, _right_saw, _bottom_saw, _left_saw };
            }

            int nn_index = 0;
            foreach (var result in results)
            {
                switch (result[0])
                {
                    case "0":
                        for (int i = 0; i < 4; i++)
                        {
                            if (i == nn_index) continue;
                            predictions[i] += Double.Parse(result[1]);
                        }
                        break;
                    default:
                        predictions[nn_index] += Double.Parse(result[1]);
                        break;
                }
                nn_index++;
            }

            if (prev_step_way != Way.NoWay)
            {
                double ex = 1.7;
                switch (prev_step_way)
                {
                    case Way.Up:
                        predictions[(int)Way.Down - 1] /= ex;
                        break;
                    case Way.Right:
                        predictions[(int)Way.Left - 1] /= ex;
                        break;
                    case Way.Down:
                        predictions[(int)Way.Up - 1] /= ex;
                        break;
                    case Way.Left:
                        predictions[(int)Way.Right - 1] /= ex;
                        break;
                }
            }

            int direction = predictions.IndexOf(predictions.Max());
            direction++;

            x1 = x; y1 = y;
            map[x, y] = 1;

            //neironet_steps[x, y]++;

            switch (direction)
            {
                case 1:
                    Map_staff.go_up(ref x, ref y, map);
                    global_stat_object.AddUp();
                    prev_step_way = Way.Up;
                    break;
                case 2:
                    Map_staff.go_right(ref x, ref y, map);
                    global_stat_object.AddRight();
                    prev_step_way = Way.Right;
                    break;
                case 3:
                    Map_staff.go_down(ref x, ref y, map);
                    global_stat_object.AddDown();
                    prev_step_way = Way.Down;
                    break;
                case 4:
                    Map_staff.go_left(ref x, ref y, map);
                    global_stat_object.AddLeft();
                    prev_step_way = Way.Left;
                    break;
                default:
                    curr_step_way = Way.NoWay;
                    return;
            }

            //nn_curr_step.X = x;
            //nn_curr_step.Y = y;

            //if (x == x1 && y == y1)
            //{
            //    map[x, y] = 3;
            //    buttonNextStep.Enabled = true;
            //    return;
            //}            

            //if (nn_preprev_step.Equals(nn_curr_step))
            //{
            //    int destiny = Random.Next(1, 5);
            //    switch (direction)
            //    {
            //        case 1:
            //            Map_staff.go_up(ref x, ref y, map);
            //            global_stat_object.AddUp();
            //            prev_step_way = Way.Up;
            //            break;
            //        case 2:
            //            Map_staff.go_right(ref x, ref y, map);
            //            global_stat_object.AddRight();
            //            prev_step_way = Way.Right;
            //            break;
            //        case 3:
            //            Map_staff.go_down(ref x, ref y, map);
            //            global_stat_object.AddDown();
            //            prev_step_way = Way.Down;
            //            break;
            //        case 4:
            //            Map_staff.go_left(ref x, ref y, map);
            //            global_stat_object.AddLeft();
            //            prev_step_way = Way.Left;
            //            break;
            //        default:
            //            curr_step_way = Way.NoWay;
            //            return;
            //    }
            //    nn_curr_step.X = x;
            //    nn_curr_step.Y = y;
            //}

            if (map[x, y] == 2)
            {
                m_g_i.things--;
                gathered_bonuses++;
            }

            map[x, y] = 3;
            pictureBox1.Invalidate();
            buttonNextStep.Enabled = true;
            */
        }

        private void buttonLoadStat_Click(object sender, EventArgs e)
        {
            //
            // Задача функции - сохранить пути к выбранным файлам в массив "maps"
            //
            OpenFileDialog o = new OpenFileDialog();

            o.Filter = "Статистика|Статистика *.txt";
            o.Multiselect = true;
            o.RestoreDirectory = true;

            int iterator = 0;

            if (o.ShowDialog() == DialogResult.OK && o.FileNames.Length > 0)
            {
                stats = new string[o.FileNames.Length];
                foreach (var file in o.FileNames)
                {
                    stats[iterator++] = file;
                }
            }
            o.Dispose();
        }

        private void buttonGetNNStat_Click(object sender, EventArgs e)
        {
            //buttonGenerate_Click(sender, e);

            char step = '\0';

            for (int i = 0; i < 42*200; i++)
            {
                if(x < currentTargetPath[0].X)
                {
                    step = 'в';
                }
                else if (currentTargetPath[0].X < x)
                {
                    step = 'a';
                }
                else if (y > currentTargetPath[0].Y)
                {
                    step = 'w';
                }
                else if (currentTargetPath[0].Y > y)
                {
                    step = 's';
                }
                Form1_KeyPress(sender, new KeyPressEventArgs(step));
            }


            return;
            //foreach (var stat in stats)
            //{
            //    string[] strings = File.ReadAllLines(stat);
            //    Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
            //    int map_line = -1;
            //    foreach (var s in strings)
            //    {
            //        map_line++;

            //        // Обнаружили [map], выходим из цикла, дальше только карта
            //        if (s.StartsWith("[map]"))
            //            break;

            //        configs.Add(s.Split(':')[0], s.Split(':')[1]);
            //    }
            //    /*  map_ip:Карты\карта-15x15_19.txt
            //        start:1,10
            //        bonuses:10
            //        up:13
            //        right:17
            //        down:7
            //        left:5                          */
            //    map_name = configs["map_id"];
            //    int start_x = Int32.Parse(configs["start"].Split(',')[0]);
            //    int start_y = Int32.Parse(configs["start"].Split(',')[1]);

            //    // Считываем карту что после [map]
            //    string[] current_map = new string[15];
            //    for (int i = ++map_line; i < strings.Length; i++)
            //    {
            //        current_map[i - map_line] = strings[i];
            //    }

            //    m_g_i.max_steps = max_steps;
            //    m_g_i.things = targets;

            //    m_g_i.map_width = (int)current_map[0].Length;
            //    m_g_i.map_heigth = (int)current_map.Length;

            //    map = new int[m_g_i.map_width, m_g_i.map_heigth];
            //    #region String-map-to-int-map
            //    for (int j = 0; j < m_g_i.map_heigth; j++)
            //    {
            //        for (int i = 0; i < m_g_i.map_width; i++)
            //        {
            //            map[i, j] = Int32.Parse(current_map[j][i].ToString());
            //        }
            //    }
            //    #endregion

            //    x = start_x; y = start_y;
            //    m_g_i.things = targets;

            //    #region Statistic-staff
            //    // При каждом пуске инициализируем обект, хранящий статитику эксперимента
            //    global_stat_object = new Statistica();

            //    // Запоминаем начальные координаты оператора в начале эксперимента
            //    global_stat_object.X = x;
            //    global_stat_object.Y = y;
            //    #endregion

            //    map[x, y] = 3;

            //    gathered_bonuses = 0;
            //    rememberSteps = remember_steps;
            //    memory = new string[rememberSteps, 1 + 1 + 24];
            //    bonuses = new int[rememberSteps, 1];

            //    int block = 0;
            //    int[] template = new int[25];
            //    for (int i = 0; i < template.Length; i++) { template[i] = 0; }  // Заполняем стенами
            //    //
            //    // Сохраняем видимую область в memory на нулевом шаге
            //    // при генерации карты
            //    //
            //    // Поле зрения - 5х5
            //    // , и если ходим по краю карты, то за пределами карты мы должны видеть стены
            //    #region Save-vision-to-memory[0, i]
            //    for (int j = y - 2; j <= y + 2; j++)
            //    {
            //        for (int i = x - 2; i <= x + 2; i++)
            //        {
            //            try
            //            {
            //                template[block] = map[i, j];  // Если отрицателен один из координат
            //            }
            //            catch
            //            {
            //                template[block] = 0;          // То пишем стену
            //            }
            //            block++;
            //        }
            //    }
            //    for (int i = 0; i < template.Length; i++)
            //    {
            //        memory[0, i] = template[i].ToString();
            //    }
            //    #endregion

            //    global_stat_object = new Statistica();

            //    for (int step = 0; step < 42; step++)
            //    {
            //        //nn_preprev_step.X = nn_curr_step.X;
            //        //nn_preprev_step.Y = nn_curr_step.Y;

            //        int visionIndex = 0;
            //        int max_i = 15;
            //        int max_j = 15;

            //        string[] vision = new string[1 + 1 + 24];
            //        vision[visionIndex++] = global_step.ToString();
            //        vision[visionIndex++] = gathered_bonuses.ToString();
            //        global_step++;
            //        //labelSteps.Text = global_step.ToString();

            //        int from_y = y - 2;
            //        int to_y = y + 2;

            //        int from_x = x - 2;
            //        int to_x = x + 2;

            //        #region Get-vision-area-into-string[] vision
            //        for (int j = y - 2; j <= y + 2; j++)
            //        {
            //            for (int i = x - 2; i <= x + 2; i++)
            //            {
            //                if (i < 0 || i >= max_i || j < 0 || j >= max_j)
            //                {
            //                    vision[visionIndex] = "0";      // Если отрицателен один из координат
            //                }                                   // то пишем стену
            //                else
            //                {
            //                    if (j == x && i == y || map[i, j] == 3)
            //                    {
            //                        continue;
            //                    }
            //                    vision[visionIndex] = map[i, j].ToString();    // Иначе пишем то что на карте
            //                }
            //                visionIndex++;
            //            }
            //        }
            //        #endregion

            //        string[] _top_see = nn_top_see.Main(vision);
            //        string[] _right_see = nn_right_see.Main(vision);
            //        string[] _bottom_see = nn_bottom_see.Main(vision);
            //        string[] _left_see = nn_left_see.Main(vision);
            //        string[] _top_saw = nn_top_see.Main(vision);
            //        string[] _right_saw = nn_right_see.Main(vision);
            //        string[] _bottom_saw = nn_bottom_see.Main(vision);
            //        string[] _left_saw = nn_left_see.Main(vision);

            //        List<double> predictions = new List<double>(4) { 0, 0, 0, 0 };
            //        List<string[]> results = null;
            //        string tmp = String.Join("", vision);
            //        if (tmp.Substring(2, 24).Contains('2'))
            //        {
            //            results = new List<string[]>() { _top_see, _right_see, _bottom_see, _left_see };
            //        }
            //        else
            //        {
            //            results = new List<string[]>() { _top_saw, _right_saw, _bottom_saw, _left_saw };
            //        }

            //        int nn_index = 0;
            //        foreach (var result in results)
            //        {
            //            switch (result[0])
            //            {
            //                case "0":
            //                    for (int i = 0; i < 4; i++)
            //                    {
            //                        if (i == nn_index) continue;
            //                        predictions[i] += Double.Parse(result[1]);
            //                    }
            //                    break;
            //                default:
            //                    predictions[nn_index] += Double.Parse(result[1]);
            //                    break;
            //            }
            //            nn_index++;
            //        }

            //        if (prev_step_way != Way.NoWay)
            //        {
            //            double ex = 1.7;
            //            switch (prev_step_way)
            //            {
            //                case Way.Up:
            //                    predictions[(int)Way.Down - 1] /= ex;
            //                    break;
            //                case Way.Right:
            //                    predictions[(int)Way.Left - 1] /= ex;
            //                    break;
            //                case Way.Down:
            //                    predictions[(int)Way.Up - 1] /= ex;
            //                    break;
            //                case Way.Left:
            //                    predictions[(int)Way.Right - 1] /= ex;
            //                    break;
            //            }
            //        }

            //        int direction = predictions.IndexOf(predictions.Max());
            //        direction++;

            //        x1 = x; y1 = y;
            //        map[x, y] = 1;

            //        switch (direction)
            //        {
            //            case 1:
            //                Map_staff.go_up(ref x, ref y, map);
            //                global_stat_object.AddUp();
            //                prev_step_way = Way.Up;
            //                break;
            //            case 2:
            //                Map_staff.go_right(ref x, ref y, map);
            //                global_stat_object.AddRight();
            //                prev_step_way = Way.Right;
            //                break;
            //            case 3:
            //                Map_staff.go_down(ref x, ref y, map);
            //                global_stat_object.AddDown();
            //                prev_step_way = Way.Down;
            //                break;
            //            case 4:
            //                Map_staff.go_left(ref x, ref y, map);
            //                global_stat_object.AddLeft();
            //                prev_step_way = Way.Left;
            //                break;
            //            default:
            //                curr_step_way = Way.NoWay;
            //                return;
            //        }

            //        //nn_curr_step.X = x;
            //        //nn_curr_step.Y = y;

            //        //if (x == x1 && y == y1)
            //        //{
            //        //    map[x, y] = 3;
            //        //    continue;
            //        //}

            //        //if (nn_preprev_step.Equals(nn_curr_step))
            //        //{
            //        //    int destiny = Random.Next(1, 5);

            //        //    switch (direction)
            //        //    {
            //        //        case 1:
            //        //            Map_staff.go_up(ref x, ref y, map);
            //        //            global_stat_object.AddUp();
            //        //            prev_step_way = Way.Up;
            //        //            break;
            //        //        case 2:
            //        //            Map_staff.go_right(ref x, ref y, map);
            //        //            global_stat_object.AddRight();
            //        //            prev_step_way = Way.Right;
            //        //            break;
            //        //        case 3:
            //        //            Map_staff.go_down(ref x, ref y, map);
            //        //            global_stat_object.AddDown();
            //        //            prev_step_way = Way.Down;
            //        //            break;
            //        //        case 4:
            //        //            Map_staff.go_left(ref x, ref y, map);
            //        //            global_stat_object.AddLeft();
            //        //            prev_step_way = Way.Left;
            //        //            break;
            //        //        default:
            //        //            curr_step_way = Way.NoWay;
            //        //            return;
            //        //    }
            //        //    nn_curr_step.X = x;
            //        //    nn_curr_step.Y = y;
            //        //}

            //        if (map[x, y] == 2)
            //        {
            //            gathered_bonuses++;
            //        }

            //        map[x, y] = 3;
            //    }/* for step 0 -> 42 */
            //    SaveNNExperiment();
            //}/* foreach stat in stats*/

        }
        #endregion

        #region Methods
        private void OpenMaps()
        {
            try
            {
                maps = System.IO.Directory.GetFiles("Карты", "карта-*.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить карты:\n" + ex.Message);
            }
        }


        private static int[,] ParseStringArrayToInt(string[] iArray)
        {
            int _width = (int)iArray[0].Length;
            int _heigth = (int)iArray.Length;
            int[,] oArray = new int[_width, _heigth];
            for (int j = 0; j < _heigth; j++)
                for (int i = 0; i < _width; i++)
                    oArray[i, j] = Int32.Parse(iArray[j][i].ToString());
            return oArray;
        }


        private string[,] SaveVisibleAreaAtStep(int[,] iMap, int iStep, string[,] ioMemory)
        {
            int block = 0;
            int[] template = new int[25];
            int max_i = map.GetLength(0);
            int max_j = map.GetLength(1);
            // Поле зрения - 5х5
            // , и если ходим по краю карты, то за пределами карты мы должны видеть стены
            // Проходим по видимой в данный момент области 5х5, и сохраняем все в int[25] template
            for (int j = y - 2; j <= y + 2; j++)
                for (int i = x - 2; i <= x + 2; i++)
                {
                    if (i < 0 || i >= max_i || j < 0 || j >= max_j)
                    {
                        template[block] = 0;            // Если отрицателен один из координат
                    }                                   // то пишем стену
                    else
                    {
                        template[block] = map[i, j];    // Иначе пишем то что на карте
                        MemoryMap[i, j] = iMap[i, j];   // Обновляем глобальную карту в памяти
                    }
                    block++;
                }
            for (int i = 0; i < template.Length; i++)
                ioMemory[iStep, i] = template[i].ToString();
            return ioMemory;
        }

        private string[] ParseIntArrayToString(int[,] iMap)
        {
            int width   = iMap.GetLength(0);
            int heigth  = iMap.GetLength(1);
            string[] oMap = new string[heigth];
            for (int j = 0; j < heigth; j++)
                for (int i = 0; i < width; i++)
                    oMap[j] += iMap[i, j].ToString();
            return oMap;
        }

        private int[,] CoverMapWithBonusesAndSelectStartPoint(int bonusesLeft, int[,] ioMap, int destination, Random r)
        {
            int width   = ioMap.GetLength(0);
            int heigth  = ioMap.GetLength(1);
            int index   = 0;
            while (bonusesLeft > 0)
            {
                for (int j = 0; j < heigth; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        if (ioMap[i, j] == 1 && bonusesLeft > 0)
                        {
                            //
                            // Начальные координаты
                            //
                            if (index++ == destination)
                            {
                                x = i; y = j;
                                continue;
                            }
                            if (r.Next(1, width * heigth / 10) == 1)
                            {
                                if (i != x && j != y)
                                {
                                    ioMap[i, j] = 2;
                                    bonusesLeft--;
                                }
                            }
                        }
                    }
                }
            }
            return ioMap;
        }
                
        private byte[] StringToBytes(string sbytes)
        {
            if (sbytes == "") return new byte[] { 0 };
            List<string> lines = new List<string>(sbytes.Split(new char[] { ',' }));
            List<byte> lbytes = new List<byte>();
            foreach (var b in lines)
            {
                lbytes.Add(byte.Parse(b));
            }
            return lbytes.ToArray();
        }

        // SAVING
        private void SaveExperiment()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(patient + " ");              // Добавляем имя пациента
                sb.Append(maps[map_id] + " ");                // Добавляем имя карты
                int steps = memory.GetLength(0);
                int size = memory.GetLength(1);
                int stage = 0;
                for (int i = 0; i < steps; i++)
                {
                    sb.Append(bonuses[stage++, 0].ToString()); // Добавляем количество собранных бонусов
                    sb.Append(";");
                    for (int j = 0; j < size; j++)
                    {
                        sb.Append(memory[i, j]);
                    }
                    sb.Append(";");
                }

                string filename = "Ходы " + DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss.ffffff") + ".csv";
                System.IO.File.WriteAllText(filename, sb.ToString());
                sb = new StringBuilder();
                sb.AppendLine("patient:"    + patient);
                sb.AppendLine("map_id:"     + maps[map_id]);
                sb.AppendLine("start:"      + global_stat_object.X + "," + global_stat_object.Y);
                sb.AppendLine("bonuses:"    + bonuses[bonuses.Length - 1, 0].ToString());
                sb.AppendLine("up:"         + global_stat_object.Up);
                sb.AppendLine("right:"      + global_stat_object.Right);
                sb.AppendLine("down:"       + global_stat_object.Down);
                sb.AppendLine("left:"       + global_stat_object.Left);
                sb.AppendLine("[map]");

                foreach(var s in global_current_map)
                {
                    sb.AppendLine(s);
                }

                //global_stat_object
                //filename = "Статистика ходов " + DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss.ffffff.") + DateTime.Now.Ticks + ".txt";
                filename = filename.Replace("Ходы", "Статистика ходов").Replace(".csv", ".txt");
                System.IO.File.WriteAllText(filename, sb.ToString());
                saved_experiments++;
                toolStripStatusLabel1.Text = "Сохранено экспериментов: " + saved_experiments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить эксперимент:\n" + ex.Message);
            }
        }


        static Random Random = new Random();

        private void RandomStep(int direction)
        {
            direction = Random.Next(1, 4);
            
            x1 = x; y1 = y;
            map[x, y] = 1;

            switch (direction)
            {
                case 1:
                    Map_staff.go_up(ref x, ref y, map);
                    global_stat_object.AddUp();
                    break;
                case 2:
                    Map_staff.go_right(ref x, ref y, map);
                    global_stat_object.AddRight();
                    break;
                case 3:
                    Map_staff.go_down(ref x, ref y, map);
                    global_stat_object.AddDown();
                    break;
                case 4:
                    Map_staff.go_left(ref x, ref y, map);
                    global_stat_object.AddLeft();
                    break;
                default:
                    return;
            }

            if (x == x1 && y == y1)
            {
                map[x, y] = 3;
                return;
            }

            if (map[x, y] == 2)
            {
                m_g_i.things--;
                gathered_bonuses++;
            }

            map[x, y] = 3;
            pictureBox1.Invalidate();
        }

        // Пути к файлам статистик
        string[] stats;
        int global_index_nn_stat_save = 0;

        [Obsolete]
        private void SaveNNExperiment()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("patient:" + "NEIRONET");              // Добавляем имя пациента
            sb.AppendLine("map_id:" + map_name);
            sb.AppendLine("bonuses:" + gathered_bonuses);
            sb.AppendLine("up:" + global_stat_object.Up);
            sb.AppendLine("right:" + global_stat_object.Right);
            sb.AppendLine("down:" + global_stat_object.Down);
            sb.AppendLine("left:" + global_stat_object.Left);

            //global_stat_object
            string filename = "Статистика ходов сети " + global_index_nn_stat_save + ".txt";
            global_index_nn_stat_save++;
            System.IO.File.WriteAllText(filename, sb.ToString());
        }

        // Инициализирует двумерный массив значением слова
        private void Initialize(ref int[,] ioArray, int iValue)
        {
            for (int i = 0; i < ioArray.GetLength(0); i++)
                for (int j = 0; j < ioArray.GetLength(1); j++)
                    ioArray[i, j] = iValue;
        }
        private int[] Initialize(int[] ioArray, int iValue)
        {
            for (int i = 0; i < ioArray.Length; i++)
                ioArray[i] = iValue;
            return ioArray;
        }
        #endregion
    }
}
#region comments
/*
 
        

 */


/*int visionIndex = 0;

                    int max_i = 15;
                    int max_j = 15;

                    string[] vision = new string[1 + 1 + 24];

                    vision[visionIndex++] = step.ToString();
                    vision[visionIndex++] = gathered_bonuses.ToString();

                    int from_y  = y - 2;
                    int to_y    = y + 2;

                    int from_x  = x - 2;
                    int to_x    = x + 2;

                    #region Get-vision-area-into-string[] vision
                    for (int j = y - 2; j <= y + 2; j++)
                    {
                        for (int i = x - 2; i <= x + 2; i++)
                        {
                            if (i < 0 || i >= max_i || j < 0 || j >= max_j)
                            {
                                vision[visionIndex] = "0";      // Если отрицателен один из координат
                            }                                   // то пишем стену
                            else
                            {
                                if (j == x && i == y || map[i, j] == 3) continue;
                                vision[visionIndex] = map[i, j].ToString();    // Иначе пишем то что на карте
                            }
                            //try
                            //{
                            //    template[block] = map[i, j];
                            //}
                            //catch
                            //{
                            //    template[block] = 0;
                            //}
                            visionIndex++;
                        }
                    }
                    #endregion

                    string[] _top       = Predict_Top     .   Main(vision);
                    string[] _right     = Predict_Right   .   Main(vision);
                    string[] _bottom    = Predict_Bottom  .   Main(vision);
                    string[] _left      = Predict_Left    .   Main(vision);

                    List<double> predictions = new List<double>(4) { 0, 0, 0, 0 };
                    List<string[]> results = new List<string[]>() { _top, _right, _bottom, _left };

                    int nn_index = 0;
                    foreach (var result in results)
                    {
                        switch (result[0])
                        {
                            case "0":
                                for (int i = 0; i < 4; i++)
                                {
                                    if (i == nn_index) continue;
                                    predictions[i] += Double.Parse(result[1]);
                                }
                                break;
                            default:
                                predictions[nn_index] += Double.Parse(result[1]);
                                break;
                        }
                        nn_index++;
                    }

                    int direction = predictions.IndexOf(predictions.Max());
                    direction++;

                    x1 = x; y1 = y;
                    map[x, y] = 1;

                    //neironet_steps[x, y]++;

                    switch (direction)
                    {
                        case 1:
                            Map_staff.go_up(ref x, ref y, map);
                            global_stat_object.AddUp();
                            break;
                        case 2:
                            Map_staff.go_right(ref x, ref y, map);
                            global_stat_object.AddRight();
                            break;
                        case 3:
                            Map_staff.go_down(ref x, ref y, map);
                            global_stat_object.AddDown();
                            break;
                        case 4:
                            Map_staff.go_left(ref x, ref y, map);
                            global_stat_object.AddLeft();
                            break;
                        default:
                            continue;
                    }

                    if (x == x1 && y == y1)
                        continue;

                    if (map[x, y] == 2)
                    {
                        m_g_i.things--;
                        gathered_bonuses++;
                    }

                    map[x, y] = 3;

                    //if (neironet_steps[x, y] > 5)
                    //{
                    //    this.RandomStep(direction);
                    //}*/
#endregion