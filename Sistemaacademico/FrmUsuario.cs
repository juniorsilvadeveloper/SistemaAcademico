using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmUsuario : Form
    {
        private Tela telaSelecionada;
        private Usuario usuarioSelecionado;

        private void AtualizarComboBoxInstituicao()
        {
            try
            {
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                var dataTable = instituicaoRegraNegocio.CarregarComboBox(LoginSistema.Instituicao.Codigo.ToString());
                comboBoxInstituicao.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxInstituicao.DataSource = dataTable;
                comboBoxInstituicao.ValueMember = "Codigo";
                comboBoxInstituicao.DisplayMember = "NomeFantasia";
                comboBoxInstituicao.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AtualizarComboBoxInstituicaoTodas()
        {
            try
            {
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                comboBoxInstituicao.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxInstituicao.DataSource = instituicaoRegraNegocio.Consultar(null, "", null, null, null);
                comboBoxInstituicao.ValueMember = "Codigo";
                comboBoxInstituicao.DisplayMember = "NomeFantasia";
                comboBoxInstituicao.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PreencherCampos(Usuario usuario)
        {
            try
            {
                txtCodigo.Text = usuario.Codigo.ToString();
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(usuario.Instituicao.Codigo);

                radioButtonAdministrador.Checked = usuario.Administrador;
                radioButtonAluno.Checked = usuario.Aluno;
                radioButtonProfessor.Checked = usuario.Professor;
                radioButtonSecretariado.Checked = usuario.Secretariado;

                txtCodigoOperador.Text = usuario.IdUsuario.ToString();
                txtNome.Text = usuario.NomeReal.ToString();
                txtNomeUsuario.Text = usuario.NomeUsuario.ToString();
                txtSenha.Text = usuario.Senha.ToString();
                txtConfirmacaoSenha.Text = usuario.Senha.ToString();

                if (!radioButtonAdministrador.Checked)
                    comboBoxUsuario.SelectedValue = usuario.IdUsuario;
                else
                    txtCodigoOperador.Text = usuario.IdUsuario.ToString();
                    txtNome.Text = usuario.NomeReal.ToString();
                    txtNomeUsuario.Text = usuario.NomeUsuario.ToString();
                    txtSenha.Text = usuario.Senha.ToString();

                if (usuario.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;

                dateTimePickerDataCadastro.Text = usuario.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = usuario.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = usuario.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = usuario.UsuarioAlterou.NomeReal.ToString();

                if (usuario.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (usuario.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (usuario.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AtualizarComboBoxUsuario()
        {
            try
            {
                comboBoxUsuario.DropDownStyle = ComboBoxStyle.DropDown;

                if (radioButtonAluno.Checked)
                {
                    var alunoRegraNegocio = new AlunoRegraNegocio();
                    comboBoxUsuario.DataSource = telaSelecionada == Tela.Inserir ? 
                        (object)alunoRegraNegocio.CarregarComboUsuarioInserir()
                        :
                        alunoRegraNegocio.Consultar(
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                null, null, null, null, null);
                }
                else if (radioButtonProfessor.Checked)
                {
                    var professorRegraNegocio = new ProfessorRegraNegocio();
                    comboBoxUsuario.DataSource = telaSelecionada == Tela.Inserir ?
                        (object)professorRegraNegocio.CarregarComboUsuarioInserir()
                        :
                        professorRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                null, null, null, null);
                }
                else if (radioButtonSecretariado.Checked)
                {
                    var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                    comboBoxUsuario.DataSource = telaSelecionada == Tela.Inserir ?
                        (object)secretariadoRegraNegocio.CarregarComboUsuarioInserir()
                        :
                        secretariadoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                null, null, null, null);
                }
                comboBoxUsuario.ValueMember = "Codigo";
                comboBoxUsuario.DisplayMember = "Nome";
                comboBoxUsuario.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void BloquearControles()
        {
            radioButtonAdministrador.Enabled = false;
            radioButtonAluno.Enabled = false;
            radioButtonProfessor.Enabled = false;
            radioButtonSecretariado.Enabled = false;
            comboBoxUsuario.Enabled = false;
            comboBoxInstituicao.Enabled = false;
            btnAdicionarInstituicao.Enabled = false;
            btnAdicionarUsuario.Enabled = false;
            txtNome.ReadOnly = true;
        }

        public FrmUsuario(Tela tela, Tela ? telaTipoUsuario, Usuario usuario)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            telaSelecionada = tela;
            usuarioSelecionado = usuario;
            AtualizarComboBoxInstituicao();
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            if (tela == Tela.Inserir)
            {
                if (telaTipoUsuario == Tela.Aluno)
                {
                    radioButtonAluno.Checked = true;
                    comboBoxUsuario.SelectedValue = usuario.IdUsuario;
                    comboBoxInstituicao.SelectedValue = usuario.Instituicao.Codigo;
                    txtCodigoOperador.Text = usuario.IdUsuario.ToString();
                    BloquearControles();
                }
                else if (telaTipoUsuario == Tela.Professor)
                {
                    radioButtonProfessor.Checked = true;
                    comboBoxUsuario.SelectedValue = usuario.IdUsuario;
                    comboBoxInstituicao.SelectedValue = usuario.Instituicao.Codigo;
                    txtCodigoOperador.Text = usuario.IdUsuario.ToString();
                    BloquearControles();
                }
                else if (telaTipoUsuario == Tela.Secretariado)
                {
                    radioButtonSecretariado.Checked = true;
                    comboBoxUsuario.SelectedValue = usuario.IdUsuario;
                    comboBoxInstituicao.SelectedValue = usuario.Instituicao.Codigo;
                    txtCodigoOperador.Text = usuario.IdUsuario.ToString();
                    BloquearControles();
                }
                this.Text = "Usuário - Novo";
                txtNome.Focus();
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
                lblDataCadastro.Visible = false;
                lblDataAlteracao.Visible = false;
                dateTimePickerDataCadastro.Visible = false;
                dateTimePickerDataAlteracao.Visible = false;
                lblUsuarioAlterou.Visible = false;
                txtCodigoUsuarioAlterou.Visible = false;
                txtNomeUsuarioAlterou.Visible = false;
                checkBoxAdministrador.Visible = false;
                checkBoxAluno.Visible = false;
                checkBoxProfessor.Visible = false;
                checkBoxSecretariado.Visible = false;
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Usuário - Alterar";
                txtNome.Focus();
                PreencherCampos(usuario);
                BloquearControles();
            }
            else //Exibir
            {
                this.Text = "Usuário - Exibir";
                PreencherCampos(usuario);
                BloquearControles();
                txtNomeUsuario.ReadOnly = true;
                txtSenha.ReadOnly = true;
                lblConfirmacao.Visible = false;
                txtConfirmacaoSenha.Visible = false;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarUsuario.Enabled = false;
                btnSalvar.Visible = false;
                linkDica.Visible = false;
            }
        }
        private void ControlarCampos()
        {
            if (!radioButtonAdministrador.Checked)
            {
                comboBoxUsuario.Visible = true;
                btnAdicionarUsuario.Visible = true;
                txtNome.Visible = false;
                comboBoxUsuario.Text = string.Empty;
                AtualizarComboBoxUsuario();
                return;
            }
            else
            {
                comboBoxUsuario.Visible = false;
                btnAdicionarUsuario.Visible = false;
                txtNome.Visible = true;
            }
        }

        private void radioButtonAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            ControlarCampos();
            txtCodigoOperador.Text = "0";
        }

        private void radioButtonAluno_CheckedChanged(object sender, EventArgs e)
        {
            ControlarCampos();
        }

        private void radioButtonProfessor_CheckedChanged(object sender, EventArgs e)
        {
            ControlarCampos();
        }

        private void radioButtonSecretariado_CheckedChanged(object sender, EventArgs e)
        {
            ControlarCampos();
        }

        private void btnAdicionarInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                var frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                var dialogResult = frmInstituicao.ShowDialog();
                AtualizarComboBoxInstituicao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {

            if (radioButtonAluno.Checked)
            {
                var frmAluno = new FrmAluno(Tela.Inserir, null);
                if (frmAluno.ShowDialog() == DialogResult.Yes)
                    AtualizarComboBoxUsuario();
            }
            else if (radioButtonProfessor.Checked)
            {
                var frmProfessor = new FrmProfessor(Tela.Inserir, null);
                if (frmProfessor.ShowDialog() == DialogResult.Yes)
                    AtualizarComboBoxUsuario();
            }
            else
            {
                var frmSecretariado = new FrmSecretariado(Tela.Inserir, null);
                if (frmSecretariado.ShowDialog() == DialogResult.Yes)
                    AtualizarComboBoxUsuario();
            }
        }

        private void comboBoxInstituicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxInstituicao.FindString(comboBoxInstituicao.Text);
                    comboBoxInstituicao.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituicao_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxInstituicao.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxInstituicao.FindStringExact(text) < 0)
                {
                    this.comboBoxInstituicao.SelectedIndex = -1;
                    if (comboBoxInstituicao.Items.Count > 0)
                        this.comboBoxInstituicao.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxUsuario.FindString(comboBoxUsuario.Text);
                    comboBoxUsuario.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxUsuario_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxUsuario.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxUsuario.FindStringExact(text) < 0)
                {
                    this.comboBoxUsuario.SelectedIndex = -1;
                    if (comboBoxUsuario.Items.Count > 0)
                        this.comboBoxUsuario.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUsuario.SelectedValue != null && comboBoxUsuario.ValueMember != "")
                    txtCodigoOperador.Text = comboBoxUsuario.SelectedValue.ToString();
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private Usuario BuscarDados()
        {
            var usuario = new Usuario();
            if (txtCodigo.Text != string.Empty)
                usuario.Codigo = Convert.ToInt32(txtCodigo.Text);
            usuario.Administrador = radioButtonAdministrador.Checked;
            usuario.Aluno = radioButtonAluno.Checked;
            usuario.Professor = radioButtonProfessor.Checked;
            usuario.Secretariado = radioButtonSecretariado.Checked;
            usuario.IdUsuario = !radioButtonAdministrador.Checked ? Convert.ToInt32(comboBoxUsuario.SelectedValue) : 15;
            usuario.NomeReal = !radioButtonAdministrador.Checked 
                ? comboBoxUsuario.Text.ToString() 
                : txtNome.Text.ToString();
            usuario.NomeUsuario = txtNomeUsuario.Text.ToString();
            usuario.Senha = txtSenha.Text.ToString();
            usuario.Situacao = radioButtonSituacaoAtivo.Checked ? true : false;
            usuario.UsuarioAlterou = LoginSistema.UsuarioLogin;
            usuario.Instituicao = new Instituicao() { Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue) };

            return usuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButtonAdministrador.Checked && txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Digite o nome do usuário administrador.", "Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (!radioButtonAdministrador.Checked && comboBoxUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione o usuário para realizar a operação.", "Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                  
                if ((txtNomeUsuario.Text == string.Empty || txtNomeUsuario.Text.Length < 8 ||
                    txtNomeUsuario.Text.Length > 20) && 
                    (telaSelecionada == Tela.Alterar && txtNomeUsuario.Text != usuarioSelecionado.NomeUsuario))
                    MessageBox.Show("Digite o nome do usuário com tamanho de 8 a 20 caracteres.", "Salvar", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtSenha.Text == string.Empty || txtSenha.Text.Length < 6 || txtSenha.Text.Length > 16)
                    MessageBox.Show("Digite a senha do usuário com tamanho de 6 a 16 caracteres.", "Salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (telaSelecionada == Tela.Inserir && txtSenha.Text != txtConfirmacaoSenha.Text)
                    MessageBox.Show("Senhas não conferem.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var usuario = BuscarDados();
                        var usuarioRegraNegocio = new UsuarioRegraNegocio();
                        var retorno = usuarioRegraNegocio.Manipulacoes("1", usuario);
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Usuário cadastrado com sucesso", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            if(usuario.Administrador || usuario.Secretariado)
                            {
                                var frmUsuariopermissao = new FrmUsuarioPermissao(Tela.Inserir, usuario);
                                frmUsuariopermissao.ShowDialog();
                            }
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var usuario = BuscarDados();
                        var usuarioRegraNegocio = new UsuarioRegraNegocio();
                        var retorno = usuarioRegraNegocio.Manipulacoes("2", usuario);
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Usuário alterado com sucesso", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Não foi possível alterar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a operação. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void FrmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else
                    if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                    txtNomeUsuario.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
