namespace Lab1
{
    partial class FormHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCart = new System.Windows.Forms.PictureBox();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ucAllType1 = new Lab1.UserControls.UCAllType();
            this.ucCocktail2 = new Lab1.UserControls.UCCocktail();
            this.ucDessert1 = new Lab1.UserControls.UCDessert();
            this.ucDinner1 = new Lab1.UserControls.UCDinner();
            this.ucGolden1 = new Lab1.UserControls.UCGolden();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbCart);
            this.panel1.Controls.Add(this.linkLabel7);
            this.panel1.Controls.Add(this.linkLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 77);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Lab1.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(1188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbCart
            // 
            this.pbCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCart.Image = global::Lab1.Properties.Resources.shopping_cart;
            this.pbCart.Location = new System.Drawing.Point(1132, 12);
            this.pbCart.Name = "pbCart";
            this.pbCart.Size = new System.Drawing.Size(50, 50);
            this.pbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCart.TabIndex = 10;
            this.pbCart.TabStop = false;
            this.pbCart.Click += new System.EventHandler(this.pbCart_Click);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel7.Location = new System.Drawing.Point(5, 19);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(150, 47);
            this.linkLabel7.TabIndex = 9;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "FatChef";
            // 
            // linkLabel6
            // 
            this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel6.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel6.Location = new System.Drawing.Point(900, 12);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(227, 50);
            this.linkLabel6.TabIndex = 7;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "LogIn / Register";
            this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1250, 43);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1250, 43);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.linkLabel5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1002, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.MaximumSize = new System.Drawing.Size(350, 43);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(8);
            this.panel8.Size = new System.Drawing.Size(246, 39);
            this.panel8.TabIndex = 10;
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.Black;
            this.linkLabel5.Location = new System.Drawing.Point(36, 3);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(163, 30);
            this.linkLabel5.TabIndex = 9;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Golden Combo";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.MaximumSize = new System.Drawing.Size(350, 43);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(246, 39);
            this.panel5.TabIndex = 8;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(96, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 30);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "All";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.linkLabel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(502, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.MaximumSize = new System.Drawing.Size(350, 43);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(8);
            this.panel7.Size = new System.Drawing.Size(246, 39);
            this.panel7.TabIndex = 10;
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.Black;
            this.linkLabel4.Location = new System.Drawing.Point(66, 3);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(102, 30);
            this.linkLabel4.TabIndex = 9;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Cocktails";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.linkLabel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(752, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.MaximumSize = new System.Drawing.Size(350, 43);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8);
            this.panel6.Size = new System.Drawing.Size(246, 39);
            this.panel6.TabIndex = 10;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(75, 3);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(88, 30);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Dessert";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.linkLabel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(252, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.MaximumSize = new System.Drawing.Size(350, 43);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(246, 39);
            this.panel4.TabIndex = 10;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(78, 3);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(81, 30);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Dinner";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.MaximumSize = new System.Drawing.Size(1400, 1000);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 585);
            this.panel3.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ucAllType1);
            this.panel10.Controls.Add(this.ucCocktail2);
            this.panel10.Controls.Add(this.ucDessert1);
            this.panel10.Controls.Add(this.ucDinner1);
            this.panel10.Controls.Add(this.ucGolden1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 106);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel10.Size = new System.Drawing.Size(1250, 479);
            this.panel10.TabIndex = 3;
            // 
            // ucAllType1
            // 
            this.ucAllType1.AutoScroll = true;
            this.ucAllType1.BackColor = System.Drawing.Color.White;
            this.ucAllType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAllType1.Location = new System.Drawing.Point(5, 0);
            this.ucAllType1.Name = "ucAllType1";
            this.ucAllType1.Size = new System.Drawing.Size(1245, 479);
            this.ucAllType1.TabIndex = 0;
            this.ucAllType1.ucAllType_Load += new System.EventHandler(this.ucAllType1_ucAllType_Load);
            // 
            // ucCocktail2
            // 
            this.ucCocktail2.AutoSize = true;
            this.ucCocktail2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCocktail2.Location = new System.Drawing.Point(5, 0);
            this.ucCocktail2.Name = "ucCocktail2";
            this.ucCocktail2.Size = new System.Drawing.Size(1245, 479);
            this.ucCocktail2.TabIndex = 2;
            this.ucCocktail2.ucCockTail_Load += new System.EventHandler(this.ucCocktail2_ucCockTail_Load);
            // 
            // ucDessert1
            // 
            this.ucDessert1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDessert1.Location = new System.Drawing.Point(5, 0);
            this.ucDessert1.Name = "ucDessert1";
            this.ucDessert1.Size = new System.Drawing.Size(1245, 479);
            this.ucDessert1.TabIndex = 3;
            this.ucDessert1.ucDessert_Load += new System.EventHandler(this.ucDessert1_ucDessert_Load);
            // 
            // ucDinner1
            // 
            this.ucDinner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDinner1.Location = new System.Drawing.Point(5, 0);
            this.ucDinner1.Name = "ucDinner1";
            this.ucDinner1.Size = new System.Drawing.Size(1245, 479);
            this.ucDinner1.TabIndex = 4;
            this.ucDinner1.ucDinner_Load += new System.EventHandler(this.ucDinner1_ucDinner_Load);
            // 
            // ucGolden1
            // 
            this.ucGolden1.AutoSize = true;
            this.ucGolden1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGolden1.Location = new System.Drawing.Point(5, 0);
            this.ucGolden1.Name = "ucGolden1";
            this.ucGolden1.Size = new System.Drawing.Size(1245, 479);
            this.ucGolden1.TabIndex = 1;
            this.ucGolden1.ucGolden_Load += new System.EventHandler(this.ucGolden1_ucGolden_Load);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 43);
            this.panel9.MaximumSize = new System.Drawing.Size(1400, 63);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1250, 63);
            this.panel9.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(560, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private LinkLabel linkLabel1;
        private Panel panel8;
        private LinkLabel linkLabel5;
        private Panel panel7;
        private LinkLabel linkLabel4;
        private Panel panel6;
        private LinkLabel linkLabel3;
        private Panel panel4;
        private LinkLabel linkLabel2;
        private Panel panel9;
        private Label label1;
        private Panel panel10;
        private LinkLabel linkLabel6;
        private LinkLabel linkLabel7;
        private UserControls.UCCocktail ucCocktail2;
        private UserControls.UCAllType ucAllType1;
        private UserControls.UCDessert ucDessert1;
        private UserControls.UCDinner ucDinner1;
        private TableLayoutPanel tableLayoutPanel1;
        private UserControls.UCGolden ucGolden1;
        private PictureBox pbCart;
        private PictureBox pictureBox1;
    }
}