using System;
using System.Windows.Forms;
using DevExpress.UserSkins;

namespace DXApplication1
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

            BonusSkins.Register();
            new Form1().Show();
            Application.Run();
        }
    }
}
