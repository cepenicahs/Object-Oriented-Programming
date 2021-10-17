using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1_Name
{
    public partial class Form1 : Form
    {
        string fn = "Nicah";
        string mn = "Sabay";
        string ln = "Cepe";
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(fn + " " + mn + " " + ln, "This is my full name");
        }
    }
}
