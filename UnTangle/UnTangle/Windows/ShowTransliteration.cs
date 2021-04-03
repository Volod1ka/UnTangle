using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnTangle
{
    public partial class ShowTransliteration : Form
    {
        #region Variables

        public string TextLine
        {
            get { return TextBoxOutput.Text; }
            set { TextBoxOutput.Text = value; }
        }

        #endregion

        #region Form Constructor

        public ShowTransliteration()
        {
            InitializeComponent();

            ThemeColors.ChangeThemeEvents += ChangeTheme;
        }

        #endregion

        #region Customer Methods

        public void ChangeTheme(int idTheme)
        {
            ThemeColors.IdTheme = idTheme;
            ThemeColors.SelectTheme();

            this.BackColor = ButtonClose.BackColor = ThemeColors.BackGround;
            this.ForeColor = ButtonClose.ForeColor = ThemeColors.ForeGround;

            TextBoxOutput.BackColor = ThemeColors.Workspace;
            TextBoxOutput.ForeColor = ThemeColors.ForeGround;
        }

        public void FormLocation()
        {
            Location = new Point
            (
                x: Screen.PrimaryScreen.Bounds.Width - Cursor.Position.X > this.Width ? Cursor.Position.X : Cursor.Position.X - this.Width,
                y: Screen.PrimaryScreen.Bounds.Height - Cursor.Position.Y > this.Height ? Cursor.Position.Y : Cursor.Position.Y - this.Height
            );
        }

        private void UnFocus()
        {
            PanelTitleBar.Focus();
        }

        #endregion

        #region Form Methods

        private void ShowTransliteration_Shown(object sender, EventArgs e)
        {
            FormLocation();
        }
                
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextBoxOutput.Clear();
        }

        private void ShowTransliteration_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemeColors.ChangeThemeEvents -= ChangeTheme;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(Event: e, Handle: Handle);
        }

        private void ShowTransliteration_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(Event: e, Handle: Handle);
        }
                
        private void ShowTransliteration_Deactivate(object sender, EventArgs e)
        {
            UnFocus();
        }

        private void ShowTransliteration_Activated(object sender, EventArgs e)
        {
            TextBoxOutput.Focus();
        }

        private void TextBoxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        /*
        public static Rectangle[] FindDockedTaskBars(int DockedRectCounter)
        {
            int LeftDockedWidth = 0;
            int TopDockedHeight = 0;
            int RightDockedWidth = 0;
            int BottomDockedHeight = 0;

            Screen.

            Rectangle[] DockedRects = new Rectangle[Screen.AllScreens.Count() * 4];

            DockedRectCounter = 0;
            foreach (Screen TmpScrn in Screen.AllScreens)
            {
                if (!TmpScrn.Bounds.Equals(TmpScrn.WorkingArea))
                {
                    LeftDockedWidth = Math.Abs(Math.Abs(TmpScrn.Bounds.Left) - Math.Abs(TmpScrn.WorkingArea.Left));
                    TopDockedHeight = Math.Abs(Math.Abs(TmpScrn.Bounds.Top) - Math.Abs(TmpScrn.WorkingArea.Top));
                    RightDockedWidth = (TmpScrn.Bounds.Width - LeftDockedWidth) - TmpScrn.WorkingArea.Width;
                    BottomDockedHeight = (TmpScrn.Bounds.Height - TopDockedHeight) - TmpScrn.WorkingArea.Height;

                    if (LeftDockedWidth > 0)
                    {
                        DockedRects[DockedRectCounter].X = TmpScrn.Bounds.Left;
                        DockedRects[DockedRectCounter].Y = TmpScrn.Bounds.Top;
                        DockedRects[DockedRectCounter].Width = LeftDockedWidth;
                        DockedRects[DockedRectCounter].Height = TmpScrn.Bounds.Height;
                        DockedRectCounter += 1;
                    }

                    if (RightDockedWidth > 0)
                    {
                        DockedRects[DockedRectCounter].X = TmpScrn.WorkingArea.Right;
                        DockedRects[DockedRectCounter].Y = TmpScrn.Bounds.Top;
                        DockedRects[DockedRectCounter].Width = RightDockedWidth;
                        DockedRects[DockedRectCounter].Height = TmpScrn.Bounds.Height;
                        DockedRectCounter += 1;
                    }
                    if (TopDockedHeight > 0)
                    {
                        DockedRects[DockedRectCounter].X = TmpScrn.WorkingArea.Left;
                        DockedRects[DockedRectCounter].Y = TmpScrn.Bounds.Top;
                        DockedRects[DockedRectCounter].Width = TmpScrn.WorkingArea.Width;
                        DockedRects[DockedRectCounter].Height = TopDockedHeight;
                        DockedRectCounter += 1;
                    }
                    if (BottomDockedHeight > 0)
                    {
                        DockedRects[DockedRectCounter].X = TmpScrn.WorkingArea.Left;
                        DockedRects[DockedRectCounter].Y = TmpScrn.WorkingArea.Bottom;
                        DockedRects[DockedRectCounter].Width = TmpScrn.WorkingArea.Width;
                        DockedRects[DockedRectCounter].Height = BottomDockedHeight;
                        DockedRectCounter += 1;
                    }
                }
            }

            return DockedRects;
        }*/
    }
}

