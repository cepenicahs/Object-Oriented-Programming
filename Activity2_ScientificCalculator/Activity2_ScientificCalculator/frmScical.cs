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
       
        public frmScical()
        {
            InitializeComponent();

        }

        bool enter_value = false;
        String operation = "";
        Double result = 0;

        private void frmScical_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result = 0;
            txtField.Text = "0";
            lblShow.Text = "";
            rboBin.Checked = false;
            rboDec.Checked = false;
            rboHex.Checked = false;
            rboOct.Checked = false;
        }



        private void btnPercent_Click(object sender, EventArgs e)
        {
            
            Double a;
            a = Convert.ToDouble(txtField.Text) / Convert.ToDouble(100);
            txtField.Text = System.Convert.ToString(a);
        }
        
        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("sin" + "(" + (txtField.Text) + ")");
            qSin = Math.Sin(qSin);
            txtField.Text = System.Convert.ToString(qSin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("cos" + "(" + (txtField.Text) + ")");
            qCos = Math.Cos(qCos);
            txtField.Text = System.Convert.ToString(qCos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("tan" + "(" + (txtField.Text) + ")");
            qTan = Math.Tan(qTan);
            txtField.Text = System.Convert.ToString(qTan);
        }


        private void btnArcsin_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("sinh" + "(" + (txtField.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txtField.Text = System.Convert.ToString(qSinh);
        }

        private void btnArccos_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("cosh" + "(" + (txtField.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txtField.Text = System.Convert.ToString(qCosh);
        }

        private void btnArctan_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("tanh" + "(" + (txtField.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txtField.Text = System.Convert.ToString(qTanh);
        }


        private void button18_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtField.Text) * Convert.ToDouble(txtField.Text);
            txtField.Text = System.Convert.ToString(a);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtField.Text);
            result = Math.Exp(result);
            txtField.Text = result.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("√" + (txtField.Text));
            sq = Math.Sqrt(sq);
            txtField.Text = System.Convert.ToString(sq);

        }


        private void button17_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("log" + "(" + (txtField.Text) + ")");
            ilog = Math.Log10(ilog);
            txtField.Text = System.Convert.ToString(ilog);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("log" + "(" + (txtField.Text) + ")");
            ilog = Math.Log(ilog);
            txtField.Text = System.Convert.ToString(ilog);
        }



        private void button22_Click(object sender, EventArgs e)
        {

            double a = Double.Parse(txtField.Text);
            a = Math.Abs(a);
            txtField.Text = System.Convert.ToString(a);

        }

        private void button31_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtField.Text));
            txtField.Text = System.Convert.ToString(a);
        }

   

        private void button11_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
           
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (txtField.Text.Length > 0)
            {
                txtField.Text = txtField.Text.Remove(txtField.Text.Length - 1, 1);
            }
            if (txtField.Text == "")
            {
                txtField.Text = "0";
            }
        }

       
        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            switch (operation)
            {
                case "+":
                    txtField.Text = (result + Double.Parse(txtField.Text)).ToString();
                    break;

                case "-":
                    txtField.Text = (result - Double.Parse(txtField.Text)).ToString();
                    break;

                case "*":
                    txtField.Text = (result * Double.Parse(txtField.Text)).ToString();
                    break;

                case "/":
                    txtField.Text = (result / Double.Parse(txtField.Text)).ToString();
                    break;
            }

          }

        private void Arithmetic_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtField.Text);
            txtField.Text = "";
            lblShow.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if ((txtField.Text == "0") || (enter_value)) txtField.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtField.Text.Contains("."))
                    txtField.Text = txtField.Text + num.Text;
            }
            else
                txtField.Text = txtField.Text + num.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtField.Text) / Convert.ToDouble(100);
            txtField.Text = System.Convert.ToString(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtField.Text) * Convert.ToDouble(txtField.Text) * Convert.ToDouble(txtField.Text);
            txtField.Text = System.Convert.ToString(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtField.Text = "3.141592653589793238";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtField.Text.Contains("-"))
                txtField.Text = txtField.Text.Remove(0, 1);
            else
                txtField.Text = "-" + txtField.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtField.Text);
            result = (result % double.Parse(txtField.Text));
            txtField.Text = result.ToString();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 2);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By definition, a scientific calculator is a calculator designed to help you calculate science, engineering, and mathematics problems. It has way more buttons than your standard calculator that just lets you do your four basic arithmetic operations of addition, subtraction, multiplication, and division.");
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a);
        }

        private void graphingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 16);
        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 8);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("By definition, a scientific calculator is a calculator designed to help you calculate science, engineering, and mathematics problems. It has way more buttons than your standard calculator that just lets you do your four basic arithmetic operations of addition, subtraction, multiplication, and division.");
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String [] a;
            result = 1;
            a = txtField.Text.Split();
            int num = Convert.ToInt16(a[0]);

            for (int i = 1; i < num + 1; i++)
            {
                result *= (Convert.ToDouble(i));
            }

            txtField.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String[] a;
            Double b;
            txtField.Text = txtField.Text + " = ";
            a = txtField.Text.Split();
            b = Convert.ToDouble(a[0]);
            result = Math.Log10(b);
            txtField.Text = Convert.ToString(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String[] a;
            Double b;
            a = txtField.Text.Split();
            b = Convert.ToDouble(a[0]);
            result = Math.Pow(10, b);
            txtField.Text = Convert.ToString(result);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double cbroot_num = Double.Parse(txtField.Text);
            lblShow.Text = System.Convert.ToString("cuberoot" + "(" + (txtField.Text) + ")");
            cbroot_num = (Math.Pow(cbroot_num, (double)1.0 / 3.0));
            txtField.Text = System.Convert.ToString(cbroot_num);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rboDec.Checked = false;
            rboHex.Checked = false;
            rboOct.Checked = false;
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 2);
        }

        private void rboDec_CheckedChanged(object sender, EventArgs e)
        {
            rboBin.Checked = false;
            rboHex.Checked = false;
            rboOct.Checked = false;
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a);
        }

        private void rboHex_CheckedChanged(object sender, EventArgs e)
        {
            rboBin.Checked = false;
            rboDec.Checked = false;
            rboOct.Checked = false;
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 16);
        }

        private void rboOct_CheckedChanged(object sender, EventArgs e)
        {
            rboBin.Checked = false;
            rboDec.Checked = false;
            rboHex.Checked = false;
            int a = int.Parse(txtField.Text);
            txtField.Text = System.Convert.ToString(a, 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtField.Text = "0";
            lblShow.Text = "";
            rboBin.Checked = false;
            rboDec.Checked = false;
            rboHex.Checked = false;
            rboOct.Checked = false;
        }
    }
}
