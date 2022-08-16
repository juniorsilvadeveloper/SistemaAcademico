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

namespace SistemaAcademico
{
    public partial class FrmInstituicao : Form
    {
        public Instituicao BuscarDados()
        {
            try
            {
                Instituicao instituicao = new Instituicao();
                Cidade cidade = new Cidade();
                if (txtCodigo.Text != "")
                    instituicao.Codigo = Convert.ToInt32(txtCodigo.Text);
                instituicao.NomeFantasia = txtNomeFantasia.Text.ToString();
                instituicao.RazaoSocial = txtRazaoSocial.Text.ToString();
                instituicao.Cnpj = maskedTextBoxCNPJ.Text.ToString();
                instituicao.InscricaoEstadual = txtInscricaoEstadual.Text.ToString();
                instituicao.Logradouro = txtLogradouro.Text.ToString();
                instituicao.NumeroLogradouro = txtNumero.Text.ToString();
                instituicao.Bairro = txtBairro.Text.ToString();
                instituicao.Complemento = txtComplemento.Text.ToString();
                cidade.Codigo = Convert.ToInt32(comboBoxCidade.SelectedValue);
                instituicao.Cidade = cidade;
                instituicao.Cep = maskedTextBoxCEP.Text.ToString();
                instituicao.Telefone = maskedTextBoxTelefone.Text.ToString();
                instituicao.Email = txtEmail.Text.ToString();
                instituicao.MediaNotaFinal = radioButtonMedia.Checked;
                instituicao.Observacao = txtObservacoes.Text.ToString();
                if (radioButtonSituacaoAtivo.Checked)
                    instituicao.Situacao = true;
                else
                    instituicao.Situacao = false;
                instituicao.UsuarioAlterou = LoginSistema.UsuarioLogin;

                instituicao.PorcentagemAprovacao = Convert.ToDouble(txtPorcentagemAprovacao.Text);
                instituicao.PorcentagemReprovacaoDireta = Convert.ToDouble(txtPorcentagemReprovacaoDireta.Text);
                instituicao.PorcentagemExameFinal = Convert.ToDouble(txtPorcentagemAprovacaoExameFinal.Text);
                instituicao.ConsiderarNotaTotalEtapaResultadoFinal = checkConsiderarNotaFinalEtapasExameFinal.Checked;


                return instituicao;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
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

        private void PreencherDados(Instituicao instituicao)
        {
            try
            {
                txtCodigo.Text = instituicao.Codigo.ToString();
                txtNomeFantasia.Text = instituicao.NomeFantasia.ToString();
                txtRazaoSocial.Text = instituicao.RazaoSocial.ToString();
                maskedTextBoxCNPJ.Text = instituicao.Cnpj.ToString();
                txtInscricaoEstadual.Text = instituicao.InscricaoEstadual.ToString();
                txtLogradouro.Text = instituicao.Logradouro.ToString();
                txtNumero.Text = instituicao.NumeroLogradouro.ToString();
                txtBairro.Text = instituicao.Bairro.ToString();
                txtComplemento.Text = instituicao.Complemento.ToString();
                comboBoxEstado.SelectedValue = Convert.ToInt32(instituicao.Cidade.Estado.Codigo);
                comboBoxCidade.SelectedValue = Convert.ToInt32(instituicao.Cidade.Codigo);
                maskedTextBoxCEP.Text = instituicao.Cep.ToString();
                if (instituicao.Telefone.ToString().Length == 10)
                    maskedTextBoxTelefone.Mask = "(##)####-####";
                maskedTextBoxTelefone.Text = instituicao.Telefone.ToString();
                txtEmail.Text = instituicao.Email.ToString();
                txtPorcentagemAprovacao.Text = instituicao.PorcentagemAprovacao.ToString();
                txtPorcentagemReprovacaoDireta.Text = instituicao.PorcentagemReprovacaoDireta.ToString();
                txtPorcentagemAprovacaoExameFinal.Text = instituicao.PorcentagemExameFinal.ToString();
                if (instituicao.ConsiderarNotaTotalEtapaResultadoFinal)
                    checkConsiderarNotaFinalEtapasExameFinal.Checked = true;

                if (instituicao.MediaNotaFinal)
                    radioButtonMedia.Checked = true;
                else
                    radioButtonSomatorio.Checked = true;
                
                txtObservacoes.Text = instituicao.Observacao.ToString();
                if (instituicao.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataAlteracao.Text = instituicao.DataAlteracao.ToString();
                dateTimePickerDataCadastro.Text = instituicao.DataCadastro.ToString();
                txtCodigoUsuarioAlterou.Text = instituicao.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = instituicao.UsuarioAlterou.NomeReal.ToString();
                if (instituicao.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (instituicao.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (instituicao.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;

                /*instituicao.PorcentagemAprovacao = Convert.ToDouble(txtPorcentagemAprovacao.Text);
                instituicao.PorcentagemReprovacaoDireta = Convert.ToDouble(txtPorcentagemReprovacaoDireta.Text);
                instituicao.PorcentagemExameFinal = Convert.ToDouble(txtPorcentagemAprovacaoExameFinal.Text);
                instituicao.ConsiderarNotaTotalEtapaResultadoFinal = checkConsiderarNotaFinalEtapasExameFinal.Checked;*/
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmInstituicao()
        {
            InitializeComponent();
        }

        private Tela telaSelecionada;
        private Instituicao instituicaoSelecionada = new Instituicao();
        public FrmInstituicao(Tela tela, Instituicao instituicao)
        {
            InitializeComponent();
            telaSelecionada = tela;
            instituicaoSelecionada = instituicao;
            AtualizarComboEstado(null);

            if (tela == Tela.Inserir)
            {
                this.Text = "Instituição - Novo";
                txtNomeFantasia.Focus();
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
                if (LoginSistema.Instituicao != null)
                {
                    comboBoxEstado.SelectedValue = LoginSistema.Instituicao.Cidade.Estado.Codigo;
                    comboBoxCidade.SelectedValue = LoginSistema.Instituicao.Cidade.Codigo;
                }
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Instituição - Alterar";
                txtNomeFantasia.Focus();

                PreencherDados(instituicao);
            }
            else // Tela Exibir
            {
                this.Text = "Instituição - Exibir";
                PreencherDados(instituicao);
                txtNomeFantasia.ReadOnly = true;
                txtRazaoSocial.ReadOnly = true;
                maskedTextBoxCNPJ.ReadOnly = true;
                txtInscricaoEstadual.ReadOnly = true;
                txtLogradouro.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                comboBoxCidade.Enabled = false;
                comboBoxEstado.Enabled = false;
                maskedTextBoxCEP.ReadOnly = true;
                maskedTextBoxTelefone.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPorcentagemAprovacao.ReadOnly = true;
                txtPorcentagemReprovacaoDireta.ReadOnly = true;
                txtPorcentagemAprovacaoExameFinal.ReadOnly = true;
                checkConsiderarNotaFinalEtapasExameFinal.Enabled = false;
                radioButtonMedia.Enabled = false;
                radioButtonSomatorio.Enabled = false;
                txtObservacoes.ReadOnly = true;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
                btnSalvar.Visible = false;
            }

        }

        private void comboBoxEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEstado.SelectedValue != null && comboBoxEstado.ValueMember != "")
                    AtualizarComboCidade(comboBoxEstado.SelectedValue.ToString(), LoginSistema.Instituicao == null ? null : LoginSistema.Instituicao.Cidade.Codigo.ToString());
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeFantasia.Text == "")
                    MessageBox.Show("Digite o nome fantasia.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtRazaoSocial.Text == "")
                    MessageBox.Show("Digite a razao social.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (maskedTextBoxCNPJ.Text == "")
                    MessageBox.Show("Digite o CNPJ.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtLogradouro.Text == "")
                    MessageBox.Show("Digite o logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtNumero.Text == "")
                    MessageBox.Show("Digite o número do logradouro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtBairro.Text == "")
                    MessageBox.Show("Digite o nome do bairro.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (maskedTextBoxCEP.Text == "" || maskedTextBoxCEP.Text.Length < 8)
                    MessageBox.Show("Preencha o campo CEP corretamente.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtPorcentagemAprovacao.Text == "0")
                    MessageBox.Show("Digite a média para aprovação com valor maior que 0.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtPorcentagemReprovacaoDireta.Text == "0")
                    MessageBox.Show("Digite a média para reprovação direta com valor maior que 0.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (txtPorcentagemAprovacaoExameFinal.Text == "0")
                    MessageBox.Show("Digite a média para aprovação no exame final com valor maior que 0.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?.", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        Instituicao instituicao = BuscarDados();

                        InstituicaoRegraNegocio instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                        string retorno = instituicaoRegraNegocio.Manipulacoes("1", instituicao);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Instituição cadastrada com sucesso. \nCódigo da instituição: " + codigo,
                                "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        Instituicao instituicao = BuscarDados();
                        InstituicaoRegraNegocio instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                        string retorno = instituicaoRegraNegocio.Manipulacoes("2", instituicao);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Instituição alterada com sucesso. \nCódigo da instituição: " + codigo,
                                "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FrmInstituicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else
                    if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                    txtNomeFantasia.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPorcentagemAprovacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {               
                string KeyInput = e.KeyChar.ToString();
                if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == ',') && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                    e.Handled = true;
                if (e.KeyChar == ',' && txtPorcentagemAprovacao.Text == "")
                    e.Handled = true;
                if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
                    e.Handled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPorcentagemReprovacaoDireta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string KeyInput = e.KeyChar.ToString();
                if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == ',') && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                    e.Handled = true;
                if (e.KeyChar == ',' && txtPorcentagemReprovacaoDireta.Text == "")
                    e.Handled = true;
                if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
                    e.Handled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPorcentagemAprovacaoExameFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string KeyInput = e.KeyChar.ToString();
                if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == ',') && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                    e.Handled = true;
                if (e.KeyChar == ',' && txtPorcentagemAprovacaoExameFinal.Text == "")
                    e.Handled = true;
                if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
                    e.Handled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtPorcentagemAprovacao_Leave(object sender, EventArgs e)
        {
            if (txtPorcentagemAprovacao.Text == "")
                txtPorcentagemAprovacao.Text = "0";
        }

        private void txtReprovacaoDireta_Leave(object sender, EventArgs e)
        {
            if (txtPorcentagemReprovacaoDireta.Text == "")
                txtPorcentagemReprovacaoDireta.Text = "0";
        }

        private void txtPorcentagemAprovacaoExameFinal_Leave(object sender, EventArgs e)
        {
            if (txtPorcentagemAprovacaoExameFinal.Text == "")
                txtPorcentagemAprovacaoExameFinal.Text = "0";
        }        
    }
}
