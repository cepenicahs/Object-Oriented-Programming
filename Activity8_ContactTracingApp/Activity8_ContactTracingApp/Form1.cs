using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Activity8_ContactTracingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            txtQRCode.Clear();
        
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    StreamWriter Decode;
                    Decode = File.AppendText("ITraceRecords.txt");
                    Decode.WriteLine("ITRACE CONTACT TRACING APP RECORDS");
                    Decode.WriteLine(" ");
                    Decode.WriteLine("Date:" + " " + DateTime.Now.ToString("MM/dd/yyyy"));
                    Decode.WriteLine("Time:" + " " + DateTime.Now.ToString("h:mm:ss tt"));
                    Decode.WriteLine(result.Text);
                    Decode.WriteLine(" ");
                    Decode.Close();

                    txtQRCode.Text = "Thank you for using ITrace!";
                    txtQRCode.Text += Environment.NewLine;
                    txtQRCode.Text += "Date:" + " " + DateTime.Now.ToString("MM/dd/yyyy");
                    txtQRCode.Text += Environment.NewLine;
                    txtQRCode.Text += "Time:" + " " + DateTime.Now.ToString("h:mm:ss tt");
                    txtQRCode.Text += Environment.NewLine;
                    txtQRCode.Text += "Result: ";
                    txtQRCode.Text += result.Text;
                    MessageBox.Show("Recorded. Thank you for using ITrace!");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a contact tracing application. Click the SCAN button and start scanning your QR code with the system camera.");
        }
    }
}
