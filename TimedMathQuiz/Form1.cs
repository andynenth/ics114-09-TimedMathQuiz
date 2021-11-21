using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {
        private int secondsCounter;
        public Form1()
        {
            InitializeComponent();
            GenerateRandomAdditions();
            StartTheTime();
        }
        private void StartTheTime()
        {
            timer1.Start();
            secondsCounter = 0;
            lblTimer.Text = secondsCounter.ToString() + " seconds";
        }
        private void GenerateRandomAdditions()
        {
            Random r = new Random();
            label1.Text = r.Next(1, 11).ToString();
            label3.Text = r.Next(1, 11).ToString();
            label5.Text = r.Next(1, 11).ToString();
            label7.Text = r.Next(1, 11).ToString();
            label9.Text = r.Next(1, 11).ToString();
            label11.Text = r.Next(1, 11).ToString();
        }
        private bool checkAnswers()
        {
            int answer1 = int.Parse(label1.Text) + int.Parse(label3.Text);
            int answer2 = int.Parse(label5.Text) + int.Parse(label7.Text);
            int answer3 = int.Parse(label9.Text) + int.Parse(label11.Text);

            if (answer1.ToString()==txtAnswer1.Text && answer2.ToString() == txtAnswer2.Text && answer3.ToString() == txtAnswer3.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsCounter++;
            lblTimer.Text = secondsCounter.ToString() + " seconds";
        }
        private void txtAnswer1_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();
                lblMessage.Text = string.Format("Your time: {0} seconds.", secondsCounter);
            }
        }
        private void txtAnswer2_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();
                lblMessage.Text = string.Format("Your time: {0} seconds.", secondsCounter);
            }
        }

        private void txtAnswer3_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswers())
            {
                timer1.Stop();
                lblMessage.Text = string.Format("Your time: {0} seconds.", secondsCounter);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateRandomAdditions();
            StartTheTime();
            lblMessage.Text = "xxxxxxxx";
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
        }
    }
}
