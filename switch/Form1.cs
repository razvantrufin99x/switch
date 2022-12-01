using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace @switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void schimba(ref string x, ref string y)
        {
            string tmp;
            tmp = x;
            x = y ;
            y = tmp;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            schimba(ref a, ref b );
            textBox1.Text = a;
            textBox2.Text = b;
        }
    }
}
