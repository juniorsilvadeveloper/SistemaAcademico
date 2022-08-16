namespace SistemaAcademico
{
    partial class FrmBackupImportar
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
            this.groupBoxSQLServerAutenticacao = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogon = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblLogon = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.groupBoxSelecionarBaseDeDados = new System.Windows.Forms.GroupBox();
            this.comboBoxBancoDeDados = new System.Windows.Forms.ComboBox();
            this.lblBaseDeDados = new System.Windows.Forms.Label();
            this.groupBoxRestaurarBaseDeDados = new System.Windows.Forms.GroupBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnBrowserRestaurar = new System.Windows.Forms.Button();
            this.txtLocalizacaoRestauracao = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBoxSQLServerAutenticacao.SuspendLayout();
            this.groupBoxSelecionarBaseDeDados.SuspendLayout();
            this.groupBoxRestaurarBaseDeDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSQLServerAutenticacao
            // 
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.btnConectar);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.txtSenha);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.lblSenha);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.txtLogon);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.txtServidor);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.lblLogon);
            this.groupBoxSQLServerAutenticacao.Controls.Add(this.lblServidor);
            this.groupBoxSQLServerAutenticacao.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSQLServerAutenticacao.Name = "groupBoxSQLServerAutenticacao";
            this.groupBoxSQLServerAutenticacao.Size = new System.Drawing.Size(534, 82);
            this.groupBoxSQLServerAutenticacao.TabIndex = 0;
            this.groupBoxSQLServerAutenticacao.TabStop = false;
            this.groupBoxSQLServerAutenticacao.Text = "SQL Server Autenticação";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(453, 47);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(284, 49);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(163, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(240, 52);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogon
            // 
            this.txtLogon.Location = new System.Drawing.Point(58, 49);
            this.txtLogon.Name = "txtLogon";
            this.txtLogon.Size = new System.Drawing.Size(176, 20);
            this.txtLogon.TabIndex = 3;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(58, 23);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(470, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // lblLogon
            // 
            this.lblLogon.AutoSize = true;
            this.lblLogon.Location = new System.Drawing.Point(6, 52);
            this.lblLogon.Name = "lblLogon";
            this.lblLogon.Size = new System.Drawing.Size(37, 13);
            this.lblLogon.TabIndex = 1;
            this.lblLogon.Text = "Logon";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(6, 26);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor";
            // 
            // groupBoxSelecionarBaseDeDados
            // 
            this.groupBoxSelecionarBaseDeDados.Controls.Add(this.comboBoxBancoDeDados);
            this.groupBoxSelecionarBaseDeDados.Controls.Add(this.lblBaseDeDados);
            this.groupBoxSelecionarBaseDeDados.Location = new System.Drawing.Point(12, 100);
            this.groupBoxSelecionarBaseDeDados.Name = "groupBoxSelecionarBaseDeDados";
            this.groupBoxSelecionarBaseDeDados.Size = new System.Drawing.Size(534, 62);
            this.groupBoxSelecionarBaseDeDados.TabIndex = 1;
            this.groupBoxSelecionarBaseDeDados.TabStop = false;
            this.groupBoxSelecionarBaseDeDados.Text = "Selecionar Base de Dados";
            // 
            // comboBoxBancoDeDados
            // 
            this.comboBoxBancoDeDados.FormattingEnabled = true;
            this.comboBoxBancoDeDados.Location = new System.Drawing.Point(92, 19);
            this.comboBoxBancoDeDados.Name = "comboBoxBancoDeDados";
            this.comboBoxBancoDeDados.Size = new System.Drawing.Size(436, 21);
            this.comboBoxBancoDeDados.TabIndex = 4;
            // 
            // lblBaseDeDados
            // 
            this.lblBaseDeDados.AutoSize = true;
            this.lblBaseDeDados.Location = new System.Drawing.Point(6, 22);
            this.lblBaseDeDados.Name = "lblBaseDeDados";
            this.lblBaseDeDados.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDeDados.TabIndex = 3;
            this.lblBaseDeDados.Text = "Base de Dados";
            // 
            // groupBoxRestaurarBaseDeDados
            // 
            this.groupBoxRestaurarBaseDeDados.Controls.Add(this.btnRestaurar);
            this.groupBoxRestaurarBaseDeDados.Controls.Add(this.btnBrowserRestaurar);
            this.groupBoxRestaurarBaseDeDados.Controls.Add(this.txtLocalizacaoRestauracao);
            this.groupBoxRestaurarBaseDeDados.Controls.Add(this.lblLocalizacao);
            this.groupBoxRestaurarBaseDeDados.Location = new System.Drawing.Point(12, 168);
            this.groupBoxRestaurarBaseDeDados.Name = "groupBoxRestaurarBaseDeDados";
            this.groupBoxRestaurarBaseDeDados.Size = new System.Drawing.Size(534, 76);
            this.groupBoxRestaurarBaseDeDados.TabIndex = 2;
            this.groupBoxRestaurarBaseDeDados.TabStop = false;
            this.groupBoxRestaurarBaseDeDados.Text = "Restaurar Base de Dados";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(453, 46);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnBrowserRestaurar
            // 
            this.btnBrowserRestaurar.Location = new System.Drawing.Point(453, 17);
            this.btnBrowserRestaurar.Name = "btnBrowserRestaurar";
            this.btnBrowserRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserRestaurar.TabIndex = 7;
            this.btnBrowserRestaurar.Text = "...";
            this.btnBrowserRestaurar.UseVisualStyleBackColor = true;
            this.btnBrowserRestaurar.Click += new System.EventHandler(this.btnBrowserRestaurar_Click);
            // 
            // txtLocalizacaoRestauracao
            // 
            this.txtLocalizacaoRestauracao.Location = new System.Drawing.Point(76, 19);
            this.txtLocalizacaoRestauracao.Name = "txtLocalizacaoRestauracao";
            this.txtLocalizacaoRestauracao.Size = new System.Drawing.Size(371, 20);
            this.txtLocalizacaoRestauracao.TabIndex = 4;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(6, 22);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 3;
            this.lblLocalizacao.Text = "Localização";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(465, 250);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
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
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 250);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 250);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 10;
            // 
            // FrmBackupImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 280);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxRestaurarBaseDeDados);
            this.Controls.Add(this.groupBoxSelecionarBaseDeDados);
            this.Controls.Add(this.groupBoxSQLServerAutenticacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupImportar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup - Importar Dados";
            this.Load += new System.EventHandler(this.FrmBackupImportar_Load);
            this.groupBoxSQLServerAutenticacao.ResumeLayout(false);
            this.groupBoxSQLServerAutenticacao.PerformLayout();
            this.groupBoxSelecionarBaseDeDados.ResumeLayout(false);
            this.groupBoxSelecionarBaseDeDados.PerformLayout();
            this.groupBoxRestaurarBaseDeDados.ResumeLayout(false);
            this.groupBoxRestaurarBaseDeDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSQLServerAutenticacao;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogon;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblLogon;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.GroupBox groupBoxSelecionarBaseDeDados;
        private System.Windows.Forms.ComboBox comboBoxBancoDeDados;
        private System.Windows.Forms.Label lblBaseDeDados;
        private System.Windows.Forms.GroupBox groupBoxRestaurarBaseDeDados;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnBrowserRestaurar;
        private System.Windows.Forms.TextBox txtLocalizacaoRestauracao;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Button btnSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}