﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games.Ocix.MainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Text = "Select";
            button1.Text = "Select";
            button3.Text = "Unselect";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Text = "Select";
            button1.Text = "Select";
            button2.Text = "Unselect";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Select";
            button3.Text = "Select";
            button1.Text = "Unselect";
        }
    }
}
