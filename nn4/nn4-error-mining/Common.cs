using Neural;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn4_error_mining
{
    class Common
    {

        public static string[] ParseStringVision(string vision, int size)
        {
            string[] vis = vision.Split(' ');
            string[] res = new string[size];
            int index = 0;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    res[j] += vis[index++];
                }
            }
            return res;
        }

        public static string[] ParseArray(int[,] intVision)
        {
            int size = intVision.GetLength(0);
            string[] strintVision = new string[size];
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    strintVision[j] += intVision[i, j];
                }
            }
            return strintVision;
        }

        public static int[,] UpdateMap(string vision, int x, int y, int[,] MemoryMap)
        {
            string[] str_vision = Common.ParseStringVision(vision, 5);

            string[] a = vision.Split(' ');
            int max_i = MemoryMap.GetLength(0);
            int max_j = MemoryMap.GetLength(1);

            int[,] intVision = new int[15, 15];
            Common.Initialize(ref intVision, 8);

            int index = 0;
            for (int j = y - 2; j <= y + 2; j++)
            {
                for (int i = x - 2; i <= x + 2; i++)
                {
                    if (i < 0 || i >= max_i || j < 0 || j >= max_j)
                    {
                        index++;
                    }
                    else
                    {
                        intVision[i, j] = Int32.Parse(a[index++]);
                    }
                }
            }

            string[] str_intVision = Common.ParseArray(intVision);

            string[] str_MemoryMap = Common.ParseArray(MemoryMap);
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
                        MemoryMap[i, j] = intVision[i, j];   // Обновляем глобальную карту в памяти
                    }
                }
            return MemoryMap;
        }

        public static int FindErrors(List<string> vision_at_step, int x, int y)
        {
            //=================================
            // Контейнер с ошибками
            //=================================
            int errors = 0;
            //=================================
            //===================================================================
            //==========================  Найти цель  ===========================
            //===================================================================
            //===================================================================
            // Здесь наша глобальная карта, по мере прохождения она разведывается
            //===================================================================
            int[,] MemoryMap = new int[15, 15];  // Хардкод, в данном исследовании используютсятолько карты 15х15
            // Инициализируем её восьмерками
            Common.Initialize(ref MemoryMap, 8);

            foreach (var vision in vision_at_step)
            {
                // Куда пошел пацан
                int practiceWayOfGOing = 0;

                // Оптимальный путь
                int theoryBestWayGoing = 0;

                MemoryMap = Common.UpdateMap(vision, x, y, MemoryMap);
                var tmp = Common.ParseArray(MemoryMap);
                if (vision.Length != 52)
                    continue;

                practiceWayOfGOing = Int32.Parse(vision.Substring(50, 1));

                theoryBestWayGoing = Common.GetBestDirection(MemoryMap, x, y, "");

                if (practiceWayOfGOing != theoryBestWayGoing)
                    errors++;
            }
            
            return errors;
        }

        public static int GetBestDirection(int[,] MemoryMap, int x, int y, string line)
        {
            //===================================================================
            //Найти все координаты видимых бонусов и краев
            //====================================================
            List<Point> bonusesPoints = FindAllBonuses(MemoryMap);
            List<Point> edgesPoints = FindAllEdges(MemoryMap);
            //====================================================
            //Найти те, до которых можно дойти
            A_star a_star = new A_star();

            //var a = Common.ParseArray(MemoryMap);
            List<List<Point>> listOfListsOfBonuses = new List<List<Point>>();
            List<List<Point>> listOfListsOfEdges = new List<List<Point>>();

            foreach (var b in bonusesPoints)
            {
                var tmpListOfPoints = a_star.Find(MemoryMap, new Point(x, y), b);
                if (tmpListOfPoints.Count > 0)
                    listOfListsOfBonuses.Add(tmpListOfPoints);
            }
            foreach (var edge in edgesPoints)
            {
                var tmpListOfPoints = a_star.Find(MemoryMap, new Point(x, y), edge);
                if (tmpListOfPoints.Count > 0)
                    listOfListsOfEdges.Add(tmpListOfPoints);
            }

            List<Point> bestWay = null;

            //Если лист листов полон, то выбираем кротчайший путь
            if (listOfListsOfBonuses.Count > 0)
                bestWay = GetBestWay(listOfListsOfBonuses);
            //Если лист листов пуст, то либо не видим бонусов, либо до видимых не можем дойти
            //ищем ближайщий проход на границе неизвестности   
            else
            {
                bestWay = GetBestWay(listOfListsOfEdges);
            }
            //string[] str_MemoryMep = Common.ParseArray(MemoryMap);
            //====
            //ЦЕЛЬ
            //====
            Point way;
            if(bestWay.Count != 0)
                way = bestWay[0];
            else
                return -1;
            //currentTargetPoint = target;
            //currentTargetPath = bestWay;
            //====
            if (way.X > x)
            {
                return 2;
            }
            else if (way.X < x)
            {
                return 4;
            }
            else if (way.Y > y)
            {
                return 3;
            }
            else if (way.Y < y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static void Initialize(ref int[,] MemoryMap, int value)
        {
            for (int i = 0; i < MemoryMap.GetLength(0); i++)
                for (int j = 0; j < MemoryMap.GetLength(1); j++)
                    MemoryMap[i, j] = value;
        }

        public static List<Point> FindAllEdges(int[,] MemoryMap)
        {
            List<Point> edges = new List<Point>();
            for (int j = 0; j < MemoryMap.GetLength(1); j++)
                for (int i = 0; i < MemoryMap.GetLength(0); i++)
                    if (MemoryMap[i, j] == 1 && OnTheEdge(MemoryMap, i, j))
                    {
                        edges.Add(new Point(i, j));
                    }
            return edges;
        }

        public static bool OnTheEdge(int[,] MemoryMap, int i, int j)
        {
            int max_i = 15;
            int max_j = 15;
            max_i--;
            max_j--;

            if (
                (i >= 0 && i <= max_i && j >= 0 && j <= max_j) &&  // Если не выходим за границы карты, И
                // Если рядом есть хотя бы одна неразведанная область
                (MemoryMap[i + 1 >= max_i ? i : i + 1, j] == 8 ||
                    MemoryMap[i, j + 1 >= max_j ? j : j + 1] == 8 ||
                    MemoryMap[i - 1 < 0 ? i : i - 1, j] == 8 ||
                    MemoryMap[i, j - 1 < 0 ? j : j - 1] == 8)
            )
            {   // То говорим что данная клетка находится на краю
                return true;
            }
            else
                return false;
        }

        public static List<Point> GetBestWay(List<List<Point>> listOfLists)
        {
            List<Point> path = new List<Point>();
            Int32 Min = Int32.MaxValue;
            foreach (var list in listOfLists)
            {
                if (list.Count < Min)
                {
                    Min = list.Count;
                    path = list;
                }
            }
            return path;
        }

        public static List<Point> FindAllBonuses(int[,] MemoryMap)
        {
            List<Point> bonuses = new List<Point>();
            for (int i = 0; i < MemoryMap.GetLength(0); i++)
                for (int j = 0; j < MemoryMap.GetLength(1); j++)
                    if (MemoryMap[i, j] == 2)
                        bonuses.Add(new Point(i, j));
            return bonuses;
        }

        internal static int FindErrors(string memory)
        {

            

            return 1;
        }

        internal static int[,] ConstructArray(string memory, string line)
        {
            int[,] MemoryMap = new int[15, 15];
            var tmp = memory.Split(' ');
            int index = 0;
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 15; i++)
                {
                    MemoryMap[i, j] = Int32.Parse(tmp[index++]);
                }
            }
            return MemoryMap;
        }

        internal static double[] GetDouble(string vision, int p)
        {
            var tmp = vision.Split(' ');
            List<double> result = new List<double>();
            foreach (var item in tmp)
            {
                result.Add(Double.Parse(item));
            }
            return result.ToArray();
        }

        internal static string RecognisePath(Network[] networks, double[] memory)
        {
            Dictionary<string, double[]> results = new Dictionary<string, double[]>();
            results.Add("0",   networks[0].Compute(memory));
            results.Add("90",  networks[1].Compute(memory));
            results.Add("180", networks[2].Compute(memory));
            results.Add("270", networks[3].Compute(memory));

            Dictionary<string, double> predictions = new Dictionary<string, double>();
            foreach (var r in results.Keys)
            {
                predictions.Add(r, 0d);
            }

            foreach (var result in results)
            {
                string angle = result.Key;
                double predic = Math.Max(result.Value[0], result.Value[1]);// Наибольшая вероятность
                // Пример result.Value : 
                //          [0] 0,862429399125645
                //          [1] 0,277449151367172
                switch (Common.Max(result.Value))// Индекс этой наибольшей вероятности в массиве[2],
                // при обучении в начале идет класс "-1" - не распознаваемый, т.е. если Common.Max(result.Value) == 0 - 
                // то прибавляем всем остальным классам вероятность,
                // если же Common.Max(result.Value) == 1 то распознали класс, и прибавляем вероятность к нему.
                {
                    case 1:// Угол сети
                        predictions[angle] += predic;
                        break;
                    case 0:// Не её угол
                        var keys = predictions.Keys.ToList();
                        foreach (var item in keys)
                        {
                            if (item != angle) predictions[item] += predic;
                        }
                        break;
                }
            }
            string recognisedAngle = predictions.FirstOrDefault(n => n.Value == predictions.Values.Max()).Key;
            return recognisedAngle;
        }

        private static string[] ParseArray(string[] memory, int size)
        {
            string[] tmp = new string[size];
            int index = 0;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    tmp[j] += memory[index++];
                }
            }
            return tmp;
        }

        internal static string[] GenerateVision(int x, int y, int[,] map)
        {
            string[] vision = new string[25];
            int from_y = y - 2;
            int to_y = y + 2;

            int from_x = x - 2;
            int to_x = x + 2;
            int visionIndex = 0;
            var a = Common.ParseArray(map);
            for (int j = y - 2; j <= y + 2; j++)
            {
                for (int i = x - 2; i <= x + 2; i++)
                {
                    if (i < 0 || i >= 15 || j < 0 || j >= 15)
                    {
                        vision[visionIndex] = "0";      // Если отрицателен один из координат
                    }                                   // то пишем стену
                    else
                    {
                        //if (j == y && i == x || map[i, j] == 3)
                        //{
                        //    continue;
                        //}
                        vision[visionIndex] = map[i, j].ToString();    // Иначе пишем то - что на карте
                    }
                    visionIndex++;
                }
            }
            return vision;
        }

        internal static string[] GenerateMemory(int[,] map)
        {
            string[] memory = new string[15 * 15];
            int memoryIndex = 0;
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 15; i++)
                {
                    memory[memoryIndex++] = map[i, j].ToString();
                }
            }
            return memory;
        }

        internal static string[] ParseStringArrayVision(string[] vision, int size)
        {
            string[] res = new string[size];
            int index = 0;
            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    res[j] += vision[index++];
                }
            }
            return res;
        }

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

        internal static int Validate(Network network, double[] trainClasses, List<int> classes, double[][] input, double[][] output)
        {
            int j = 0;
            double[] res;
            for (int i = 0; i < input.Length; i++)
            {
                res = network.Compute(input[i]);
                if(trainClasses[i] == classes[Common.Max(res)])
                    j++;
            }
            return j;
        }

        public static bool ChechRage(List<string> _rageWays)
        {
            int _length = _rageWays.Count;
            if (_length < 4)
                return false;
            string a = _rageWays[_length - 1];
            string b = _rageWays[_length - 2];
            string c = _rageWays[_length - 3];
            string d = _rageWays[_length - 4];
            //if (a + b == c + d && !((a == b) && (b == c) && (c == d) && (a == c) && (a == d) && (b == d)))
            //if ((a == b) && (a == c) && (a == d) && (b == c) && (b == d) && (c == d))
            if ((a == c) && (b == d) &&
                // и если направление противоположны,
                // например 1-3, 2-4
                (
                    Int32.Parse(a) + Int32.Parse(b) == 4 ||
                    Int32.Parse(a) + Int32.Parse(b) == 6
                ))
                return true;
            else
                return false;
        }
    }
}
