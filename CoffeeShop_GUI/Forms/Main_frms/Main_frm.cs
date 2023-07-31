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
using CoffeeShop_GUI.Forms.Main_frms;

namespace CoffeeShop_GUI
{
    public partial class Main_frm : Form
    {
        bool TermsCondition=false;
        public Main_frm()
        {
            InitializeComponent();
            UsersDL.ExtractData();
        }
        CheckBox Checkedbox;


        private void checkBox1_CheckedChanged( object sender, EventArgs e )
        {
            Checkedbox = sender as CheckBox;
            Admin_chkbx.CheckState = Checkedbox.CheckState;
            Customer_chkbx.CheckState = CheckState.Unchecked;
         //   Delivery_chkbx.CheckState = CheckState.Unchecked;
        }

        private void Customer_chkbx_CheckedChanged( object sender, EventArgs e )
        {
            Checkedbox = sender as CheckBox;
            if (Checkedbox.Text != "Admin")
            {
                Customer_chkbx.CheckState = Checkedbox.CheckState;
                //     Delivery_chkbx.CheckState = CheckState.Unchecked;
                Admin_chkbx.CheckState = CheckState.Unchecked;
            }
            //Admin_chkbx.Checked = false;
            //Delivery_chkbx.Checked = false;
            //Customer_chkbx.Checked = true;
        }


        private void SignUp_btn_Click( object sender, EventArgs e )
        {
            SignUp_frm signUp_Frm = new SignUp_frm();
            signUp_Frm.ShowDialog();
        }

        private void Login_btn_Click( object sender, EventArgs e )
        {
            if (TermsCondition && Checkedbox!= null)
            {
                string UserName = EnterUserName_txtbx.Text;
                string Password = EnterPassword_txtbx.Text;
                string role = Checkedbox.Text;
                bool verify = UsersDL.VerifyUser(UserName, Password);
                if (verify)
                {
                    role = UsersDL.ReturnRole(UserName, Password);
                    if (role == "Admin")
                    { Admin_frm admin = new Admin_frm(); admin.Show(); }
                    else if (role == "Customer")
                    { Customer_frm customer = new Customer_frm(UserName, Password); customer.Show(); }
                }
                else
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD", "Error-402", MessageBoxButtons.RetryCancel);
                }
            }
            if (Checkedbox == null)
            {
                MessageBox.Show("YOU HAVEN'T SELECT THE USERTYPE", "Error-403", MessageBoxButtons.RetryCancel);
            }
            if (!TermsCondition)
            {
                MessageBox.Show("YOU HAVEN'T ACCEPT THE TERMS AND CONDITIONS", "Error-405", MessageBoxButtons.RetryCancel);
            }
        }
        private void Koibhi_txtbx_Enter( object sender, EventArgs e )
        {
                RichTextBox koibhi_box = (RichTextBox)sender;
               
            koibhi_box.ForeColor = Color.Gray;
        }

        private void EnterUserName_txtbx_Enter( object sender, EventArgs e )
        {
            EnterUserName_txtbx.ForeColor = Color.Gray;
        }

        private void EnterPassword_txtbx_Enter( object sender, EventArgs e )
        {
            EnterPassword_txtbx.ForeColor = Color.Gray;
        }

        private void EnterUserName_txtbx_TextChanged( object sender, EventArgs e )
        {
            if (EnterUserName_txtbx.Text == "Enter User Name")
                EnterUserName_txtbx.Text = null;
        }

        private void EnterPassword_txtbx_TextChanged( object sender, EventArgs e )
        {
            if (EnterPassword_txtbx.Text == "Enter Password")
                EnterPassword_txtbx.Text = "";
        }

        private void EnterUserName_txtbx_Leave( object sender, EventArgs e )
        {
            if (EnterUserName_txtbx.Text == null)
                EnterUserName_txtbx.Text = "Enter User Name";
        }

        private void EnterPassword_txtbx_Leave( object sender, EventArgs e )
        {
            if (EnterPassword_txtbx.Text == "")
                EnterPassword_txtbx.Text = "Enter Password";
        }

        private void checkBox2_CheckedChanged( object sender, EventArgs e )
        {
            TermsCondition = true;
            checkBox1.Enabled = true;
            TermsConditions b = new TermsConditions();
            b.ShowDialog();
        }
    }
}
