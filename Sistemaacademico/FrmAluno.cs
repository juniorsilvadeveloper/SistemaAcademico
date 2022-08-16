using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmAluno : Form
    {
        private void AtualizarComboBoxGrauEscolar()
        {
            try
            {
                var grauEscolarRegraNegocio = new GrauEscolarRegraNegocio();
                var dataTable = grauEscolarRegraNegocio.CarregarComboBox();
                comboBoxGrauEscolar.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxGrauEscolar.DataSource = dataTable;
                comboBoxGrauEscolar.ValueMember = "Codigo";
                comboBoxGrauEscolar.DisplayMember = "Nome";
                comboBoxGrauEscolar.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
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
        public void AtualizarComboEstado(string estado)
        {
            try
            {
                var estadoRegraNegocio = new EstadoRegraNegocio();
                var dataTable = estadoRegraNegocio.ComboBoxEstado();
                comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxEstado.DataSource = dataTable;
                comboBoxEstado.ValueMember = "Codigo";
                comboBoxEstado.DisplayMember = "Sigla";
                if (estado != null)
                {
                    comboBoxEstado.SelectedValue = Convert.ToInt32(estado);
                    comboBoxEstado.Update();
                    AtualizarComboCidade(comboBoxEstado.SelectedValue.ToString(), LoginSistema.Instituicao.Cidade.Codigo.ToString());
                }
                else
                {
                    comboBoxEstado.Update();
                    AtualizarComboCidade(comboBoxEstado.SelectedValue.ToString(), null);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void AtualizarComboCidade(string estado, string cidade)
        {
            try
            {
                var cidadeRegraNegocio = new CidadeRegraNegocio();
                var dataTable = cidadeRegraNegocio.ComboBoxCidade(estado);
                comboBoxCidade.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxCidade.DataSource = dataTable;
                comboBoxCidade.ValueMember = "Codigo";
                comboBoxCidade.DisplayMember = "Nome";
                if (cidade != null)
                {
                    comboBoxCidade.SelectedValue = Convert.ToInt32(cidade);
                    comboBoxCidade.Update();
                }
                else
                    comboBoxCidade.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PreencherDados(Aluno aluno)
        {
            try
            {
                txtCodigo.Text = aluno.Codigo.ToString();
                txtNome.Text = aluno.Nome.ToString();
                maskedTextBoxCPF.Text = aluno.Cpf.ToString();
                txtIdentidade.Text = aluno.Identidade.ToString();
                txtCNH.Text = aluno.Cnh.ToString();
                dateTimePickerDataNascimento.Text = aluno.DataNascimento.ToString();
                comboBoxGrauEscolar.SelectedValue = Convert.ToInt32(aluno.GrauEscolar.Codigo);
                txtMatricula.Text = aluno.Matricula.ToString();
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(aluno.Instituicao.Codigo);
                txtLogradouro.Text = aluno.Logradouro.ToString();
                txtNumero.Text = aluno.NumeroLogradouro.ToString();
                txtBairro.Text = aluno.Bairro.ToString();
                txtComplemento.Text = aluno.Complemento.ToString();
                comboBoxEstado.SelectedValue = Convert.ToInt32(aluno.Cidade.Estado.Codigo);
                comboBoxCidade.SelectedValue = Convert.ToInt32(aluno.Cidade.Codigo);
                maskedTextBoxCEP.Text = aluno.Cep.ToString();
                if (aluno.Telefone.ToString().Length == 10)
                    maskedTextBoxTelefone.Mask = "(##)####-####";
                maskedTextBoxTelefone.Text = aluno.Telefone.ToString();
                txtEmail.Text = aluno.Email.ToString();
                txtObservacoes.Text = aluno.Observacao.ToString();
                if (aluno.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Text = aluno.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = aluno.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = aluno.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = aluno.UsuarioAlterou.NomeReal.ToString();
                if (aluno.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (aluno.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (aluno.UsuarioAlterou.Professor)
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

        private Tela telaSelecionada;
        private Aluno alunoSelecionada = new Aluno();
        public FrmAluno()
        {
            InitializeComponent();
        }

        public FrmAluno(Tela tela, Aluno aluno)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            alunoSelecionada = aluno;
            telaSelecionada = tela;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            AtualizarComboEstado(null);
            AtualizarComboBoxGrauEscolar();
            if (tela == Tela.Inserir)
            {
                this.Text = "Aluno - Novo";
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
                if (LoginSistema.Instituicao.Codigo != 1)
                {
                    comboBoxEstado.SelectedValue = LoginSistema.Instituicao.Cidade.Estado.Codigo;
                    comboBoxCidade.SelectedValue = LoginSistema.Instituicao.Cidade.Codigo;
                }
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Aluno - Alterar";
                txtNome.Focus();
                PreencherDados(aluno);
            }
            else // Exibição
            {
                this.Text = "Aluno - Exibir";
                PreencherDados(aluno);
                txtNome.ReadOnly = true;
                maskedTextBoxCPF.ReadOnly = true;
                txtIdentidade.ReadOnly = true;
                txtCNH.ReadOnly = true;
                dateTimePickerDataNascimento.Enabled = false;
                comboBoxGrauEscolar.Enabled = false;
                txtMatricula.ReadOnly = true;
                comboBoxInstituicao.Enabled = false;
                txtLogradouro.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                comboBoxEstado.Enabled = false;
                comboBoxCidade.Enabled = false;
                maskedTextBoxCEP.ReadOnly = true;
                maskedTextBoxTelefone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtObservacoes.ReadOnly = true;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
                btnGrauEscolarAdicionar.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnSalvar.Visible = false;
            }
        }

        private void comboBoxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEstado.SelectedValue != null && comboBoxEstado.ValueMember != "")
                    AtualizarComboCidade(comboBoxEstado.SelectedValue.ToString(), LoginSistema.Instituicao.Cidade.Codigo.ToString());
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxEstado.FindString(comboBoxEstado.Text);
                    comboBoxEstado.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxEstado_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxEstado.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxEstado.FindStringExact(text) < 0)
                {
                    this.comboBoxEstado.SelectedIndex = -1;
                    if (comboBoxEstado.Items.Count > 0)
                        this.comboBoxEstado.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxCidade.FindString(comboBoxCidade.Text);
                    comboBoxCidade.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxCidade_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCidade.SelectedIndex == -1)
                {
                    string text = comboBoxCidade.Text;
                    if (string.IsNullOrWhiteSpace(text) || comboBoxCidade.FindStringExact(text) < 0)
                    {
                        this.comboBoxCidade.SelectedIndex = -1;
                        if (comboBoxCidade.Items.Count > 0)
                            this.comboBoxCidade.SelectedIndex = 0;
                    }
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
                string textoCombo = comboBoxInstituicao.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxInstituicao.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxInstituicao.SelectedIndex = -1;
                    if (comboBoxInstituicao.Items.Count > 0)
                        this.comboBoxInstituicao.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
                AtualizarComboBoxInstituicao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxGrauEscolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxGrauEscolar.FindString(comboBoxGrauEscolar.Text);
                    comboBoxGrauEscolar.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxGrauEscolar_Leave(object sender, EventArgs e)
        {

            try
            {
                string textoCombo = comboBoxGrauEscolar.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxGrauEscolar.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxGrauEscolar.SelectedIndex = -1;
                    if (comboBoxGrauEscolar.Items.Count > 0)
                        this.comboBoxGrauEscolar.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Aluno BuscarDados()
        {
            try
            {
                var aluno = new Aluno();
                var grauEscolar = new GrauEscolar();
                var instituicao = new Instituicao();
                var cidade = new Cidade();
                if (txtCodigo.Text != "")
                    aluno.Codigo = Convert.ToInt32(txtCodigo.Text);
                aluno.Nome = txtNome.Text.ToString();
                aluno.Cpf = maskedTextBoxCPF.Text.ToString();
                aluno.Identidade = txtIdentidade.Text.ToString();
                aluno.Cnh = txtCNH.Text.ToString();
                aluno.DataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text.ToString());
                grauEscolar.Codigo = Convert.ToInt32(comboBoxGrauEscolar.SelectedValue);
                aluno.GrauEscolar = grauEscolar;
                aluno.Matricula = txtMatricula.Text.ToString();
                instituicao.Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue);
                aluno.Instituicao = instituicao;
                aluno.Logradouro = txtLogradouro.Text.ToString();
                aluno.NumeroLogradouro = txtNumero.Text.ToString();
                aluno.Bairro = txtBairro.Text.ToString();
                aluno.Complemento = txtComplemento.Text.ToString();
                cidade.Codigo = Convert.ToInt32(comboBoxCidade.SelectedValue);
                aluno.Cidade = cidade;
                aluno.Cep = maskedTextBoxCEP.Text.ToString();
                aluno.Telefone = maskedTextBoxTelefone.Text.ToString();
                aluno.Email = txtEmail.Text.ToString();
                aluno.Observacao = txtObservacoes.Text.ToString();
                if (radioButtonSituacaoAtivo.Checked)
                    aluno.Situacao = true;
                else
                    aluno.Situacao = false;
                aluno.UsuarioAlterou = LoginSistema.UsuarioLogin;
                return aluno;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data;
                if (txtNome.Text == "")
                    MessageBox.Show("Digite o nome.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (maskedTextBoxCPF.Text == "")
                    MessageBox.Show("Digite o CPF.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtIdentidade.Text == "")
                    MessageBox.Show("Digite o número de identidade.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (!DateTime.TryParse(dateTimePickerDataNascimento.Text.ToString(), out data))
                    MessageBox.Show("Digite a data de nascimento.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtMatricula.Text == "")
                    MessageBox.Show("Digite número da matrícula.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtLogradouro.Text == "")
                    MessageBox.Show("Digite o logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtNumero.Text == "")
                    MessageBox.Show("Digite o número do logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtBairro.Text == "")
                    MessageBox.Show("Digite o nome do bairro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (maskedTextBoxCEP.Text == "" || maskedTextBoxCEP.Text.Length < 8)
                    MessageBox.Show("Preencha o campo CEP corretamente.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        Aluno aluno = BuscarDados();
                        AlunoRegraNegocio alunoRegraNegocio = new AlunoRegraNegocio();
                        string retorno = alunoRegraNegocio.Manipulacoes("1", aluno);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            if (codigo == 0)
                                MessageBox.Show("Aluno e usuário cadastrado com sucesso.", "Salvar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (MessageBox.Show("Aluno cadastrado com sucesso, mas não foi possível realizar o cadastro do usuário. Deseja realizar o cadastro?", "Salvar",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                var frmUsuario = new FrmUsuario(Tela.Inserir, Tela.Aluno,
                                new Usuario() { IdUsuario = codigo, Instituicao = aluno.Instituicao });
                                frmUsuario.ShowDialog();
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
                        var aluno = BuscarDados();
                        var alunoRegraNegocio = new AlunoRegraNegocio();
                        string retorno = alunoRegraNegocio.Manipulacoes("2", aluno);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Aluno Alterado com sucesso.", "Salvar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Não foi possível realizar a alteração. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a operação selecionada. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxTelefone_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxTelefone.Text.ToString().Length == 10)
                maskedTextBoxTelefone.Mask = "(##)####-####";
            else
                maskedTextBoxTelefone.Mask = "(##)#####-####";
        }

        private void maskedTextBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxTelefone.Text.ToString().Length != 10)
                maskedTextBoxTelefone.Mask = "(##)#####-####";
        }

        private void btnGrauEscolarAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var frmGrauEscolar = new FrmGrauEscolar(Tela.Inserir, null);
                frmGrauEscolar.ShowDialog();
                AtualizarComboBoxGrauEscolar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo grau Escolar. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    txtNome.Focus();
                }                    
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
