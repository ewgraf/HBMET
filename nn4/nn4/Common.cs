using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace nn4
{
    class Common
    {
        public static List<Point> FindAllBonuses(int[,] MemoryMap)
        {
            List<Point> bonuses = new List<Point>();
            for (int i = 0; i < MemoryMap.GetLength(0); i++)
                for (int j = 0; j < MemoryMap.GetLength(1); j++)
                    if (MemoryMap[i, j] == 2)
                    {
                        bonuses.Add(new Point(i, j));
                    }
            return bonuses;
        }
        public static bool OnTheEdge(int[,] MemoryMap, int i, int j)
        {
            int max_i = MemoryMap.GetLength(0);
            int max_j = MemoryMap.GetLength(1);
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
        public static List<Point> GetBestWay(List<List<Point>> listOfLists)
        {
            List<Point> path = new List<Point>();
            Int32 Min = Int32.MaxValue;
            // Похоже, что форыч не гарантирует "последовательность" перебора, элементы перебераются не по порядку
            //foreach (var list in listOfLists)
            for (int i = 0; i < listOfLists.Count; i++)
            {
                if (listOfLists[i].Count < Min)
                {
                    Min = listOfLists[i].Count;
                    path = listOfLists[i];
                }
            }
            return path;
        }
        public static void FindBestWayAndTarget(ref int[,] _MemoryMap, ref int x, ref int y, ref Point _currentTargetPoint, ref List<Point> _currentTargetPath)
        {
            //Найти цель
            //======================================================
            //Найти все координаты видимых бонусов и краев
            //======================================================
            List<Point> bonusesPoints = Common.FindAllBonuses(_MemoryMap);
            List<Point> edgesPoints = Common.FindAllEdges(_MemoryMap);
            //======================================================
            //Найти те, до которых можно дойти
            A_star a_star = new A_star();

            List<List<Point>> listOfListsOfBonuses = new List<List<Point>>();
            List<List<Point>> listOfListsOfEdges = new List<List<Point>>();

            foreach (var b in bonusesPoints)
            {
                var tmpListOfPoints = a_star.Find(_MemoryMap, new Point(x, y), b);
                if (tmpListOfPoints.Count > 0)
                    listOfListsOfBonuses.Add(tmpListOfPoints);
            }
            foreach (var edge in edgesPoints)
            {
                var tmpListOfPoints = a_star.Find(_MemoryMap, new Point(x, y), edge);
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

            //====
            //ЦЕЛЬ
            //====
            Point target = bestWay[bestWay.Count - 1];
            _currentTargetPoint = target;
            _currentTargetPath = bestWay;
            //====
        }

        // PARSER
        
    }
}
