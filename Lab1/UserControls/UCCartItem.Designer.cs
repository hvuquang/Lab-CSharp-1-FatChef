namespace Lab1.UserControls
{
    partial class UCCartItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pbMinus = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbRef = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(458, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 118);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Lab1.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(21, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 118);
            this.panel1.TabIndex = 14;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::Lab1.Properties.Resources.Dame_credit_Evan_Sung;
            this.pbIcon.Location = new System.Drawing.Point(21, 10);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 100);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 12;
            this.pbIcon.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.Location = new System.Drawing.Point(271, 44);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 28);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "90";
            // 
            // pbMinus
            // 
            this.pbMinus.Image = global::Lab1.Properties.Resources.minus;
            this.pbMinus.Location = new System.Drawing.Point(136, 44);
            this.pbMinus.Name = "pbMinus";
            this.pbMinus.Size = new System.Drawing.Size(30, 30);
            this.pbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinus.TabIndex = 17;
            this.pbMinus.TabStop = false;
            this.pbMinus.MouseLeave += new System.EventHandler(this.pbMinus_MouseLeave);
            this.pbMinus.MouseHover += new System.EventHandler(this.pbMinus_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(251, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "$";
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::Lab1.Properties.Resources.plus;
            this.pbAdd.Location = new System.Drawing.Point(195, 44);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(30, 30);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 16;
            this.pbAdd.TabStop = false;
            this.pbAdd.MouseLeave += new System.EventHandler(this.pbAdd_MouseLeave);
            this.pbAdd.MouseHover += new System.EventHandler(this.pbAdd_MouseHover);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(6, 34);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 25);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Combo1";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuantity.Location = new System.Drawing.Point(172, 49);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(17, 20);
            this.lbQuantity.TabIndex = 15;
            this.lbQuantity.Text = "3";
            // 
            // lbRef
            // 
            this.lbRef.AutoSize = true;
            this.lbRef.Location = new System.Drawing.Point(6, 79);
            this.lbRef.Name = "lbRef";
            this.lbRef.Size = new System.Drawing.Size(87, 17);
            this.lbRef.TabIndex = 14;
            this.lbRef.Text = "Ref 06980256";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbPrice);
            this.panel3.Controls.Add(this.lbRef);
            this.panel3.Controls.Add(this.pbMinus);
            this.panel3.Controls.Add(this.lbQuantity);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbTitle);
            this.panel3.Controls.Add(this.pbAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(144, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 118);
            this.panel3.TabIndex = 15;
            // 
            // UCCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UCCartItem";
            this.Size = new System.Drawing.Size(528, 118);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label lbPrice;
        private PictureBox pbIcon;
        private PictureBox pbMinus;
        private Label label4;
        private PictureBox pbAdd;
        private Label lbTitle;
        private Label lbQuantity;
        private Label lbRef;
        private Panel panel3;
    }
}
