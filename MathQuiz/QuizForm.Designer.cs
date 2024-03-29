﻿namespace MathQuiz
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.diff = new System.Windows.Forms.NumericUpDown();
            this.minRightLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minLeftLabel = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.NumericUpDown();
            this.multRightLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.multLeftLabel = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.NumericUpDown();
            this.divideRightLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divideLeftLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.rndQuizBtn = new System.Windows.Forms.Button();
            this.plusCheck = new System.Windows.Forms.Label();
            this.minCheck = new System.Windows.Forms.Label();
            this.multCheck = new System.Windows.Forms.Label();
            this.divCheck = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(284, 45);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(200, 30);
            this.lblTimeLeft.TabIndex = 0;
            this.lblTimeLeft.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(63, 100);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(195, 100);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 5;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(327, 105);
            this.sum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 41);
            this.sum.TabIndex = 2;
            // 
            // diff
            // 
            this.diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diff.Location = new System.Drawing.Point(327, 170);
            this.diff.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(100, 41);
            this.diff.TabIndex = 3;
            // 
            // minRightLabel
            // 
            this.minRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRightLabel.Location = new System.Drawing.Point(195, 165);
            this.minRightLabel.Name = "minRightLabel";
            this.minRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minRightLabel.TabIndex = 10;
            this.minRightLabel.Text = "?";
            this.minRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLeftLabel
            // 
            this.minLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLeftLabel.Location = new System.Drawing.Point(63, 165);
            this.minLeftLabel.Name = "minLeftLabel";
            this.minLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minLeftLabel.TabIndex = 7;
            this.minLeftLabel.Text = "?";
            this.minLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(327, 235);
            this.multiply.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(100, 41);
            this.multiply.TabIndex = 4;
            // 
            // multRightLabel
            // 
            this.multRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multRightLabel.Location = new System.Drawing.Point(195, 230);
            this.multRightLabel.Name = "multRightLabel";
            this.multRightLabel.Size = new System.Drawing.Size(60, 50);
            this.multRightLabel.TabIndex = 15;
            this.multRightLabel.Text = "?";
            this.multRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 14;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(129, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 13;
            this.label10.Text = "x";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multLeftLabel
            // 
            this.multLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multLeftLabel.Location = new System.Drawing.Point(63, 230);
            this.multLeftLabel.Name = "multLeftLabel";
            this.multLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.multLeftLabel.TabIndex = 12;
            this.multLeftLabel.Text = "?";
            this.multLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(327, 293);
            this.divide.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(100, 41);
            this.divide.TabIndex = 5;
            // 
            // divideRightLabel
            // 
            this.divideRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRightLabel.Location = new System.Drawing.Point(195, 288);
            this.divideRightLabel.Name = "divideRightLabel";
            this.divideRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divideRightLabel.TabIndex = 20;
            this.divideRightLabel.Text = "?";
            this.divideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(261, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 19;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(129, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideLeftLabel
            // 
            this.divideLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLeftLabel.Location = new System.Drawing.Point(63, 288);
            this.divideLeftLabel.Name = "divideLeftLabel";
            this.divideLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divideLeftLabel.TabIndex = 17;
            this.divideLeftLabel.Text = "?";
            this.divideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 370);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(510, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start The Quiz!";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // quizTimer
            // 
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // rndQuizBtn
            // 
            this.rndQuizBtn.AutoSize = true;
            this.rndQuizBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.rndQuizBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rndQuizBtn.FlatAppearance.BorderSize = 0;
            this.rndQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndQuizBtn.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndQuizBtn.Location = new System.Drawing.Point(28, 45);
            this.rndQuizBtn.Name = "rndQuizBtn";
            this.rndQuizBtn.Size = new System.Drawing.Size(75, 32);
            this.rndQuizBtn.TabIndex = 21;
            this.rndQuizBtn.Text = "Random";
            this.rndQuizBtn.UseVisualStyleBackColor = false;
            this.rndQuizBtn.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // plusCheck
            // 
            this.plusCheck.AutoSize = true;
            this.plusCheck.BackColor = System.Drawing.Color.Ivory;
            this.plusCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.plusCheck.Location = new System.Drawing.Point(443, 109);
            this.plusCheck.Name = "plusCheck";
            this.plusCheck.Size = new System.Drawing.Size(29, 29);
            this.plusCheck.TabIndex = 22;
            this.plusCheck.Text = "✓";
            this.plusCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusCheck.Visible = false;
            // 
            // minCheck
            // 
            this.minCheck.AutoSize = true;
            this.minCheck.BackColor = System.Drawing.Color.Ivory;
            this.minCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.minCheck.Location = new System.Drawing.Point(443, 173);
            this.minCheck.Name = "minCheck";
            this.minCheck.Size = new System.Drawing.Size(29, 29);
            this.minCheck.TabIndex = 23;
            this.minCheck.Text = "✓";
            this.minCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minCheck.Visible = false;
            // 
            // multCheck
            // 
            this.multCheck.AutoSize = true;
            this.multCheck.BackColor = System.Drawing.Color.Ivory;
            this.multCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.multCheck.Location = new System.Drawing.Point(443, 237);
            this.multCheck.Name = "multCheck";
            this.multCheck.Size = new System.Drawing.Size(29, 29);
            this.multCheck.TabIndex = 24;
            this.multCheck.Text = "✓";
            this.multCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multCheck.Visible = false;
            // 
            // divCheck
            // 
            this.divCheck.AutoSize = true;
            this.divCheck.BackColor = System.Drawing.Color.Ivory;
            this.divCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divCheck.ForeColor = System.Drawing.Color.ForestGreen;
            this.divCheck.Location = new System.Drawing.Point(443, 301);
            this.divCheck.Name = "divCheck";
            this.divCheck.Size = new System.Drawing.Size(29, 29);
            this.divCheck.TabIndex = 25;
            this.divCheck.Text = "✓";
            this.divCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divCheck.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Tomato;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(476, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 31);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.Location = new System.Drawing.Point(442, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(34, 31);
            this.minimizeBtn.TabIndex = 27;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(510, 410);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.divCheck);
            this.Controls.Add(this.multCheck);
            this.Controls.Add(this.minCheck);
            this.Controls.Add(this.plusCheck);
            this.Controls.Add(this.rndQuizBtn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.divideRightLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divideLeftLabel);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.multRightLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multLeftLabel);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.minRightLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.Text = "Math Quiz";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuizForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown diff;
        private System.Windows.Forms.Label minRightLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minLeftLabel;
        private System.Windows.Forms.NumericUpDown multiply;
        private System.Windows.Forms.Label multRightLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label multLeftLabel;
        private System.Windows.Forms.NumericUpDown divide;
        private System.Windows.Forms.Label divideRightLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divideLeftLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Button rndQuizBtn;
        private System.Windows.Forms.Label plusCheck;
        private System.Windows.Forms.Label minCheck;
        private System.Windows.Forms.Label multCheck;
        private System.Windows.Forms.Label divCheck;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minimizeBtn;
    }
}

