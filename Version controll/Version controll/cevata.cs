﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_controll
{
    public partial class cevata : Form
    {
        public cevata()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUtomnul3!!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GittesDev3 gt = new GittesDev3();
            gt.Show();
        }
<<<<<<< HEAD
=======

        private void cevata_Load(object sender, EventArgs e)
        {

        }
>>>>>>> develop3
    }
}
