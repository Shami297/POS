using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Sample());
            //Application.Run(new MDI());
            //Application.Run(new Sample3());
            //Application.Run(new Login());
            // Application.Run(new Category());
            //Application.Run(new Purchase());
            Application.Run(new Product());
            // Application.Run(new Sale());
            //Application.Run(new Sample2());
        }
    }
}
