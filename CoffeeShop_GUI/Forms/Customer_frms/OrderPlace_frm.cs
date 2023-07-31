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

namespace CoffeeShop_GUI.Forms.Customer_frms
{
    public partial class OrderPlace_frm : Form
    {
        int UserID;
        public OrderPlace_frm(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            if (UsersDL.Customerlist1[UserID].OrderedFood.Count > 0)
            {
                Cart_panel.SendToBack();
                Cart_panel.Visible = false;
                Cart_panel.Enabled = false;
                webBrowser1.Navigate("https://www.google.com/maps");

                List<String> orders = new List<String>();
                List<float> prices = new List<float>();
                List<float> quantites = new List<float>();

                for (int i = 0; i < UsersDL.Customerlist1[UserID].OrderedFood.Count; i++)
                {
                    orders.Add(UsersDL.Customerlist1[UserID].OrderedFood[i].FoodName);
                    prices.Add(UsersDL.Customerlist1[UserID].OrderedFood[i].FoodPrice);
                    quantites.Add(UsersDL.Customerlist1[UserID].f_Price[i] / prices[i]);
                }
                listBox1.DataSource = orders;
                listBox2.DataSource = prices;
                listBox3.DataSource = quantites;

                //    dataGridView1.DataSource = UsersDL.Customerlist1[UserID].OrderedFood.Select(c => new { c.FoodName, c.FoodPrice } ;


                listBox4.DataSource = UsersDL.Customerlist1[UserID].f_Price;
                label2.Text = "Rs." + UsersDL.Customerlist1[UserID].CalucalteBill().ToString() + "/-";
            }
            else
            {
                Cart_panel.Enabled = true;
                Cart_panel.BringToFront();
            }
        }


        private void back_btn_Click( object sender, EventArgs e )
        {
            this.Close();
        }

    }
}
