using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop_GUI.DL;
using CoffeeShop_GUI.Forms.Main_frms;
using CoffeeShop_GUI.Forms.Admin_frms;
namespace CoffeeShop_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UsersDL.ExtractData();
            FoodDL.ExtractData();
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_frm());

            //Application.Run(new Customer_frm("ramiz", "123"));
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
