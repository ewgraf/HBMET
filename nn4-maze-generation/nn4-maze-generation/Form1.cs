using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn4_maze_generation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Эллеров Лабиринт";
            /* Number of maps generate to
             * */
            int count = 20;
            for (int i = 0; i < count; i++)
            {
                Eller eller = new Eller(8, 8, r);
                eller.makeMaze();
                System.IO.File.WriteAllText("Карты\\карта-15х15_" + i.ToString() + ".txt", eller.getMaze());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eller eller = new Eller(8, 8, r);
            eller.makeMaze();
            richTextBox1.Text = eller.getMaze();
        }
    }
}
