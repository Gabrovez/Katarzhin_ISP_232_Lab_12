using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int time_left = 10;
        private int countclc = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        private void buttomReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            time_left = 10;
            labelTime.Text = "Time: " + time_left;
            countclc = 0;
            labelPresses.Text = "Clicks: " + countclc;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                timer1.Start();
                countclc++;
                labelPresses.Text = "Clicks: " + countclc;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_left--;
            if (time_left < 0)
            {
                timer1.Stop();
                MessageBox.Show($"Congraulations! In 10 seconds you managed to click {countclc} times! ");
                time_left = 10;
                labelTime.Text = "Time: " + time_left;
                countclc = 0;
                labelPresses.Text = "Clicks: " + countclc;
            }
            else
            {
                labelTime.Text = "Time: " + time_left;
            }
        }
    }
}
