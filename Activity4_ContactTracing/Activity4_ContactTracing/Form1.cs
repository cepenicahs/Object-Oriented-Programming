using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity4_ContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAll()
        {
            txtFN.Clear();
            txtCN.Clear();
            txtAdd.Clear();
            txtEmail.Clear();
            dateTimePicker1.Value = DateTime.Now;
            chkContactNo.Checked = false;
            chkContactYes.Checked = false;
            chkCoughNo.Checked = false;
            chkCoughYes.Checked = false;
            chkFeverNo.Checked = false;
            chkFeverYes.Checked = false;
            chkTasteNo.Checked = false;
            chkTasteYes.Checked = false;
            chkTiredNo.Checked = false;
            chkTiredYes.Checked = false;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string path = (Application.StartupPath + "\\form\\" + "contact.txt");

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("\nFull Name: " + txtFN.Text);
                sw.WriteLine("Contact Number: " + txtCN.Text + "\n");
                sw.WriteLine("Address: " + txtAdd.Text + "\n");
                sw.WriteLine("Email: " + txtEmail.Text + "\n");
                sw.WriteLine("Date: " + dateTimePicker1.Text + "\n");
                sw.WriteLine("Did you have any of the following COVID19 symptoms for the past few weeks?\n");
                sw.WriteLine("Fever: ");
                if (chkFeverYes.Checked)
                {
                    sw.WriteLine("Yes\n");
                }
                else if (chkFeverNo.Checked)
                {
                    sw.WriteLine("No\n");
                }
                sw.WriteLine("Cough: ");
                if (chkCoughYes.Checked)
                {
                    sw.WriteLine("Yes\n");
                }
                else if (chkCoughNo.Checked)
                {
                    sw.WriteLine("No\n");
                }
                sw.WriteLine("Tiredness: ");
                if (chkTiredYes.Checked)
                {
                    sw.WriteLine("Yes\n");
                }
                else if (chkTiredNo.Checked)
                {
                    sw.WriteLine("No\n");
                }
                sw.WriteLine("Loss of taste and smell: ");
                if (chkTasteYes.Checked)
                {
                    sw.WriteLine("Yes\n");
                }
                else if (chkTasteNo.Checked)
                {
                    sw.WriteLine("No\n");
                }

                sw.WriteLine("Did you have a close contact to a person who is asymptomatic or tested positive in COVID19 for the past few weeks?");
                if (chkContactYes.Checked)
                {
                    sw.WriteLine("Yes\n");
                }
                else if (chkContactNo.Checked)
                {
                    sw.WriteLine("No\n");
                }
                sw.WriteLine("\n////////////////////////////////////////////////////");

                MessageBox.Show("Thank you for your response.", "Response Recorded.");
                clearAll();
            }
        }

        private void chkFeverYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeverNo.Checked == true)
            {
                chkFeverNo.Checked = false;
            }
        }

        private void chkFeverNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeverYes.Checked == true)
            {
                chkFeverYes.Checked = false;
            }
        }

        private void chkCoughYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoughNo.Checked == true)
            {
                chkCoughNo.Checked = false;
            }
        }

        private void chkCoughNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoughYes.Checked == true)
            {
                chkCoughYes.Checked = false;
            }
        }

        private void chkTiredYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTiredNo.Checked == true)
            {
                chkTiredNo.Checked = false;
            }
        }

        private void chkTiredNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTiredYes.Checked == true)
            {
                chkTiredYes.Checked = false;
            }
        }

        private void chkTasteYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTasteNo.Checked == true)
            {
                chkTasteNo.Checked = false;
            }
        }

        private void chkTasteNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTasteYes.Checked == true)
            {
                chkTasteYes.Checked = false;
            }
        }

        private void chkContactYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactNo.Checked == true)
            {
                chkContactNo.Checked = false;
            }
        }

        private void chkContactNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContactYes.Checked == true)
            {
                chkContactYes.Checked = false;
            }
        }
    }
}
