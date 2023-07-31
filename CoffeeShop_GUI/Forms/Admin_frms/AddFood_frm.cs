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
    public partial class AddFood_frm : Form
    {
        public AddFood_frm()
        {
            InitializeComponent();
        }

        private void AddImage_btn_Click( object sender, EventArgs e )
        {
                OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                AddImage_btn.BackgroundImage = new Bitmap(open.FileName);
                // image file path  
                ImagePath_lbl.Text = open.FileName;
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            string FoodName, Description;
            float price;
            FoodName = EnterFoodName_txtBX.Text;
            Description =enterDescription_txtBX.Text;
            Image image = new Bitmap(ImagePath_lbl.Text);
            price = float.Parse(EnterPrice.Text);

            Food food = new Food(FoodName,price,Description,image);
            FoodDL.FoodList1.Add(food);
            this.Close();
        }

    }
}
