using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeeShop_GUI.BL;

namespace CoffeeShop_GUI.DL
{
    internal class UsersDL
    {
        private static List<Users> Userslist = new List<Users>();
        private static List<Customer> Customerlist = new List<Customer>();
        internal static List<Users> UsersList { get => Userslist; set => Userslist = value; }
        internal static List<Customer> Customerlist1 { get => Customerlist; set => Customerlist = value; }

        public static void AddToList( Users user )
        {
            Userslist.Add(user);
        }
        public static bool VerifyUser( string UserName, string Password )
        {
            foreach (Users user in UsersList)
            {
                if (user.UserName == UserName && user.Password == Password)
                { return true; }
            }
            return false;
        }
        public static string ReturnRole( string UserName, string Password )
        {
            foreach (Users user in UsersList)
            {
                if (user.UserName == UserName && user.Password == Password)
                { return user.Role; }
            }
            return null;
        }
        public static int GetUserId( string UserName, string Password )
        {
            for(int i=0;i<Customerlist.Count;i++)
            {
                if (Customerlist[i].UserName == UserName && Customerlist[i].Password == Password)
                {
                    return i;
                }
            }
            return 0;
        }
        public static void deleteUserFromList( Users user )
        {
            for (int index = 0; index < Customerlist.Count; index++)
            {
                if (Customerlist[index].UserName == user.UserName && Customerlist[index].Password == user.Password)
                {
                    Customerlist.RemoveAt(index);                    
                }
            }

        }

        public static void EditUserFromList( Customer previous, Customer updated )
        {
            foreach (Customer c in Customerlist)
            {
                if (c.UserName == previous.UserName && c.Password == previous.Password)
                {
                    c.UserName = updated.UserName;
                    c.Password = updated.Password;
                    c.Role = updated.Role;
                    c.Address = updated.Address;
                    c.CardNo = updated.CardNo;
                    c.UserOrders1 = updated.UserOrders1;
                }
            }

        }
        public static void ExtractData()
        {
            string path = "Admin.txt";

            StreamReader fileVariable = new StreamReader(path);
            string record;
            string UserName, Password, Role, Address;
            int UserOrders, cardNo;


            while ((record = fileVariable.ReadLine()) != null)
            {
                UserName = record;
                record = fileVariable.ReadLine();
                Password = record;
                record = fileVariable.ReadLine();
                Role = record;
                record = fileVariable.ReadLine();

                Users user = new Users(UserName, Password, Role);
                Userslist.Add(user);
            }
            fileVariable.Close();

            path = "Customers.txt";
            StreamReader CustomerFile = new StreamReader(path);
            record = "";
            while ((record = CustomerFile.ReadLine()) != null)
            {
                UserName = record;
                record = CustomerFile.ReadLine();
                Password = record;
                record = CustomerFile.ReadLine();
                Role = record;
                record = CustomerFile.ReadLine();
                Address = record;
                record = CustomerFile.ReadLine();
                UserOrders = int.Parse(record);
                record = CustomerFile.ReadLine();
                cardNo = int.Parse(record);

                Customer customer = new Customer(UserName, Password, Role, Address, UserOrders, cardNo);
                Userslist.Add(customer);
                Customerlist1.Add(customer);
            }
        }
    }
}
