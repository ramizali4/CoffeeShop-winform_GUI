using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.Drawing;

namespace CoffeeShop_GUI.BL
{
    public class Food
    {         
        private string foodName  ;
        private float foodPrice  ;
        private string description;
        private Image image;
     public Food() { }
        public Food( string foodName,float foodPrice,string description,Image image)
        {
            this.foodName = foodName;
            this.foodPrice = foodPrice;
            this.description = description;
            this.image = image;
        }
         public string FoodName { get => foodName; set => foodName = value; }
        public float FoodPrice { get => foodPrice; set => foodPrice = value; }
        public string Description { get => description; set => description = value; }
       public Image Image { get => image; set => image = value; }
    }

    
    //class Beverages : Food
    //{
    //    private float Tax = 29f;

    //    public override float AddOn()
    //    {
    //        return 50f;
    //    }
    //}
    //class Snacks : Food
    //{
    //    public override float AddOn()
    //    {
    //        return 70f;
    //    }
    //}
}
