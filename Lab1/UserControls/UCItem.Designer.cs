namespace Lab1.UserControls
{
    partial class UCItem
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
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.panel23);
            this.panel21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Padding = new System.Windows.Forms.Padding(10);
            this.panel21.Size = new System.Drawing.Size(205, 291);
            this.panel21.TabIndex = 5;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label1);
            this.panel22.Controls.Add(this.btnOrder);
            this.panel22.Controls.Add(this.lbPrice);
            this.panel22.Controls.Add(this.lbRate);
            this.panel22.Controls.Add(this.lbTitle);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(10, 167);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(183, 102);
            this.panel22.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "$";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.btnOrder.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.btnOrder.Location = new System.Drawing.Point(3, 68);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 35);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseHover += new System.EventHandler(this.btnOrder_MouseHover);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(140, 71);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 26);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "30";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRate.Location = new System.Drawing.Point(135, 5);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(44, 21);
            this.lbRate.TabIndex = 1;
            this.lbRate.Text = "10.0";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(3, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(131, 46);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Mi Tocaya Antojería";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.pbIcon);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel23.Location = new System.Drawing.Point(10, 10);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(183, 157);
            this.panel23.TabIndex = 1;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbIcon.Image = global::Lab1.Properties.Resources.Dame_credit_Evan_Sung;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(183, 157);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // UCItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel21);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "UCItem";
            this.Size = new System.Drawing.Size(205, 291);
            this.Click += new System.EventHandler(this.UCItem_Click);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel21;
        private Panel panel22;
        private Label lbPrice;
        private Label lbRate;
        private Label lbTitle;
        private Panel panel23;
        private PictureBox pbIcon;
        private Button btnOrder;
        private Label label1;
    }
}
