using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn4_test_random_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();

            int[] data = new int[1000];

            for(int i = 0; i < 1000; i++)
            {
                data[i] = r.Next(0, 100);
            }

            File.WriteAllLines(
                @"0-99.txt",
                data.Select(d => d.ToString()).ToArray()
            );

            for (int i = 0; i < 1000; i++)
            {
                data[i] = r.Next(0, 2);
            }

            File.WriteAllLines(
                @"0-1.txt",
                data.Select(d => d.ToString()).ToArray()
            );

            for (int i = 0; i < 1000; i++)
            {
                data[i] = r.Next(1, 3);
            }

            File.WriteAllLines(
                @"1-2.txt",
                data.Select(d => d.ToString()).ToArray()
            );

        }
    }
}
