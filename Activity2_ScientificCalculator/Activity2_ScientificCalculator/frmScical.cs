using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2_ScientificCalculator
{
    public partial class frmScical : Form
    {
        int firstNum;
        int SecondNum;

        public frmScical()
        {
            InitializeComponent();

        }

        private void frmScical_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtField.Clear();
            txtField.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + ".";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "sin(";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "cos(";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "tan(";
        }

        private void btnCotan_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "cotan(";
        }

        private void btnArcsin_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "arcsin(";
        }

        private void btnArccos_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "arccos(";
        }

        private void btnArctan_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "arctan(";
        }

        private void btnArccot_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "arccot(";
        }

        private void button18_Click(object sender, EventArgs e)
        {
                if (txtField.Text == "0")
                {
                    txtField.Clear();
                }

                txtField.Text = txtField.Text + "logY(";
        }

        private void button26_Click(object sender, EventArgs e)
        {
          
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "√";
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "∛";
             
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "log(";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "ln(";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "10^";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "ran";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "|x|";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "2^";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "1/x";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "!";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "(";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + ")";
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "π";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "f'(x)";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtField.Text == "0")
            {
                txtField.Clear();
            }

            txtField.Text = txtField.Text + "∑";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + "+";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + "*";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtField.Text = txtField.Text + "-";
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            txtField.Clear();
            txtField.Text = "ANS";
        }
    }
}
