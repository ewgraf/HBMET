using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nn4_skolko_bolshe_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = System.IO.File.ReadAllLines("a.out");
            int b = 0;
            foreach(var aa in a)
            {
                if(Int32.Parse(aa) > 32)
                {
                    b++;
                }
            }
            MessageBox.Show(b.ToString());
        }
    }
}
