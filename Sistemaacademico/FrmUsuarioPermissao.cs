using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmUsuarioPermissao : Form
    {
        private Tela telaSelecionada;
        public FrmUsuarioPermissao()
        {
            InitializeComponent();
        }

        public FrmUsuarioPermissao(Tela tela, Usuario usuario)
        {
            InitializeComponent();
            telaSelecionada = tela;
            if(tela == Tela.Inserir)
            {
                txtCodigo.Text = usuario.Codigo.ToString();
                txtNome.Text = usuario.NomeReal.ToString();
                radioButtonAdministrador.Checked = usuario.Administrador;
                radioButtonSecretariado.Checked = usuario.Secretariado;
            }
            else if(tela == Tela.Alterar)
            {
                var usuarioPermissao = new UsuarioPermissaoRegraNegocio().ConsultarPorCodigoUnico(usuario.Codigo.ToString());
                if(usuarioPermissao.Usuario == null)
                {
                    txtCodigo.Text = usuario.Codigo.ToString();
                    txtNome.Text = usuario.NomeReal.ToString();
                    radioButtonAdministrador.Checked = usuario.Administrador;
                    radioButtonSecretariado.Checked = usuario.Secretariado;
                    telaSelecionada = Tela.Inserir;
                    return;
                }
                txtCodigo.Text = usuarioPermissao.Usuario.Codigo.ToString();
                txtCodigo.Name = usuarioPermissao.Usuario.NomeReal.ToString();
                checkBoxExportarBackup.Checked = usuarioPermissao.ExportarBackup;
                checkBoxImportarBackup.Checked = usuarioPermissao.ImportarBackup;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (telaSelecionada == Tela.Inserir)
                Salvar();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (Salvar())
            {
                MessageBox.Show("Permissão cadastrada com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }                
            else
                MessageBox.Show("Não foi possível gravar permissões.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean Salvar()
        {
            try
            {
                var usuarioPermissao = new UsuarioPermissao
                {
                    Usuario = new Usuario { Codigo = Convert.ToInt32(txtCodigo.Text) },
                    ExportarBackup = checkBoxExportarBackup.Checked,
                    ImportarBackup = checkBoxImportarBackup.Checked
                };
                if (telaSelecionada == Tela.Inserir)
                {
                    var retorno = new UsuarioPermissaoRegraNegocio().Manipulacoes("1", usuarioPermissao);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else
                {
                    var retorno = new UsuarioPermissaoRegraNegocio().Manipulacoes("2", usuarioPermissao);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }                
            }
            catch (Exception exception)
            {
                return false;
            }            
        }
    }
}
