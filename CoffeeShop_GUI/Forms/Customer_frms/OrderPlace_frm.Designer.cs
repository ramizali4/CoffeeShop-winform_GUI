namespace CoffeeShop_GUI.Forms.Customer_frms
{
    partial class OrderPlace_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Confirm_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBill_lbl = new System.Windows.Forms.Label();
            this.Bill_header = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cart_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OrderNow_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cart_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(768, 143);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1105, 848);
            this.webBrowser1.TabIndex = 1;
            // 
            // Confirm_header
            // 
            this.Confirm_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Confirm_header.AutoSize = true;
            this.Confirm_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_header.Font = new System.Drawing.Font("Century Gothic", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Confirm_header.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Confirm_header.Location = new System.Drawing.Point(394, 9);
            this.Confirm_header.Name = "Confirm_header";
            this.Confirm_header.Size = new System.Drawing.Size(1076, 110);
            this.Confirm_header.TabIndex = 2;
            this.Confirm_header.Text = "S H O P P I N G   C A R T";
            this.Confirm_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.Total_bill_Panel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TotalBill_lbl);
            this.panel1.Controls.Add(this.Bill_header);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 857);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(352, 819);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 10);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(111, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "   NAME                         P    QTY    FP";
            // 
            // listBox4
            // 
            this.listBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox4.BackColor = System.Drawing.SystemColors.Control;
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.ColumnWidth = 1;
            this.listBox4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.IntegralHeight = false;
            this.listBox4.ItemHeight = 37;
            this.listBox4.Location = new System.Drawing.Point(592, 208);
            this.listBox4.Margin = new System.Windows.Forms.Padding(8);
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Size = new System.Drawing.Size(94, 493);
            this.listBox4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(378, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 63);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rs. 1000/-";
            // 
            // TotalBill_lbl
            // 
            this.TotalBill_lbl.AutoSize = true;
            this.TotalBill_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalBill_lbl.Font = new System.Drawing.Font("Century Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBill_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalBill_lbl.Location = new System.Drawing.Point(33, 752);
            this.TotalBill_lbl.Name = "TotalBill_lbl";
            this.TotalBill_lbl.Size = new System.Drawing.Size(314, 63);
            this.TotalBill_lbl.TabIndex = 2;
            this.TotalBill_lbl.Text = "TOTAL BILL: ";
            // 
            // Bill_header
            // 
            this.Bill_header.AutoSize = true;
            this.Bill_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bill_header.Font = new System.Drawing.Font("Century Gothic", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bill_header.Location = new System.Drawing.Point(245, 0);
            this.Bill_header.Name = "Bill_header";
            this.Bill_header.Size = new System.Drawing.Size(209, 110);
            this.Bill_header.TabIndex = 2;
            this.Bill_header.Text = "BILL";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 1;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 37;
            this.listBox1.Location = new System.Drawing.Point(24, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(412, 426);
            this.listBox1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox3);
            this.panel2.Location = new System.Drawing.Point(237, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 415);
            this.panel2.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ColumnWidth = 1;
            this.listBox2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 37;
            this.listBox2.Location = new System.Drawing.Point(201, -3);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox2.Size = new System.Drawing.Size(75, 507);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.ColumnWidth = 1;
            this.listBox3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.IntegralHeight = false;
            this.listBox3.ItemHeight = 37;
            this.listBox3.Location = new System.Drawing.Point(279, 0);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(74, 504);
            this.listBox3.TabIndex = 5;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(-7, 12);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 15);
            this.textBox.TabIndex = 3;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.back_btn1;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(33, 33);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(89, 49);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = " ";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.shopppintCart_icon2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1476, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 104);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Cart_panel
            // 
            this.Cart_panel.Controls.Add(this.label3);
            this.Cart_panel.Controls.Add(this.OrderNow_btn);
            this.Cart_panel.Controls.Add(this.label5);
            this.Cart_panel.Controls.Add(this.label4);
            this.Cart_panel.Location = new System.Drawing.Point(33, 146);
            this.Cart_panel.Name = "Cart_panel";
            this.Cart_panel.Size = new System.Drawing.Size(1840, 875);
            this.Cart_panel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(277, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 74);
            this.label3.TabIndex = 2;
            this.label3.Text = "OOPS !";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 56F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(288, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(886, 336);
            this.label4.TabIndex = 2;
            this.label4.Text = "IT\'S LOOK LIKE YOU\r\nHAVEN\'T ORDERED\r\nANYTHING YET.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 117F);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(1566, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 244);
            this.label5.TabIndex = 2;
            this.label5.Text = ":(";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderNow_btn
            // 
            this.OrderNow_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderNow_btn.Font = new System.Drawing.Font("Century Gothic", 26F);
            this.OrderNow_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OrderNow_btn.Location = new System.Drawing.Point(575, 597);
            this.OrderNow_btn.Name = "OrderNow_btn";
            this.OrderNow_btn.Size = new System.Drawing.Size(313, 93);
            this.OrderNow_btn.TabIndex = 3;
            this.OrderNow_btn.Text = "ORDER NOW";
            this.OrderNow_btn.UseVisualStyleBackColor = true;
            this.OrderNow_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // OrderPlace_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Confirm_header);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cart_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderPlace_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPlace_frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cart_panel.ResumeLayout(false);
            this.Cart_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label Confirm_header;
        private System.Windows.Forms.Label Bill_header;
        private System.Windows.Forms.Label TotalBill_lbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Cart_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OrderNow_btn;
    }
}