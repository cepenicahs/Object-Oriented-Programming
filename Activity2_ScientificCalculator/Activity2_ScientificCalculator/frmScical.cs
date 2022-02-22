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

       
        private void Button_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtField.Text = "0";
            lblShow.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
         

        }

        private void btn2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn3_Click(object sender, EventArgs e)
        {
          
        }

        private void btn4_Click(object sender, EventArgs e)
        {
              

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
          
        }

        private void btn8_Click(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCotan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnArcsin_Click(object sender, EventArgs e)
        {
              
        }

        private void btnArccos_Click(object sender, EventArgs e)
        {
              
        }

        private void btnArctan_Click(object sender, EventArgs e)
        {
                
        }

        private void btnArccot_Click(object sender, EventArgs e)
        {
              
        }

        private void button18_Click(object sender, EventArgs e)
        {
             
        }

        private void button26_Click(object sender, EventArgs e)
        {
          
        }

        private void button33_Click(object sender, EventArgs e)
        {
       
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
         
             
        }

        private void button17_Click(object sender, EventArgs e)
        {
         
        }

        private void button25_Click(object sender, EventArgs e)
        {
          
        }

        private void button32_Click(object sender, EventArgs e)
        {
          
        }

        private void button39_Click(object sender, EventArgs e)
        {
           
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
           
        }

        private void button31_Click(object sender, EventArgs e)
        {
           
        }

        private void button38_Click(object sender, EventArgs e)
        {
         
        }

        private void button21_Click(object sender, EventArgs e)
        {
          
        }

        private void button20_Click(object sender, EventArgs e)
        {
          
        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
          
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
    }
}
