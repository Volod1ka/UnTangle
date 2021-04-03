using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UnTangle.Windows.MessageBoxWindow
{
    public static class MessageBoxWindow
    {
        #region Public Methods

        public static DialogResult Show(string Message = "", string Caption = "", MessageBoxButtons Buttons = MessageBoxButtons.OK)
        {
            DialogResult Result = DialogResult.None;

            using (Windows.MessageBoxWindows ms = new Windows.MessageBoxWindows())
            {
                ms.Caption = Caption;
                ms.Message = Message;

                ms.SetStyle(Buttons: Buttons);

                Result = ms.ShowDialog();
            }

            return Result;
        }

        #endregion
    }
}
