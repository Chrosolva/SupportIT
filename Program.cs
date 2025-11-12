using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventaris.View;
using Master.Controller;
using Master.View;

namespace Inventaris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("id-ID");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Master.View.FormLogin(ControllerStaticVariables.NamaProgram).ShowDialog();
            Application.Run(new MainMDI_Form());
        }
    }
}
