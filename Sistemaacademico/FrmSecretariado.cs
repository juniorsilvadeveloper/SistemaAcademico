using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocios;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmSecretariado : Form
    {
        private void AtualizarComboBoxCargo()
        {
            try
            {
                var cargoRegraNegocio = new CargoRegraNegocio();
                var dataTable = cargoRegraNegocio.ComboBoxCargo();
                comboBoxCargo.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxCargo.DataSource = dataTable;
                comboBoxCargo.ValueMember = "Codigo";
                comboBoxCargo.DisplayMember = "Nome";
                comboBoxCargo.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
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
        private void PreencherDados(Secretariado secretariado)
        {
            try
            {
                txtCodigo.Text = secretariado.Codigo.ToString();
                txtNome.Text = secretariado.Nome.ToString();
                maskedTextBoxCPF.Text = secretariado.Cpf.ToString();
                txtIdentidade.Text = secretariado.Identidade.ToString();
                txtCNH.Text = secretariado.Cnh.ToString();
                dateTimePickerDataNascimento.Text = secretariado.DataNascimento.ToString();
                comboBoxGrauEscolar.SelectedValue = Convert.ToInt32(secretariado.GrauEscolar.Codigo);
                comboBoxCargo.SelectedValue = Convert.ToInt32(secretariado.Cargo.Codigo);
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(secretariado.Instituicao.Codigo);
                txtLogradouro.Text = secretariado.Logradouro.ToString();
                txtNumero.Text = secretariado.NumeroLogradouro.ToString();
                txtBairro.Text = secretariado.Bairro.ToString();
                txtComplemento.Text = secretariado.Complemento.ToString();
                comboBoxEstado.SelectedValue = Convert.ToInt32(secretariado.Cidade.Estado.Codigo);
                comboBoxCidade.SelectedValue = Convert.ToInt32(secretariado.Cidade.Codigo);
                maskedTextBoxCEP.Text = secretariado.Cep.ToString();
                if (secretariado.Telefone.ToString().Length == 10)
                    maskedTextBoxTelefone.Mask = "(##)####-####";
                maskedTextBoxTelefone.Text = secretariado.Telefone.ToString();
                txtEmail.Text = secretariado.Email.ToString();
                txtObservacoes.Text = secretariado.Observacao.ToString();
                if (secretariado.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Text = secretariado.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = secretariado.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = secretariado.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = secretariado.UsuarioAlterou.NomeReal.ToString();
                if (secretariado.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (secretariado.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (secretariado.UsuarioAlterou.Professor)
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
        private Secretariado secretariadoSelecionado = new Secretariado();
        public FrmSecretariado()
        {
            InitializeComponent();
        }

        public FrmSecretariado(Tela tela, Secretariado secretariado)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            telaSelecionada = tela;
            secretariadoSelecionado = secretariado;
            AtualizarComboEstado(null);
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();            
            AtualizarComboBoxGrauEscolar();
            AtualizarComboBoxCargo();
            if (tela == Tela.Inserir)
            {
                this.Text = "Secretariado - Novo";
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
                this.Text = "Secretariado - Alterar";
                txtNome.Focus();
                PreencherDados(secretariado);
            }
            else // Exibição
            {
                this.Text = "Secretariado - Exibir";
                PreencherDados(secretariado);
                txtNome.ReadOnly = true;
                maskedTextBoxCPF.ReadOnly = true;
                txtIdentidade.ReadOnly = true;
                txtCNH.ReadOnly = true;
                dateTimePickerDataNascimento.Enabled = false;
                comboBoxGrauEscolar.Enabled = false;
                comboBoxCargo.Enabled = false;
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
                btnCargoAdicionar.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnSalvar.Visible = false;
                btnCargoAdicionar.Enabled = false;

            }
        }

        private void comboBoxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEstado.SelectedValue != null && comboBoxEstado.ValueMember != "")
                    AtualizarComboCidade(comboBoxEstado.SelectedValue.ToString(), 
                        LoginSistema.Instituicao.Cidade.Codigo.ToString());
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
                var frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
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

        private void comboBoxCargo_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxCargo.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxCargo.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxCargo.SelectedIndex = -1;
                    if (comboBoxCargo.Items.Count > 0)
                        this.comboBoxCargo.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxCargo.FindString(comboBoxCargo.Text);
                    comboBoxCargo.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Secretariado BuscarDados()
        {
            try
            {
                var secretariado = new Secretariado();
                var grauEscolar = new GrauEscolar();
                var cargo = new Cargo();
                var instituicao = new Instituicao();
                var cidade = new Cidade();
                if (txtCodigo.Text != "")
                    secretariado.Codigo = Convert.ToInt32(txtCodigo.Text);
                secretariado.Nome = txtNome.Text.ToString();
                secretariado.Cpf = maskedTextBoxCPF.Text.ToString();
                secretariado.Identidade = txtIdentidade.Text.ToString();
                secretariado.Cnh = txtCNH.Text.ToString();
                secretariado.DataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text.ToString());
                grauEscolar.Codigo = Convert.ToInt32(comboBoxGrauEscolar.SelectedValue);
                secretariado.GrauEscolar = grauEscolar;
                cargo.Codigo = Convert.ToInt32(comboBoxCargo.SelectedValue);
                secretariado.Cargo = cargo;
                instituicao.Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue);
                secretariado.Instituicao = instituicao;
                secretariado.Logradouro = txtLogradouro.Text.ToString();
                secretariado.NumeroLogradouro = txtNumero.Text.ToString();
                secretariado.Bairro = txtBairro.Text.ToString();
                secretariado.Complemento = txtComplemento.Text.ToString();
                cidade.Codigo = Convert.ToInt32(comboBoxCidade.SelectedValue);
                secretariado.Cidade = cidade;
                secretariado.Cep = maskedTextBoxCEP.Text.ToString();
                secretariado.Telefone = maskedTextBoxTelefone.Text.ToString();
                secretariado.Email = txtEmail.Text.ToString();
                secretariado.Observacao = txtObservacoes.Text.ToString();
                if (radioButtonSituacaoAtivo.Checked)
                    secretariado.Situacao = true;
                else
                    secretariado.Situacao = false;
                secretariado.UsuarioAlterou = LoginSistema.UsuarioLogin;
                return secretariado;
            }
            catch (Exception exeption)
            {
                throw new Exception(exeption.Message);
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
                else if (txtLogradouro.Text == "")
                    MessageBox.Show("Digite o logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtNumero.Text == "")
                    MessageBox.Show("Digite o número do logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtBairro.Text == "")
                    MessageBox.Show("Digite o nome do bairro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (maskedTextBoxCEP.Text == "" || maskedTextBoxCEP.Text.Length < 8)
                    MessageBox.Show("Preencha o campo CEP corretamente.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?.", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var secretariado = BuscarDados();
                        var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                        string retorno = secretariadoRegraNegocio.Manipulacoes("1", secretariado);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            if (codigo == 0)
                                MessageBox.Show("Secretariado e usuário cadastrado com sucesso.", "Salvar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (MessageBox.Show("Secretariado cadastrado com sucesso, mas não foi possível realizar o cadastro do usuário. Deseja realizar o cadastro?", 
                                "Salvar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                var frmUsuario = new FrmUsuario(Tela.Inserir, Tela.Secretariado,
                                    new Usuario() { IdUsuario = codigo, Instituicao = secretariado.Instituicao });
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
                        var secretariado = BuscarDados();
                        var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                        string retorno = secretariadoRegraNegocio.Manipulacoes("2", secretariado);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Secretariado Alterado com sucesso.", "Salvar",
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

        private void btnCargoAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCargo = new FrmCargo(Tela.Inserir, null);
                frmCargo.ShowDialog();
                AtualizarComboBoxCargo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo cargo. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void FrmSecretariado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else
                    if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                    txtNome.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
