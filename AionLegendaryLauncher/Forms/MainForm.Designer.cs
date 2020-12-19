namespace AionLegendaryLauncher
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.downloadSpeedText = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Discord = new System.Windows.Forms.Button();
            this.btn_Youtube = new System.Windows.Forms.Button();
            this.btn_Instagram = new System.Windows.Forms.Button();
            this.btn_Website = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Shop = new System.Windows.Forms.Button();
            this.btn_ForgotPassword = new System.Windows.Forms.Button();
            this.btn_Facebook = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.minimize;
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.CausesValidation = false;
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Minimize.Location = new System.Drawing.Point(716, 20);
            this.btn_Minimize.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Minimize.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // downloadSpeedText
            // 
            this.downloadSpeedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadSpeedText.AutoSize = true;
            this.downloadSpeedText.BackColor = System.Drawing.Color.Black;
            this.downloadSpeedText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.downloadSpeedText.Location = new System.Drawing.Point(528, 419);
            this.downloadSpeedText.Name = "downloadSpeedText";
            this.downloadSpeedText.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.downloadSpeedText.Size = new System.Drawing.Size(109, 19);
            this.downloadSpeedText.TabIndex = 10;
            this.downloadSpeedText.Text = "Download Speed";
            this.downloadSpeedText.Visible = false;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.btn_Play.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.play;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.Enabled = false;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Play.Location = new System.Drawing.Point(738, 378);
            this.btn_Play.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Play.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(32, 32);
            this.btn_Play.TabIndex = 10;
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(30, 459);
            this.progressBar.MaximumSize = new System.Drawing.Size(756, 10);
            this.progressBar.MinimumSize = new System.Drawing.Size(756, 10);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(756, 10);
            this.progressBar.TabIndex = 10;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.close;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Exit.Location = new System.Drawing.Point(754, 20);
            this.btn_Exit.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Exit.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(32, 32);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Black;
            this.Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Status.Location = new System.Drawing.Point(30, 419);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Status.Size = new System.Drawing.Size(143, 19);
            this.Status.TabIndex = 11;
            this.Status.Text = "www.aionlegendary.com";
            this.Status.Visible = false;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.settings;
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Settings.CausesValidation = false;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.Enabled = false;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Settings.Location = new System.Drawing.Point(700, 378);
            this.btn_Settings.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Settings.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(32, 32);
            this.btn_Settings.TabIndex = 12;
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Discord
            // 
            this.btn_Discord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Discord.BackColor = System.Drawing.Color.Transparent;
            this.btn_Discord.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.discord;
            this.btn_Discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Discord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Discord.FlatAppearance.BorderSize = 0;
            this.btn_Discord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Discord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Discord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discord.Location = new System.Drawing.Point(307, 39);
            this.btn_Discord.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Discord.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Discord.Name = "btn_Discord";
            this.btn_Discord.Size = new System.Drawing.Size(32, 32);
            this.btn_Discord.TabIndex = 16;
            this.btn_Discord.UseVisualStyleBackColor = false;
            this.btn_Discord.Click += new System.EventHandler(this.btn_Discord_Click);
            // 
            // btn_Youtube
            // 
            this.btn_Youtube.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Youtube.BackColor = System.Drawing.Color.Transparent;
            this.btn_Youtube.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.youtube;
            this.btn_Youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Youtube.FlatAppearance.BorderSize = 0;
            this.btn_Youtube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Youtube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Youtube.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Youtube.Location = new System.Drawing.Point(345, 39);
            this.btn_Youtube.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Youtube.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Youtube.Name = "btn_Youtube";
            this.btn_Youtube.Size = new System.Drawing.Size(32, 32);
            this.btn_Youtube.TabIndex = 17;
            this.btn_Youtube.UseVisualStyleBackColor = false;
            this.btn_Youtube.Click += new System.EventHandler(this.btn_Youtube_Click);
            // 
            // btn_Instagram
            // 
            this.btn_Instagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Instagram.BackColor = System.Drawing.Color.Transparent;
            this.btn_Instagram.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.instagram;
            this.btn_Instagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Instagram.FlatAppearance.BorderSize = 0;
            this.btn_Instagram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Instagram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instagram.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Instagram.Location = new System.Drawing.Point(383, 39);
            this.btn_Instagram.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Instagram.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Instagram.Name = "btn_Instagram";
            this.btn_Instagram.Size = new System.Drawing.Size(32, 32);
            this.btn_Instagram.TabIndex = 18;
            this.btn_Instagram.UseVisualStyleBackColor = false;
            this.btn_Instagram.Click += new System.EventHandler(this.btn_Instagram_Click);
            // 
            // btn_Website
            // 
            this.btn_Website.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Website.BackColor = System.Drawing.Color.Transparent;
            this.btn_Website.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.web;
            this.btn_Website.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Website.CausesValidation = false;
            this.btn_Website.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Website.FlatAppearance.BorderSize = 0;
            this.btn_Website.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Website.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Website.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Website.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Website.Location = new System.Drawing.Point(33, 39);
            this.btn_Website.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Website.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Website.Name = "btn_Website";
            this.btn_Website.Size = new System.Drawing.Size(32, 32);
            this.btn_Website.TabIndex = 20;
            this.btn_Website.UseVisualStyleBackColor = false;
            this.btn_Website.Click += new System.EventHandler(this.btn_Website_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Register.BackColor = System.Drawing.Color.Transparent;
            this.btn_Register.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.register;
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Register.CausesValidation = false;
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Register.Location = new System.Drawing.Point(71, 39);
            this.btn_Register.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Register.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(32, 32);
            this.btn_Register.TabIndex = 21;
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Shop
            // 
            this.btn_Shop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Shop.BackColor = System.Drawing.Color.Transparent;
            this.btn_Shop.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.shop;
            this.btn_Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Shop.CausesValidation = false;
            this.btn_Shop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shop.FlatAppearance.BorderSize = 0;
            this.btn_Shop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Shop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Shop.Location = new System.Drawing.Point(109, 39);
            this.btn_Shop.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Shop.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Shop.Name = "btn_Shop";
            this.btn_Shop.Size = new System.Drawing.Size(32, 32);
            this.btn_Shop.TabIndex = 22;
            this.btn_Shop.UseVisualStyleBackColor = false;
            this.btn_Shop.Click += new System.EventHandler(this.btn_Shop_Click);
            // 
            // btn_ForgotPassword
            // 
            this.btn_ForgotPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btn_ForgotPassword.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.password;
            this.btn_ForgotPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ForgotPassword.CausesValidation = false;
            this.btn_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ForgotPassword.FlatAppearance.BorderSize = 0;
            this.btn_ForgotPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForgotPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ForgotPassword.Location = new System.Drawing.Point(147, 39);
            this.btn_ForgotPassword.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_ForgotPassword.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_ForgotPassword.Name = "btn_ForgotPassword";
            this.btn_ForgotPassword.Size = new System.Drawing.Size(32, 32);
            this.btn_ForgotPassword.TabIndex = 23;
            this.btn_ForgotPassword.UseVisualStyleBackColor = false;
            this.btn_ForgotPassword.Click += new System.EventHandler(this.btn_ForgotPassword_Click);
            // 
            // btn_Facebook
            // 
            this.btn_Facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Facebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_Facebook.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.facebook;
            this.btn_Facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Facebook.FlatAppearance.BorderSize = 0;
            this.btn_Facebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Facebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facebook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Facebook.Location = new System.Drawing.Point(421, 39);
            this.btn_Facebook.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_Facebook.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_Facebook.Name = "btn_Facebook";
            this.btn_Facebook.Size = new System.Drawing.Size(32, 32);
            this.btn_Facebook.TabIndex = 24;
            this.btn_Facebook.UseVisualStyleBackColor = false;
            this.btn_Facebook.Click += new System.EventHandler(this.btn_Facebook_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(33, 77);
            this.webBrowser1.MaximumSize = new System.Drawing.Size(420, 300);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(420, 300);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(420, 300);
            this.webBrowser1.TabIndex = 25;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::AionLegendaryLauncher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btn_Facebook);
            this.Controls.Add(this.btn_ForgotPassword);
            this.Controls.Add(this.btn_Shop);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Website);
            this.Controls.Add(this.btn_Instagram);
            this.Controls.Add(this.btn_Youtube);
            this.Controls.Add(this.btn_Discord);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.downloadSpeedText);
            this.Controls.Add(this.btn_Minimize);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::AionLegendaryLauncher.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aion Legendary © 2021";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Minimize;
        public System.Windows.Forms.Label downloadSpeedText;
        public System.Windows.Forms.Button btn_Play;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button btn_Discord;
        private System.Windows.Forms.Button btn_Youtube;
        private System.Windows.Forms.Button btn_Instagram;
        private System.Windows.Forms.Button btn_Website;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Shop;
        private System.Windows.Forms.Button btn_ForgotPassword;
        private System.Windows.Forms.Button btn_Facebook;
        private System.Windows.Forms.WebBrowser webBrowser1;
        public System.Windows.Forms.Button btn_Settings;
    }
}

