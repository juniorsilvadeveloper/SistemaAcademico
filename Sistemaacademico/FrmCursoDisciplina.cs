using System;
using System.Windows.Forms;
using RegrasNegocio;
using RegrasNegocios;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmCursoDisciplina : Form
    {
        private Tela telaSelecionada;
        private CursoDisciplina cursoDisciplinaSelecionada;
        private void AtualizarComboBoxInstituicao()
        {
            try
            {
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                comboBoxInstituicao.DataSource = instituicaoRegraNegocio.CarregarComboBox(
                    LoginSistema.Instituicao.Codigo.ToString());
                comboBoxInstituicao.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxInstituicao.ValueMember = "Codigo";
                comboBoxInstituicao.DisplayMember = "NomeFantasia";
                comboBoxInstituicao.Update();
                AtualizarComboBoxCurso(comboBoxInstituicao.SelectedValue.ToString());
                AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString());
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

        private void AtualizarComboBoxCurso(string instituicao)
        {
            try
            {
                var cursoRegraNegocio = new CursoRegraNegocio();
                comboBoxCurso.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxCurso.DataSource = cursoRegraNegocio.Consultar(                    
                    instituicao,
                    null, null, "1");
                comboBoxCurso.ValueMember = "Codigo";
                comboBoxCurso.DisplayMember = "Nome";
                comboBoxCurso.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AtualizarComboBoxDisciplina(string instituicao)
        {
            try
            {
                var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                comboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxDisciplina.DataSource = disciplinaRegraNegocio.Consultar(
                    null, null, instituicao, "1");
                comboBoxDisciplina.ValueMember = "Codigo";
                comboBoxDisciplina.DisplayMember = "Nome";
                comboBoxDisciplina.Update();
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
                var dialogResult = frmInstituicao.ShowDialog();
                AtualizarComboBoxInstituicao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCurso = new FrmCurso(Tela.Inserir, null);
                var dialogResult = frmCurso.ShowDialog();
                AtualizarComboBoxCurso(comboBoxInstituicao.SelectedValue.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo curso. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                var frmDisciplina = new FrmDisciplina(Tela.Inserir, null);
                var dialogResult = frmDisciplina.ShowDialog();
                AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituição_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxInstituicao.SelectedValue != null && comboBoxInstituicao.ValueMember != "")
                {
                    AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString());
                    AtualizarComboBoxCurso(comboBoxInstituicao.SelectedValue.ToString());
                }
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
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

        private void comboBoxCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxCurso.FindString(comboBoxCurso.Text);
                    comboBoxCurso.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxCurso_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxCurso.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxCurso.FindStringExact(text) < 0)
                {
                    this.comboBoxCurso.SelectedIndex = -1;
                    if (comboBoxCurso.Items.Count > 0)
                        this.comboBoxCurso.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxDisciplina.FindString(comboBoxDisciplina.Text);
                    comboBoxDisciplina.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxDisciplina_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxDisciplina.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxDisciplina.FindStringExact(text) < 0)
                {
                    this.comboBoxDisciplina.SelectedIndex = -1;
                    if (comboBoxDisciplina.Items.Count > 0)
                        this.comboBoxDisciplina.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        public FrmCursoDisciplina()
        {
            InitializeComponent();
        }

        public FrmCursoDisciplina(Tela tela, CursoDisciplina cursoDisciplina)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            AtualizarComboBoxInstituicao();
            telaSelecionada = tela;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            cursoDisciplinaSelecionada = cursoDisciplina;
            if (tela == Tela.Inserir)
            {
                this.Text = "Curso / Disciplina - Cadastrar";
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
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
            if (tela == Tela.Exibir)
            {
                this.Text = "Curso / Disciplina - Consultar";
                comboBoxInstituicao.SelectedValue = cursoDisciplina.Curso.Instituicao.Codigo;
                comboBoxCurso.SelectedValue = cursoDisciplina.Curso.Codigo;
                comboBoxDisciplina.SelectedValue = cursoDisciplina.Disciplina.Codigo;
                if (cursoDisciplina.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Text = cursoDisciplina.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = cursoDisciplina.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = cursoDisciplina.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = cursoDisciplina.UsuarioAlterou.NomeReal.ToString();
                if (cursoDisciplina.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (cursoDisciplina.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (cursoDisciplina.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;
                comboBoxInstituicao.Enabled = false;
                comboBoxCurso.Enabled = false;
                comboBoxDisciplina.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarCurso.Enabled = false;
                btnAdicionarDisciplina.Enabled = false;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
                btnSalvar.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxInstituicao.SelectedIndex == -1 || comboBoxDisciplina.SelectedIndex == -1 ||
                    comboBoxCurso.SelectedIndex == -1)
                    MessageBox.Show("Preencha todos os dados acima.", "Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var cursoDisciplina = new CursoDisciplina()
                    {
                        Disciplina = new Disciplina() { Codigo = Convert.ToInt32(comboBoxDisciplina.SelectedValue) },
                        Curso = new Curso() { Codigo = Convert.ToInt32(comboBoxCurso.SelectedValue) },
                        UsuarioAlterou = LoginSistema.UsuarioLogin,
                        Situacao = true
                    };
                    var cursoDisciplinaRegraNegocio = new CursoDisciplinaRegraNegocio();
                    var retorno = cursoDisciplinaRegraNegocio.Manipulacoes("1", cursoDisciplina);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Vinculação realizada com sucesso.", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmCursoDisciplina_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else
                    if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
