using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        static void Main()
        {


            ArrayList attributes;
            ArrayList characters;
            ArrayList paths;
            ArrayList hubs;
            ArrayList pathGroups;
            ArrayList p2PG;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectHomeForm());
        }
    }
}
