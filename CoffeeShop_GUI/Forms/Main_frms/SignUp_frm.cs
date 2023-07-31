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

namespace CoffeeShop_GUI
{
    public partial class SignUp_frm : Form
    {
        public SignUp_frm()
        {
            InitializeComponent();
        }
        private bool CheckValidity(String letter)
        {
            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private void SignUp_btn_Click( object sender, EventArgs e )
        {
            string UserName = EnterUserName_txtbx.Text;
            string Password = EnterPassword_txtbx.Text;
            //label1.Text = UserName;
            //label2.Text = Password;


            if (CheckValidity(UserName) && CheckValidity(Password))
                {
                    Users user = new Users(UserName, Password);
                    UsersDL.AddToList(user);

                    this.Close();
                }
                else
                {
                    MessageBox.Show(" INPUT CANNOT BE BLANK SPACES", "Error 409");
                }

        }
            private void Back_btn_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void EnterUserName_txtbx_TextChanged( object sender, EventArgs e )
        {
            if (EnterUserName_txtbx.Text == "Enter User Name")
                EnterUserName_txtbx.Text = null;
        }

        private void EnterPassword_txtbx_TextChanged( object sender, EventArgs e )
        {
            if (EnterPassword_txtbx.Text == "Enter Password")
                EnterPassword_txtbx.Text = null;
        }

        private void EnterUserName_txtbx_Leave( object sender, EventArgs e )
        {
            if (EnterUserName_txtbx.Text == null)
                EnterUserName_txtbx.Text = "Enter User Name";
        }

        private void EnterPassword_txtbx_Leave( object sender, EventArgs e )
        {
            if (EnterPassword_txtbx.Text == null)
                EnterPassword_txtbx.Text = "Enter Password";
        }

        private void EnterUserName_txtbx_MouseHover( object sender, EventArgs e )
        {
            EnterUserName_bg.Visible = true;
        }
        private void EnterUserName_txtbx_MouseLeave( object sender, EventArgs e )
        {
            EnterUserName_bg.Visible = false;
        }

        private void EnterPAssword_bg_MouseHover( object sender, EventArgs e )
        {
            EnterPAssword_bg.Visible = true;
        }

        private void EnterPAssword_bg_MouseLeave( object sender, EventArgs e )
        {
            EnterPAssword_bg.Visible = false;
        }

    }
}
