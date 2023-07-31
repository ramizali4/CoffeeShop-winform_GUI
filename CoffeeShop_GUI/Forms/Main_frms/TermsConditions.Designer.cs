namespace CoffeeShop_GUI.Forms.Main_frms
{
    partial class TermsConditions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Agree_btn = new System.Windows.Forms.Button();
            this.somnixCafe_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you agree that Ramiz is the most \r\npyaara insaan ever";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(450, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "?";
            // 
            // Agree_btn
            // 
            this.Agree_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Agree_btn.FlatAppearance.BorderSize = 0;
            this.Agree_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agree_btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agree_btn.Location = new System.Drawing.Point(812, 541);
            this.Agree_btn.Name = "Agree_btn";
            this.Agree_btn.Size = new System.Drawing.Size(180, 54);
            this.Agree_btn.TabIndex = 1;
            this.Agree_btn.Text = "AGREE";
            this.Agree_btn.UseVisualStyleBackColor = false;
            this.Agree_btn.Click += new System.EventHandler(this.button1_Click);
            this.Agree_btn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.Agree_btn.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // somnixCafe_lbl
            // 
            this.somnixCafe_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.somnixCafe_lbl.AutoSize = true;
            this.somnixCafe_lbl.BackColor = System.Drawing.Color.Transparent;
            this.somnixCafe_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.somnixCafe_lbl.Font = new System.Drawing.Font("Soettally", 25F);
            this.somnixCafe_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(179)))));
            this.somnixCafe_lbl.Location = new System.Drawing.Point(12, 573);
            this.somnixCafe_lbl.Name = "somnixCafe_lbl";
            this.somnixCafe_lbl.Size = new System.Drawing.Size(160, 43);
            this.somnixCafe_lbl.TabIndex = 12;
            this.somnixCafe_lbl.Text = "Somnix Cafe";
            this.somnixCafe_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TermsConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1027, 625);
            this.Controls.Add(this.somnixCafe_lbl);
            this.Controls.Add(this.Agree_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TermsConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "background";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Agree_btn;
        private System.Windows.Forms.Label somnixCafe_lbl;
    }
}