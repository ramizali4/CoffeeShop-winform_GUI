namespace CoffeeShop_GUI
{
    partial class Admin_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_frm));
            this.EditFoodMenu_btn = new System.Windows.Forms.Button();
            this.EditUsers_btn = new System.Windows.Forms.Button();
            this.ShowAllOrders_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EditFoodMenu_btn
            // 
            this.EditFoodMenu_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditFoodMenu_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditFoodMenu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditFoodMenu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditFoodMenu_btn.FlatAppearance.BorderSize = 0;
            this.EditFoodMenu_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditFoodMenu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditFoodMenu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditFoodMenu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFoodMenu_btn.Font = new System.Drawing.Font("Futura Bk BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFoodMenu_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.EditFoodMenu_btn.Image = global::CoffeeShop_GUI.Properties.Resources.food_i6con;
            this.EditFoodMenu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditFoodMenu_btn.Location = new System.Drawing.Point(141, 83);
            this.EditFoodMenu_btn.Margin = new System.Windows.Forms.Padding(0);
            this.EditFoodMenu_btn.Name = "EditFoodMenu_btn";
            this.EditFoodMenu_btn.Size = new System.Drawing.Size(399, 52);
            this.EditFoodMenu_btn.TabIndex = 2;
            this.EditFoodMenu_btn.Text = "Edit Food Menu";
            this.EditFoodMenu_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditFoodMenu_btn.UseVisualStyleBackColor = false;
            this.EditFoodMenu_btn.Click += new System.EventHandler(this.EditFoodMenu_btn_Click);
            this.EditFoodMenu_btn.MouseLeave += new System.EventHandler(this.EditUsers_btn_MouseLeave);
            this.EditFoodMenu_btn.MouseHover += new System.EventHandler(this.EditFoodMenu_btn_MouseHover);
            // 
            // EditUsers_btn
            // 
            this.EditUsers_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditUsers_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditUsers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditUsers_btn.FlatAppearance.BorderSize = 0;
            this.EditUsers_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditUsers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditUsers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.EditUsers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUsers_btn.Font = new System.Drawing.Font("Futura Bk BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUsers_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.EditUsers_btn.Image = global::CoffeeShop_GUI.Properties.Resources.user_ic6on;
            this.EditUsers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditUsers_btn.Location = new System.Drawing.Point(141, 211);
            this.EditUsers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.EditUsers_btn.Name = "EditUsers_btn";
            this.EditUsers_btn.Size = new System.Drawing.Size(399, 52);
            this.EditUsers_btn.TabIndex = 2;
            this.EditUsers_btn.Text = "Edit Customers";
            this.EditUsers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditUsers_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditUsers_btn.UseVisualStyleBackColor = false;
            this.EditUsers_btn.Click += new System.EventHandler(this.EditUsers_btn_Click);
            this.EditUsers_btn.MouseLeave += new System.EventHandler(this.EditUsers_btn_MouseLeave);
            this.EditUsers_btn.MouseHover += new System.EventHandler(this.EditFoodMenu_btn_MouseHover);
            // 
            // ShowAllOrders_btn
            // 
            this.ShowAllOrders_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowAllOrders_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowAllOrders_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ShowAllOrders_btn.FlatAppearance.BorderSize = 0;
            this.ShowAllOrders_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ShowAllOrders_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ShowAllOrders_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ShowAllOrders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAllOrders_btn.Font = new System.Drawing.Font("Futura Bk BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllOrders_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.ShowAllOrders_btn.Image = global::CoffeeShop_GUI.Properties.Resources.order_ic4on;
            this.ShowAllOrders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAllOrders_btn.Location = new System.Drawing.Point(141, 343);
            this.ShowAllOrders_btn.Margin = new System.Windows.Forms.Padding(0);
            this.ShowAllOrders_btn.Name = "ShowAllOrders_btn";
            this.ShowAllOrders_btn.Size = new System.Drawing.Size(399, 52);
            this.ShowAllOrders_btn.TabIndex = 2;
            this.ShowAllOrders_btn.Text = "Show All Orders";
            this.ShowAllOrders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowAllOrders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ShowAllOrders_btn.UseVisualStyleBackColor = false;
            this.ShowAllOrders_btn.Click += new System.EventHandler(this.ShowAllOrders_btn_Click);
            this.ShowAllOrders_btn.MouseLeave += new System.EventHandler(this.EditUsers_btn_MouseLeave);
            this.ShowAllOrders_btn.MouseHover += new System.EventHandler(this.EditFoodMenu_btn_MouseHover);
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_btn.BackColor = System.Drawing.Color.Transparent;
            this.Back_btn.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.back_btn1;
            this.Back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Location = new System.Drawing.Point(39, 32);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(98, 76);
            this.Back_btn.TabIndex = 3;
            this.Back_btn.Text = " ";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            this.Back_btn.MouseLeave += new System.EventHandler(this.Back_btn_MouseLeave);
            this.Back_btn.MouseHover += new System.EventHandler(this.Back_btn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.EditUsers_btn);
            this.panel1.Controls.Add(this.ShowAllOrders_btn);
            this.panel1.Controls.Add(this.EditFoodMenu_btn);
            this.panel1.Location = new System.Drawing.Point(366, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 476);
            this.panel1.TabIndex = 4;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Soettally", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(666, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 81);
            this.label3.TabIndex = 12;
            this.label3.Text = "Somnix Cafe";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.PROFILE_icon_png;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(478, -24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 803);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_frm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditFoodMenu_btn;
        private System.Windows.Forms.Button EditUsers_btn;
        private System.Windows.Forms.Button ShowAllOrders_btn;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}