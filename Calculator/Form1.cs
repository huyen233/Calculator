﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a + b;
            txtkq.Text = c.ToString();
        }

<<<<<<< HEAD
        private void bttru_Click(object sender, EventArgs e)
=======
        private void btTru_Click(object sender, EventArgs e)
>>>>>>> 66ea9f744e1e4b980bc5239545bd76c18b2f8409
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = a - b;
            txtkq.Text = c.ToString();
        }
    }
}
