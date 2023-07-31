using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop_GUI.BL;
using CoffeeShop_GUI.DL;

namespace CoffeeShop_GUI.Forms.Admin_frms
{
    public partial class SpecificUserEdit_frm : Form
    {
        private Customer previous;
        bool nonNumberEntered = false;
        public SpecificUserEdit_frm( Customer previous )
        {
            InitializeComponent();
            this.previous = previous;

            Username_txtbx.Text = previous.UserName;
            Password_txtbx.Text = previous.Password;
            Address_txtbx.Text = previous.Address;
            Orders_txtbx.Text = previous.UserOrders1.ToString();
            CardNo_txtbx.Text = previous.CardNo.ToString();
        }

        private void label1_Click( object sender, EventArgs e )
        {

        }

        private void Update_btn_Click( object sender, EventArgs e )
        {
            Customer updated = new Customer(Username_txtbx.Text, Password_txtbx.Text, Address_txtbx.Text, int.Parse(Orders_txtbx.Text), int.Parse(CardNo_txtbx.Text));
            UsersDL.EditUserFromList(previous, updated);
            this.Close();

        }

        private void textBox1_KeyPress( object sender, KeyPressEventArgs e )
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                nonNumberEntered = true;
            }
            else
            {
                e.Handled = false;
                nonNumberEntered = false;
            }
        }

    }
}
