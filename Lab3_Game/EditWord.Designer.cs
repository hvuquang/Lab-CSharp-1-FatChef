namespace Lab3_Game
{
    partial class EditWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditWord));
            this.tbNewWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ucDictionary1 = new Lab3_Game.UserControls.UCDictionary();
            this.ucHomeScreen1 = new Lab3_Game.UserControls.UCHomeScreen();
            this.SuspendLayout();
            // 
            // tbNewWord
            // 
            this.tbNewWord.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNewWord.Location = new System.Drawing.Point(700, 304);
            this.tbNewWord.Name = "tbNewWord";
            this.tbNewWord.PlaceholderText = "Enter here";
            this.tbNewWord.Size = new System.Drawing.Size(271, 43);
            this.tbNewWord.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(700, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(487, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter new word";
            // 
            // ucDictionary1
            // 
            this.ucDictionary1.BackColor = System.Drawing.SystemColors.Control;
            this.ucDictionary1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDictionary1.BackgroundImage")));
            this.ucDictionary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDictionary1.Location = new System.Drawing.Point(0, 0);
            this.ucDictionary1.Name = "ucDictionary1";
            this.ucDictionary1.Size = new System.Drawing.Size(1076, 610);
            this.ucDictionary1.TabIndex = 9;
            this.ucDictionary1.lbback_click += new System.EventHandler<System.EventArgs>(this.ucDictionary1_lbback_click);
            // 
            // ucHomeScreen1
            // 
            this.ucHomeScreen1.BackColor = System.Drawing.Color.White;
            this.ucHomeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomeScreen1.BackgroundImage")));
            this.ucHomeScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.ucHomeScreen1.Name = "ucHomeScreen1";
            this.ucHomeScreen1.Size = new System.Drawing.Size(1076, 610);
            this.ucHomeScreen1.TabIndex = 10;
            // 
            // EditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(1076, 610);
            this.Controls.Add(this.ucDictionary1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNewWord);
            this.Controls.Add(this.ucHomeScreen1);
            this.Name = "EditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNewWord;
        private Button button1;
        private Button button2;
        private Label label3;
        private UserControls.UCDictionary ucDictionary1;
        private UserControls.UCHomeScreen ucHomeScreen1;
    }
}