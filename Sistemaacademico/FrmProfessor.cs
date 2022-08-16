using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmProfessor : Form
    {
        private void AtualizarComboBoxGrauEscolar()
        {
            try
            {
                GrauEscolarRegraNegocio grauEscolarRegraNegocio = new GrauEscolarRegraNegocio();
                DataTable dataTable = grauEscolarRegraNegocio.CarregarComboBox();
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
                InstituicaoRegraNegocio instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                DataTable dataTable = instituicaoRegraNegocio.CarregarComboBox(LoginSistema.Instituicao.Codigo.ToString());
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
                EstadoRegraNegocio estadoRegraNegocio = new EstadoRegraNegocio();
                DataTable dataTable = estadoRegraNegocio.ComboBoxEstado();
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
                CidadeRegraNegocio cidadeRegraNegocio = new CidadeRegraNegocio();
                DataTable dataTable = cidadeRegraNegocio.ComboBoxCidade(estado);
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

        private void PreencherDados(Professor professor)
        {
            try
            {
                txtCodigo.Text = professor.Codigo.ToString();
                txtNome.Text = professor.Nome.ToString();
                maskedTextBoxCPF.Text = professor.Cpf.ToString();
                txtIdentidade.Text = professor.Identidade.ToString();
                txtCNH.Text = professor.Cnh.ToString();
                dateTimePickerDataNascimento.Text = professor.DataNascimento.ToString();
                comboBoxGrauEscolar.SelectedValue = Convert.ToInt32(professor.GrauEscolar.Codigo);
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(professor.Instituicao.Codigo);
                txtLogradouro.Text = professor.Logradouro.ToString();
                txtNumero.Text = professor.NumeroLogradouro.ToString();
                txtBairro.Text = professor.Bairro.ToString();
                txtComplemento.Text = professor.Complemento.ToString();
                comboBoxEstado.SelectedValue = Convert.ToInt32(professor.Cidade.Estado.Codigo);
                comboBoxCidade.SelectedValue = Convert.ToInt32(professor.Cidade.Codigo);
                maskedTextBoxCEP.Text = professor.Cep.ToString();
                if (professor.Telefone.ToString().Length == 10)
                    maskedTextBoxTelefone.Mask = "(##)####-####";
                maskedTextBoxTelefone.Text = professor.Telefone.ToString();
                txtEmail.Text = professor.Email.ToString();
                txtObservacoes.Text = professor.Observacao.ToString();
                if (professor.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Text = professor.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = professor.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = professor.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = professor.UsuarioAlterou.NomeReal.ToString();
                if (professor.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (professor.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (professor.UsuarioAlterou.Professor)
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
        private Professor professorSelecionado = new Professor();

        public FrmProfessor()
        {
            InitializeComponent();
        }

        public FrmProfessor(Tela tela, Professor professor)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            telaSelecionada = tela;                      
            professorSelecionado = professor;
            AtualizarComboEstado(null);
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            AtualizarComboBoxGrauEscolar();
            if (tela == Tela.Inserir)
            {
                this.Text = "Professor - Novo";
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
                this.Text = "Professor - Alterar";
                txtNome.Focus();
                PreencherDados(professor);
            }
            else // Exibição
            {
                this.Text = "Professor - Exibir";
                PreencherDados(professor);
                txtNome.ReadOnly = true;
                maskedTextBoxCPF.ReadOnly = true;
                txtIdentidade.ReadOnly = true;
                txtCNH.ReadOnly = true;
                dateTimePickerDataNascimento.Enabled = false;
                comboBoxGrauEscolar.Enabled = false;
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

        private Professor BuscarDados()
        {
            try
            {
                Professor professor = new Professor();
                GrauEscolar grauEscolar = new GrauEscolar();
                Instituicao instituicao = new Instituicao();
                Cidade cidade = new Cidade();
                if (txtCodigo.Text != "")
                    professor.Codigo = Convert.ToInt32(txtCodigo.Text);
                professor.Nome = txtNome.Text.ToString();
                professor.Cpf = maskedTextBoxCPF.Text.ToString();
                professor.Identidade = txtIdentidade.Text.ToString();
                professor.Cnh = txtCNH.Text.ToString();
                professor.DataNascimento = Convert.ToDateTime(dateTimePickerDataNascimento.Text.ToString());
                grauEscolar.Codigo = Convert.ToInt32(comboBoxGrauEscolar.SelectedValue);
                professor.GrauEscolar = grauEscolar;
                instituicao.Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue);
                professor.Instituicao = instituicao;
                professor.Logradouro = txtLogradouro.Text.ToString();
                professor.NumeroLogradouro = txtNumero.Text.ToString();
                professor.Bairro = txtBairro.Text.ToString();
                professor.Complemento = txtComplemento.Text.ToString();
                cidade.Codigo = Convert.ToInt32(comboBoxCidade.SelectedValue);
                professor.Cidade = cidade;
                professor.Cep = maskedTextBoxCEP.Text.ToString();
                professor.Telefone = maskedTextBoxTelefone.Text.ToString();
                professor.Email = txtEmail.Text.ToString();
                professor.Observacao = txtObservacoes.Text.ToString();
                if (radioButtonSituacaoAtivo.Checked)
                    professor.Situacao = true;
                else
                    professor.Situacao = false;
                professor.UsuarioAlterou = LoginSistema.UsuarioLogin;
                return professor;
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
                        Professor professor = BuscarDados();
                        ProfessorRegraNegocio professorRegraNegocio = new ProfessorRegraNegocio();
                        string retorno = professorRegraNegocio.Manipulacoes("1", professor);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            if (codigo == 0)
                                MessageBox.Show("Professor e usuário cadastrado com sucesso.", "Salvar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else if (MessageBox.Show("Professor cadastrado com sucesso, mas não foi possível realizar o cadastro do usuário. Deseja realizar o cadastro?", 
                                "Salvar",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                var frmUsuario = new FrmUsuario(Tela.Inserir, Tela.Professor,
                                    new Usuario() { IdUsuario = codigo, Instituicao = professor.Instituicao });
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
                        Professor professor = BuscarDados();
                        ProfessorRegraNegocio professorRegraNegocio = new ProfessorRegraNegocio();
                        string retorno = professorRegraNegocio.Manipulacoes("2", professor);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Professor Alterado com sucesso.", "Salvar",
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
                FrmGrauEscolar frmGrauEscolar = new FrmGrauEscolar(Tela.Inserir, null);
                frmGrauEscolar.ShowDialog();
                AtualizarComboBoxGrauEscolar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo grau Escolar. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmProfessor_FormClosing(object sender, FormClosingEventArgs e)
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
