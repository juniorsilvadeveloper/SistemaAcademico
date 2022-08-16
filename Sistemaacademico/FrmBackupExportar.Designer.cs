namespace SistemaAcademico
{
    partial class FrmBackupExportar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowserBackup = new System.Windows.Forms.Button();
            this.txtLocalizacaoBackup = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBrowserBackup);
            this.groupBox1.Controls.Add(this.txtLocalizacaoBackup);
            this.groupBox1.Controls.Add(this.lblLocalizacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Banco de Dados";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(386, 56);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowserBackup
            // 
            this.btnBrowserBackup.Location = new System.Drawing.Point(386, 27);
            this.btnBrowserBackup.Name = "btnBrowserBackup";
            this.btnBrowserBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserBackup.TabIndex = 2;
            this.btnBrowserBackup.Text = "...";
            this.btnBrowserBackup.UseVisualStyleBackColor = true;
            this.btnBrowserBackup.Click += new System.EventHandler(this.btnBrowserBackup_Click);
            // 
            // txtLocalizacaoBackup
            // 
            this.txtLocalizacaoBackup.Location = new System.Drawing.Point(80, 29);
            this.txtLocalizacaoBackup.Name = "txtLocalizacaoBackup";
            this.txtLocalizacaoBackup.Size = new System.Drawing.Size(300, 20);
            this.txtLocalizacaoBackup.TabIndex = 1;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(7, 32);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(67, 13);
            this.lblLocalizacao.TabIndex = 0;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(398, 103);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // FrmBackupExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 138);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupExportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup - Exportar Dados";
            this.Load += new System.EventHandler(this.FrmBackupExportar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBrowserBackup;
        private System.Windows.Forms.TextBox txtLocalizacaoBackup;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Button btnSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}