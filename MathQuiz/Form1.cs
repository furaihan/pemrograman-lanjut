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
    public partial class Form1 : Form
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
        internal bool quizStart = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            plusLeft = random.Next(8, 100);
            plusRight = random.Next(8, 100);
            plusLeftLabel.Text = plusLeft.ToString();
            plusRightLabel.Text = plusRight.ToString();

            minLeft = random.Next(50, 100);
            minRight = random.Next(0, minLeft);
            minLeftLabel.Text = minLeft.ToString();
            minRightLabel.Text = minRight.ToString();

            multLeft = random.Next(1, 26);
            multRight = random.Next(2, 15);
            multLeftLabel.Text = multLeft.ToString();
            multRightLabel.Text = multRight.ToString();

            btnStart.Enabled = false;

            for (int i = 0; i < 100; i++)
            {

            }
            quizStart = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            quizStart = false;
        }
    }
}
