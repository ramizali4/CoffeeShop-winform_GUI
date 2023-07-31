using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop_GUI.BL;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace CoffeeShop_GUI.DL
{
   public class FoodDL
    {
        private static List<Food> FoodList = new List<Food>();
        internal static List<Food> FoodList1 { get => FoodList; set => FoodList = value; }      

       public static void ExtractData(  )
        {
            string path = "fooditems.txt";
            string record;
            StreamReader foodFile = new StreamReader(path);

            while ((record = foodFile.ReadLine()) != null)
            {
                Food foodItemData = new Food();

                foodItemData.FoodName = record;

                record = foodFile.ReadLine();
                foodItemData.FoodPrice = int.Parse(record);

                record = foodFile.ReadLine();
                foodItemData.Description = record;

                record = foodFile.ReadLine();

                Image image =new Bitmap(record);
                foodItemData.Image = image;

                FoodList.Add(foodItemData);
            }
            foodFile.Close();
        }
        static void StoreData()
        {
            string path =  "FoodMenu.txt";
            StreamWriter Foodfile = new StreamWriter(path, false);

            for (int i = 0; i < FoodList.Count; i++)
            {
                Foodfile.Write(FoodList[i].FoodName);
                Foodfile.WriteLine();
                Foodfile.Write(FoodList[i].FoodPrice);

                if (i < FoodList.Count - 1)
                {
                    Foodfile.WriteLine();
                }
            }
            Foodfile.Flush();
            Foodfile.Close();
        }
    }
}
