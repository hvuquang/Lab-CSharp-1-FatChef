namespace Lab3_Game.UserControls
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
            this.components = new System.ComponentModel.Container();
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
            this.lbHint = new System.Windows.Forms.Label();
            this.timer1_Tick = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWord)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(363, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question: 0 / 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(738, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score: 0 / 100";
            // 
            // pbWord
            // 
            this.pbWord.Location = new System.Drawing.Point(458, 127);
            this.pbWord.Margin = new System.Windows.Forms.Padding(4);
            this.pbWord.Name = "pbWord";
            this.pbWord.Size = new System.Drawing.Size(300, 300);
            this.pbWord.TabIndex = 4;
            this.pbWord.TabStop = false;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.Color.White;
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAnswer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnswer.Location = new System.Drawing.Point(13, 12);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.PlaceholderText = "Your answer here";
            this.tbAnswer.Size = new System.Drawing.Size(430, 45);
            this.tbAnswer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbAnswer);
            this.panel1.Location = new System.Drawing.Point(375, 556);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Size = new System.Drawing.Size(458, 70);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(986, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Question 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(986, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Question 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(986, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Question 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(986, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Question 4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(986, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "Question 5:";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBack.Location = new System.Drawing.Point(1299, 17);
            this.lbBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(79, 40);
            this.lbBack.TabIndex = 12;
            this.lbBack.Text = "Back";
            this.lbBack.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Lab3_Game.Properties.Resources.mute;
            this.pictureBox2.Location = new System.Drawing.Point(30, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 652);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 62);
            this.button1.TabIndex = 24;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbIsCorrect1
            // 
            this.pbIsCorrect1.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect1.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect1.Location = new System.Drawing.Point(1180, 127);
            this.pbIsCorrect1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIsCorrect1.Name = "pbIsCorrect1";
            this.pbIsCorrect1.Size = new System.Drawing.Size(63, 63);
            this.pbIsCorrect1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect1.TabIndex = 25;
            this.pbIsCorrect1.TabStop = false;
            // 
            // pbIsCorrect2
            // 
            this.pbIsCorrect2.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect2.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect2.Location = new System.Drawing.Point(1180, 215);
            this.pbIsCorrect2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIsCorrect2.Name = "pbIsCorrect2";
            this.pbIsCorrect2.Size = new System.Drawing.Size(63, 63);
            this.pbIsCorrect2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect2.TabIndex = 26;
            this.pbIsCorrect2.TabStop = false;
            // 
            // pbIsCorrect3
            // 
            this.pbIsCorrect3.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect3.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect3.Location = new System.Drawing.Point(1180, 300);
            this.pbIsCorrect3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIsCorrect3.Name = "pbIsCorrect3";
            this.pbIsCorrect3.Size = new System.Drawing.Size(63, 63);
            this.pbIsCorrect3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect3.TabIndex = 27;
            this.pbIsCorrect3.TabStop = false;
            // 
            // pbIsCorrect4
            // 
            this.pbIsCorrect4.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect4.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect4.Location = new System.Drawing.Point(1180, 384);
            this.pbIsCorrect4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIsCorrect4.Name = "pbIsCorrect4";
            this.pbIsCorrect4.Size = new System.Drawing.Size(63, 63);
            this.pbIsCorrect4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect4.TabIndex = 28;
            this.pbIsCorrect4.TabStop = false;
            // 
            // pbIsCorrect5
            // 
            this.pbIsCorrect5.BackColor = System.Drawing.Color.Transparent;
            this.pbIsCorrect5.Image = global::Lab3_Game.Properties.Resources.correct;
            this.pbIsCorrect5.Location = new System.Drawing.Point(1180, 485);
            this.pbIsCorrect5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbIsCorrect5.Name = "pbIsCorrect5";
            this.pbIsCorrect5.Size = new System.Drawing.Size(63, 63);
            this.pbIsCorrect5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIsCorrect5.TabIndex = 29;
            this.pbIsCorrect5.TabStop = false;
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.BackColor = System.Drawing.Color.Transparent;
            this.lbHint.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHint.ForeColor = System.Drawing.Color.Salmon;
            this.lbHint.Location = new System.Drawing.Point(514, 485);
            this.lbHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(176, 40);
            this.lbHint.TabIndex = 30;
            this.lbHint.Text = "Hint: --ange";
            // 
            // timer1_Tick
            // 
            this.timer1_Tick.Interval = 1000;
            this.timer1_Tick.Tick += new System.EventHandler(this.timer1_Tick_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.countdownLabel.ForeColor = System.Drawing.Color.White;
            this.countdownLabel.Location = new System.Drawing.Point(987, 56);
            this.countdownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(0, 40);
            this.countdownLabel.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Lab3_Game.Properties.Resources.add_button;
            this.pictureBox1.Location = new System.Drawing.Point(756, 462);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Purple;
            this.btnSubmit.Location = new System.Drawing.Point(514, 652);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(179, 65);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // UCPlayingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources._11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.lbHint);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCPlayingScreen";
            this.Size = new System.Drawing.Size(1383, 754);
            ((System.ComponentModel.ISupportInitialize)(this.pbWord)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIsCorrect5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Label lbHint;
        private System.Windows.Forms.Timer timer1_Tick;
        private Label countdownLabel;
        private PictureBox pictureBox1;
        private Button btnSubmit;
    }
}
