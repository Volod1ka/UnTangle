using System;
using System.Windows.Forms;

namespace UnTangle.Windows.MessageBoxWindow.Windows
{
    public partial class MessageBoxWindows : Form
    {
        #region Variables

        public string Caption
        {
            get { return LabelTitleMessage.Text; }
            set { LabelTitleMessage.Text = value; }
        }

        public string Message
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }

        #endregion

        #region Form Constructor

        public MessageBoxWindows()
        {
            InitializeComponent();
            SetTheme();
        }

        #endregion

        #region Customer Methods

        public void SetTheme()
        {
            this.BackColor = ThemeColors.Workspace;
            this.ForeColor = ThemeColors.ForeGround;

            ButtonClose.BackColor = ButtonOK1.BackColor = ButtonOK2.BackColor = ButtonCancel1.BackColor = ButtonYes1.BackColor = ButtonNo1.BackColor = ThemeColors.BackGround;
            ButtonClose.ForeColor = ButtonOK1.ForeColor = ButtonOK2.ForeColor = ButtonCancel1.ForeColor = ButtonYes1.ForeColor = ButtonNo1.ForeColor = ThemeColors.ForeGround;

            PanelTitleBar.BackColor = PanelButtonsOK.BackColor = PanelButtonsOKCancel.BackColor = PanelButtonsYesNo.BackColor = ThemeColors.BackGround;
        }

        public void SetStyle(MessageBoxButtons Buttons)
        {
            PanelButtonsOK.Visible = Buttons.Equals(MessageBoxButtons.OK);
            PanelButtonsOKCancel.Visible = Buttons.Equals(MessageBoxButtons.OKCancel);
            PanelButtonsYesNo.Visible = Buttons.Equals(MessageBoxButtons.YesNo);
        }

        public void SetDialogResult(DialogResult Result)
        {
            this.DialogResult = Result;
            this.Close();
        }

        #endregion

        #region Form Methods

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            SetDialogResult(Result: DialogResult.OK);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            SetDialogResult(Result: DialogResult.Cancel);
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            SetDialogResult(Result: DialogResult.Yes);
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            SetDialogResult(Result: DialogResult.No);
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void LabelTitleMessage_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void MessageBoxWindows_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void LabelMessage_MouseDown(object sender, MouseEventArgs e)
        {
            Scripts.Engine.Engine.MoveWindow(e, Handle);
        }

        private void LabelMessage_SizeChanged(object sender, EventArgs e)
        {
            this.Width = LabelMessage.Width + LabelMessage.Location.X * 2;
            this.Height = LabelMessage.Height + LabelMessage.Location.Y * 2;
        }

        #endregion

    }
}
