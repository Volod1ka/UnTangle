
namespace UnTangle
{
    partial class ShowTransliteration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTransliteration));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            resources.ApplyResources(this.PanelTitleBar, "PanelTitleBar");
            this.PanelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.PanelTitleBar.Controls.Add(this.ButtonClose);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
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
            // TextBoxOutput
            // 
            resources.ApplyResources(this.TextBoxOutput, "TextBoxOutput");
            this.TextBoxOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.TextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOutput_KeyPress);
            // 
            // ShowTransliteration
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.PanelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowTransliteration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.ShowTransliteration_Activated);
            this.Deactivate += new System.EventHandler(this.ShowTransliteration_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowTransliteration_FormClosed);
            this.Shown += new System.EventHandler(this.ShowTransliteration_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowTransliteration_MouseDown);
            this.PanelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.RichTextBox TextBoxOutput;
        private System.Windows.Forms.Button ButtonClose;
    }
}