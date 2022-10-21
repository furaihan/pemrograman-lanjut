using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class QuizForm : Form
    {
        Random random = new Random();
        private int plusLeft = 0;
        private int plusRight = 0;
        private int minLeft = 0;
        private int minRight = 0;
        private int multLeft = 0;
        private int multRight = 0;
        private int divLeft = 0;
        private int divRight = 0;
        private TimeSpan timeLeft;
        internal bool quizStart = false;
        public QuizForm()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            plusLeft = random.Next(8, 100);
            plusRight = random.Next(8, 100);
            plusLeftLabel.Text = plusLeft.ToString();
            plusRightLabel.Text = plusRight.ToString();
            sum.Value = 0;
            sum.Enabled = true;
            plusCheck.Visible = false;

            minRight = random.Next(10, 50);
            minLeft = random.Next(20, 50) + minRight;
            minLeftLabel.Text = minLeft.ToString();
            minRightLabel.Text = minRight.ToString();
            diff.Value = 0;
            diff.Enabled = true;
            minCheck.Visible = false;

            multLeft = random.Next(2, 26);
            multRight = random.Next(2, 16);
            multLeftLabel.Text = multLeft.ToString();
            multRightLabel.Text = multRight.ToString();
            multiply.Value = 0;
            multiply.Enabled = true;
            multCheck.Visible = false; 

            divRight = random.Next(2, 11);
            int quotient = random.Next(2, 11);
            divLeft = quotient * divRight;
            divideLeftLabel.Text = divLeft.ToString();
            divideRightLabel.Text = divRight.ToString();
            divide.Value = 0;
            divide.Enabled = true;
            divCheck.Visible = false;

            timeLeft = TimeSpan.FromSeconds(45);
            lblTimeLeft.Text = timeLeft.ToString("ss\\.f") + " seconds";
            quizTimer.Start();

            btnStart.Enabled = false;

        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                quizTimer.Stop();
                DisplayCheckWhenCorrect();
                MessageBox.Show("Selamat! Kamu benar!!");
                btnStart.Enabled = true;
            }
            else if (timeLeft > TimeSpan.Zero)
            {
                DisplayCheckWhenCorrect();
                timeLeft -= TimeSpan.FromMilliseconds(100);
                lblTimeLeft.Text = timeLeft.ToString("ss\\.f") + " seconds";
            }
            else
            {
                quizTimer.Stop();
                lblTimeLeft.Text = "Waktu Habis";
                MessageBox.Show("Kamu gagal menyelesaikan quiz tepat waktu", "Silahkan coba lagi");
                sum.Value = plusLeft + plusRight;
                diff.Value = minLeft - minRight;
                multiply.Value = multLeft * multRight;
                divide.Value = divLeft / divRight;
                btnStart.Enabled = true;
            } 
        }
        private void DisplayCheckWhenCorrect()
        {
            if (sum.Value == plusLeft + plusRight && sum.Enabled)
            {
                plusCheck.Visible = true;
                sum.Enabled = true;
            }
            else if (diff.Value == minLeft - minRight && diff.Enabled)
            {
                minCheck.Visible = true;
                diff.Enabled = false;
            }
            else if (multiply.Value == multLeft * multRight && multiply.Enabled)
            {
                multCheck.Visible = true;
                multiply.Enabled = false;
            }
            else if (divide.Value == divLeft / divRight && divide.Enabled)
            {
                divCheck.Visible = true;
                divide.Enabled = false;
            }
        }
        private bool CheckAnswer() =>
            (plusLeft + plusRight == sum.Value) &&
            (minLeft - minRight == diff.Value) &&
            (multLeft * multRight == multiply.Value) &&
            (divLeft / divRight == divide.Value);
    }
}
