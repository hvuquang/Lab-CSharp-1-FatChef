namespace Lab3_Game
{
    partial class CongratulationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnToHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(-3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 62);
            this.label1.TabIndex = 29;
            this.label1.Text = "Congratulation!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(74, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "Questions: 3 / 5 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(74, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 32;
            this.label4.Text = "Score: 0 / 100";
            // 
            // btnReturnToHome
            // 
            this.btnReturnToHome.BackColor = System.Drawing.Color.Purple;
            this.btnReturnToHome.FlatAppearance.BorderSize = 0;
            this.btnReturnToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnToHome.ForeColor = System.Drawing.Color.White;
            this.btnReturnToHome.Location = new System.Drawing.Point(118, 199);
            this.btnReturnToHome.Name = "btnReturnToHome";
            this.btnReturnToHome.Size = new System.Drawing.Size(118, 52);
            this.btnReturnToHome.TabIndex = 33;
            this.btnReturnToHome.Text = "Home";
            this.btnReturnToHome.UseVisualStyleBackColor = false;
            this.btnReturnToHome.Click += new System.EventHandler(this.btnReturnToHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReturnToHome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(59, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 265);
            this.panel1.TabIndex = 34;
            // 
            // CongratulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab3_Game.Properties.Resources.congrat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 305);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CongratulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CongratulationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnReturnToHome;
        private Panel panel1;
    }
}