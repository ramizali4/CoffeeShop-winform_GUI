using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop_GUI.DL;

namespace CoffeeShop_GUI.BL
{
    public class Users
    {
        private string Username;
        private string password;
        private string role;

        public Users( string Username, string password )
        {
            this.Username = Username;
            this.password = password;
        }
        public Users( string Username, string password, string role )
        {
            this.Username = Username;
            this.password = password;
            this.role = role;
        }

        public string UserName { get => Username; set => Username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
    public class Customer : Users
    {
        private string address;
        private int UserOrders;
        private int cardNo;
        private List<Food> orderedFood=new List<Food>();
        private List<int> orderedFoodQuantity =new List<int>();
     public List<float> f_Price = new List<float>();
    
        public Customer( string Username, string password, string address, int UserOrders, int cardNo ) : base(Username, password)
        {
            this.Address = address;
            this.UserOrders1 = UserOrders;
            this.CardNo = cardNo;
        }
        public Customer( string Username, string password, string role, string address, int UserOrders, int cardNo ) : base(Username, password, role)
        {
            this.Address = address;
            this.UserOrders1 = UserOrders;
            this.CardNo = cardNo;
        }
        public List<Food> OrderedFood { get => orderedFood; set => orderedFood = value; }
        public void FoodOrdered( int idx, int quantity )
        {
            float price=0;
            orderedFood.Add(FoodDL.FoodList1[idx]);
            orderedFoodQuantity.Add(quantity);
            for (int i = 0; i < orderedFood.Count; i++)
            {
                price = orderedFood[i].FoodPrice * orderedFoodQuantity[i];
            }
            f_Price.Add(price);
        }
        
        public float CalucalteBill()
        {
            float FPrice=0f;
            for(int i = 0; i < orderedFood.Count; i++)
            {
                FPrice = FPrice + f_Price[i];
            } 
            return FPrice;
        }
       
        public string Address { get => address; set => address = value; }
        public int UserOrders1 { get => UserOrders; set => UserOrders = value; }
        public int CardNo { get => cardNo; set => cardNo = value; }
    }
}