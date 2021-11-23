using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Activity3_TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true: X, false: Y
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            audio();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TicTacToe is a simple, two-player game that if played optimally by both players, " +
                "will always result in a tie. The goal of tic-tac-toe is to be the first player to get three in a row on a 3-by-3 grid", "Welcome to TicTacToe!");
        }

        private void audio()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.BGM);
            sound.Play();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == true)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            count++;
            b.Enabled = false;
            b.BackColor = Color.Magenta;
            b.ForeColor = Color.Black;
            testInputs();
        }

        private void testInputs()
        {
            bool winner = false;

            //Horizontal
            if ((btn11.Text == btn12.Text) && (btn12.Text == btn13.Text) && (!btn11.Enabled))
                winner = true;
            if ((btn21.Text == btn22.Text) && (btn22.Text == btn23.Text) && (!btn21.Enabled))
                winner = true;
            if ((btn31.Text == btn32.Text) && (btn32.Text == btn33.Text) && (!btn31.Enabled))
                winner = true;
            //Vertical
            if ((btn11.Text == btn21.Text) && (btn21.Text == btn31.Text) && (!btn31.Enabled))
                winner = true;
            if ((btn12.Text == btn22.Text) && (btn22.Text == btn32.Text) && (!btn32.Enabled))
                winner = true;
            if ((btn13.Text == btn23.Text) && (btn23.Text == btn33.Text) && (!btn33.Enabled))
                winner = true;
            //Diagonal
            if ((btn11.Text == btn22.Text) && (btn22.Text == btn33.Text) && (!btn33.Enabled))
                winner = true;
            if ((btn13.Text == btn22.Text) && (btn22.Text == btn31.Text) && (!btn31.Enabled))
                winner = true;

            if (winner)
            {
                String player = "";
                if (turn)
                    player = "O";
                else
                    player = "X";
                MessageBox.Show("Congratulations Player " + player + "!\nYou won the game!", "Results");
            }
            else
            { 
                if (count == 9)
                    MessageBox.Show("It's a draw!", "Results");
              //  clearAll();

            }

        }

        private void reset()
        {
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn23.Text = "";
            btn31.Text = "";
            btn32.Text = "";
            btn33.Text = "";

            btn11.BackColor = Color.MediumSlateBlue;
            btn12.BackColor = Color.MediumSlateBlue;
            btn13.BackColor = Color.MediumSlateBlue;
            btn21.BackColor = Color.MediumSlateBlue;
            btn22.BackColor = Color.MediumSlateBlue;
            btn23.BackColor = Color.MediumSlateBlue;
            btn31.BackColor = Color.MediumSlateBlue;
            btn32.BackColor = Color.MediumSlateBlue;
            btn33.BackColor = Color.MediumSlateBlue;

            turn = true;
            count = 0;

            btn11.Enabled = true;
            btn12.Enabled = true;
            btn13.Enabled = true;
            btn21.Enabled = true;
            btn22.Enabled = true;
            btn23.Enabled = true;
            btn31.Enabled = true;
            btn32.Enabled = true;
            btn33.Enabled = true;

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
