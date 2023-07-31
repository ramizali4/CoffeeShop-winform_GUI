using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop_GUI.Forms.Main_frms;

namespace CoffeeShop_GUI.Forms.Main_frms
{
    public partial class TermsConditions : Form
    {
        public TermsConditions()
        {
            InitializeComponent();
        }

        private void button1_MouseHover( object sender, EventArgs e )
        {
            this.BackColor = SystemColors.ControlLight;
           Agree_btn.ForeColor = SystemColors.ControlLight;

            somnixCafe_lbl.ForeColor = Color.FromArgb(25, 25, 25);
label1.ForeColor = Color.FromArgb(25,25,25);
            label2.ForeColor = Color.FromArgb(25, 25, 25);
            Agree_btn.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void button1_MouseLeave( object sender, EventArgs e )
        {
            this.BackColor = Color.FromArgb(25, 25, 25);
            Agree_btn.ForeColor = Color.FromArgb(25, 25, 25);

            somnixCafe_lbl.ForeColor = Color.FromArgb(215, 195, 179);
            label1.ForeColor = SystemColors.ControlLight;
            label2.ForeColor = SystemColors.ControlLight;
            Agree_btn.BackColor = SystemColors.ControlLight;

        }
    }
}
