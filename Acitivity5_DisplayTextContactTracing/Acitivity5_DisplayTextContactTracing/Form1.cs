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

namespace Acitivity5_DisplayTextContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Contact Tracing Record list. Click the button below to view the list of contacts.", "Contact Tracing Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = (Application.StartupPath + "\\form\\" + "contact.txt");
            StreamReader stream = new StreamReader(path);
            string filedata = stream.ReadToEnd();
            richTextBox1.Text = filedata.ToString();
            stream.Close();
        }
    }
}
