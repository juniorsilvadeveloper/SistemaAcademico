using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace SistemaAcademico.Módulos.Acadêmico.Principal
{
    public partial class FrmTurma : Form
    {
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
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
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

        private void AtualizarComboBoxTurno()
        {
            try
            {
                var turnoRegraNegocio = new TurnoRegraNegocio();
                comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxTurno.DataSource = turnoRegraNegocio.ConsultarTurno();
                comboBoxTurno.ValueMember = "Codigo";
                comboBoxTurno.DisplayMember = "Nome";
                comboBoxTurno.Update();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxTurno_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxTurno.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxTurno.FindStringExact(text) < 0)
                {
                    this.comboBoxTurno.SelectedIndex = -1;
                    if (comboBoxTurno.Items.Count > 0)
                        this.comboBoxTurno.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxTurno.FindString(comboBoxTurno.Text);
                    comboBoxTurno.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void PreencherDados(Turma turma)
        {
            try
            {
                txtCodigo.Text = turma.Codigo.ToString();
                txtNome.Text = turma.Nome.ToString();
                comboBoxInstituicao.SelectedValue = turma.Instituicao.Codigo;
                comboBoxCurso.SelectedValue = turma.Curso.Codigo;
                comboBoxTurno.SelectedValue = turma.Turno.Codigo;
                maskedTextBoxDataInicio.Text = turma.DataInicio.ToString("dd/mm/yyyy");
                maskedTextBoxDataFim.Text = turma.DataFim.ToString();
                dateTimePickerDataCadastro.Text = turma.DataCadastro.ToString();
                dateTimePickerDataAlteracao.Text = turma.DataAlteracao.ToString();
                txtCodigoUsuarioAlterou.Text = turma.UsuarioAlterou.Codigo.ToString();
                txtNomeUsuarioAlterou.Text = turma.UsuarioAlterou.NomeReal.ToString();
                if (turma.UsuarioAlterou.Administrador)
                    checkBoxAdministrador.Checked = true;
                else if (turma.UsuarioAlterou.Aluno)
                    checkBoxAluno.Checked = true;
                else if (turma.UsuarioAlterou.Professor)
                    checkBoxProfessor.Checked = true;
                else
                    checkBoxSecretariado.Checked = true;
                switch (turma.SituacaoTurma.Codigo)
                {
                    case 1:
                        radioButtonSituacaoEmAndamento.Checked = true;
                        break;
                    case 2:
                        radioButtonSituacaoFinalizado.Checked = true;
                        break;
                    case 3:
                        radioButtonSituacaoCancelado.Checked = true;
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Tela telaSelecionada;
        private Turma turmaSelecionada = new Turma();

        public FrmTurma()
        {
            InitializeComponent();
        }

        public FrmTurma(Tela tela, Turma turma)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            telaSelecionada = tela;
            turmaSelecionada = turma;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();           
            AtualizarComboBoxTurno();
            if (tela == Tela.Inserir)
            {
                this.Text = "Turma - Inserir";
                comboBoxTurno.SelectedValue = 3;
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
                maskedTextBoxDataFim.Enabled = false;
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Turma - Alterar";
                PreencherDados(turma);

            }
            else // Exibir
            {
                this.Text = "Turma - Consultar";
                PreencherDados(turma);
                txtNome.ReadOnly = true;
                comboBoxInstituicao.Enabled = false;
                comboBoxCurso.Enabled = false;
                comboBoxTurno.Enabled = false;
                maskedTextBoxDataInicio.Enabled = false;
                radioButtonSituacaoEmAndamento.Enabled = false;
                radioButtonSituacaoFinalizado.Enabled = false;
                radioButtonSituacaoCancelado.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarCurso.Enabled = false;
                btnSalvar.Visible = false;
            }
        }

        private Turma BuscarDados()
        {
            int situacao;
            if (radioButtonSituacaoEmAndamento.Checked)
                situacao = 1;
            else if (radioButtonSituacaoFinalizado.Checked)
                situacao = 2;
            else
                situacao = 3;
            DateTime? datafim = null;
            if (maskedTextBoxDataFim.Text != "  /  /")
                datafim = Convert.ToDateTime(maskedTextBoxDataFim.Text);
            return new Turma()
            {
                Codigo = txtCodigo.Text != "" ? Convert.ToInt32(txtCodigo.Text) : 0,
                Nome = txtNome.Text.ToString(),
                Curso = new Curso() { Codigo = Convert.ToInt32(comboBoxCurso.SelectedValue) },
                Instituicao = new Instituicao() { Codigo = Convert.ToInt32(comboBoxInstituicao.SelectedValue) },
                Turno = new Turno() { Codigo = Convert.ToInt32(comboBoxTurno.SelectedValue) },
                SituacaoTurma = new SituacaoTurma() { Codigo = situacao },
                UsuarioAlterou = LoginSistema.UsuarioLogin,
                DataInicio = Convert.ToDateTime(maskedTextBoxDataInicio.Text),
                DataFim = datafim
            };
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty)
                {
                    MessageBox.Show("Digite o nome da turma.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                }
                
                else if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione a Instituição.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxCurso.SelectedIndex == -1)
                    MessageBox.Show("Selecione o curso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (maskedTextBoxDataInicio.Text == "  /  /")
                    MessageBox.Show("Selecione a data de início.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (maskedTextBoxDataFim.Text == "  /  /" && radioButtonSituacaoFinalizado.Checked)
                    MessageBox.Show("Selecione a data fim.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var turmaRegraNegocio = new TurmaRegraNegocio();
                        var retorno = turmaRegraNegocio.Manipulacoes("1", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma cadastrada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var turmaRegraNegocio = new TurmaRegraNegocio();
                        var retorno = turmaRegraNegocio.Manipulacoes("2", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma alterada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar a alteração da turma. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void maskedTextBoxDataInicio_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDataInicio.Text != "  /  /")
            {
                if (!ValidadorDados.ValidarData(maskedTextBoxDataInicio.Text))
                {
                    MessageBox.Show("Data início inválida.", "Data início", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    maskedTextBoxDataInicio.Focus();
                    return;
                }
            }
        }

        private void maskedTextBoxDataFim_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDataInicio.Text != "  /  /")
            {
                if (!ValidadorDados.ValidarData(maskedTextBoxDataFim.Text))
                {
                    MessageBox.Show("Data início inválida.", "Data início", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    maskedTextBoxDataFim.Focus();
                    return;
                }                
            }
        }

        private void radioButtonSituacaoFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDataFim.Enabled = true;
        }

        private void radioButtonSituacaoEmAndamento_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDataFim.Enabled = false;
        }

        private void radioButtonSituacaoCancelado_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxDataFim.Enabled = false;
        }

        private void comboBoxInstituicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarComboBoxTurno();
            AtualizarComboBoxCurso(comboBoxCurso.SelectedIndex.ToString());
            AtualizarComboBoxInstituicao();
        }
    }
}
