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
            this.ucPlayingScreen1 = new Lab3_Game.UserControls.UCPlayingScreen();
            this.ucHomeScreen1 = new Lab3_Game.UserControls.UCHomeScreen();
            this.SuspendLayout();
            // 
            // ucPlayingScreen1
            // 
            this.ucPlayingScreen1.BackColor = System.Drawing.Color.White;
            this.ucPlayingScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlayingScreen1.Location = new System.Drawing.Point(0, 0);
            this.ucPlayingScreen1.Name = "ucPlayingScreen1";
            this.ucPlayingScreen1.Size = new System.Drawing.Size(1076, 610);
            this.ucPlayingScreen1.TabIndex = 3;
            this.ucPlayingScreen1.back_click += new System.EventHandler<System.EventArgs>(this.ucPlayingScreen1_back_click);
            // 
            // ucHomeScreen1
            // 
            this.ucHomeScreen1.BackColor = System.Drawing.Color.White;
            this.ucHomeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHomeScreen1.Location = new System.Drawing.Point(0, 0);
            this.ucHomeScreen1.Name = "ucHomeScreen1";
            this.ucHomeScreen1.Size = new System.Drawing.Size(1076, 610);
            this.ucHomeScreen1.TabIndex = 4;
            this.ucHomeScreen1.label2_click += new System.EventHandler<System.EventArgs>(this.ucHomeScreen1_label2_click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 610);
            this.Controls.Add(this.ucHomeScreen1);
            this.Controls.Add(this.ucPlayingScreen1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.UCPlayingScreen ucPlayingScreen1;
        private UserControls.UCHomeScreen ucHomeScreen1;
    }
}