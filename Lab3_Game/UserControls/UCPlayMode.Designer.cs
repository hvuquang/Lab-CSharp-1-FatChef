namespace Lab3_Game.UserControls
{
    partial class UCPlayMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPlayMode));
            this.pbEasy = new System.Windows.Forms.PictureBox();
            this.lbFruit = new System.Windows.Forms.Label();
            this.pbMedium = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHard = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEasy
            // 
            this.pbEasy.Image = ((System.Drawing.Image)(resources.GetObject("pbEasy.Image")));
            this.pbEasy.Location = new System.Drawing.Point(144, 239);
            this.pbEasy.Name = "pbEasy";
            this.pbEasy.Size = new System.Drawing.Size(200, 200);
            this.pbEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEasy.TabIndex = 27;
            this.pbEasy.TabStop = false;
            this.pbEasy.Click += new System.EventHandler(this.pbEasy_Click);
            // 
            // lbFruit
            // 
            this.lbFruit.AutoSize = true;
            this.lbFruit.BackColor = System.Drawing.Color.Transparent;
            this.lbFruit.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFruit.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbFruit.Location = new System.Drawing.Point(160, 455);
            this.lbFruit.Name = "lbFruit";
            this.lbFruit.Size = new System.Drawing.Size(149, 37);
            this.lbFruit.TabIndex = 26;
            this.lbFruit.Text = "Easy Mode";
            // 
            // pbMedium
            // 
            this.pbMedium.Image = ((System.Drawing.Image)(resources.GetObject("pbMedium.Image")));
            this.pbMedium.Location = new System.Drawing.Point(431, 239);
            this.pbMedium.Name = "pbMedium";
            this.pbMedium.Size = new System.Drawing.Size(200, 200);
            this.pbMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedium.TabIndex = 29;
            this.pbMedium.TabStop = false;
            this.pbMedium.Click += new System.EventHandler(this.pbMedium_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(431, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Medium Mode";
            // 
            // pbHard
            // 
            this.pbHard.Image = ((System.Drawing.Image)(resources.GetObject("pbHard.Image")));
            this.pbHard.Location = new System.Drawing.Point(727, 239);
            this.pbHard.Name = "pbHard";
            this.pbHard.Size = new System.Drawing.Size(200, 200);
            this.pbHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHard.TabIndex = 31;
            this.pbHard.TabStop = false;
            this.pbHard.Click += new System.EventHandler(this.pbHard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(750, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Hard Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(154, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(745, 99);
            this.label3.TabIndex = 32;
            this.label3.Text = "Choose your path !!!";
            // 
            // UCPlayMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources._9;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbHard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEasy);
            this.Controls.Add(this.lbFruit);
            this.Name = "UCPlayMode";
            this.Size = new System.Drawing.Size(1076, 610);
            ((System.ComponentModel.ISupportInitialize)(this.pbEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbEasy;
        private Label lbFruit;
        private PictureBox pbMedium;
        private Label label1;
        private PictureBox pbHard;
        private Label label2;
        private Label label3;
    }
}
