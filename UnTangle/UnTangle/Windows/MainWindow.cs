using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnTangle
{
    public partial class MainWindow : Form
    {
        // Designer this.Icon = System.Drawing.Icon.FromHandle(Properties.Resources.icon.Handle);
        #region Variables

        private bool _isClosing;

        #endregion

        #region Form Constructor

        public MainWindow()
        {
            _isClosing = true;
            Scripts.Engine.Engine.IsHotKeyAccess = true;

            Scripts.Language.SetLanguage(Properties.Settings.Default.Language);
            InitializeComponent();

            LabelTitleProgram.Text = Application.ProductName;

            Scripts.Engine.Engine.SetPriorityClass(System.Diagnostics.Process.GetCurrentProcess().Handle, 0x00000100);
            Scripts.Engine.Engine.Hook(Handle);
            
            ThemeColors.ChangeThemeEvents += ChangeTheme;
            ThemeColors.ChangeTheme(Properties.Settings.Default.IdTheme);
        }

        #endregion

        #region Customer Methods
        
        private void ShowMessageTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            if (!this.Visible)
            {
                Notify.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
            }
        }
       
        private void FormLocation()
        {
            // Визначення розширення екрану робочого стола.
            Size screen = new Size(SystemInformation.PrimaryMonitorSize.Width, SystemInformation.PrimaryMonitorSize.Height);

            Size taskBar = new Size(Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height);
            
            // Встановлення розположення головного вікна.
            this.DesktopLocation = new Point(screen.Width - this.Width - taskBar.Width, screen.Height - this.Height - taskBar.Height);
        }
        
        public void ChangeTheme(int idTheme)
        {
            ThemeColors.IdTheme = idTheme;
            ThemeColors.SelectTheme();

            // Вікно
            this.BackColor = ButtonClose.BackColor = ThemeColors.BackGround;
            this.ForeColor = LabelSettings.ForeColor = LabelExit.ForeColor = ButtonClose.ForeColor = ThemeColors.ForeGround;
            PanelTools.BackColor = ThemeColors.Workspace;
            PanelTools.ForeColor = ThemeColors.ForeGround;

            // Транслітератор
            ButtonTranslit.BackColor = ButtonLanUa.BackColor = ButtonLanRu.BackColor = ThemeColors.Workspace;
            // Вибрана кнопка з Panel1 (транслітерація - мова)
            Panel1(Properties.Settings.Default.IdPanel1);

            // Зміна регістра
            ButtonCaseChanging.BackColor = ButtonToLower.BackColor = ButtonToUpper.BackColor = ButtonToTitleCase.BackColor = ThemeColors.Workspace;
            // Вибрана кнопка з Panel2 (зміна регістра - тип)
            Panel2(Properties.Settings.Default.IdPanel2);

            // Реверс текста
            ButtonReverser.BackColor = ThemeColors.Workspace;

            // Вибрана кнопка функцій
            ChangeColor(Properties.Settings.Default.ButtonSelected);

            // contextMenuStrip1
            NotifyContextMenu.BackColor = ThemeColors.BackGround;
            NotifyContextMenu.ForeColor = ThemeColors.ForeGround;

            // toolTip
            ToolTip.OwnerDraw = true;
            ToolTip.BackColor = ThemeColors.BackGround;
            ToolTip.ForeColor = ThemeColors.ForeGround;

            Properties.Settings.Default.IdTheme = idTheme;
            Properties.Settings.Default.Save();
        }
        
        private void UnFocus()
        {
            LabelTitleProgram.Focus();
        }
        
        private string ChangeMenu()
        {
            Scripts.Engine.Engine.IsHotKeyAccess = false;
            string TipText = string.Empty;

            try
            {
                switch (ProgramProcess.ButtonSelected + 1)
                {
                    case 2:
                        {
                            ButtonCaseChanging_Click(null, null);
                            TipText = Languages.language.FuncCaseChanging;
                        }
                        break;
                    case 3:
                        {
                            ButtonReverser_Click(null, null);
                            TipText = Languages.language.FuncReverser;//"Вибрана функція \"Обернення\"";
                        }
                        break;
                    default:
                        {
                            ButtonTranslit_Click(null, null);
                            TipText = Languages.language.FuncTranslit;//"Вибрана функція \"Транслітерація\"";
                        }
                        break;
                }
            }
            catch (Exception) { }

            Scripts.Engine.Engine.IsHotKeyAccess = true;

            return TipText;
        }
        
        private string ChangeSubMenu()
        {
            Scripts.Engine.Engine.IsHotKeyAccess = false;
            string TipText = string.Empty;

            try
            {
                switch (ProgramProcess.ButtonSelected)
                {
                    case 1:
                        {
                            switch (ProgramProcess.IdPanel1 + 1)
                            {
                                case (int)Scripts.Language.Lang.Ru:
                                    {
                                        ButtonLanRu_Click(null, null);
                                        TipText = $"{Languages.language.FuncTranslit} ENG => RU";//"Вибрана функція \"Транслітерація\" ENG => RU";
                                    }
                                    break;

                                default:
                                    {
                                        ButtonLanUa_Click(null, null);
                                        TipText = $"{Languages.language.FuncTranslit} ENG => UA";//"Вибрана функція \"Транслітерація\" ENG => UA";
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            switch (ProgramProcess.IdPanel2 + 1)
                            {
                                case 2:
                                    {
                                        ButtonToUpper_Click(null, null);
                                        TipText = $"{Languages.language.FuncCaseChanging} ut => UT";//"Вибрана функція \"Зміна регістра\" ut => UT";
                                    }
                                    break;

                                case 3:
                                    {
                                        ButtonToTitleCase_Click(null, null);
                                        TipText = $"{Languages.language.FuncCaseChanging} Ut";//"Вибрана функція \"Зміна регістра\" Ut";
                                    }
                                    break;

                                default:
                                    {
                                        ButtonToLower_Click(null, null);
                                        TipText = $"{Languages.language.FuncCaseChanging} UT => ut"; //"Вибрана функція \"Зміна регістра\" UT => ut";
                                    }
                                    break;
                            }
                        }
                        break;
                }
            }
            catch (Exception) { }

            Scripts.Engine.Engine.IsHotKeyAccess = true;

            return TipText;
        }

        #endregion

        #region Form Methods

        protected override void WndProc(ref Message m)
        {
            if (m.Msg.Equals(Scripts.Engine.Engine.WM_HOTKEY) && Scripts.Engine.Engine.IsHotKeyAccess)
            {
                var TipText = string.Empty;
                var IdHook = m.WParam.ToInt32();

                switch (IdHook)
                {
                    case 0:
                        {
                            Scripts.Engine.Engine.ChangeText();
                        }
                        break;
                    case 1:
                        {
                            TipText = ChangeMenu();
                        }
                        break;
                    case 2:
                        {
                            TipText = ChangeSubMenu();
                        }
                        break;
                }

                if (!string.IsNullOrEmpty(TipText))
                {
                    ShowMessageTip(1, Application.ProductName, TipText, ToolTipIcon.Info);
                }
            }

            base.WndProc(ref m);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = _isClosing;

            if (_isClosing && !Program.SettingsWindow.Visible)
            {
                Notify.ShowBalloonTip(500, Application.ProductName, Languages.language.TipTextHide, ToolTipIcon.Info);
            }

            this.Hide();
        }
        
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemeColors.ChangeThemeEvents -= ChangeTheme;
            Scripts.Engine.Engine.Unhook(Handle);
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FormLocation();
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            UnFocus();
        }

        private void Panel1(int id)
        {
            ProgramProcess.SetIdPanel1(id);

            LabelENto.ForeColor = ButtonLanUa.ForeColor = ButtonLanRu.ForeColor = ThemeColors.ForeGround;

            switch (id)
            {
                case 0:
                    {
                        CharTranslate.AddDictionaryList((int)Scripts.Language.Lang.Ua);
                        ButtonLanUa.ForeColor = ThemeColors.Active;
                    }
                    break;

                case 1:
                    {
                        CharTranslate.AddDictionaryList((int)Scripts.Language.Lang.Ru);
                        ButtonLanRu.ForeColor = ThemeColors.Active;
                    }
                    break;
            }
        }

        private void ChangeColor(int id)
        {
            ProgramProcess.SetButtonSelected(id);

            ButtonTranslit.ForeColor = ButtonCaseChanging.ForeColor = ButtonReverser.ForeColor = ThemeColors.ForeGround;

            switch (id)
            {
                case 1:
                    {
                        PanelCases.Enabled = false;
                        PanelLanguages.Enabled = true;

                        ButtonTranslit.ForeColor = ThemeColors.Active;
                    }
                    break;

                case 2:
                    {
                        PanelCases.Enabled = true;
                        PanelLanguages.Enabled = false;

                        ButtonCaseChanging.ForeColor = ThemeColors.Active;
                    }
                    break;

                case 3:
                    {
                        PanelCases.Enabled = false;
                        PanelLanguages.Enabled = false;

                        ButtonReverser.ForeColor = ThemeColors.Active;
                    }
                    break;
            }
        }

        private void Panel2(int id)
        {
            ProgramProcess.SetIdPanel2(id);

            ButtonToLower.ForeColor = ButtonToUpper.ForeColor = ButtonToTitleCase.ForeColor = ThemeColors.ForeGround;

            switch (id)
            {
                case 1:
                    {
                        ButtonToLower.ForeColor = ThemeColors.Active;
                        ButtonCaseChanging.Image = Properties.Resources._2_1;
                    }
                    break;

                case 2:
                    {
                        ButtonToUpper.ForeColor = ThemeColors.Active;
                        ButtonCaseChanging.Image = Properties.Resources._2_2;
                    }
                    break;

                case 3:
                    {
                        ButtonToTitleCase.ForeColor = ThemeColors.Active;
                        ButtonCaseChanging.Image = Properties.Resources._2_3;
                    }
                    break;
            }
        }
      
        #region Menu Methods

        private void ItemShowWindow_Click(object sender, EventArgs e)
        {
            FormLocation();
            this.Show();
        }

        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left) && !this.Visible)
            {
                FormLocation();
                this.Show();
            }
            else if (e.Button.Equals(MouseButtons.Left) && this.Visible)
            {
                this.Close();
            }
        }

        private void ButtonLanUa_Click(object sender, EventArgs e)
        {
            Panel1((int)Scripts.Language.Lang.Ua);
        }

        private void ButtonLanRu_Click(object sender, EventArgs e)
        {
            Panel1((int)Scripts.Language.Lang.Ru);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            _isClosing = false;

            this.Close();
        }

        private void ButtonTranslit_Click(object sender, EventArgs e)
        {
            ChangeColor(1);
        }

        private void ButtonCaseChanging_Click(object sender, EventArgs e)
        {
            ChangeColor(2);
        }

        private void ButtonReverser_Click(object sender, EventArgs e)
        {
            ChangeColor(3);
        }

        private void ButtonToLower_Click(object sender, EventArgs e)
        {
            Panel2(1);
        }

        private void ButtonToUpper_Click(object sender, EventArgs e)
        {
            Panel2(2);
        }

        private void ButtonToTitleCase_Click(object sender, EventArgs e)
        {
            Panel2(3);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            Scripts.Engine.Engine.OpenSettingsWindow();
        }

        private void ItemSettings_Click(object sender, EventArgs e)
        {
            Scripts.Engine.Engine.OpenSettingsWindow();
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void PanelTools_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelExit_Click(object sender, EventArgs e)
        {
            _isClosing = false;

            this.Close();
        }

        private void LabelSettings_Click(object sender, EventArgs e)
        {
            Scripts.Engine.Engine.OpenSettingsWindow();
        }

        private void LabelTitleProgram_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, this.Font, new SolidBrush(ThemeColors.ForeGround), new PointF(4, 2));
        }

        #endregion

        #endregion
    }
}