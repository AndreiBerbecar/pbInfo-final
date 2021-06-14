using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 a = Convert.ToInt64(txt1.Text);
            double rad =(double) Math.Sqrt(a);
            txt2.Text = rad.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
