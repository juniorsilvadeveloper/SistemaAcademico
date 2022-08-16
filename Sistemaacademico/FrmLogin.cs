using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmLogin : Form
    {
        private bool mouseclicked;
        private Point clickedAt;
        private string erro = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Usuário ou senha inválida.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                }
                else
                {
                    txtUsuario.Enabled = false;
                    txtSenha.Enabled = false;
                    btnEntrar.Enabled = false;
                    backgroundWorkerLogin.RunWorkerAsync();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível logar no sistema." + exception.Message,"Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void backgroundWorkerLogin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarLogin.Increment(e.ProgressPercentage);
        }

        private void backgroundWorkerLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorkerLogin.ReportProgress(10);
                Usuario usuario = new Usuario();
                usuario.NomeUsuario = txtUsuario.Text.ToString();
                usuario.Senha = txtSenha.Text.ToString();
                backgroundWorkerLogin.ReportProgress(20);
                UsuarioRegraNegocio usuarioRegraNegocio = new UsuarioRegraNegocio();
                string retornoLogin = usuarioRegraNegocio.validarLogin(usuario);
                backgroundWorkerLogin.ReportProgress(50);

                    if(retornoLogin == "0")
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        usuario = usuarioRegraNegocio.ConsultarCodigoUnico(retornoLogin);
                        LoginSistema.UsuarioLogin = usuario;
                    if (usuario.Administrador || usuario.Secretariado)
                        LoginSistema.UsuarioPermissao = new UsuarioPermissaoRegraNegocio().ConsultarPorCodigoUnico(usuario.Codigo.ToString());
                    else
                        LoginSistema.UsuarioPermissao = null;
                        backgroundWorkerLogin.ReportProgress(100);
                    }
            }
            catch (Exception exception)
            {
                erro = exception.Message;
                e.Cancel = true;
            }
        }

        private void backgroundWorkerLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if(e.Cancelled)
                {
                    txtSenha.Text = "";
                    txtUsuario.Enabled = true;
                    txtSenha.Enabled = true;
                    btnEntrar.Enabled = true;
                    progressBarLogin.Value = 0;
                    MensagemErro("Usuário ou senha inválida.");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void MensagemErro(string mensagem)
        {
            try
            {
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível logar no sistema." + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseclicked)
                this.Location = new Point(Cursor.Position.X - clickedAt.X, Cursor.Position.Y - clickedAt.Y);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            mouseclicked = true;
            clickedAt = e.Location;
        }

        private void FrmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseclicked = false;
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F6:
                        var frmConfigurarConexaoBD = new FrmConfigurarConexaoBD();
                        frmConfigurarConexaoBD.ShowDialog();
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
