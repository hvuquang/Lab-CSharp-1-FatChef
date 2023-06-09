﻿namespace Lab3_Game.UserControls
{
    partial class UCScoreBoard
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
            this.btnAnimalScoreboard = new System.Windows.Forms.Button();
            this.btnColorScoreboard = new System.Windows.Forms.Button();
            this.btnFruitScoreBoard = new System.Windows.Forms.Button();
            this.lvScoreboard = new System.Windows.Forms.ListView();
            this.cSTT = new System.Windows.Forms.ColumnHeader();
            this.cType = new System.Windows.Forms.ColumnHeader();
            this.cScore = new System.Windows.Forms.ColumnHeader();
            this.cTime = new System.Windows.Forms.ColumnHeader();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnimalScoreboard
            // 
            this.btnAnimalScoreboard.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAnimalScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimalScoreboard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnimalScoreboard.ForeColor = System.Drawing.Color.Purple;
            this.btnAnimalScoreboard.Location = new System.Drawing.Point(935, 209);
            this.btnAnimalScoreboard.Name = "btnAnimalScoreboard";
            this.btnAnimalScoreboard.Size = new System.Drawing.Size(129, 45);
            this.btnAnimalScoreboard.TabIndex = 5;
            this.btnAnimalScoreboard.Text = "Animal";
            this.btnAnimalScoreboard.UseVisualStyleBackColor = false;
            this.btnAnimalScoreboard.Click += new System.EventHandler(this.btnAnimalScoreboard_Click);
            // 
            // btnColorScoreboard
            // 
            this.btnColorScoreboard.BackColor = System.Drawing.Color.Chartreuse;
            this.btnColorScoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorScoreboard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColorScoreboard.ForeColor = System.Drawing.Color.Purple;
            this.btnColorScoreboard.Location = new System.Drawing.Point(935, 144);
            this.btnColorScoreboard.Name = "btnColorScoreboard";
            this.btnColorScoreboard.Size = new System.Drawing.Size(129, 44);
            this.btnColorScoreboard.TabIndex = 4;
            this.btnColorScoreboard.Text = "Color";
            this.btnColorScoreboard.UseVisualStyleBackColor = false;
            this.btnColorScoreboard.Click += new System.EventHandler(this.btnColorScoreboard_Click);
            // 
            // btnFruitScoreBoard
            // 
            this.btnFruitScoreBoard.BackColor = System.Drawing.Color.Chartreuse;
            this.btnFruitScoreBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFruitScoreBoard.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFruitScoreBoard.ForeColor = System.Drawing.Color.Purple;
            this.btnFruitScoreBoard.Location = new System.Drawing.Point(935, 79);
            this.btnFruitScoreBoard.Name = "btnFruitScoreBoard";
            this.btnFruitScoreBoard.Size = new System.Drawing.Size(129, 44);
            this.btnFruitScoreBoard.TabIndex = 3;
            this.btnFruitScoreBoard.Text = "Fruit";
            this.btnFruitScoreBoard.UseVisualStyleBackColor = false;
            this.btnFruitScoreBoard.Click += new System.EventHandler(this.btnFruitScoreBoard_Click);
            // 
            // lvScoreboard
            // 
            this.lvScoreboard.BackColor = System.Drawing.Color.SlateBlue;
            this.lvScoreboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvScoreboard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cSTT,
            this.cType,
            this.cScore,
            this.cTime});
            this.lvScoreboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvScoreboard.ForeColor = System.Drawing.Color.Goldenrod;
            this.lvScoreboard.GridLines = true;
            this.lvScoreboard.Location = new System.Drawing.Point(315, 79);
            this.lvScoreboard.Name = "lvScoreboard";
            this.lvScoreboard.Scrollable = false;
            this.lvScoreboard.Size = new System.Drawing.Size(573, 471);
            this.lvScoreboard.TabIndex = 6;
            this.lvScoreboard.UseCompatibleStateImageBehavior = false;
            this.lvScoreboard.View = System.Windows.Forms.View.Details;
            // 
            // cSTT
            // 
            this.cSTT.Text = "STT";
            this.cSTT.Width = 120;
            // 
            // cType
            // 
            this.cType.DisplayIndex = 2;
            this.cType.Text = "Type";
            this.cType.Width = 150;
            // 
            // cScore
            // 
            this.cScore.DisplayIndex = 1;
            this.cScore.Text = "Score";
            this.cScore.Width = 150;
            // 
            // cTime
            // 
            this.cTime.Text = "Time";
            this.cTime.Width = 320;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Purple;
            this.btnBack.Location = new System.Drawing.Point(935, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 44);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UCScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources._4;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvScoreboard);
            this.Controls.Add(this.btnAnimalScoreboard);
            this.Controls.Add(this.btnColorScoreboard);
            this.Controls.Add(this.btnFruitScoreBoard);
            this.Name = "UCScoreBoard";
            this.Size = new System.Drawing.Size(1076, 610);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnimalScoreboard;
        private Button btnColorScoreboard;
        private Button btnFruitScoreBoard;
        private ListView lvScoreboard;
        private ColumnHeader cSTT;
        private ColumnHeader cType;
        private ColumnHeader cScore;
        private ColumnHeader cTime;
        private Button btnBack;
    }
}
