namespace SistemaAcademico
{
    partial class FrmConfigurarConexaoBD
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
            this.groupBoxSelecionarBaseDeDados = new System.Windows.Forms.GroupBox();
            this.comboBoxBancoDeDados = new System.Windows.Forms.ComboBox();
            this.lblBaseDeDados = new System.Windows.Forms.Label();
            this.groupBoxSQLServerAutenticacao = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogon = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblLogon = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxSelecionarBaseDeDados.SuspendLayout();
            this.groupBoxSQLServerAutenticacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSelecionarBaseDeDados
            // 
            this.groupBoxSelecionarBaseDeDados.Controls.Add(this.comboBoxBancoDeDados);
            this.groupBoxSelecionarBaseDeDados.Controls.Add(this.lblBaseDeDados);
            this.groupBoxSelecionarBaseDeDados.Location = new System.Drawing.Point(12, 100);
            this.groupBoxSelecionarBaseDeDados.Name = "groupBoxSelecionarBaseDeDados";
            this.groupBoxSelecionarBaseDeDados.Size = new System.Drawing.Size(534, 62);
            this.groupBoxSelecionarBaseDeDados.TabIndex = 3;
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
            this.groupBoxSQLServerAutenticacao.TabIndex = 2;
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
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(465, 168);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(384, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 168);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmConfigurarConexaoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 203);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBoxSelecionarBaseDeDados);
            this.Controls.Add(this.groupBoxSQLServerAutenticacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigurarConexaoBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar - Conexao BD";
            this.Load += new System.EventHandler(this.FrmConfigurarConexaoBD_Load);
            this.groupBoxSelecionarBaseDeDados.ResumeLayout(false);
            this.groupBoxSelecionarBaseDeDados.PerformLayout();
            this.groupBoxSQLServerAutenticacao.ResumeLayout(false);
            this.groupBoxSQLServerAutenticacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSelecionarBaseDeDados;
        private System.Windows.Forms.ComboBox comboBoxBancoDeDados;
        private System.Windows.Forms.Label lblBaseDeDados;
        private System.Windows.Forms.GroupBox groupBoxSQLServerAutenticacao;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtLogon;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblLogon;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}