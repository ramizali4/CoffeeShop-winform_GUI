namespace CoffeeShop_GUI
{
    partial class SignUp_frm
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
            this.back_btn = new System.Windows.Forms.Button();
            this.EnterUserName_txtbx = new System.Windows.Forms.RichTextBox();
            this.EnterPassword_txtbx = new System.Windows.Forms.RichTextBox();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.SomnixCafe_lbl = new System.Windows.Forms.Label();
            this.logo_box = new System.Windows.Forms.PictureBox();
            this.EnterUserName_bg = new System.Windows.Forms.Panel();
            this.EnterPAssword_bg = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightGray;
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Futura Bk BT", 15F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_btn.Location = new System.Drawing.Point(642, 667);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(106, 48);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // EnterUserName_txtbx
            // 
            this.EnterUserName_txtbx.AcceptsTab = true;
            this.EnterUserName_txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EnterUserName_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterUserName_txtbx.Font = new System.Drawing.Font("Futura Bk BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterUserName_txtbx.ForeColor = System.Drawing.Color.Gray;
            this.EnterUserName_txtbx.Location = new System.Drawing.Point(410, 308);
            this.EnterUserName_txtbx.MaxLength = 30;
            this.EnterUserName_txtbx.Name = "EnterUserName_txtbx";
            this.EnterUserName_txtbx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EnterUserName_txtbx.Size = new System.Drawing.Size(563, 52);
            this.EnterUserName_txtbx.TabIndex = 10;
            this.EnterUserName_txtbx.Text = "Enter User Name";
            this.EnterUserName_txtbx.TextChanged += new System.EventHandler(this.EnterUserName_txtbx_TextChanged);
            this.EnterUserName_txtbx.Enter += new System.EventHandler(this.EnterUserName_txtbx_TextChanged);
            this.EnterUserName_txtbx.Leave += new System.EventHandler(this.EnterUserName_txtbx_Leave);
            this.EnterUserName_txtbx.MouseLeave += new System.EventHandler(this.EnterUserName_txtbx_MouseLeave);
            this.EnterUserName_txtbx.MouseHover += new System.EventHandler(this.EnterUserName_txtbx_MouseHover);
            // 
            // EnterPassword_txtbx
            // 
            this.EnterPassword_txtbx.AcceptsTab = true;
            this.EnterPassword_txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EnterPassword_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterPassword_txtbx.Font = new System.Drawing.Font("Futura Bk BT", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPassword_txtbx.ForeColor = System.Drawing.Color.Gray;
            this.EnterPassword_txtbx.Location = new System.Drawing.Point(410, 439);
            this.EnterPassword_txtbx.MaxLength = 30;
            this.EnterPassword_txtbx.Name = "EnterPassword_txtbx";
            this.EnterPassword_txtbx.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EnterPassword_txtbx.Size = new System.Drawing.Size(563, 52);
            this.EnterPassword_txtbx.TabIndex = 11;
            this.EnterPassword_txtbx.Text = "Enter Password";
            this.EnterPassword_txtbx.TextChanged += new System.EventHandler(this.EnterPassword_txtbx_TextChanged);
            this.EnterPassword_txtbx.Enter += new System.EventHandler(this.EnterPassword_txtbx_TextChanged);
            this.EnterPassword_txtbx.Leave += new System.EventHandler(this.EnterPassword_txtbx_Leave);
            this.EnterPassword_txtbx.MouseLeave += new System.EventHandler(this.EnterPAssword_bg_MouseLeave);
            this.EnterPassword_txtbx.MouseHover += new System.EventHandler(this.EnterPAssword_bg_MouseHover);
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SignUp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SignUp_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.SignUp_btn.FlatAppearance.BorderSize = 0;
            this.SignUp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SignUp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SignUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_btn.Font = new System.Drawing.Font("Futura Bk BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUp_btn.Location = new System.Drawing.Point(571, 587);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(248, 57);
            this.SignUp_btn.TabIndex = 12;
            this.SignUp_btn.Text = "SIGN UP";
            this.SignUp_btn.UseVisualStyleBackColor = false;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // SomnixCafe_lbl
            // 
            this.SomnixCafe_lbl.AutoSize = true;
            this.SomnixCafe_lbl.Font = new System.Drawing.Font("Soettally", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomnixCafe_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.SomnixCafe_lbl.Location = new System.Drawing.Point(564, 134);
            this.SomnixCafe_lbl.Name = "SomnixCafe_lbl";
            this.SomnixCafe_lbl.Size = new System.Drawing.Size(255, 68);
            this.SomnixCafe_lbl.TabIndex = 13;
            this.SomnixCafe_lbl.Text = "Somnix Cafe";
            // 
            // logo_box
            // 
            this.logo_box.BackgroundImage = global::CoffeeShop_GUI.Properties.Resources.PROFILE_icon_png;
            this.logo_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_box.Location = new System.Drawing.Point(568, -13);
            this.logo_box.Name = "logo_box";
            this.logo_box.Size = new System.Drawing.Size(247, 144);
            this.logo_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_box.TabIndex = 14;
            this.logo_box.TabStop = false;
            // 
            // EnterUserName_bg
            // 
            this.EnterUserName_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.EnterUserName_bg.Location = new System.Drawing.Point(405, 351);
            this.EnterUserName_bg.Name = "EnterUserName_bg";
            this.EnterUserName_bg.Size = new System.Drawing.Size(573, 16);
            this.EnterUserName_bg.TabIndex = 15;
            this.EnterUserName_bg.Visible = false;
            // 
            // EnterPAssword_bg
            // 
            this.EnterPAssword_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.EnterPAssword_bg.Location = new System.Drawing.Point(405, 486);
            this.EnterPAssword_bg.Name = "EnterPAssword_bg";
            this.EnterPAssword_bg.Size = new System.Drawing.Size(573, 12);
            this.EnterPAssword_bg.TabIndex = 15;
            this.EnterPAssword_bg.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 0.1F);
            this.textBox1.Location = new System.Drawing.Point(671, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 1);
            this.textBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 793);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 10);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // SignUp_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1382, 803);
            this.Controls.Add(this.logo_box);
            this.Controls.Add(this.SomnixCafe_lbl);
            this.Controls.Add(this.SignUp_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.EnterUserName_txtbx);
            this.Controls.Add(this.EnterPassword_txtbx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EnterPAssword_bg);
            this.Controls.Add(this.EnterUserName_bg);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp_frm";
            ((System.ComponentModel.ISupportInitialize)(this.logo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.RichTextBox EnterUserName_txtbx;
        private System.Windows.Forms.RichTextBox EnterPassword_txtbx;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.Label SomnixCafe_lbl;
        private System.Windows.Forms.PictureBox logo_box;
        private System.Windows.Forms.Panel EnterUserName_bg;
        private System.Windows.Forms.Panel EnterPAssword_bg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}