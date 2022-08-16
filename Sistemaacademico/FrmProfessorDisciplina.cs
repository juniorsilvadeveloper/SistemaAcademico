using System;
using System.Windows.Forms;
using RegrasNegocio;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmProfessorDisciplina : Form
    {
        private Tela telaSelecionada;
        private ProfessorDisciplina professorDisciplinaSelecionada;
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
                AtualizarComboBoxProfessor(comboBoxInstituicao.SelectedValue.ToString());
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

        private void AtualizarComboBoxProfessor(string instituicao)
        {
            try
            {
                var professorRegraNegocio = new ProfessorRegraNegocio();
                comboBoxProfessor.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxProfessor.DataSource = professorRegraNegocio.Consultar(
                    instituicao,
                    null, null, null, "1");
                comboBoxProfessor.ValueMember = "Codigo";
                comboBoxProfessor.DisplayMember = "Nome";
                comboBoxProfessor.Update();
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

        private void btnAdicionarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                var frmProfessor = new FrmProfessor(Tela.Inserir, null);
                var dialogResult = frmProfessor.ShowDialog();
                AtualizarComboBoxProfessor(comboBoxInstituicao.SelectedValue.ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
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
                    AtualizarComboBoxProfessor(comboBoxInstituicao.SelectedValue.ToString());
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

        private void comboBoxProfessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxProfessor.FindString(comboBoxProfessor.Text);
                    comboBoxProfessor.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxProfessor_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxProfessor.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxProfessor.FindStringExact(text) < 0)
                {
                    this.comboBoxProfessor.SelectedIndex = -1;
                    if (comboBoxProfessor.Items.Count > 0)
                        this.comboBoxProfessor.SelectedIndex = 0;
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

        public FrmProfessorDisciplina()
        {
            InitializeComponent();
        }

        public FrmProfessorDisciplina(Tela tela, ProfessorDisciplina professorDisciplina)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            AtualizarComboBoxInstituicao();
            telaSelecionada = tela;            
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            professorDisciplinaSelecionada = professorDisciplina;
            if (tela == Tela.Inserir)
            {
                this.Text = "Professor / Disciplina - Cadastrar";
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
            if(tela == Tela.Exibir)
            {
                this.Text = "Professor / Disciplina - Consultar";
                comboBoxInstituicao.SelectedValue = professorDisciplina.Professor.Instituicao.Codigo;
                comboBoxProfessor.SelectedValue = professorDisciplina.Professor.Codigo;
                comboBoxDisciplina.SelectedValue = professorDisciplina.Disciplina.Codigo;
                if (professorDisciplina.Situacao)
                    radioButtonSituacaoAtivo.Checked = true;
                else
                    radioButtonSituacaoInativo.Checked = true;
                dateTimePickerDataCadastro.Text = professorDisciplina.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = professorDisciplina.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = professorDisciplina.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = professorDisciplina.UsuarioAlterou.NomeReal.ToString();
                if (professorDisciplina.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (professorDisciplina.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (professorDisciplina.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;
                comboBoxInstituicao.Enabled = false;
                comboBoxProfessor.Enabled = false;
                comboBoxDisciplina.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarProfessor.Enabled = false;
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
                    comboBoxProfessor.SelectedIndex == -1)
                    MessageBox.Show("Preencha todos os dados acima.", "Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var professorDisciplina = new ProfessorDisciplina()
                    {
                        Disciplina = new Disciplina() { Codigo = Convert.ToInt32(comboBoxDisciplina.SelectedValue) },
                        Professor = new Professor() { Codigo = Convert.ToInt32(comboBoxProfessor.SelectedValue) },
                        UsuarioAlterou = LoginSistema.UsuarioLogin,
                        Situacao = true
                    };
                    var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                    var retorno = professorDisciplinaRegraNegocio.Manipulacoes("1", professorDisciplina);
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

        private void FrmProfessorDisciplina_FormClosing(object sender, FormClosingEventArgs e)
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
