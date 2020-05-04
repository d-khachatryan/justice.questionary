using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AspNetMembershipMgr
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
            Application.Run(new frmUserManager("hy-AM", System.Configuration.ConfigurationManager.ConnectionStrings["AspNetMembershipMgr.Properties.Settings.JusticeDBConnectionString"].ConnectionString));
        }
    }
}
