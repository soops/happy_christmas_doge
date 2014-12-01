using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UGLYAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowTransparency = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            string[] such = {"wow", "amaze", "cool"};
            string[] many = {"rainbow", "doge", "colorblind"};
            string[] very = {"psycho", "kewl", "color"};

            Random awesome = new Random();

            int amaze = awesome.Next(4);
            int coolamaze = awesome.Next(4);
            switch(amaze)
            {
                case 1:
                    label1.Text = "very " + very[coolamaze];
                    break;

                case 2:
                    label1.Text = "many " + many[coolamaze];
                    break;

                case 3:
                    label1.Text = "such " + such[coolamaze];
                    break;
            }
            label1.Show();
            label1.BringToFront();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, p) =>
            {
                label1.Hide();
                pictureBox1.Hide();
                t.Stop();
            };
            t.Start();
        }
    }
}
