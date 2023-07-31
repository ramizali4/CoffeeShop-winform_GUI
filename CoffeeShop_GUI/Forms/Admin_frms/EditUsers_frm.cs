using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop_GUI.DL;
using CoffeeShop_GUI.BL;

namespace CoffeeShop_GUI.Forms.Admin_frms
{
    public partial class EditUsers_frm : Form
    {
        public EditUsers_frm()
        {
            InitializeComponent();

            Users_GV.DataSource = UsersDL.Customerlist1;
        }
        public void dataBind()
        {
            Users_GV.DataSource = null;
            Users_GV.DataSource = UsersDL.Customerlist1;
            Users_GV.Refresh();
        }
        private void Users_GV_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

            Customer user = (Customer)Users_GV.CurrentRow.DataBoundItem;
            if (Users_GV.Columns["Remove"].Index == e.ColumnIndex)
            {
                UsersDL.deleteUserFromList(user);
                dataBind();
            }
            else if (Users_GV.Columns["Update"].Index == e.ColumnIndex)
            {
                SpecificUserEdit_frm myform = new SpecificUserEdit_frm(user);
                myform.ShowDialog();
                //  UsersDL.storeAllDataIntoFile(path);
                dataBind();
            }
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
        private void Back_btn_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
