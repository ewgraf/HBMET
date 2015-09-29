using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn4_Astar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] Map;
        int MapWidht;
        int MapHeight;

        private void Form1_Load(object sender, EventArgs e)
        {
            int[,] WayMap;

            MapWidht = 16;
            MapHeight = 9;
            Map = new int[,]{
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
                {1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}};
            WayMap = new int[10, 10];
            FindWave(2, 5, 3, 4);
        }

        public void FindWave(int startX, int startY, int targetX, int targetY)
        {
            bool add = true;
            int[,] cMap = new int[MapHeight, MapWidht];
            int x, y, step = 0;
            for (y = 0; y < MapHeight; y++)
                for (x = 0; x < MapWidht; x++)
                {
                    if (Map[y, x] == 1)
                        cMap[y, x] = -2;//индикатор стены
                    else
                        cMap[y, x] = -1;//индикатор еще не ступали сюда
                }
            cMap[targetY, targetX] = 0;//Начинаем с финиша
            while (add == true)
            {
                add = false;
                for (y = 0; y < MapWidht; y++)
                {
                    for (x = 0; x < MapHeight; x++)
                    {
                        if (cMap[x, y] == step)
                        {
                            //Ставим значение шага+1 в соседние ячейки (если они проходимы)
                            if (y - 1 >= 0 && cMap[x - 1, y] != -2 && cMap[x - 1, y] == -1)
                                cMap[x - 1, y] = step + 1;
                            if (x - 1 >= 0 && cMap[x, y - 1] != -2 && cMap[x, y - 1] == -1)
                                cMap[x, y - 1] = step + 1;
                            if (y + 1 < MapWidht && cMap[x + 1, y] != -2 && cMap[x + 1, y] == -1)
                                cMap[x + 1, y] = step + 1;
                            if (x + 1 < MapHeight && cMap[x, y + 1] != -2 && cMap[x, y + 1] == -1)
                                cMap[x, y + 1] = step + 1;
                        }
                    }
                }
                step++;
                add = true;
                if (cMap[startY, startX] != -1)//решение найдено
                    add = false;
                if (step > MapWidht * MapHeight)//решение не найдено
                    add = false;
            }
            StringBuilder sb = new StringBuilder();
            //Отрисовываем карты
            for (y = 0; y < MapHeight; y++)
            {
                for (x = 0; x < MapWidht; x++)
                {
                    if (cMap[y, x] == -1)
                        sb.Append(" ");
                    else
                        if (cMap[y, x] == -2)
                            sb.Append("#");
                        else
                            if (y == startY && x == startX)
                                sb.Append("S");
                            else
                                if (y == targetY && x == targetX)
                                    sb.Append("F");
                                else
                                    if (cMap[y, x] > -1)
                                        //sb.Append(cMap[y, x].ToString());
                                        sb.Append(".");
                }
                sb.AppendLine();
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
