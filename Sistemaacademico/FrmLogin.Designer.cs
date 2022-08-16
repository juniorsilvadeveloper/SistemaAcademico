
namespace SistemaAcademico
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtSistemaAcademico = new System.Windows.Forms.Label();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.txtAcessoSistema = new System.Windows.Forms.Label();
            this.txtUsuarioSc = new System.Windows.Forms.Label();
            this.txtSenhaSc = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorkerLogin = new System.ComponentModel.BackgroundWorker();
            this.progressBarLogin = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSistemaAcademico
            // 
            this.txtSistemaAcademico.AutoSize = true;
            this.txtSistemaAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSistemaAcademico.Location = new System.Drawing.Point(283, 21);
            this.txtSistemaAcademico.Name = "txtSistemaAcademico";
            this.txtSistemaAcademico.Size = new System.Drawing.Size(224, 26);
            this.txtSistemaAcademico.TabIndex = 0;
            this.txtSistemaAcademico.Text = "Sistema Acadêmico";
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.ErrorImage = null;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.InitialImage = null;
            this.pictureBoxLogin.Location = new System.Drawing.Point(-25, 0);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(282, 214);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 1;
            this.pictureBoxLogin.TabStop = false;
            // 
            // txtAcessoSistema
            // 
            this.txtAcessoSistema.AutoSize = true;
            this.txtAcessoSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcessoSistema.Location = new System.Drawing.Point(314, 56);
            this.txtAcessoSistema.Name = "txtAcessoSistema";
            this.txtAcessoSistema.Size = new System.Drawing.Size(163, 20);
            this.txtAcessoSistema.TabIndex = 1;
            this.txtAcessoSistema.Text = "Acesso ao Sistema";
            // 
            // txtUsuarioSc
            // 
            this.txtUsuarioSc.AutoSize = true;
            this.txtUsuarioSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSc.Location = new System.Drawing.Point(263, 107);
            this.txtUsuarioSc.Name = "txtUsuarioSc";
            this.txtUsuarioSc.Size = new System.Drawing.Size(64, 17);
            this.txtUsuarioSc.TabIndex = 2;
            this.txtUsuarioSc.Text = "Usuário";
            // 
            // txtSenhaSc
            // 
            this.txtSenhaSc.AutoSize = true;
            this.txtSenhaSc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaSc.Location = new System.Drawing.Point(273, 142);
            this.txtSenhaSc.Name = "txtSenhaSc";
            this.txtSenhaSc.Size = new System.Drawing.Size(54, 17);
            this.txtSenhaSc.TabIndex = 4;
            this.txtSenhaSc.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(333, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(174, 20);
            this.txtUsuario.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUsuario, "Insira seu nome de usuário");
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(333, 139);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(174, 20);
            this.txtSenha.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtSenha, "Insira sua senha");
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(333, 165);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(80, 23);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(427, 165);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // backgroundWorkerLogin
            // 
            this.backgroundWorkerLogin.WorkerReportsProgress = true;
            this.backgroundWorkerLogin.WorkerSupportsCancellation = true;
            this.backgroundWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLogin_DoWork);
            this.backgroundWorkerLogin.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLogin_ProgressChanged);
            this.backgroundWorkerLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLogin_RunWorkerCompleted);
            // 
            // progressBarLogin
            // 
            this.progressBarLogin.Location = new System.Drawing.Point(256, 203);
            this.progressBarLogin.Name = "progressBarLogin";
            this.progressBarLogin.Size = new System.Drawing.Size(274, 10);
            this.progressBarLogin.TabIndex = 8;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(529, 214);
            this.Controls.Add(this.progressBarLogin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenhaSc);
            this.Controls.Add(this.txtUsuarioSc);
            this.Controls.Add(this.txtAcessoSistema);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.txtSistemaAcademico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSistemaAcademico;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Label txtAcessoSistema;
        private System.Windows.Forms.Label txtUsuarioSc;
        private System.Windows.Forms.Label txtSenhaSc;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLogin;
        private System.Windows.Forms.ProgressBar progressBarLogin;
    }
}