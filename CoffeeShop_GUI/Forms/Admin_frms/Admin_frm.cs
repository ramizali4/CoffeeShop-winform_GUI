using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop_GUI.Forms.Admin_frms;

namespace CoffeeShop_GUI
{
    public partial class Admin_frm : Form
    {
        public Admin_frm()
        {
            InitializeComponent();
        }

        private void EditUsers_btn_Click( object sender, EventArgs e )
        {
            EditUsers_frm editUsers_Frm = new EditUsers_frm();
            editUsers_Frm.ShowDialog();
        }

        private void EditFoodMenu_btn_Click( object sender, EventArgs e )
        {
            MenuEdit_frm menuEdit_Frm = new MenuEdit_frm();
            menuEdit_Frm.ShowDialog();
        }

        private void ShowAllOrders_btn_Click( object sender, EventArgs e )
        {

        }

        private void Back_btn_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void panel1_MouseEnter( object sender, EventArgs e )
        {
            //        panel1.Size = new Size(735, 556);

        }

        private void panel1_MouseLeave( object sender, EventArgs e )
        {
            //      panel1.Size = new Size(716, 539);
        }

        private void EditFoodMenu_btn_MouseHover( object sender, EventArgs e )
        {
            Button b = (Button)sender;
            //     b.Size = new Size(420, 70);

            b.Font = new Font("Futura Bk BT", 25.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            //    b.Location = new Point(b.Location.X - 5, b.Location.Y - 5);

        }

        private void EditUsers_btn_MouseLeave( object sender, EventArgs e )
        {
            Button b = (Button)sender;
            b.Font = new Font("Futura Bk BT", 22.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            // b.Size = new Size(399, 52);
            //   b.Location = new Point(b.Location.X + 5, b.Location.Y + 5);

        }

        private void Back_btn_MouseHover( object sender, EventArgs e )
        {
            Back_btn.Size = new Size(Back_btn.Width + 10, Back_btn.Height + 10);
            Back_btn.Location = new Point(Back_btn.Location.X - 5, Back_btn.Location.Y - 5);
        }

        private void Back_btn_MouseLeave( object sender, EventArgs e )
        {

            Back_btn.Size = new Size(Back_btn.Width - 10, Back_btn.Height - 10);
            Back_btn.Location = new Point(Back_btn.Location.X + 5, Back_btn.Location.Y + 5);
        }
    }
}
