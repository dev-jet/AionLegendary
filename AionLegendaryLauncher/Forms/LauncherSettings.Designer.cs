
namespace AionLegendaryLauncher.Forms
{
    partial class LauncherSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherSettings));
            this.btn_Close = new System.Windows.Forms.Button();
            this.labelGameLang = new System.Windows.Forms.Label();
            this.labelGameType = new System.Windows.Forms.Label();
            this.radioButtonENG = new System.Windows.Forms.RadioButton();
            this.radioButtonTRK = new System.Windows.Forms.RadioButton();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.labelGamePathShow = new System.Windows.Forms.Label();
            this.btn_SetPath = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBoxGameLang = new System.Windows.Forms.GroupBox();
            this.groupBoxGameType = new System.Windows.Forms.GroupBox();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.labelSettings = new System.Windows.Forms.Label();
            this.groupBoxUILang = new System.Windows.Forms.GroupBox();
            this.radioButtonUILangTR = new System.Windows.Forms.RadioButton();
            this.radioButtonUILangEN = new System.Windows.Forms.RadioButton();
            this.labelUILang = new System.Windows.Forms.Label();
            this.fullCheck = new System.Windows.Forms.CheckBox();
            this.groupBoxGameLang.SuspendLayout();
            this.groupBoxGameType.SuspendLayout();
            this.groupBoxUILang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.close;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // labelGameLang
            // 
            resources.ApplyResources(this.labelGameLang, "labelGameLang");
            this.labelGameLang.Name = "labelGameLang";
            // 
            // labelGameType
            // 
            resources.ApplyResources(this.labelGameType, "labelGameType");
            this.labelGameType.Name = "labelGameType";
            // 
            // radioButtonENG
            // 
            resources.ApplyResources(this.radioButtonENG, "radioButtonENG");
            this.radioButtonENG.Name = "radioButtonENG";
            this.radioButtonENG.TabStop = true;
            this.radioButtonENG.UseVisualStyleBackColor = true;
            this.radioButtonENG.CheckedChanged += new System.EventHandler(this.radioButtonENG_CheckedChanged);
            // 
            // radioButtonTRK
            // 
            resources.ApplyResources(this.radioButtonTRK, "radioButtonTRK");
            this.radioButtonTRK.Name = "radioButtonTRK";
            this.radioButtonTRK.TabStop = true;
            this.radioButtonTRK.UseVisualStyleBackColor = true;
            this.radioButtonTRK.CheckedChanged += new System.EventHandler(this.radioButtonTRK_CheckedChanged);
            // 
            // labelGamePath
            // 
            resources.ApplyResources(this.labelGamePath, "labelGamePath");
            this.labelGamePath.Name = "labelGamePath";
            // 
            // labelGamePathShow
            // 
            resources.ApplyResources(this.labelGamePathShow, "labelGamePathShow");
            this.labelGamePathShow.Name = "labelGamePathShow";
            // 
            // btn_SetPath
            // 
            resources.ApplyResources(this.btn_SetPath, "btn_SetPath");
            this.btn_SetPath.BackColor = System.Drawing.Color.Transparent;
            this.btn_SetPath.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.folder;
            this.btn_SetPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SetPath.FlatAppearance.BorderSize = 0;
            this.btn_SetPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SetPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SetPath.Name = "btn_SetPath";
            this.btn_SetPath.UseVisualStyleBackColor = false;
            this.btn_SetPath.Click += new System.EventHandler(this.btn_SetPath_Click);
            // 
            // btn_Save
            // 
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.save;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.close;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // groupBoxGameLang
            // 
            resources.ApplyResources(this.groupBoxGameLang, "groupBoxGameLang");
            this.groupBoxGameLang.Controls.Add(this.radioButtonTRK);
            this.groupBoxGameLang.Controls.Add(this.radioButtonENG);
            this.groupBoxGameLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGameLang.Name = "groupBoxGameLang";
            this.groupBoxGameLang.TabStop = false;
            // 
            // groupBoxGameType
            // 
            resources.ApplyResources(this.groupBoxGameType, "groupBoxGameType");
            this.groupBoxGameType.Controls.Add(this.radioButton64);
            this.groupBoxGameType.Controls.Add(this.radioButton32);
            this.groupBoxGameType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGameType.Name = "groupBoxGameType";
            this.groupBoxGameType.TabStop = false;
            // 
            // radioButton64
            // 
            resources.ApplyResources(this.radioButton64, "radioButton64");
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.TabStop = true;
            this.radioButton64.UseVisualStyleBackColor = true;
            this.radioButton64.CheckedChanged += new System.EventHandler(this.radioButton64_CheckedChanged);
            // 
            // radioButton32
            // 
            resources.ApplyResources(this.radioButton32, "radioButton32");
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.TabStop = true;
            this.radioButton32.UseVisualStyleBackColor = true;
            this.radioButton32.CheckedChanged += new System.EventHandler(this.radioButton32_CheckedChanged);
            // 
            // labelSettings
            // 
            resources.ApplyResources(this.labelSettings, "labelSettings");
            this.labelSettings.Name = "labelSettings";
            // 
            // groupBoxUILang
            // 
            resources.ApplyResources(this.groupBoxUILang, "groupBoxUILang");
            this.groupBoxUILang.Controls.Add(this.radioButtonUILangTR);
            this.groupBoxUILang.Controls.Add(this.radioButtonUILangEN);
            this.groupBoxUILang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxUILang.Name = "groupBoxUILang";
            this.groupBoxUILang.TabStop = false;
            // 
            // radioButtonUILangTR
            // 
            resources.ApplyResources(this.radioButtonUILangTR, "radioButtonUILangTR");
            this.radioButtonUILangTR.Name = "radioButtonUILangTR";
            this.radioButtonUILangTR.TabStop = true;
            this.radioButtonUILangTR.UseVisualStyleBackColor = true;
            this.radioButtonUILangTR.CheckedChanged += new System.EventHandler(this.radioButtonUILangTR_CheckedChanged);
            // 
            // radioButtonUILangEN
            // 
            resources.ApplyResources(this.radioButtonUILangEN, "radioButtonUILangEN");
            this.radioButtonUILangEN.Name = "radioButtonUILangEN";
            this.radioButtonUILangEN.TabStop = true;
            this.radioButtonUILangEN.UseVisualStyleBackColor = true;
            this.radioButtonUILangEN.CheckedChanged += new System.EventHandler(this.radioButtonUILangEN_CheckedChanged);
            // 
            // labelUILang
            // 
            resources.ApplyResources(this.labelUILang, "labelUILang");
            this.labelUILang.Name = "labelUILang";
            // 
            // fullCheck
            // 
            resources.ApplyResources(this.fullCheck, "fullCheck");
            this.fullCheck.Name = "fullCheck";
            this.fullCheck.UseVisualStyleBackColor = true;
            this.fullCheck.CheckedChanged += new System.EventHandler(this.fullCheck_CheckedChanged);
            // 
            // LauncherSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ControlBox = false;
            this.Controls.Add(this.fullCheck);
            this.Controls.Add(this.groupBoxUILang);
            this.Controls.Add(this.labelUILang);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.groupBoxGameType);
            this.Controls.Add(this.groupBoxGameLang);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_SetPath);
            this.Controls.Add(this.labelGamePathShow);
            this.Controls.Add(this.labelGamePath);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.labelGameLang);
            this.Controls.Add(this.btn_Close);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LauncherSettings_FormClosing);
            this.Load += new System.EventHandler(this.LauncherSettings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LauncherSettings_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LauncherSettings_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LauncherSettings_MouseUp);
            this.groupBoxGameLang.ResumeLayout(false);
            this.groupBoxGameLang.PerformLayout();
            this.groupBoxGameType.ResumeLayout(false);
            this.groupBoxGameType.PerformLayout();
            this.groupBoxUILang.ResumeLayout(false);
            this.groupBoxUILang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label labelGameLang;
        private System.Windows.Forms.Label labelGameType;
        private System.Windows.Forms.RadioButton radioButtonENG;
        private System.Windows.Forms.RadioButton radioButtonTRK;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.Label labelGamePathShow;
        private System.Windows.Forms.Button btn_SetPath;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.GroupBox groupBoxGameLang;
        private System.Windows.Forms.GroupBox groupBoxGameType;
        private System.Windows.Forms.RadioButton radioButton64;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.GroupBox groupBoxUILang;
        private System.Windows.Forms.RadioButton radioButtonUILangTR;
        private System.Windows.Forms.RadioButton radioButtonUILangEN;
        private System.Windows.Forms.Label labelUILang;
        private System.Windows.Forms.CheckBox fullCheck;
    }
}