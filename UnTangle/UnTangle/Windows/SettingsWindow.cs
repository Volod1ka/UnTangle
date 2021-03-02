using System;
using System.Windows.Forms;

namespace UnTangle
{
    public partial class SettingsWindow : Form
    {
        #region Form Constructor

        public SettingsWindow()
        {
            Scripts.Language.SetLanguage(Properties.Settings.Default.Language);
            InitializeComponent();

            LabelVersionProgram.Text = $"{Languages.language.Version}{Application.ProductVersion}";

            ThemeColors.ChangeThemeEvents += ChangeTheme;
        }

        #endregion

        #region Customer Methods

        public void ChangeTheme(int idTheme)
        {
            ThemeColors.IdTheme = idTheme;
            ThemeColors.SelectTheme();

            // Вікно
            this.BackColor = ButtonClose.BackColor = ThemeColors.BackGround;
            this.ForeColor = LabelApply.ForeColor = LabelCancel.ForeColor = ButtonClose.ForeColor = ThemeColors.ForeGround;
            PanelTools.BackColor = LabelVersionProgram.BackColor = ThemeColors.Workspace;
            PanelTools.ForeColor = ThemeColors.ForeGround;

            // toolTip
            ToolTip.OwnerDraw = true;
            ToolTip.BackColor = ThemeColors.BackGround;
            ToolTip.ForeColor = ThemeColors.ForeGround;
        }

        private void LoadSettings()
        {
            Properties.Settings.Default.Autorun = Scripts.Engine.Engine.IsAutoRun(Application.ExecutablePath);
            Properties.Settings.Default.Save();

            CheckBoxAutorun.Checked = Properties.Settings.Default.Autorun;
            CheckBoxShowMainWindow.Checked = Properties.Settings.Default.IsVisibledWindow;

            switch (Properties.Settings.Default.Language)
            {
                default:
                case 0: { RadioButtonUA.Checked = true; } break;
                case 1: { RadioButtonRU.Checked = true; } break;
                case 2: { RadioButtonEN.Checked = true; } break;
            }

            Scripts.Language.UILanguage = Properties.Settings.Default.Language;
        }

        private void SaveSettings(bool isSave)
        {
            if (isSave)
            {
                try
                {
                    if (isSave = CheckingChange())
                    {
                        Scripts.Engine.Engine.SetAutoRunValue(CheckBoxAutorun.Checked, Application.ExecutablePath);
                        Properties.Settings.Default.IdTheme = ThemeColors.IdTheme;
                        Properties.Settings.Default.IsVisibledWindow = CheckBoxShowMainWindow.Checked;
                        Scripts.Language.SetLanguage(Scripts.Language.UILanguage);

                        Properties.Settings.Default.Save();
                        MessageBox.Show(Languages.language.SuccessfullApply, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Scripts.Engine.Engine.CloseAndOpenWindow(isSave, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Languages.language.FailedApply + ex.ToString(), Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else if (AccessToCancel())
            {
                Scripts.Engine.Engine.CloseAndOpenWindow(isSave, this);
            }
        }

        private bool AccessToCancel()
        {
            if (CheckingChange())
            {
                DialogResult result = MessageBox.Show(Languages.language.CancelMessage, Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                return result.Equals(DialogResult.OK);
            }

            return true;
        }

        private bool CheckingChange()
        {
            bool lan = false;

            switch (Properties.Settings.Default.Language)
            {
                case 0: { lan = !RadioButtonUA.Checked; } break;
                case 1: { lan = !RadioButtonRU.Checked; } break;
                case 2: { lan = !RadioButtonEN.Checked; } break;
            }

            return lan || Properties.Settings.Default.Autorun != CheckBoxAutorun.Checked ||
                          Properties.Settings.Default.IsVisibledWindow != CheckBoxShowMainWindow.Checked ||
                          Properties.Settings.Default.IdTheme != ThemeColors.IdTheme;
        }

        private void UnFocus()
        {
            LabelMore.Focus();
        }

        #endregion

        #region Form Methods
        
        public void SettingsWindow_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            LoadSettings();
        }

        private void SettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemeColors.ChangeThemeEvents -= ChangeTheme;
        }

        private void SettingsWindow_Deactivate(object sender, EventArgs e)
        {
            UnFocus();
        }

        private void SettingsWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        #region Menu Methods

        private void LabelApply_Click(object sender, EventArgs e)
        {
            SaveSettings(true);
        }

        private void LabelCancel_Click(object sender, EventArgs e)
        {
            SaveSettings(false);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            SaveSettings(false);
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void PanelTools_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void ButtonThemeLight_Click(object sender, EventArgs e)
        {
            ThemeColors.ChangeTheme(0);
        }

        private void ButtonThemeDarkBlue_Click(object sender, EventArgs e)
        {
            ThemeColors.ChangeTheme(1);
        }

        private void ButtonThemeDark_Click(object sender, EventArgs e)
        {
            ThemeColors.ChangeTheme(2);
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.Graphics.DrawString(e.ToolTipText, this.Font, new System.Drawing.SolidBrush(ThemeColors.ForeGround), new System.Drawing.PointF(4, 2));
        }

        private void RadioButtonUA_Click(object sender, EventArgs e)
        {
            Scripts.Language.UILanguage = (int)Scripts.Language.Lang.Ua;
        }

        private void RadioButtonRU_Click(object sender, EventArgs e)
        {
            Scripts.Language.UILanguage = (int)Scripts.Language.Lang.Ru;
        }

        private void RadioButtonEN_Click(object sender, EventArgs e)
        {
            Scripts.Language.UILanguage = (int)Scripts.Language.Lang.En;
        }

        #endregion

        #endregion
    }
}