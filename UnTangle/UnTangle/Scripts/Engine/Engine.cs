using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace UnTangle.Scripts.Engine
{
    internal static class Engine
    {
        #region Variables

        public static bool IsHotKeyAccess;

        #endregion

        #region DLL imports

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Пріорітет програми.
        [DllImport("Kernel32.dll")]
        public static extern bool SetPriorityClass(IntPtr hProcess, int dwPriorityClass);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        #endregion

        #region Global Hook Key

        #region Constants

        public const int WM_HOTKEY = 0x0312;

        //private const int MOD_NOMOD = 0x0000;
        private const int MOD_ALT = 0x0001;
        private const int MOD_CTRL = 0x0002;
        //private const int MOD_SHIFT = 0x0004;
        //private const int MOD_WIN = 0x0008;

        #endregion

        #region Hook and Unhook

        public static void Hook(IntPtr Handle)
        {
            Scripts.Engine.Engine.RegisterHotKey(Handle, 0, MOD_CTRL, (int)Keys.Q);
            Scripts.Engine.Engine.RegisterHotKey(Handle, 1, MOD_ALT, (int)Keys.D1);
            Scripts.Engine.Engine.RegisterHotKey(Handle, 2, MOD_ALT, (int)Keys.D2);
        }

        public static void Unhook(IntPtr Handle)
        {
            for (int i = 0; i < 3; i++)
            {
                Scripts.Engine.Engine.UnregisterHotKey(Handle, i);
            }
        }

        #endregion

        #endregion

        #region Public Methods

        public static void MoveWindow(MouseEventArgs e, IntPtr Handle)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                ReleaseCapture();

                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        public static bool SetAutoRunValue(bool isAtorun, string exePath)
        {
            RegistryKey Reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\");

            try
            {
                if (isAtorun)
                {
                    Reg.SetValue(Application.ProductName, exePath);
                }
                else
                {
                    var names = Reg.GetValueNames();

                    foreach (var item in names)
                    {
                        if (item.Equals(Application.ProductName) || Reg.GetValue(item).ToString().Equals(exePath))
                        {
                            Reg.DeleteValue(item);
                        }
                    }                    
                }

                Properties.Settings.Default.Autorun = isAtorun;

                Reg.Flush();
                Reg.Close();
            }
            catch (Exception)
            {
                return false;
            }

            Properties.Settings.Default.Save();

            return true;
        }

        public static bool IsAutoRun(string exePath)
        {
            bool isAutorun = false;

            try
            {
                RegistryKey Reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run\");

                if (Reg != null)
                {
                    var names = Reg.GetValueNames();

                    foreach (var item in names)
                    {
                        isAutorun = Reg.GetValue(item).ToString().Equals(exePath);

                        if (isAutorun)
                        {
                            break;
                        }
                    }
                }

                Reg.Flush();
                Reg.Close();
            }
            catch (Exception)
            {
                isAutorun = false;
            }

            return isAutorun;
        }

        public static void CloseAndOpenWindow(bool isSave, SettingsWindow settingsForm)
        {
            if (isSave)
            {
                Program.MainWindow.Notify.Dispose();

                Application.Restart();
                Environment.Exit(1);
            }
            else
            {
                Program.MainWindow.Show();
                settingsForm.Hide();
            }
        }

        public static void ChangeText()
        {
            IsHotKeyAccess = false;

            WindowsInput.InputSimulator _InputSimulator = new WindowsInput.InputSimulator();

            try
            {
                Scripts.Engine.ClipboardData.TempClipboard = Scripts.Engine.ClipboardData.GetClipboardData();
                Scripts.Engine.ClipboardData.ClipboardClear();

                _InputSimulator.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.CONTROL, WindowsInput.Native.VirtualKeyCode.VK_C);

                Thread.Sleep(50);

                if (Scripts.Engine.ClipboardData.GetText().Length > 0)
                {
                    Scripts.Engine.ClipboardData.SetText(TranslateText(Scripts.Engine.ClipboardData.GetText()));
                    Thread.Sleep(50);

                    _InputSimulator.Keyboard.ModifiedKeyStroke(WindowsInput.Native.VirtualKeyCode.CONTROL, WindowsInput.Native.VirtualKeyCode.VK_V);

                    Thread.Sleep(50);
                }

            }
            catch (Exception) {  }

            Thread.Sleep(50);
            Scripts.Engine.ClipboardData.SetClipboardData(Scripts.Engine.ClipboardData.TempClipboard);

            Thread.Sleep(50);
            Scripts.Engine.ClipboardData.TempClipboard.Clear();

            IsHotKeyAccess = true;
        }
        
        public static string TranslateText(string text)
        {
            switch (ProgramProcess.ButtonSelected)
            {
                case 1:
                    {
                        return CharTranslate.TranslateLangChar(text);
                    }
                case 2:
                    {
                        switch (ProgramProcess.IdPanel2)
                        {
                            case 1:
                                {
                                    return TextChange.CharToLower(text);
                                }
                            case 2:
                                {
                                    return TextChange.CharToUpper(text);
                                }
                            case 3:
                                {
                                    return TextChange.CharToTitleCase(text);
                                }
                        }
                    }
                    break;
                case 3:
                    {
                        return TextChange.CharReverse(text);
                    }
            }

            return text;
        }

        public static void OpenSettingsWindow()
        {
            try
            {
                Program.SettingsWindow.Show();
            }
            catch (Exception)
            {
                Program.SettingsWindow = new SettingsWindow();
                Program.SettingsWindow.Show();
            }

            Program.SettingsWindow.SettingsWindow_Load(null, null);

            Program.MainWindow.Close();
        }

        public static void CheckUpgradeRequired()
        {
            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }
        }

        #endregion
    }
}
