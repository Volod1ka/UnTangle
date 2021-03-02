
namespace UnTangle
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.NotifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ItemShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSeparate = new System.Windows.Forms.ToolStripSeparator();
            this.ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonLanUa = new System.Windows.Forms.Button();
            this.ButtonLanRu = new System.Windows.Forms.Button();
            this.ButtonToLower = new System.Windows.Forms.Button();
            this.ButtonToUpper = new System.Windows.Forms.Button();
            this.ButtonToTitleCase = new System.Windows.Forms.Button();
            this.LabelExit = new System.Windows.Forms.Label();
            this.LabelSettings = new System.Windows.Forms.Label();
            this.ButtonReverser = new System.Windows.Forms.Button();
            this.ButtonTranslit = new System.Windows.Forms.Button();
            this.ButtonCaseChanging = new System.Windows.Forms.Button();
            this.PanelTools = new System.Windows.Forms.Panel();
            this.PanelCases = new System.Windows.Forms.Panel();
            this.PanelLanguages = new System.Windows.Forms.Panel();
            this.LabelENto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.LabelTitleProgram = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.NotifyContextMenu.SuspendLayout();
            this.PanelTools.SuspendLayout();
            this.PanelCases.SuspendLayout();
            this.PanelLanguages.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyContextMenu
            // 
            this.NotifyContextMenu.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.NotifyContextMenu, "NotifyContextMenu");
            this.NotifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemShowWindow,
            this.ItemSettings,
            this.ItemSeparate,
            this.ItemExit});
            this.NotifyContextMenu.Name = "contextMenuStrip1";
            this.NotifyContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // ItemShowWindow
            // 
            this.ItemShowWindow.BackColor = System.Drawing.Color.Transparent;
            this.ItemShowWindow.Name = "ItemShowWindow";
            resources.ApplyResources(this.ItemShowWindow, "ItemShowWindow");
            this.ItemShowWindow.Click += new System.EventHandler(this.ItemShowWindow_Click);
            // 
            // ItemSettings
            // 
            this.ItemSettings.BackColor = System.Drawing.Color.Transparent;
            this.ItemSettings.Name = "ItemSettings";
            resources.ApplyResources(this.ItemSettings, "ItemSettings");
            this.ItemSettings.Click += new System.EventHandler(this.ItemSettings_Click);
            // 
            // ItemSeparate
            // 
            this.ItemSeparate.BackColor = System.Drawing.Color.Transparent;
            this.ItemSeparate.Name = "ItemSeparate";
            resources.ApplyResources(this.ItemSeparate, "ItemSeparate");
            // 
            // ItemExit
            // 
            this.ItemExit.BackColor = System.Drawing.Color.Transparent;
            this.ItemExit.Name = "ItemExit";
            resources.ApplyResources(this.ItemExit, "ItemExit");
            this.ItemExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Notify
            // 
            resources.ApplyResources(this.Notify, "Notify");
            this.Notify.ContextMenuStrip = this.NotifyContextMenu;
            this.Notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseClick);
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.White;
            this.ToolTip.ForeColor = System.Drawing.Color.Black;
            this.ToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ToolTip_Draw);
            // 
            // ButtonLanUa
            // 
            this.ButtonLanUa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLanUa.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonLanUa, "ButtonLanUa");
            this.ButtonLanUa.ForeColor = System.Drawing.Color.Black;
            this.ButtonLanUa.Name = "ButtonLanUa";
            this.ButtonLanUa.TabStop = false;
            this.ButtonLanUa.Tag = "";
            this.ToolTip.SetToolTip(this.ButtonLanUa, resources.GetString("ButtonLanUa.ToolTip"));
            this.ButtonLanUa.UseVisualStyleBackColor = true;
            this.ButtonLanUa.Click += new System.EventHandler(this.ButtonLanUa_Click);
            // 
            // ButtonLanRu
            // 
            this.ButtonLanRu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLanRu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonLanRu, "ButtonLanRu");
            this.ButtonLanRu.ForeColor = System.Drawing.Color.Black;
            this.ButtonLanRu.Name = "ButtonLanRu";
            this.ButtonLanRu.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonLanRu, resources.GetString("ButtonLanRu.ToolTip"));
            this.ButtonLanRu.UseVisualStyleBackColor = true;
            this.ButtonLanRu.Click += new System.EventHandler(this.ButtonLanRu_Click);
            // 
            // ButtonToLower
            // 
            this.ButtonToLower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToLower.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonToLower, "ButtonToLower");
            this.ButtonToLower.ForeColor = System.Drawing.Color.Black;
            this.ButtonToLower.Name = "ButtonToLower";
            this.ButtonToLower.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonToLower, resources.GetString("ButtonToLower.ToolTip"));
            this.ButtonToLower.UseVisualStyleBackColor = true;
            this.ButtonToLower.Click += new System.EventHandler(this.ButtonToLower_Click);
            // 
            // ButtonToUpper
            // 
            this.ButtonToUpper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToUpper.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonToUpper, "ButtonToUpper");
            this.ButtonToUpper.ForeColor = System.Drawing.Color.Black;
            this.ButtonToUpper.Name = "ButtonToUpper";
            this.ButtonToUpper.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonToUpper, resources.GetString("ButtonToUpper.ToolTip"));
            this.ButtonToUpper.UseVisualStyleBackColor = true;
            this.ButtonToUpper.Click += new System.EventHandler(this.ButtonToUpper_Click);
            // 
            // ButtonToTitleCase
            // 
            this.ButtonToTitleCase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToTitleCase.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonToTitleCase, "ButtonToTitleCase");
            this.ButtonToTitleCase.ForeColor = System.Drawing.Color.Black;
            this.ButtonToTitleCase.Name = "ButtonToTitleCase";
            this.ButtonToTitleCase.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonToTitleCase, resources.GetString("ButtonToTitleCase.ToolTip"));
            this.ButtonToTitleCase.UseVisualStyleBackColor = true;
            this.ButtonToTitleCase.Click += new System.EventHandler(this.ButtonToTitleCase_Click);
            // 
            // LabelExit
            // 
            this.LabelExit.BackColor = System.Drawing.Color.Transparent;
            this.LabelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LabelExit, "LabelExit");
            this.LabelExit.Name = "LabelExit";
            this.ToolTip.SetToolTip(this.LabelExit, resources.GetString("LabelExit.ToolTip"));
            this.LabelExit.Click += new System.EventHandler(this.LabelExit_Click);
            // 
            // LabelSettings
            // 
            this.LabelSettings.BackColor = System.Drawing.Color.Transparent;
            this.LabelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.LabelSettings, "LabelSettings");
            this.LabelSettings.Name = "LabelSettings";
            this.ToolTip.SetToolTip(this.LabelSettings, resources.GetString("LabelSettings.ToolTip"));
            this.LabelSettings.Click += new System.EventHandler(this.LabelSettings_Click);
            // 
            // ButtonReverser
            // 
            this.ButtonReverser.BackColor = System.Drawing.Color.Transparent;
            this.ButtonReverser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReverser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonReverser, "ButtonReverser");
            this.ButtonReverser.Image = global::UnTangle.Properties.Resources._3;
            this.ButtonReverser.Name = "ButtonReverser";
            this.ButtonReverser.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonReverser, resources.GetString("ButtonReverser.ToolTip"));
            this.ButtonReverser.UseVisualStyleBackColor = false;
            this.ButtonReverser.Click += new System.EventHandler(this.ButtonReverser_Click);
            // 
            // ButtonTranslit
            // 
            this.ButtonTranslit.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTranslit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTranslit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonTranslit, "ButtonTranslit");
            this.ButtonTranslit.Image = global::UnTangle.Properties.Resources._1;
            this.ButtonTranslit.Name = "ButtonTranslit";
            this.ButtonTranslit.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonTranslit, resources.GetString("ButtonTranslit.ToolTip"));
            this.ButtonTranslit.UseVisualStyleBackColor = false;
            this.ButtonTranslit.Click += new System.EventHandler(this.ButtonTranslit_Click);
            // 
            // ButtonCaseChanging
            // 
            this.ButtonCaseChanging.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCaseChanging.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCaseChanging.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonCaseChanging, "ButtonCaseChanging");
            this.ButtonCaseChanging.Image = global::UnTangle.Properties.Resources._2_1;
            this.ButtonCaseChanging.Name = "ButtonCaseChanging";
            this.ButtonCaseChanging.TabStop = false;
            this.ToolTip.SetToolTip(this.ButtonCaseChanging, resources.GetString("ButtonCaseChanging.ToolTip"));
            this.ButtonCaseChanging.UseVisualStyleBackColor = false;
            this.ButtonCaseChanging.Click += new System.EventHandler(this.ButtonCaseChanging_Click);
            // 
            // PanelTools
            // 
            this.PanelTools.Controls.Add(this.PanelCases);
            this.PanelTools.Controls.Add(this.PanelLanguages);
            this.PanelTools.Controls.Add(this.ButtonReverser);
            this.PanelTools.Controls.Add(this.ButtonTranslit);
            this.PanelTools.Controls.Add(this.ButtonCaseChanging);
            this.PanelTools.Controls.Add(this.groupBox2);
            this.PanelTools.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.PanelTools, "PanelTools");
            this.PanelTools.Name = "PanelTools";
            this.PanelTools.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTools_MouseDown);
            // 
            // PanelCases
            // 
            this.PanelCases.BackColor = System.Drawing.Color.Transparent;
            this.PanelCases.Controls.Add(this.ButtonToTitleCase);
            this.PanelCases.Controls.Add(this.ButtonToLower);
            this.PanelCases.Controls.Add(this.ButtonToUpper);
            this.PanelCases.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PanelCases, "PanelCases");
            this.PanelCases.Name = "PanelCases";
            // 
            // PanelLanguages
            // 
            this.PanelLanguages.BackColor = System.Drawing.Color.Transparent;
            this.PanelLanguages.Controls.Add(this.ButtonLanRu);
            this.PanelLanguages.Controls.Add(this.LabelENto);
            this.PanelLanguages.Controls.Add(this.ButtonLanUa);
            this.PanelLanguages.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PanelLanguages, "PanelLanguages");
            this.PanelLanguages.Name = "PanelLanguages";
            // 
            // LabelENto
            // 
            resources.ApplyResources(this.LabelENto, "LabelENto");
            this.LabelENto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelENto.ForeColor = System.Drawing.Color.Black;
            this.LabelENto.Name = "LabelENto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // PanelTitleBar
            // 
            resources.ApplyResources(this.PanelTitleBar, "PanelTitleBar");
            this.PanelTitleBar.Controls.Add(this.LabelTitleProgram);
            this.PanelTitleBar.Controls.Add(this.ButtonClose);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // LabelTitleProgram
            // 
            resources.ApplyResources(this.LabelTitleProgram, "LabelTitleProgram");
            this.LabelTitleProgram.Name = "LabelTitleProgram";
            this.LabelTitleProgram.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitleProgram_MouseDown);
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
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LabelSettings);
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelTools);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Opacity = 0.95D;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.NotifyContextMenu.ResumeLayout(false);
            this.PanelTools.ResumeLayout(false);
            this.PanelCases.ResumeLayout(false);
            this.PanelLanguages.ResumeLayout(false);
            this.PanelLanguages.PerformLayout();
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip NotifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ItemShowWindow;
        private System.Windows.Forms.ToolStripSeparator ItemSeparate;
        private System.Windows.Forms.ToolStripMenuItem ItemExit;
        internal System.Windows.Forms.NotifyIcon Notify;
        private System.Windows.Forms.ToolStripMenuItem ItemSettings;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Panel PanelTools;
        private System.Windows.Forms.Button ButtonLanRu;
        private System.Windows.Forms.Label LabelENto;
        private System.Windows.Forms.Button ButtonLanUa;
        private System.Windows.Forms.Button ButtonReverser;
        private System.Windows.Forms.Button ButtonTranslit;
        private System.Windows.Forms.Button ButtonToTitleCase;
        private System.Windows.Forms.Button ButtonToUpper;
        private System.Windows.Forms.Button ButtonToLower;
        private System.Windows.Forms.Button ButtonCaseChanging;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PanelTitleBar;
        private System.Windows.Forms.Label LabelTitleProgram;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel PanelLanguages;
        private System.Windows.Forms.Panel PanelCases;
        private System.Windows.Forms.Label LabelExit;
        private System.Windows.Forms.Label LabelSettings;
    }
}

