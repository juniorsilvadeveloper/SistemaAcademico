using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmConsultarUsuario : Form
    {

        private bool administrador = false, aluno = false, professor = false, secretariado = false;

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
            txtPesquisar.Visible = true;
        }

        public FrmConsultarUsuario()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
           if(LoginSistema.UsuarioLogin.Aluno || LoginSistema.UsuarioLogin.Professor)
            {
                groupBoxConsultar.Enabled = false;
               radioButtonCodigo.Checked = true;
                txtPesquisar.Text = LoginSistema.UsuarioLogin.Codigo.ToString();
                AtualizarGrid();
                btnNovoUsuario.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void radioButtonSituacaoAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCodigoOperador_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNomeUsuario_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void AtualizarGrid()
        {
            try
            {
                string situacao = null;
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";
                var usuarioRegraNegocio = new UsuarioRegraNegocio();
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = usuarioRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        radioButtonAluno.Checked == false ? null : "1",
                        radioButtonProfessor.Checked == false ? null : "1",
                        radioButtonSecretariado.Checked == false ? null : "1",
                        radioButtonAdministrador.Checked == false ? null : "1",
                        null,
                        null,
                        situacao,
                        null);
                    dataGridViewResultado.Update();
                    dataGridViewResultado.Refresh();
                }
                else if (radioButtonCodigoOperador.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = usuarioRegraNegocio.Consultar(
                        null,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        radioButtonAluno.Checked == false ? null : "1",
                        radioButtonProfessor.Checked == false ? null : "1",
                        radioButtonSecretariado.Checked == false ? null : "1",
                        radioButtonAdministrador.Checked == false ? null : "1",
                        txtPesquisar.Text.ToString(),
                        null,
                        situacao,
                        null);
                    dataGridViewResultado.Update();
                    dataGridViewResultado.Refresh();
                }
                else if (radioButtonNome.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = usuarioRegraNegocio.Consultar(
                        null,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                       radioButtonAluno.Checked == false ? null : "1",
                        radioButtonProfessor.Checked == false ? null : "1",
                        radioButtonSecretariado.Checked == false ? null : "1",
                        radioButtonAdministrador.Checked == false ? null : "1",
                        null,
                        null,
                        situacao,
                        txtPesquisar.Text.ToString());
                    dataGridViewResultado.Update();
                    dataGridViewResultado.Refresh();
                }
                else
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = usuarioRegraNegocio.Consultar(
                        null,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        radioButtonAluno.Checked == false ? null : "1",
                        radioButtonProfessor.Checked == false ? null : "1",
                        radioButtonSecretariado.Checked == false ? null : "1",
                        radioButtonAdministrador.Checked == false ? null : "1",
                        null,
                        txtPesquisar.Text.ToString(),
                        situacao,
                        null);
                    dataGridViewResultado.Update();
                    dataGridViewResultado.Refresh();
                }
                lblTotalRegistros.Text = $"Total Registro(s): {dataGridViewResultado.RowCount.ToString()}";
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }    

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (radioButtonCodigo.Checked)
                {
                    string KeyInput = e.KeyChar.ToString();
                    if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                        e.Handled = true;
                }
                if (e.KeyChar == 13)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewResultado.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewResultado.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewResultado.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewResultado.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void radioButtonAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            administrador = radioButtonAdministrador.Checked;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var usuario = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario);
                var frmUsuario = new FrmUsuario(Tela.Exibir, null, usuario);
                frmUsuario.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição do usuário. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                var frmUsuario = new FrmUsuario(Tela.Inserir, null, null);
                DialogResult dialogResult = frmUsuario.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo usuário. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarSituacao(Usuario usuario)
        {
            try
            {
                if (usuario.Aluno)
                {
                    var alunoRegraNegocio = new AlunoRegraNegocio();
                    var aluno = alunoRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(),null, null, null, null);
                        return aluno.Situacao;
                }
                else if (usuario.Professor)
                {
                    var professorRegraNegocio = new ProfessorRegraNegocio();
                    var professor = professorRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(), null);
                        return professor.Situacao;
                }
                else if (usuario.Secretariado)
                {
                    var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                    var secretariado = secretariadoRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(), null);
                        return secretariado.Situacao;
                }
                else
                    return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var usuario = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario);

                if (!usuario.Situacao)
                {
                    if (!ValidarSituacao(usuario))
                    {
                        MessageBox.Show("Não é possível alterar o usuário, pois o mesmo está desativado em sua carga principal (Aluno, Professor ou Secretariado)", "Alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                    }
                }

                var frmUsuario = new FrmUsuario(Tela.Alterar, null, usuario);
                    DialogResult dialogResult = frmUsuario.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                        AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração do usuário. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var usuario = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario);

                if (!usuario.Situacao)
                {
                    if (!ValidarSituacao(usuario))
                    {
                        MessageBox.Show("Não é possível alterar o usuário, pois o mesmo está desativado em sua carga principal (Aluno, Professor ou Secretariado)", "Alterar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (MessageBox.Show("Deseja Excluir o usuário selecioado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var usuarioRegraNegocio = new UsuarioRegraNegocio();
                string retorno = usuarioRegraNegocio.Manipulacoes("3", usuario);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    if (codigo != 0)
                        MessageBox.Show("Usuário selecionado excluído com sucesso.", "Excluir", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Usuário selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Usuário selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão do usuário. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResultado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                var usuario = dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario;

                if (usuario.Aluno)
                {
                    var alunoRegraNegocio = new AlunoRegraNegocio();
                    var frmAluno = new FrmAluno(Tela.Exibir, 
                        alunoRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(),null, null,null,
                        usuario.Instituicao.Codigo.ToString()));
                    frmAluno.ShowDialog();
                }
                else if (usuario.Professor)
                {
                    var professorRegraNegocio = new ProfessorRegraNegocio();
                    var frmProfessor = new FrmProfessor(Tela.Exibir,
                        professorRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(),
                        usuario.Instituicao.Codigo.ToString()));
                    frmProfessor.ShowDialog();
                }
                else if (usuario.Secretariado)
                {
                    var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                    var frmSecretariado = new FrmSecretariado(Tela.Exibir,
                        secretariadoRegraNegocio.ConsultarCodigoUnico(usuario.IdUsuario.ToString(),
                        usuario.Instituicao.Codigo.ToString()));
                    frmSecretariado.ShowDialog();
                }
                else
                {
                    var frmUsuario = new FrmUsuario(Tela.Exibir, null, usuario);
                    frmUsuario.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do usuário. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResultado_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewResultado.SelectedRows.Count != 0)
            {
                if (LoginSistema.UsuarioLogin.Administrador || LoginSistema.UsuarioLogin.Secretariado)
                {
                    var usuario = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario);
                    if (usuario.Administrador || usuario.Secretariado)
                        btnPermissoes.Visible = true;
                    else
                        btnPermissoes.Visible = false;
                }
                else
                    btnPermissoes.Visible = false;
            }
            else
                btnPermissoes.Visible = false;
        }

        private void btnPermissoes_Click(object sender, EventArgs e)
        {

            if (dataGridViewResultado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum usuário foi selecionado.", "Permissões", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            var frmUsuariopermissao = new FrmUsuarioPermissao(Tela.Alterar, dataGridViewResultado.SelectedRows[0].DataBoundItem as Usuario);
            frmUsuariopermissao.ShowDialog();

        }

        private void radioButtonAluno_CheckedChanged(object sender, EventArgs e)
        {
            aluno = radioButtonAluno.Checked;
        }

        private void radioButtonProfessor_CheckedChanged(object sender, EventArgs e)
        {
            professor = radioButtonProfessor.Checked;
        }

        private void radioButtonSecretariado_CheckedChanged(object sender, EventArgs e)
        {
            secretariado = radioButtonSecretariado.Checked;
        }        
    }
}
