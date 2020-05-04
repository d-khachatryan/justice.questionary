using System;
using System.Linq;
using System.Windows.Forms;

namespace Justice.Questionary.Catalogs
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
            Application.Run(new frmCatalogManager(Properties .Settings .Default .JusticeDB2ConnectionString ));
        }
    }
}