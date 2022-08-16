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
using RegrasNegocios;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmDisciplina : Form
    {
        private void AtualizarComboBoxInstituicao()
        {
            try
            {
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                comboBoxInstituicao.DataSource = instituicaoRegraNegocio.CarregarComboBox(LoginSistema.Instituicao.Codigo.ToString());
                comboBoxInstituicao.DropDownStyle = ComboBoxStyle.DropDown;                
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

        private void preencherDados(Disciplina disciplina)
        {
            try
            {
                txtCodigo.Text = disciplina.Codigo.ToString();
                txtNome.Text = disciplina.Nome.ToString();
                numericUpDownCargaHoraria.Value = Convert.ToInt32(disciplina.CargaHoraria);
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(disciplina.Instituicao.Codigo);
                txtDescricao.Text = disciplina.Descricao.ToString();
                radioButtonSituacaoAtivo.Checked = true;
                if (!disciplina.Situacao)
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Value = Convert.ToDateTime(disciplina.DataCadastro);
                dateTimePickerDataAlteracao.Value = Convert.ToDateTime(disciplina.DataAlteracao);
                txtCodigoUsuarioAlterou.Text = disciplina.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = disciplina.UsuarioAlterou.NomeReal.ToString();
                if (disciplina.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (disciplina.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (disciplina.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;

            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Disciplina BuscarDados()
        {
            try
            {
                var disciplina = new Disciplina();
                if (txtCodigo.Text != "")
                    disciplina.Codigo = Convert.ToInt32(txtCodigo.Text);
                disciplina.Nome = Convert.ToString(txtNome.Text);
                disciplina.CargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                var instituicao = new Instituicao();
                instituicao.Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue);
                disciplina.Instituicao = instituicao;
                disciplina.Descricao = Convert.ToString(txtDescricao.Text);
                disciplina.UsuarioAlterou = LoginSistema.UsuarioLogin;
                if (radioButtonSituacaoAtivo.Checked)
                    disciplina.Situacao = true;
                else
                    disciplina.Situacao = false;
                return disciplina;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
        }
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private Disciplina disciplinaSelecionada;
        private Tela telaSelecionada;

        public FrmDisciplina(Tela tela, Disciplina disciplina)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;            
            telaSelecionada = tela;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            disciplinaSelecionada = disciplina;
            if (tela == Tela.Inserir)
            {
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
                this.Text = "Disciplina - Alterar";
                preencherDados(disciplina);                
                txtNome.Focus();
            }
            else 
            {
                this.Text = "Disciplina - Exibir";
                preencherDados(disciplina);
                txtNome.Focus();
                txtNome.ReadOnly = true;
                comboBoxInstituicao.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                numericUpDownCargaHoraria.Enabled = false;
                txtDescricao.ReadOnly = true;
                btnSalvar.Visible = false;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
            }
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                    MessageBox.Show("Digite o nome do curso.", "salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione uma instituição", "salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (numericUpDownCargaHoraria.Value == 0)
                    MessageBox.Show("Selecione um valor para a Carga Horária maior que 0 (zero).", "Salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                        string retorno = disciplinaRegraNegocio.Manipulacoes("1", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Disciplina cadastrado com sucesso.", "Salvar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                            txtNome.Text = "";
                            txtNome.Focus();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                        var retorno = disciplinaRegraNegocio.Manipulacoes("2", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Disciplina alterada com sucesso.", "Salvar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar a alteração. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmDisciplina_FormClosing(object sender, FormClosingEventArgs e)
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
