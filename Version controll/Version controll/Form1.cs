﻿using System;

using System.Windows.Forms;

namespace Version_controll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cevata cv = new cevata();
            cv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adaoga un text te roggg !!!!!!!");
        }
    }
}
