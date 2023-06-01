namespace Lab3_Game.UserControls
{
    partial class UCWord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbTuVung = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbWorkHour = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTuVung)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbTuVung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 174);
            this.panel1.TabIndex = 0;
            // 
            // pbTuVung
            // 
            this.pbTuVung.Location = new System.Drawing.Point(7, 43);
            this.pbTuVung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTuVung.Name = "pbTuVung";
            this.pbTuVung.Size = new System.Drawing.Size(82, 92);
            this.pbTuVung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTuVung.TabIndex = 0;
            this.pbTuVung.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbContent);
            this.panel2.Controls.Add(this.lbWorkHour);
            this.panel2.Controls.Add(this.lbLocation);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(94, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 174);
            this.panel2.TabIndex = 2;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbContent.Location = new System.Drawing.Point(7, 69);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(71, 18);
            this.lbContent.TabIndex = 3;
            this.lbContent.Text = "Nội dung:";
            // 
            // lbWorkHour
            // 
            this.lbWorkHour.AutoSize = true;
            this.lbWorkHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWorkHour.Location = new System.Drawing.Point(7, 102);
            this.lbWorkHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWorkHour.Name = "lbWorkHour";
            this.lbWorkHour.Size = new System.Drawing.Size(122, 18);
            this.lbWorkHour.TabIndex = 2;
            this.lbWorkHour.Text = "Thời gian dịch vụ:";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLocation.Location = new System.Drawing.Point(7, 136);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(70, 18);
            this.lbLocation.TabIndex = 1;
            this.lbLocation.Text = "Địa điểm:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(7, 14);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(91, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Từ vựng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(307, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 174);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(30, 69);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "XÓA";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.Name = "UCWord";
            this.Size = new System.Drawing.Size(448, 174);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTuVung)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbTuVung;
        private System.Windows.Forms.Label lbWorkHour;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbTitle;
    }
}
