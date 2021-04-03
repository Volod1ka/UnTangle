using System;
using System.Windows.Forms;

namespace UnTangle
{
    static class Program
    {
        static internal MainWindow MainWindow;
        static internal SettingsWindow SettingsWindow;
        static internal ShowTransliteration ShowTransliteration;

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
                    ShowTransliteration = new ShowTransliteration();
                    MainWindow = new MainWindow();
                    
                    if (Properties.Settings.Default.IsVisibledWindow)
                    {
                        MainWindow.Show();                        
                    }

                    Application.Run();
                }
            }
        }

        //private static void lol()
        //{
        //    try
        //    {
        //        // open config
        //        var config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoaming);

        //        // update appconfig file path
        //        config.AppSettings.File = $@"C:\Users\Discijenal\AppData\Local\UnTangle\{Application.ProductVersion}\user.config";

        //        // Save the configuration file.
        //        //config.Save(System.Configuration.ConfigurationSaveMode.Modified);
        //        //config.SaveAs($@"C:\Users\Discijenal\AppData\Local\UnTangle\{Application.ProductVersion}\user.config");
                
        //        // Force a reload in memory of the changed section.
        //        //System.Configuration.ConfigurationManager.RefreshSection("userSettings");                
        //    }
        //    catch (Exception ex)
        //    {
        //        Windows.MessageBoxWindow.MessageBoxWindow.Show(ex.Message);
        //    }
        //}
    }
}
