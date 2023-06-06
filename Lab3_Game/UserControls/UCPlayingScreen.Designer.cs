﻿namespace Lab3_Game.UserControls
{
    partial class UCPlayingScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWord = new System.Windows.Forms.PictureBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbIsCorrect1 = new System.Windows.Forms.PictureBox();
            this.pbIsCorrect2 = new System.Windows.Forms.PictureBox();
            this.pbIsCorrect3 = new System.Windows.Forms.PictureBox();
            this.pbIsCorrect4 = new System.Windows.Forms.PictureBox();
            this.pbIsCorrect5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(282, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question: 0 / 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(574, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score: 0 / 100";
            // 
            // pbWord
            // 
            this.pbWord.Location = new System.Drawing.Point(353, 134);
            this.pbWord.Name = "pbWord";
            this.pbWord.Size = new System.Drawing.Size(233, 243);
            this.pbWord.TabIndex = 4;
            this.pbWord.TabStop = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.Color.White;
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(10, 10);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.PlaceholderText = "Your answer here";
            this.tbAnswer.Size = new System.Drawing.Size(335, 36);
            this.tbAnswer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbAnswer);
            this.panel1.Location = new System.Drawing.Point(282, 403);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(357, 57);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(764, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Question 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(764, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Question 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(764, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Question 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(764, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(764, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Question 5:";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBack.Location = new System.Drawing.Point(1010, 14);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(63, 31);
            this.lbBack.TabIndex = 12;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Lab3_Game.Properties.Resources.mute;
            this.pictureBox2.Location = new System.Drawing.Point(23, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbIsCorrect1
            // 
            this.pbIsCorrect1.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect1.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect1.Location = new System.Drawing.Point(915, 139);
            this.pbIsCorrect1.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsCorrect1.Name = "pbIsCorrect1";
            this.pbIsCorrect1.Size = new System.Drawing.Size(49, 51);
            this.pbIsCorrect1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect1.TabIndex = 25;
            this.pbIsCorrect1.TabStop = false;
            // 
            // pbIsCorrect2
            // 
            this.pbIsCorrect2.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect2.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect2.Location = new System.Drawing.Point(915, 210);
            this.pbIsCorrect2.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsCorrect2.Name = "pbIsCorrect2";
            this.pbIsCorrect2.Size = new System.Drawing.Size(49, 51);
            this.pbIsCorrect2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect2.TabIndex = 26;
            this.pbIsCorrect2.TabStop = false;
            // 
            // pbIsCorrect3
            // 
            this.pbIsCorrect3.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect3.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect3.Location = new System.Drawing.Point(915, 279);
            this.pbIsCorrect3.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsCorrect3.Name = "pbIsCorrect3";
            this.pbIsCorrect3.Size = new System.Drawing.Size(49, 51);
            this.pbIsCorrect3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect3.TabIndex = 27;
            this.pbIsCorrect3.TabStop = false;
            // 
            // pbIsCorrect4
            // 
            this.pbIsCorrect4.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect4.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect4.Location = new System.Drawing.Point(915, 347);
            this.pbIsCorrect4.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsCorrect4.Name = "pbIsCorrect4";
            this.pbIsCorrect4.Size = new System.Drawing.Size(49, 51);
            this.pbIsCorrect4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect4.TabIndex = 28;
            this.pbIsCorrect4.TabStop = false;
            // 
            // pbIsCorrect5
            // 
            this.pbIsCorrect5.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect5.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect5.Location = new System.Drawing.Point(915, 429);
            this.pbIsCorrect5.Margin = new System.Windows.Forms.Padding(2);
            this.pbIsCorrect5.Name = "pbIsCorrect5";
            this.pbIsCorrect5.Size = new System.Drawing.Size(49, 51);
            this.pbIsCorrect5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect5.TabIndex = 29;
            this.pbIsCorrect5.TabStop = false;
            // 
            // UCPlayingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbIsCorrect5);
            this.Controls.Add(this.pbIsCorrect4);
            this.Controls.Add(this.pbIsCorrect3);
            this.Controls.Add(this.pbIsCorrect2);
            this.Controls.Add(this.pbIsCorrect1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UCPlayingScreen";
            this.Size = new System.Drawing.Size(1076, 610);
            ((System.ComponentModel.ISupportInitialize)(this.pbWord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pbWord;
        private TextBox tbAnswer;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbBack;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pbIsCorrect1;
        private PictureBox pbIsCorrect2;
        private PictureBox pbIsCorrect3;
        private PictureBox pbIsCorrect4;
        private PictureBox pbIsCorrect5;
    }
}
