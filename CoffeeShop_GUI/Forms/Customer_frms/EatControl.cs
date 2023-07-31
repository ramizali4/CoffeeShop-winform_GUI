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

namespace CoffeeShop_GUI.Forms.Customer_frms
{
    public partial class EatControl : UserControl
    {
       public static bool isOrdered=false;
        public EatControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover( object sender, EventArgs e )
        {
            PictureBox p = sender as PictureBox;
            p.BringToFront();
            p.Size = new Size( pictureBox1.Width+30, pictureBox1.Height+30 ); 
            if (p.Location.X < 450)
            {
                p.Location = new Point(373, 140);
            }
            else
            {
                p.Location = new Point(941, 140);
            }
         //   p.Location = new Point( pictureBox1.Location.X-5, pictureBox1.Location.Y-5 );
        }

        private void pictureBox2_MouseLeave( object sender, EventArgs e )
        {
            PictureBox p = sender as PictureBox;
            p.Size = new Size(568, 586);
            if (p.Location.X < 450)
            {
                p.Location = new Point(386, 150);
            }
            else
            {
                p.Location = new Point(951, 150);
            }
        }

        private void pictureBox1_Click( object sender, EventArgs e )
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

        //    tableLayoutPanel1.DataBindings = FoodDL.FoodList1;
        }

        private void ViewAll_btn_Click( object sender, EventArgs e )
        {
            DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            iconColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //List<PictureBox> pictureBoxes = new List<PictureBox>();
            //foreach (Food food in FoodDL.FoodList1)
            //{
               

            //    pictureBoxes.Add(p);
            //}
            //listBox1.DataSource = pictureBoxes;
            //listBox1.Refresh();
            //dataGridView1.DataSource = FoodDL.FoodList1;
            //DataGridViewImageCell cell = new DataGridViewImageCell();
            //cell.Value = pictureBoxes;
            //dataGridView1.Columns.Add(2,"cell");
            //DataGridViewColumn column = cell;
            //for(int i = 0;i< FoodDL.FoodList1.Count;i++)
            //foreach (Food food in FoodDL.FoodList1)
            //    {
            //    //    cells[i].ImageLayout = new Bitmap(FoodDL.FoodList1[i].ImagePath);
            //    iconColumn.Image = new Bitmap(food.ImagePath);
            //    }

        //    dataGridView1.Columns.Add( iconColumn);
            dataGridView1.DataSource = FoodDL.FoodList1;
       //     dataGridView1.Visible = true;
            panel1.BringToFront();
            panel1.Visible = true;
            dataGridView1.BringToFront();
            listBox1.BringToFront();
        //    button1.Visible = true;
        }

        private void ViewAll_btn_MouseHover( object sender, EventArgs e )
        {
            ViewAll_btn.Size = new Size(1156, 118);
            ViewAll_btn.Location = new Point(376, 722);
            ViewAll_btn.BringToFront();
         //  393, 779
        }

        private void ViewAll_btn_MouseLeave( object sender, EventArgs e )
        {
            
            ViewAll_btn.Size = new Size(1133, 98);
            ViewAll_btn.Location = new Point(393, 732);
            ViewAll_btn.SendToBack();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            panel1.Visible = false;
        }

        private void button1_MouseHover( object sender, EventArgs e )
        {
            button1.Font = new Font("Futura Bk BT", 17.2F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        }

        private void button1_MouseLeave( object sender, EventArgs e )
        {
            button1.Font = new Font("Futura Bk BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    }

        private void PlaceOrder_btn_MouseHover( object sender, EventArgs e )
        {
            PlaceOrder_btn.Font = new Font("Century Gothic", 42F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            
        }

        private void PlaceOrder_btn_MouseLeave( object sender, EventArgs e )
        {
            PlaceOrder_btn.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        }

        private void PlaceOrder_btn_Click( object sender, EventArgs e )
        {
            int C_idx = dataGridView1.Columns["QUANTITY"].Index;
            int R_idx = FoodDL.FoodList1.Count;
            int a = 21344;
            int UserID = 0;

            for (int i = 0; i < R_idx; i++)
            {
                if (dataGridView1[C_idx, i].Value != null)
                {
                    isOrdered = true;
                    a = dataGridView1.Rows[i].Index;
                    var ffsg = dataGridView1[C_idx, i].Value;
                    a = int.Parse(ffsg.ToString());
                    UsersDL.Customerlist1[UserID].FoodOrdered(i, a);
                }

            }
            if (isOrdered)
            {
                OrderPlace_frm orderPlace_Frm = new OrderPlace_frm(UserID);
                orderPlace_Frm.Show();
            }
            else
            {
                MessageBox.Show("   HAVEN'T ORDERED YET");
            }
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }
    }
}
