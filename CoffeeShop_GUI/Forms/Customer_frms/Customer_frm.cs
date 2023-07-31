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
using CoffeeShop_GUI.Forms.Admin_frms;
using CoffeeShop_GUI.Forms.Customer_frms;
namespace CoffeeShop_GUI
{
    public partial class Customer_frm : Form
    {
       public int userID;
        
        public Customer_frm(string UserName,string Password)
        {
            InitializeComponent();
            Welcome_lbl.Text = "Welcome " + UserName+"!";
            userID = UsersDL.GetUserId(UserName, Password);
        }

        // TASK BAR EVENTS
        private void Home_btn_Click( object sender, EventArgs e )
        {
            eatControl1.Visible = false;
            home_btn2.Visible = true;
            home_btn1.Visible = true;
            home_btn3.Visible = true;
        }

        public void Food_btn_Click( object sender, EventArgs e )
        {
            eatControl1.Visible = true;
            homeView_11.SendToBack();
            home_view21.SendToBack();
            home_View31.SendToBack();

            home_btn2.Visible = false;
            home_btn1.Visible = false;
            home_btn3.Visible = false;
        }
        private void Koibhi_btn_MouseHover( object sender, EventArgs e )
        {
            Button koibhi_btn = (Button)sender;
            koibhi_btn.Size = new Size(koibhi_btn.Width + 10, koibhi_btn.Height + 10);
            koibhi_btn.Location = new Point(koibhi_btn.Location.X - 5, koibhi_btn.Location.Y - 5);
        }

        private void Koibhi_btn_MouseLeave( object sender, EventArgs e )
        {
            Button koibhi_btn = (Button)sender;
            koibhi_btn.Size = new Size(koibhi_btn.Width - 10, koibhi_btn.Height - 10);
            koibhi_btn.Location = new Point(koibhi_btn.Location.X + 5, koibhi_btn.Location.Y + 5);
        }

     // HOME slides buttons
        private void home_btn1_Click( object sender, EventArgs e )
        {
            home_view21.SendToBack();
            home_View31.SendToBack();
            home_btn1.BackColor = Color.FromArgb(118, 98, 82);

            home_btn2.BackColor = Color.FromArgb(222, 214, 207);
            home_btn3.BackColor = Color.FromArgb(222, 214, 207);
        }

        private void home_btn2_Click( object sender, EventArgs e )
        {
            homeView_11.SendToBack();
            home_View31.SendToBack();
            home_btn2.BackColor = Color.FromArgb(118, 98, 82);
            
            home_btn1.BackColor = Color.FromArgb(222, 214, 207);
            home_btn3.BackColor = Color.FromArgb(222, 214, 207);
        }

        private void home_btn3_Click( object sender, EventArgs e )
        {
            homeView_11.SendToBack();
            home_view21.SendToBack();
            home_btn3.BackColor = Color.FromArgb(118, 98, 82);

            home_btn1.BackColor = Color.FromArgb(222, 214, 207);
            home_btn2.BackColor = Color.FromArgb(222, 214, 207);

        }

        private void User_btn_Click( object sender, EventArgs e )
        {
            Profile_Panel.Visible = !Profile_Panel.Visible;
        }

        private void SignOut_btn_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void UpdatePorgile_btn_Click( object sender, EventArgs e )
        {
            SpecificUserEdit_frm myform = new SpecificUserEdit_frm(UsersDL.Customerlist1[userID]);
            myform.Show();
        }

        private void Cart_btn_Click( object sender, EventArgs e )
        {
            OrderPlace_frm orderPlace_Frm = new OrderPlace_frm(userID);
            orderPlace_Frm.Show();

        }
    }
}
