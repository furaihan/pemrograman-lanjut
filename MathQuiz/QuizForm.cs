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
        private int timeLeft = 0;
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

            minRight = random.Next(10, 50);
            minLeft = random.Next(20, 50) + minRight;
            minLeftLabel.Text = minLeft.ToString();
            minRightLabel.Text = minRight.ToString();
            diff.Value = 0;

            multLeft = random.Next(2, 26);
            multRight = random.Next(2, 16);
            multLeftLabel.Text = multLeft.ToString();
            multRightLabel.Text = multRight.ToString();
            multiply.Value = 0;

            divRight = random.Next(2, 11);
            int quotient = random.Next(2, 11);
            divLeft = quotient * divRight;
            divideLeftLabel.Text = divLeft.ToString();
            divideRightLabel.Text = divRight.ToString();
            divide.Value = 0;

            timeLeft = 45;
            lblTimeLeft.Text = timeLeft.ToString() + " seconds";
            quizTimer.Start();

            btnStart.Enabled = false;

        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (CheckAnswer())
            {
                quizTimer.Stop();
                MessageBox.Show("Selamat! Kamu benar!!");
                btnStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = timeLeft.ToString() + " seconds";
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
        private bool CheckAnswer() =>
            (plusLeft + plusRight == sum.Value) &&
            (minLeft - minRight == diff.Value) &&
            (multLeft * multRight == multiply.Value) &&
            (divLeft / divRight == divide.Value);
    }
}
