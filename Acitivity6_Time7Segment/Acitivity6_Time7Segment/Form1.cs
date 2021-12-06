using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Start(object sender, EventArgs e)
        {
            btnHours.Text = DateTime.Now.ToString("hh");
            btnMins.Text = DateTime.Now.ToString("mm");
            btnSecs.Text = DateTime.Now.ToString("ss");
            btnHours.ForeColor = Color.Green;
        }

    }
}
