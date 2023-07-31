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
using CoffeeShop_GUI.Forms.Admin_frms;

namespace CoffeeShop_GUI
{
    public partial class MenuEdit_frm : Form
    {
        public MenuEdit_frm()
        {
            InitializeComponent();
        }

        private void MenuEdit_frm_Load( object sender, EventArgs e )
        {
            
            dataGridView1.DataSource = FoodDL.FoodList1;

            dataGridView1.Refresh();
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
       
        private void Add_btn_Click( object sender, EventArgs e )
        {
            AddFood_frm addFood_Frm = new AddFood_frm();
            addFood_Frm.ShowDialog();
        }
    }
}
