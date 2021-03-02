using System;
using System.Windows.Forms;

namespace UnTangle
{
    static class Program
    {
        static internal MainWindow MainWindow;
        static internal SettingsWindow SettingsWindow;

        [STAThread]
        static void Main()
        {
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(false, Application.ProductName)) 
            {
                bool Running = !mutex.WaitOne(0, false);

                if (!Running)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Scripts.Engine.Engine.CheckUpgradeRequired();

                    SettingsWindow = new SettingsWindow();
                    MainWindow = new MainWindow();

                    if (Properties.Settings.Default.IsVisibledWindow)
                    {
                        MainWindow.Show();
                    }

                    Application.Run();
                }
            }
        }
    }
}
