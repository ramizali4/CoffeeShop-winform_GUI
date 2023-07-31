namespace CoffeeShop_GUI.Forms.Admin_frms
{
    partial class AddFood_frm
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
            this.EnterFoodName_txtBX = new System.Windows.Forms.RichTextBox();
            this.enterDescription_txtBX = new System.Windows.Forms.RichTextBox();
            this.AddImage_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImagePath_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EnterPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnterPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterFoodName_txtBX
            // 
            this.EnterFoodName_txtBX.BackColor = System.Drawing.Color.LightGray;
            this.EnterFoodName_txtBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterFoodName_txtBX.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterFoodName_txtBX.ForeColor = System.Drawing.Color.DimGray;
            this.EnterFoodName_txtBX.Location = new System.Drawing.Point(43, 120);
            this.EnterFoodName_txtBX.Name = "EnterFoodName_txtBX";
            this.EnterFoodName_txtBX.Size = new System.Drawing.Size(593, 49);
            this.EnterFoodName_txtBX.TabIndex = 0;
            this.EnterFoodName_txtBX.Text = "Enter Food Name";
            // 
            // enterDescription_txtBX
            // 
            this.enterDescription_txtBX.BackColor = System.Drawing.Color.LightGray;
            this.enterDescription_txtBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterDescription_txtBX.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.enterDescription_txtBX.ForeColor = System.Drawing.Color.DimGray;
            this.enterDescription_txtBX.Location = new System.Drawing.Point(43, 351);
            this.enterDescription_txtBX.Name = "enterDescription_txtBX";
            this.enterDescription_txtBX.Size = new System.Drawing.Size(601, 320);
            this.enterDescription_txtBX.TabIndex = 0;
            this.enterDescription_txtBX.Text = "Description";
            // 
            // AddImage_btn
            // 
            this.AddImage_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddImage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImage_btn.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.AddImage_btn.ForeColor = System.Drawing.Color.DimGray;
            this.AddImage_btn.Location = new System.Drawing.Point(703, 344);
            this.AddImage_btn.Name = "AddImage_btn";
            this.AddImage_btn.Size = new System.Drawing.Size(330, 327);
            this.AddImage_btn.TabIndex = 1;
            this.AddImage_btn.UseVisualStyleBackColor = true;
            this.AddImage_btn.Click += new System.EventHandler(this.AddImage_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(757, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Image";
            // 
            // ImagePath_lbl
            // 
            this.ImagePath_lbl.AutoSize = true;
            this.ImagePath_lbl.BackColor = System.Drawing.Color.LightGray;
            this.ImagePath_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImagePath_lbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagePath_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.ImagePath_lbl.Location = new System.Drawing.Point(451, 318);
            this.ImagePath_lbl.Name = "ImagePath_lbl";
            this.ImagePath_lbl.Size = new System.Drawing.Size(93, 18);
            this.ImagePath_lbl.TabIndex = 3;
            this.ImagePath_lbl.Text = "Image Path";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(777, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONFIRM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(777, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // EnterPrice
            // 
            this.EnterPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterPrice.BackColor = System.Drawing.Color.LightGray;
            this.EnterPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterPrice.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.EnterPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnterPrice.Location = new System.Drawing.Point(182, 242);
            this.EnterPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.EnterPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EnterPrice.Name = "EnterPrice";
            this.EnterPrice.Size = new System.Drawing.Size(135, 49);
            this.EnterPrice.TabIndex = 5;
            this.EnterPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(43, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // AddFood_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1064, 688);
            this.Controls.Add(this.EnterPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImagePath_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddImage_btn);
            this.Controls.Add(this.enterDescription_txtBX);
            this.Controls.Add(this.EnterFoodName_txtBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFood_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFood_frm";
            ((System.ComponentModel.ISupportInitialize)(this.EnterPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EnterFoodName_txtBX;
        private System.Windows.Forms.RichTextBox enterDescription_txtBX;
        private System.Windows.Forms.Button AddImage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ImagePath_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown EnterPrice;
        private System.Windows.Forms.Label label2;
    }
}