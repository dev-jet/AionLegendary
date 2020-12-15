
namespace Updater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 210);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 15);
            this.progressBar1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(25, 183);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.labelStatus.Size = new System.Drawing.Size(57, 19);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::Updater.Properties.Resources.legendary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.ControlBox = false;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AionLegendary © 2021";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label labelStatus;
    }
}

