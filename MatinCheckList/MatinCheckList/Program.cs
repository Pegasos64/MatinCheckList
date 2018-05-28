using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatinCheckList
{
    static class Program
    {
        public static Rajapinta R = new Rajapinta();
        public static Home H;
        public static Login L;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            L = new Login();
            Application.Run(L);
        }
    }
}
