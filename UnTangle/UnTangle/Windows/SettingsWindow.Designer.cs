namespace UnTangle
{
    partial class SettingsWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.RadioButtonEN = new System.Windows.Forms.RadioButton();
            this.RadioButtonRU = new System.Windows.Forms.RadioButton();
            this.RadioButtonUA = new System.Windows.Forms.RadioButton();
            this.CheckBoxAutorun = new System.Windows.Forms.CheckBox();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.LabelCancel = new System.Windows.Forms.Label();
            this.LabelApply = new System.Windows.Forms.Label();
            this.LabelVersionProgram = new System.Windows.Forms.Label();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonThemeLight = new System.Windows.Forms.Button();
            this.ButtonThemeDark = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.LabelHotKey3 = new System.Windows.Forms.Label();
            this.LabelHotKey2 = new System.Windows.Forms.Label();
            this.LabelHotKey1 = new System.Windows.Forms.Label();
            this.LabelHotKeys = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonThemeDarkBlue = new System.Windows.Forms.Button();
            this.LabelLanguage = new System.Windows.Forms.Label();
            this.LabelTheme = new System.Windows.Forms.Label();
            this.LabelMore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxShowMainWindow = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelBar.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButtonEN
            // 
            resources.ApplyResources(this.RadioButtonEN, "RadioButtonEN");
            this.RadioButtonEN.Name = "RadioButtonEN";
            this.RadioButtonEN.TabStop = true;
            this.RadioButtonEN.UseVisualStyleBackColor = true;
            this.RadioButtonEN.Click += new System.EventHandler(this.RadioButtonEN_Click);
            // 
            // RadioButtonRU
            // 
            resources.ApplyResources(this.RadioButtonRU, "RadioButtonRU");
            this.RadioButtonRU.Name = "RadioButtonRU";
            this.RadioButtonRU.TabStop = true;
            this.RadioButtonRU.UseVisualStyleBackColor = true;
            this.RadioButtonRU.Click += new System.EventHandler(this.RadioButtonRU_Click);
            // 
            // RadioButtonUA
            // 
            resources.ApplyResources(this.RadioButtonUA, "RadioButtonUA");
            this.RadioButtonUA.Name = "RadioButtonUA";
            this.RadioButtonUA.TabStop = true;
            this.RadioButtonUA.UseVisualStyleBackColor = true;
            this.RadioButtonUA.Click += new System.EventHandler(this.RadioButtonUA_Click);
            // 
            // CheckBoxAutorun
            // 
            resources.ApplyResources(this.CheckBoxAutorun, "CheckBoxAutorun");
            this.CheckBoxAutorun.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckBoxAutorun.Name = "CheckBoxAutorun";
            this.CheckBoxAutorun.UseVisualStyleBackColor = true;
            // 
            // PanelBar
            // 
            this.PanelBar.Controls.Add(this.LabelCancel);
            this.PanelBar.Controls.Add(this.LabelApply);
            this.PanelBar.Controls.Add(this.LabelVersionProgram);
            resources.ApplyResources(this.PanelBar, "PanelBar");
            this.PanelBar.Name = "PanelBar";
            // 
            // LabelCancel
            // 
            this.LabelCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LabelCancel, "LabelCancel");
            this.LabelCancel.Name = "LabelCancel";
            this.ToolTip.SetToolTip(this.LabelCancel, resources.GetString("LabelCancel.ToolTip"));
            this.LabelCancel.Click += new System.EventHandler(this.LabelCancel_Click);
            // 
            // LabelApply
            // 
            this.LabelApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LabelApply, "LabelApply");
            this.LabelApply.Name = "LabelApply";
            this.ToolTip.SetToolTip(this.LabelApply, resources.GetString("LabelApply.ToolTip"));
            this.LabelApply.Click += new System.EventHandler(this.LabelApply_Click);
            // 
            // LabelVersionProgram
            // 
            resources.ApplyResources(this.LabelVersionProgram, "LabelVersionProgram");
            this.LabelVersionProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelVersionProgram.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelVersionProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelVersionProgram.Name = "LabelVersionProgram";
            // 
            // PanelTitleBar
            // 
            resources.ApplyResources(this.PanelTitleBar, "PanelTitleBar");
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
            // ButtonThemeLight
            // 
            this.ButtonThemeLight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonThemeLight.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonThemeLight, "ButtonThemeLight");
            this.ButtonThemeLight.Name = "ButtonThemeLight";
            this.ToolTip.SetToolTip(this.ButtonThemeLight, resources.GetString("ButtonThemeLight.ToolTip"));
            this.ButtonThemeLight.UseVisualStyleBackColor = true;
            this.ButtonThemeLight.Click += new System.EventHandler(this.ButtonThemeLight_Click);
            // 
            // ButtonThemeDark
            // 
            this.ButtonThemeDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonThemeDark.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonThemeDark, "ButtonThemeDark");
            this.ButtonThemeDark.Name = "ButtonThemeDark";
            this.ToolTip.SetToolTip(this.ButtonThemeDark, resources.GetString("ButtonThemeDark.ToolTip"));
            this.ButtonThemeDark.UseVisualStyleBackColor = true;
            this.ButtonThemeDark.Click += new System.EventHandler(this.ButtonThemeDark_Click);
            // 
            // PanelTools
            // 
            this.PanelTools.Controls.Add(this.LabelHotKey3);
            this.PanelTools.Controls.Add(this.LabelHotKey2);
            this.PanelTools.Controls.Add(this.LabelHotKey1);
            this.PanelTools.Controls.Add(this.LabelHotKeys);
            this.PanelTools.Controls.Add(this.groupBox2);
            this.PanelTools.Controls.Add(this.ButtonThemeDarkBlue);
            this.PanelTools.Controls.Add(this.RadioButtonEN);
            this.PanelTools.Controls.Add(this.RadioButtonRU);
            this.PanelTools.Controls.Add(this.LabelLanguage);
            this.PanelTools.Controls.Add(this.LabelTheme);
            this.PanelTools.Controls.Add(this.RadioButtonUA);
            this.PanelTools.Controls.Add(this.LabelMore);
            this.PanelTools.Controls.Add(this.groupBox1);
            this.PanelTools.Controls.Add(this.CheckBoxShowMainWindow);
            this.PanelTools.Controls.Add(this.groupBox3);
            this.PanelTools.Controls.Add(this.CheckBoxAutorun);
            this.PanelTools.Controls.Add(this.ButtonThemeDark);
            this.PanelTools.Controls.Add(this.ButtonThemeLight);
            resources.ApplyResources(this.PanelTools, "PanelTools");
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTools_MouseDown);
            // 
            // LabelHotKey3
            // 
            resources.ApplyResources(this.LabelHotKey3, "LabelHotKey3");
            this.LabelHotKey3.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHotKey3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHotKey3.Name = "LabelHotKey3";
            // 
            // LabelHotKey2
            // 
            resources.ApplyResources(this.LabelHotKey2, "LabelHotKey2");
            this.LabelHotKey2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHotKey2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHotKey2.Name = "LabelHotKey2";
            // 
            // LabelHotKey1
            // 
            resources.ApplyResources(this.LabelHotKey1, "LabelHotKey1");
            this.LabelHotKey1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHotKey1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHotKey1.Name = "LabelHotKey1";
            this.ToolTip.SetToolTip(this.LabelHotKey1, resources.GetString("LabelHotKey1.ToolTip"));
            // 
            // LabelHotKeys
            // 
            resources.ApplyResources(this.LabelHotKeys, "LabelHotKeys");
            this.LabelHotKeys.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelHotKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelHotKeys.Name = "LabelHotKeys";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ButtonThemeDarkBlue
            // 
            this.ButtonThemeDarkBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonThemeDarkBlue.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonThemeDarkBlue, "ButtonThemeDarkBlue");
            this.ButtonThemeDarkBlue.Name = "ButtonThemeDarkBlue";
            this.ToolTip.SetToolTip(this.ButtonThemeDarkBlue, resources.GetString("ButtonThemeDarkBlue.ToolTip"));
            this.ButtonThemeDarkBlue.UseVisualStyleBackColor = true;
            this.ButtonThemeDarkBlue.Click += new System.EventHandler(this.ButtonThemeDarkBlue_Click);
            // 
            // LabelLanguage
            // 
            resources.ApplyResources(this.LabelLanguage, "LabelLanguage");
            this.LabelLanguage.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLanguage.Name = "LabelLanguage";
            // 
            // LabelTheme
            // 
            resources.ApplyResources(this.LabelTheme, "LabelTheme");
            this.LabelTheme.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTheme.Name = "LabelTheme";
            // 
            // LabelMore
            // 
            resources.ApplyResources(this.LabelMore, "LabelMore");
            this.LabelMore.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelMore.Name = "LabelMore";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CheckBoxShowMainWindow
            // 
            resources.ApplyResources(this.CheckBoxShowMainWindow, "CheckBoxShowMainWindow");
            this.CheckBoxShowMainWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckBoxShowMainWindow.Name = "CheckBoxShowMainWindow";
            this.CheckBoxShowMainWindow.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.ForeColor = System.Drawing.Color.Black;
            this.ToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ToolTip_Draw);
            // 
            // SettingsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTools);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.Opacity = 0.95D;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.SettingsWindow_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsWindow_FormClosed);
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsWindow_MouseDown);
            this.PanelBar.ResumeLayout(false);
            this.PanelBar.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTools.ResumeLayout(false);
            this.PanelTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.CheckBox CheckBoxAutorun;
        private System.Windows.Forms.RadioButton RadioButtonEN;
        private System.Windows.Forms.RadioButton RadioButtonRU;
        private System.Windows.Forms.RadioButton RadioButtonUA;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelApply;
        private System.Windows.Forms.Label LabelCancel;
        private System.Windows.Forms.Button ButtonThemeLight;
        private System.Windows.Forms.Button ButtonThemeDark;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LabelTheme;
        private System.Windows.Forms.Label LabelMore;
        private System.Windows.Forms.CheckBox CheckBoxShowMainWindow;
        private System.Windows.Forms.Label LabelLanguage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label LabelVersionProgram;
        private System.Windows.Forms.Button ButtonThemeDarkBlue;
        private System.Windows.Forms.Label LabelHotKeys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelHotKey1;
        private System.Windows.Forms.Label LabelHotKey3;
        private System.Windows.Forms.Label LabelHotKey2;
    }
}