using com.techphernalia.MyPersonalAccounts.Manager;
using System;
using System.Windows.Forms;

namespace MyPersonalAccountsManager
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
            Application.Run(new frmAccountsManager());
        }
    }
}
