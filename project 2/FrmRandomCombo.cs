﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            CmbRand.Items.Add(r.Next(100, 999));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CmbRand.Items.Clear();

        }
    }
}
