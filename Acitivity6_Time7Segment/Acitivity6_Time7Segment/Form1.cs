﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Acitivity6_Time7Segment
{
    public partial class frmTime : Form
    {
        public frmTime()
        {
            InitializeComponent();
        }

        private void frmTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
            reset();

        }

        private void Timer1_Start(object sender, EventArgs e)
        {
            btnHours.Text = DateTime.Now.ToString("hh");
            btnMins.Text = DateTime.Now.ToString("mm");
            btnSecs.Text = DateTime.Now.ToString("ss");
        }

        private void btnSecs_Click(object sender, EventArgs e)
        {

        }

        private void textChanged(object sender, EventArgs e)
        {

            if (btnSecs.ForeColor == Color.Red)
                btnSecs.ForeColor = Color.Green;
            else
                btnSecs.ForeColor = Color.Red;
        }

        private void minTextChanged(object sender, EventArgs e)
        {

            if (btnMins.ForeColor == Color.Red)
                btnMins.ForeColor = Color.Green;
            else
                btnMins.ForeColor = Color.Red;
        }

        private void reset()
        {
            btnHours.ForeColor = Color.Red;
            btnMins.ForeColor = Color.Red;
            btnSecs.ForeColor = Color.Red;
        }

        private void hrTextChanged(object sender, EventArgs e)
        {
            if (btnHours.ForeColor == Color.Red)
                btnHours.ForeColor = Color.Green;
            else
                btnHours.ForeColor = Color.Red;
        }
    }
}