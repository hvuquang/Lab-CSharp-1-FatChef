﻿namespace Lab3_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ucPlayingScreen1 = new Lab3_Game.UserControls.UCPlayingScreen();
            this.ucHomeScreen1 = new Lab3_Game.UserControls.UCHomeScreen();
            this.ucDictionary1 = new Lab3_Game.UserControls.UCDictionary();
            this.ucScoreBoard1 = new Lab3_Game.UserControls.UCScoreBoard();
            this.SuspendLayout();
            // 
            // ucPlayingScreen1
            // 
            this.ucPlayingScreen1.BackColor = System.Drawing.Color.White;
            this.ucPlayingScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucPlayingScreen1.BackgroundImage")));
            this.ucPlayingScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucPlayingScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlayingScreen1.Location = new System.Drawing.Point(0, 0);
            this.ucPlayingScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPlayingScreen1.Name = "ucPlayingScreen1";
            this.ucPlayingScreen1.Size = new System.Drawing.Size(1076, 610);
            this.ucPlayingScreen1.TabIndex = 3;
            this.ucPlayingScreen1.Type = null;
            this.ucPlayingScreen1.back_click += new System.EventHandler<System.EventArgs>(this.ucPlayingScreen1_back_click);
            // 
            // ucHomeScreen1
            // 
            this.ucHomeScreen1.BackColor = System.Drawing.Color.White;
            this.ucHomeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucHomeScreen1.BackgroundImage")));
            this.ucHomeScreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.ucHomeScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.ucHomeScreen1.Name = "ucHomeScreen1";
            this.ucHomeScreen1.Size = new System.Drawing.Size(1076, 610);
            this.ucHomeScreen1.TabIndex = 4;
            this.ucHomeScreen1.label2_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_label2_click_1);
            this.ucHomeScreen1.lbColor_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_lbColor_click);
            this.ucHomeScreen1.lbFruit_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_lbFruit_click);
            this.ucHomeScreen1.lbAnimal_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_lbAnimal_click);
            this.ucHomeScreen1.lbDictionary_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_lbDictionary_click);
            this.ucHomeScreen1.lbAchievement_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_lbAchievement_click);
            this.ucHomeScreen1.lbExit_click += new System.EventHandler(this.ucHomeScreen1_lbExit_click);
            // 
            // ucDictionary1
            // 
            this.ucDictionary1.BackColor = System.Drawing.SystemColors.Control;
            this.ucDictionary1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDictionary1.BackgroundImage")));
            this.ucDictionary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDictionary1.Location = new System.Drawing.Point(0, 0);
            this.ucDictionary1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDictionary1.Name = "ucDictionary1";
            this.ucDictionary1.Size = new System.Drawing.Size(1076, 610);
            this.ucDictionary1.TabIndex = 5;
            this.ucDictionary1.lbback_click += new System.EventHandler<System.EventArgs>(this.ucDictionary1_lbback_click);
            this.ucDictionary1.ucDictionary_load += new System.EventHandler<System.EventArgs>(this.ucDictionary1_ucDictionary_load);
            // 
            // ucScoreBoard1
            // 
            this.ucScoreBoard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucScoreBoard1.BackgroundImage")));
            this.ucScoreBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScoreBoard1.Location = new System.Drawing.Point(0, 0);
            this.ucScoreBoard1.Name = "ucScoreBoard1";
            this.ucScoreBoard1.Size = new System.Drawing.Size(1076, 610);
            this.ucScoreBoard1.TabIndex = 6;
            this.ucScoreBoard1.btnback_click += new System.EventHandler(this.ucScoreBoard1_btnback_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 610);
            this.Controls.Add(this.ucHomeScreen1);
            this.Controls.Add(this.ucPlayingScreen1);
            this.Controls.Add(this.ucDictionary1);
            this.Controls.Add(this.ucScoreBoard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void ucDictionary1_lbback_click(object sender, EventArgs e)
        {
            ucHomeScreen1.Show();
            ucHomeScreen1.BringToFront();
        }

        #endregion
        private UserControls.UCPlayingScreen ucPlayingScreen1;
        private UserControls.UCHomeScreen ucHomeScreen1;
        private UserControls.UCDictionary ucDictionary1;
        private UserControls.UCScoreBoard ucScoreBoard1;
    }
}