using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmCurso : Form
    {
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

        public FrmCurso()
        {
            InitializeComponent();
        }

        private Curso cursoSelecionado;
        private Tela telaSelecionada;

        private void PreencherDados(Curso curso)
        {
            try
            {
                txtCodigo.Text = curso.Codigo.ToString();
                txtNome.Text = curso.Nome.ToString();
                numericUpDownDuracaoPeriodo.Value = Convert.ToInt32(curso.DuracaoPeriodo);
                comboBoxInstituicao.SelectedValue = Convert.ToInt32(curso.Instituicao.Codigo);
                txtDescricao.Text = curso.Descricao.ToString();
                if (curso.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Value = Convert.ToDateTime(curso.DataCadastro);
                dateTimePickerDataAlteracao.Value = Convert.ToDateTime(curso.DataAlteracao);
                txtCodigoUsuarioAlterou.Text = curso.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = curso.UsuarioAlterou.NomeReal.ToString();
                if (curso.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (curso.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (curso.UsuarioAlterou.Professor)
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


        public FrmCurso(Tela tela, Curso curso)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            AtualizarComboBoxInstituicao();
            telaSelecionada = tela;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();            
            cursoSelecionado = curso;
            if (tela == Tela.Inserir)
            {
                this.Text = "Curso - Novo";
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
                txtNome.Focus();
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Curso - Alterar";
                PreencherDados(curso);
                txtNome.Focus();

            }
            else// Exibir
            {
                this.Text = "Curso - Exibir"; 
                PreencherDados(curso);
                txtNome.ReadOnly = true;
                comboBoxInstituicao.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                numericUpDownDuracaoPeriodo.Enabled = false;
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

        private Curso BuscarDados()
        {
            try
            {
                var curso = new Curso();
                if (txtCodigo.Text != "")
                    curso.Codigo = Convert.ToInt32(txtCodigo.Text);
                curso.Nome = Convert.ToString(txtNome.Text);
                curso.DuracaoPeriodo = Convert.ToInt32(numericUpDownDuracaoPeriodo.Value);
                var instituicao = new Instituicao();
                instituicao.Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue);
                curso.Instituicao = instituicao;
                curso.Descricao = Convert.ToString(txtDescricao.Text);
                curso.UsuarioAlterou = LoginSistema.UsuarioLogin;
                if (radioButtonSituacaoAtivo.Checked)
                    curso.Situacao = true;
                else
                    curso.Situacao = false;
                return curso;
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
                if (txtNome.Text == "")
                    MessageBox.Show("Digite o nome do curso.", "salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione uma instituição", "salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (numericUpDownDuracaoPeriodo.Value == 0)
                    MessageBox.Show("Selecione um valor para a duração do período maior que 0 (zero).", "Salvar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var cursoRegraNegocio = new CursoRegraNegocio();
                        string retorno = cursoRegraNegocio.Manipulacoes("1", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Curso cadastrado com sucesso.", "Salvar",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var cursoRegraNegocio = new CursoRegraNegocio();
                        var retorno = cursoRegraNegocio.Manipulacoes("2", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Curso alterado com sucesso.", "Salvar", 
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

        private void FrmCurso_FormClosing(object sender, FormClosingEventArgs e)
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
