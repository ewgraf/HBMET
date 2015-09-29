using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Neural;
using System.IO;

namespace nn4_error_mining
{
    class Rabbit
    {
        private Network[] _networks;

        public Rabbit(Network[] networks)
        {
            _networks = networks;
        }

        /*
         * bool rage_mode использовать ли встряхивание (true) или нет (false)
         * */
        public NNWalkingStat GetSteps(string stat, bool rage_mode)
        {
            NNWalkingStat walk = new NNWalkingStat()
            {
                totalErrors     = 0,
                totalBonuses    = 0,
                totalWays       = new int[4] {0, 0, 0, 0},
                totalGoods      = 0
            };

            Random r = new Random();

            #region Walking area

            #region Parsing stat file
            string[] strings = File.ReadAllLines(stat);
            Dictionary<string, string> configs = new Dictionary<string, string>(strings.Length);
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
                string nnAngle = Common.RecognisePath(_networks, double_tmp);
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




                if (rage_mode)
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



                walk.totalWays[practiceWayOfGOing - 1]++;
                if (practiceWayOfGOing != theoryBestWayGoing)
                    walk.totalErrors++;
                else
                    walk.totalGoods++;

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
                        return null;
                }
                if (map[x, y] == 2)
                {
                    walk.totalBonuses++;
                }
                map[x, y] = 3;

            }/* for step 0 -> 42 */
            #endregion

            return walk;
        }
    }
}
