namespace nn4_error_mining
{
    /*
     * Этот класс - контейнер трех значений:
     *      общее число ошибочных ходов
     *          ...     собранных бонусов
     *          ...     хдов по направлениям - вверх [0], вправо [1], вниз [2], влево [3]
     *          ...     совпадающих с абсолютным алгоритмом ходов
     * */
    class NNWalkingStat
    {
        public int   totalErrors;
        public int   totalBonuses;
        public int[] totalWays;
        public int   totalGoods;

        /*
         * Сминает словарь
         * */
        public static NNWalkingStat Sum(System.Collections.Generic.Dictionary<string, NNWalkingStat> walks)
        {
            NNWalkingStat walk = new NNWalkingStat(){
                totalErrors = 0,
                totalBonuses = 0,
                totalWays = new int[4]{0, 0, 0, 0},
                totalGoods = 0
            };

            foreach (var key in walks.Keys)
            {
                walk.totalErrors += walks[key].totalErrors;
                walk.totalBonuses += walks[key].totalBonuses;
                walk.totalWays = new int[4]
                {
                    walk.totalWays[0] + walks[key].totalWays[0],
                    walk.totalWays[1] + walks[key].totalWays[1],
                    walk.totalWays[2] + walks[key].totalWays[2],
                    walk.totalWays[3] + walks[key].totalWays[3]
                };
                walk.totalGoods += walks[key].totalGoods;
            }

            return walk;
        }
    }
}
