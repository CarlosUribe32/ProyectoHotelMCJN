using System;
using System.Windows.Forms;

namespace FinalPOODef
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 menu = new Form1();
            Application.Run(menu);
            menu.Admin.EscribirDB();
            menu.Dispose();
        }
    }
}
