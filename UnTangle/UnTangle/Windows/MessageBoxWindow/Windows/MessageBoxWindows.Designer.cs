
namespace UnTangle.Windows.MessageBoxWindow.Windows
{
    partial class MessageBoxWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxWindows));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.LabelTitleMessage = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PanelButtonsOK = new System.Windows.Forms.Panel();
            this.ButtonOK1 = new System.Windows.Forms.Button();
            this.PanelButtonsOKCancel = new System.Windows.Forms.Panel();
            this.ButtonOK2 = new System.Windows.Forms.Button();
            this.ButtonCancel1 = new System.Windows.Forms.Button();
            this.PanelButtonsYesNo = new System.Windows.Forms.Panel();
            this.ButtonYes1 = new System.Windows.Forms.Button();
            this.ButtonNo1 = new System.Windows.Forms.Button();
            this.PanelTitleBar.SuspendLayout();
            this.PanelButtonsOK.SuspendLayout();
            this.PanelButtonsOKCancel.SuspendLayout();
            this.PanelButtonsYesNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            resources.ApplyResources(this.PanelTitleBar, "PanelTitleBar");
            this.PanelTitleBar.Controls.Add(this.LabelTitleMessage);
            this.PanelTitleBar.Controls.Add(this.ButtonClose);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // LabelTitleMessage
            // 
            resources.ApplyResources(this.LabelTitleMessage, "LabelTitleMessage");
            this.LabelTitleMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitleMessage.Name = "LabelTitleMessage";
            this.LabelTitleMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitleMessage_MouseDown);
            // 
            // ButtonClose
            // 
            resources.ApplyResources(this.ButtonClose, "ButtonClose");
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.ForeColor = System.Drawing.Color.Black;
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelMessage
            // 
            resources.ApplyResources(this.LabelMessage, "LabelMessage");
            this.LabelMessage.BackColor = System.Drawing.Color.Transparent;
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.SizeChanged += new System.EventHandler(this.LabelMessage_SizeChanged);
            this.LabelMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelMessage_MouseDown);
            // 
            // PanelButtonsOK
            // 
            resources.ApplyResources(this.PanelButtonsOK, "PanelButtonsOK");
            this.PanelButtonsOK.Controls.Add(this.ButtonOK1);
            this.PanelButtonsOK.Name = "PanelButtonsOK";
            // 
            // ButtonOK1
            // 
            resources.ApplyResources(this.ButtonOK1, "ButtonOK1");
            this.ButtonOK1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOK1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonOK1.FlatAppearance.BorderSize = 0;
            this.ButtonOK1.ForeColor = System.Drawing.Color.Black;
            this.ButtonOK1.Name = "ButtonOK1";
            this.ButtonOK1.TabStop = false;
            this.ButtonOK1.UseVisualStyleBackColor = false;
            this.ButtonOK1.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // PanelButtonsOKCancel
            // 
            resources.ApplyResources(this.PanelButtonsOKCancel, "PanelButtonsOKCancel");
            this.PanelButtonsOKCancel.Controls.Add(this.ButtonOK2);
            this.PanelButtonsOKCancel.Controls.Add(this.ButtonCancel1);
            this.PanelButtonsOKCancel.Name = "PanelButtonsOKCancel";
            // 
            // ButtonOK2
            // 
            resources.ApplyResources(this.ButtonOK2, "ButtonOK2");
            this.ButtonOK2.BackColor = System.Drawing.Color.Transparent;
            this.ButtonOK2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonOK2.FlatAppearance.BorderSize = 0;
            this.ButtonOK2.ForeColor = System.Drawing.Color.Black;
            this.ButtonOK2.Name = "ButtonOK2";
            this.ButtonOK2.TabStop = false;
            this.ButtonOK2.UseVisualStyleBackColor = false;
            this.ButtonOK2.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel1
            // 
            resources.ApplyResources(this.ButtonCancel1, "ButtonCancel1");
            this.ButtonCancel1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonCancel1.FlatAppearance.BorderSize = 0;
            this.ButtonCancel1.ForeColor = System.Drawing.Color.Black;
            this.ButtonCancel1.Name = "ButtonCancel1";
            this.ButtonCancel1.TabStop = false;
            this.ButtonCancel1.UseVisualStyleBackColor = false;
            this.ButtonCancel1.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // PanelButtonsYesNo
            // 
            resources.ApplyResources(this.PanelButtonsYesNo, "PanelButtonsYesNo");
            this.PanelButtonsYesNo.Controls.Add(this.ButtonYes1);
            this.PanelButtonsYesNo.Controls.Add(this.ButtonNo1);
            this.PanelButtonsYesNo.Name = "PanelButtonsYesNo";
            // 
            // ButtonYes1
            // 
            resources.ApplyResources(this.ButtonYes1, "ButtonYes1");
            this.ButtonYes1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonYes1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonYes1.FlatAppearance.BorderSize = 0;
            this.ButtonYes1.ForeColor = System.Drawing.Color.Black;
            this.ButtonYes1.Name = "ButtonYes1";
            this.ButtonYes1.TabStop = false;
            this.ButtonYes1.UseVisualStyleBackColor = false;
            this.ButtonYes1.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // ButtonNo1
            // 
            resources.ApplyResources(this.ButtonNo1, "ButtonNo1");
            this.ButtonNo1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonNo1.FlatAppearance.BorderSize = 0;
            this.ButtonNo1.ForeColor = System.Drawing.Color.Black;
            this.ButtonNo1.Name = "ButtonNo1";
            this.ButtonNo1.TabStop = false;
            this.ButtonNo1.UseVisualStyleBackColor = false;
            this.ButtonNo1.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // MessageBoxWindows
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.PanelButtonsYesNo);
            this.Controls.Add(this.PanelButtonsOKCancel);
            this.Controls.Add(this.PanelButtonsOK);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.PanelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxWindows";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MessageBoxWindows_MouseDown);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.PanelButtonsOK.ResumeLayout(false);
            this.PanelButtonsOKCancel.ResumeLayout(false);
            this.PanelButtonsYesNo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label LabelTitleMessage;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Panel PanelButtonsOK;
        private System.Windows.Forms.Button ButtonOK1;
        private System.Windows.Forms.Panel PanelButtonsOKCancel;
        private System.Windows.Forms.Button ButtonCancel1;
        private System.Windows.Forms.Button ButtonOK2;
        private System.Windows.Forms.Panel PanelButtonsYesNo;
        private System.Windows.Forms.Button ButtonYes1;
        private System.Windows.Forms.Button ButtonNo1;
    }
}