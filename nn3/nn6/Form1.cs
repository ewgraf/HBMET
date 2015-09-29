using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 11111
             * 11111
             * 11 12
             * 11111
             * 11111 */
                                   // stem_num bonus_gathered map
            /*
                10100
                11111
                20311
                10100
                00100
            */
            string[] vision = new string[]{ "0", "0",   "1", "0", "1", "0", "0", 
                                                        "1", "1", "1", "1", "1", 
                                                        "2", "0",      "1", "1",
                                                        "1", "0", "1", "0", "0", 
                                                        "0", "0", "1", "0", "0" };
            //string[] vision = new string[]{ "0", "0",   "1", "1", "1", "1", "1", 
            //                                            "1", "1", "1", "0", "0", 
            //                                            "1", "1",      "0", "2",
            //                                            "1", "1", "1", "1", "1", 
            //                                            "1", "1", "1", "1", "1" };
            string[] _top       = Predict_Top.Main(vision);
            string[] _right     = Predict_Right.Main(vision);
            string[] _bottom    = Predict_Bottom.Main(vision);
            string[] _left      = Predict_Left.Main(vision);
            List<double> predictions = new List<double>(4) { 0, 0, 0, 0 };
            List<string[]> results = new List<string[]>() { _top, _right, _bottom, _left };

            int nn_index = 0;
            foreach(var result in results)
            {
                switch (result[0])
                {
                    case "0":
                        for (int i = 0; i < 4; i++ )
                        {
                            if (i == nn_index) continue;
                            predictions[i] += Double.Parse(result[1]);
                        }
                        break;
                    default:
                        predictions[nn_index] += Int32.Parse(result[1]);
                        break;
                }
                nn_index++;
            }
            int direction = predictions.IndexOf(predictions.Max());

        }
    }
}
