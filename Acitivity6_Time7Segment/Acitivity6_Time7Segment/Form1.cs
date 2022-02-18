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
using System.Media;

namespace Acitivity6_Time7Segment
{
    public partial class frmTime : Form
    {
        int FirstSecond = 0;
        int SecSecond = 0;
        int FirstMin = 0;

        int Tick = 0;

        public frmTime()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.ToString("tt");
            label2.Text = DateTime.Now.ToString("dddd");
            label3.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void frmTime_Load(object sender, EventArgs e)
        {

        }

        private void Black(Button args)
        {
            args.BackColor = Color.Black;
            args.FlatAppearance.BorderColor = Color.Black;
        }

        private void ColorRed(Button args)
        {
            args.BackColor = Color.Red;
        }

        private void RightSec(int SecSec)
        {

            if (SecSec == 1)
            {
                ColorRed(Sec2topright);
                ColorRed(Sec2botright);
                Black(Sec2top);
                Black(Sec2topleft);
                Black(Sec2mid);
                Black(Sec2botleft);
                Black(Sec2bot);
            }

            else if (SecSec == 2)
            {
                ColorRed(Sec2topright);
                ColorRed(Sec2top);
                ColorRed(Sec2mid);
                ColorRed(Sec2botleft);
                ColorRed(Sec2bot);
                Black(Sec2botright);
                Black(Sec2topleft);
            }

            else if (SecSec == 3)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topright);
                ColorRed(Sec2mid);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                Sec2topleft.BackColor = System.Drawing.Color.Black;
                Sec2botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (SecSec == 4)
            {
                ColorRed(Sec2topright);
                ColorRed(Sec2topleft);
                ColorRed(Sec2mid);
                ColorRed(Sec2botright);
                Sec2top.BackColor = System.Drawing.Color.Black;
                Sec2botleft.BackColor = System.Drawing.Color.Black;
                Sec2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecSec == 5)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topleft);
                ColorRed(Sec2mid);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                Sec2topright.BackColor = System.Drawing.Color.Black;
                Sec2botleft.BackColor = System.Drawing.Color.Black;
            }
            else if (SecSec == 6)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topleft);
                ColorRed(Sec2mid);
                ColorRed(Sec2botleft);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                Sec2topright.BackColor = System.Drawing.Color.Black;
            }
            else if (SecSec == 7)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topright);
                ColorRed(Sec2botright);
                Sec2topleft.BackColor = System.Drawing.Color.Black;
                Sec2mid.BackColor = System.Drawing.Color.Black;
                Sec2botleft.BackColor = System.Drawing.Color.Black;
                Sec2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecSec == 8)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topleft);
                ColorRed(Sec2mid);
                ColorRed(Sec2botleft);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                ColorRed(Sec2topright);
            }
            else if (SecSec == 9)
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topleft);
                ColorRed(Sec2mid);
                Black(Sec2botleft);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                ColorRed(Sec2topright);
            }
            else
            {
                ColorRed(Sec2top);
                ColorRed(Sec2topleft);
                ColorRed(Sec2topright);
                ColorRed(Sec2botleft);
                ColorRed(Sec2botright);
                ColorRed(Sec2bot);
                Black(Sec2mid);
            }
        }
        private void LeftSec(int FirstSec)
        {

            if (FirstSec == 1)
            {
                ColorRed(Sec1topright);
                ColorRed(Sec1botright);
                Black(Sec1top);
                Black(Sec1topleft);
                Black(Sec1mid);
                Black(Sec1botleft);
                Black(Sec1bot);
            }

            else if (FirstSec == 2)
            {
                ColorRed(Sec1topright);
                ColorRed(Sec1top);
                ColorRed(Sec1mid);
                ColorRed(Sec1botleft);
                ColorRed(Sec1bot);
                Black(Sec1botright);
                Black(Sec1topleft);
            }

            else if (FirstSec == 3)
            {
                ColorRed(Sec1top);
                ColorRed(Sec1topright);
                ColorRed(Sec1mid);
                ColorRed(Sec1botright);
                ColorRed(Sec1bot);
                Sec1topleft.BackColor = System.Drawing.Color.Black;
                Sec1botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (FirstSec == 4)
            {
                ColorRed(Sec1topright);
                ColorRed(Sec1topleft);
                ColorRed(Sec1mid);
                ColorRed(Sec1botright);
                Sec1top.BackColor = System.Drawing.Color.Black;
                Sec1botleft.BackColor = System.Drawing.Color.Black;
                Sec1bot.BackColor = System.Drawing.Color.Black;
            }
            else if (FirstSec == 5)
            {
                ColorRed(Sec1top);
                ColorRed(Sec1topleft);
                ColorRed(Sec1mid);
                ColorRed(Sec1botright);
                ColorRed(Sec1bot);
                Sec1topright.BackColor = System.Drawing.Color.Black;
                Sec1botleft.BackColor = System.Drawing.Color.Black;
            }

            else
            {
                ColorRed(Sec1top);
                ColorRed(Sec1topleft);
                ColorRed(Sec1topright);
                ColorRed(Sec1botleft);
                ColorRed(Sec1botright);
                ColorRed(Sec1bot);
                Black(Sec1mid);
            }

        }

        private void RightMin(int SecMin)
        {

            if (SecMin == 1)
            {
                ColorRed(Min2topright);
                ColorRed(Min2botright);
                Black(Min2top);
                Black(Min2topleft);
                Black(Min2mid);
                Black(Min2botleft);
                Black(Min2bot);
            }

            else if (SecMin == 2)
            {
                ColorRed(Min2topright);
                ColorRed(Min2top);
                ColorRed(Min2mid);
                ColorRed(Min2botleft);
                ColorRed(Min2bot);
                Black(Min2botright);
                Black(Min2topleft);
            }

            else if (SecMin == 3)
            {
                ColorRed(Min2top);
                ColorRed(Min2topright);
                ColorRed(Min2mid);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                Min2topleft.BackColor = System.Drawing.Color.Black;
                Min2botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (SecMin == 4)
            {
                ColorRed(Min2topright);
                ColorRed(Min2topleft);
                ColorRed(Min2mid);
                ColorRed(Min2botright);
                Min2top.BackColor = System.Drawing.Color.Black;
                Min2botleft.BackColor = System.Drawing.Color.Black;
                Min2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 5)
            {
                ColorRed(Min2top);
                ColorRed(Min2topleft);
                ColorRed(Min2mid);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                Min2topright.BackColor = System.Drawing.Color.Black;
                Min2botleft.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 6)
            {
                ColorRed(Min2top);
                ColorRed(Min2topleft);
                ColorRed(Min2mid);
                ColorRed(Min2botleft);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                Min2topright.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 7)
            {
                ColorRed(Min2top);
                ColorRed(Min2topright);
                ColorRed(Min2botright);
                Min2topleft.BackColor = System.Drawing.Color.Black;
                Min2mid.BackColor = System.Drawing.Color.Black;
                Min2botleft.BackColor = System.Drawing.Color.Black;
                Min2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 8)
            {
                ColorRed(Min2top);
                ColorRed(Min2topleft);
                ColorRed(Min2mid);
                ColorRed(Min2botleft);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                ColorRed(Min2topright);
            }
            else if (SecMin == 9)
            {
                ColorRed(Min2top);
                ColorRed(Min2topleft);
                ColorRed(Min2mid);
                Black(Min2botleft);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                ColorRed(Min2topright);
            }
            else
            {
                ColorRed(Min2top);
                ColorRed(Min2topleft);
                ColorRed(Min2topright);
                ColorRed(Min2botleft);
                ColorRed(Min2botright);
                ColorRed(Min2bot);
                Black(Min2mid);
            }
        }
        private void LeftMin(int FirstMin)
        {

            if (FirstMin == 1)
            {
                ColorRed(Min1topright);
                ColorRed(Min1botright);
                Black(Min1top);
                Black(Min1topleft);
                Black(Min1mid);
                Black(Min1botleft);
                Black(Min1bot);
            }

            else if (FirstMin == 2)
            {
                ColorRed(Min1topright);
                ColorRed(Min1top);
                ColorRed(Min1mid);
                ColorRed(Min1botleft);
                ColorRed(Min1bot);
                Black(Min1botright);
                Black(Min1topleft);
            }

            else if (FirstMin == 3)
            {
                ColorRed(Min1top);
                ColorRed(Min1topright);
                ColorRed(Min1mid);
                ColorRed(Min1botright);
                ColorRed(Min1bot);
                Min1topleft.BackColor = System.Drawing.Color.Black;
                Min1botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (FirstMin == 4)
            {
                ColorRed(Min1topright);
                ColorRed(Min1topleft);
                ColorRed(Min1mid);
                ColorRed(Min1botright);
                Min1top.BackColor = System.Drawing.Color.Black;
                Min1botleft.BackColor = System.Drawing.Color.Black;
                Min1bot.BackColor = System.Drawing.Color.Black;
            }
            else if (FirstMin == 5)
            {
                ColorRed(Min1top);
                ColorRed(Min1topleft);
                ColorRed(Min1mid);
                ColorRed(Min1botright);
                ColorRed(Min1bot);
                Min1topright.BackColor = System.Drawing.Color.Black;
                Min1botleft.BackColor = System.Drawing.Color.Black;
            }

            else
            {
                ColorRed(Min1top);
                ColorRed(Min1topleft);
                ColorRed(Min1topright);
                ColorRed(Min1botleft);
                ColorRed(Min1botright);
                ColorRed(Min1bot);
                Black(Min1mid);
            }

        }

        private void hrleft(int FirstSec)
        {
            if (FirstSec == 1)
            {
                ColorRed(Hour1topright);
                ColorRed(Hour1botright);
                Black(Hour1top);
                Black(Hour1topleft);
                Black(Hour1mid);
                Black(Hour1botleft);
                Black(Hour1bot);
            }

            else if (FirstSec == 2)
            {
                ColorRed(Hour1topright);
                ColorRed(Hour1top);
                ColorRed(Hour1mid);
                ColorRed(Hour1botleft);
                ColorRed(Hour1bot);
                Black(Hour1botright);
                Black(Hour1topleft);
            }

            else if (FirstSec == 3)
            {
                ColorRed(Hour1top);
                ColorRed(Hour1topright);
                ColorRed(Hour1mid);
                ColorRed(Hour1botright);
                ColorRed(Hour1bot);
                Hour1topleft.BackColor = System.Drawing.Color.Black;
                Hour1botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (FirstSec == 4)
            {
                ColorRed(Hour1topright);
                ColorRed(Hour1topleft);
                ColorRed(Hour1mid);
                ColorRed(Hour1botright);
                Hour1top.BackColor = System.Drawing.Color.Black;
                Hour1botleft.BackColor = System.Drawing.Color.Black;
                Hour1bot.BackColor = System.Drawing.Color.Black;
            }
            else if (FirstSec == 5)
            {
                ColorRed(Hour1top);
                ColorRed(Hour1topleft);
                ColorRed(Hour1mid);
                ColorRed(Hour1botright);
                ColorRed(Hour1bot);
                Hour1topright.BackColor = System.Drawing.Color.Black;
                Hour1botleft.BackColor = System.Drawing.Color.Black;
            }

            else
            {
                ColorRed(Hour1top);
                ColorRed(Hour1topleft);
                ColorRed(Hour1topright);
                ColorRed(Hour1botleft);
                ColorRed(Hour1botright);
                ColorRed(Hour1bot);
                Black(Hour1mid);
            }
        }

        private void hrrighht(int SecMin)
        {
            if (SecMin == 1)
            {
                ColorRed(Hour2topright);
                ColorRed(Hour2botright);
                Black(Hour2top);
                Black(Hour2topleft);
                Black(Hour2mid);
                Black(Hour2botleft);
                Black(Hour2bot);
            }

            else if (SecMin == 2)
            {
                ColorRed(Hour2topright);
                ColorRed(Hour2top);
                ColorRed(Hour2mid);
                ColorRed(Hour2botleft);
                ColorRed(Hour2bot);
                Black(Hour2botright);
                Black(Hour2topleft);
            }

            else if (SecMin == 3)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topright);
                ColorRed(Hour2mid);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                Hour2topleft.BackColor = System.Drawing.Color.Black;
                Hour2botleft.BackColor = System.Drawing.Color.Black;
            }

            else if (SecMin == 4)
            {
                ColorRed(Hour2topright);
                ColorRed(Hour2topleft);
                ColorRed(Hour2mid);
                ColorRed(Hour2botright);
                Hour2top.BackColor = System.Drawing.Color.Black;
                Hour2botleft.BackColor = System.Drawing.Color.Black;
                Hour2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 5)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topleft);
                ColorRed(Hour2mid);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                Hour2topright.BackColor = System.Drawing.Color.Black;
                Hour2botleft.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 6)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topleft);
                ColorRed(Hour2mid);
                ColorRed(Hour2botleft);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                Hour2topright.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 7)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topright);
                ColorRed(Hour2botright);
                Hour2topleft.BackColor = System.Drawing.Color.Black;
                Hour2mid.BackColor = System.Drawing.Color.Black;
                Hour2botleft.BackColor = System.Drawing.Color.Black;
                Hour2bot.BackColor = System.Drawing.Color.Black;
            }
            else if (SecMin == 8)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topleft);
                ColorRed(Hour2mid);
                ColorRed(Hour2botleft);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                ColorRed(Hour2topright);
            }
            else if (SecMin == 9)
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topleft);
                ColorRed(Hour2mid);
                Black(Hour2botleft);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                ColorRed(Hour2topright);
            }
            else
            {
                ColorRed(Hour2top);
                ColorRed(Hour2topleft);
                ColorRed(Hour2topright);
                ColorRed(Hour2botleft);
                ColorRed(Hour2botright);
                ColorRed(Hour2bot);
                Black(Hour2mid);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Tick++;
            string Secs = (DateTime.Now.ToString("ss"));
            SecSecond = Convert.ToInt32(Secs.Substring(Secs.Length - 1));
            RightSec(SecSecond);
            FirstSecond = Convert.ToInt32(Secs.Substring(0, 1));
            LeftSec(FirstSecond);

            string Mins = (DateTime.Now.ToString("mm"));
            int SecMin = Convert.ToInt32(Mins.Substring(Mins.Length - 1));
            RightMin(SecMin);
            FirstMin = Convert.ToInt32(Mins.Substring(0, 1));
            LeftMin(FirstMin);


            string HRS = (DateTime.Now.ToString("hh"));
            int asd = Convert.ToInt32(HRS.Substring(HRS.Length - 1));
            hrrighht(asd);
            int xxx = Convert.ToInt32(HRS.Substring(0, 1));
            hrleft(xxx);



        }

        private void all(object sender, EventArgs e)
        {
            Button all = (Button)sender;
            all.BackColor = System.Drawing.Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
