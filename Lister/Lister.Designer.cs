
namespace Lister
{
    partial class Lister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lister));
            this.btn_Browse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse.Location = new System.Drawing.Point(678, 12);
            this.btn_Browse.MaximumSize = new System.Drawing.Size(110, 25);
            this.btn_Browse.MinimumSize = new System.Drawing.Size(110, 25);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(110, 25);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Klasör Seç";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 423);
            this.progressBar.MaximumSize = new System.Drawing.Size(776, 15);
            this.progressBar.MinimumSize = new System.Drawing.Size(776, 15);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(776, 15);
            this.progressBar.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(12, 43);
            this.txtResult.MaximumSize = new System.Drawing.Size(776, 374);
            this.txtResult.MinimumSize = new System.Drawing.Size(776, 374);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(776, 374);
            this.txtResult.TabIndex = 2;
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(24, 18);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(84, 13);
            this.labelFilePath.TabIndex = 3;
            this.labelFilePath.Text = "Klasör Seçilmedi";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Lister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Browse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lister";
            this.Text = "Aion Legendary © 2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

