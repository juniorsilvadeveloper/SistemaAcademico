using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmDisciplinasMinistradas : Form
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
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
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

        private void AtualizarComboBoxProfessor(string situacao)
        {
            try
            {
                if (comboBoxDisciplina.SelectedIndex == -1)
                    return;

                var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                comboBoxProfessor.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxProfessor.DataSource = professorDisciplinaRegraNegocio.Consultar(
                null,
                null, 
                comboBoxDisciplina.SelectedValue.ToString(), 
                null, 
                situacao, 
                null);
                comboBoxProfessor.ValueMember = "CodigoProfessor";
                comboBoxProfessor.DisplayMember = "NomeProfessor";
                comboBoxProfessor.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AtualizarComboBoxDisciplina(string instituicao, string situacao)
        {
            try
            {
                if (comboBoxDisciplina.SelectedIndex == -1)
                    return;
                var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                comboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxDisciplina.DataSource = professorDisciplinaRegraNegocio.Consultar(
                    null, null, null, null, situacao, instituicao);
                comboBoxDisciplina.ValueMember = "CodigoDisciplina";
                comboBoxDisciplina.DisplayMember = "NomeDisciplina";
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
                AtualizarComboBoxProfessor(telaSelecionada == Tela.Exibir ? null : "1");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo professor. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                var frmDisciplina = new FrmDisciplina(Tela.Inserir, null);
                var dialogResult = frmDisciplina.ShowDialog();
                AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString(), telaSelecionada == Tela.Exibir ? null : "1");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova disciplina. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Tela telaSelecionada;
        private PeriodoDisciplina periodoDisciplina;
        public FrmDisciplinasMinistradas()
        {
            InitializeComponent();
        }

        public FrmDisciplinasMinistradas(Tela tela, PeriodoDisciplina periodoDisciplina)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            this.telaSelecionada = tela;
            this.periodoDisciplina = periodoDisciplina;
            if (tela == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString(),
               tela == Tela.Exibir ? null : "1");
            AtualizarComboBoxProfessor(tela == Tela.Exibir ? null : "1");

            if (tela == Tela.Inserir)
            {
                this.Text = "Disciplinas Ministradas - Inserir";
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
                this.Text = "Disciplinas Ministradas - Alterar";
                PreencherDados(periodoDisciplina);
            }
            else
            {
                this.Text = "Disciplinas Ministradas - Exibir";
                PreencherDados(periodoDisciplina);
                comboBoxInstituicao.Enabled = false;
                comboBoxDisciplina.Enabled = false;
                comboBoxProfessor.Enabled = false;
                btnSalvar.Visible = false;
                linkLabelVincularDisciplinaAoProfessor.Visible = false;
                btnAdicionarDisciplina.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarProfessor.Enabled = false;
            }
        }

        private void PreencherDados(PeriodoDisciplina periodoDisciplina)
        {
            txtCodigo.Text = periodoDisciplina.Codigo.ToString();
            comboBoxInstituicao.SelectedValue = periodoDisciplina.Disciplina.Instituicao.Codigo.ToString();
            comboBoxProfessor.SelectedValue = periodoDisciplina.Professor.Codigo;
            comboBoxDisciplina.SelectedValue = periodoDisciplina.Disciplina.Codigo;

            switch (periodoDisciplina.SituacaoDisciplina.Codigo)
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

            dateTimePickerDataCadastro.Text = periodoDisciplina.DataCadastro.ToString();
            dateTimePickerDataAlteracao.Text = periodoDisciplina.DataAlteracao.ToString();
            txtCodigoUsuarioAlterou.Text = periodoDisciplina.UsuarioAlterou.Codigo.ToString();
            txtNomeUsuarioAlterou.Text = periodoDisciplina.UsuarioAlterou.NomeReal.ToString();
            if (periodoDisciplina.UsuarioAlterou.Administrador)
                checkBoxAdministrador.Checked = true;
            else if (periodoDisciplina.UsuarioAlterou.Aluno)
                checkBoxAluno.Checked = true;
            else if (periodoDisciplina.UsuarioAlterou.Professor)
                checkBoxProfessor.Checked = true;
            else
                checkBoxSecretariado.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxInstituicao.SelectedIndex == -1)
                MessageBox.Show("Selecione a Instituição.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxDisciplina.SelectedIndex == -1)
                MessageBox.Show("Selecione a Disciplina.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxProfessor.SelectedIndex == -1)
                MessageBox.Show("Selecione a Professor.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (telaSelecionada == Tela.Inserir)
                {
                    var retorno = new PeriodoDisciplinaRegraNegocio().Manipulacoes("1", BuscarDados());
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina Ministrada cadastrada com sucesso.", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível realizar o cadastro da disciplina ministrada. Detalhes: " + retorno,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var retorno = new PeriodoDisciplinaRegraNegocio().Manipulacoes("1", BuscarDados());
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina Ministrada alterada com sucesso.", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível realizar a alteração da disciplina ministrada. Detalhes: " + retorno,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private PeriodoDisciplina BuscarDados()
        {
            int situacao;
            if (radioButtonSituacaoEmAndamento.Checked)
                situacao = 1;
            else if (radioButtonSituacaoFinalizado.Checked)
                situacao = 2;
            else
                situacao = 3;
            return new PeriodoDisciplina()
            {
                Codigo = txtCodigo.Text != "" ? Convert.ToInt32(txtCodigo.Text) : 0,
                Disciplina = new Disciplina() { Codigo = Convert.ToInt32(comboBoxDisciplina.SelectedValue) },
                Professor = new Professor() { Codigo = Convert.ToInt32(comboBoxProfessor.SelectedValue) },
                SituacaoDisciplina = new SituacaoTurma() { Codigo = situacao },
                UsuarioAlterou = LoginSistema.UsuarioLogin
            };
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

        private void comboBoxDisciplina_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxDisciplina.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxDisciplina.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxDisciplina.SelectedIndex = -1;
                    if (comboBoxDisciplina.Items.Count > 0)
                        this.comboBoxDisciplina.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
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

        private void comboBoxProfessor_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxProfessor.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxProfessor.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxProfessor.SelectedIndex = -1;
                    if (comboBoxProfessor.Items.Count > 0)
                        this.comboBoxProfessor.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
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

        private void comboBoxDisciplina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxDisciplina.SelectedValue != null && comboBoxDisciplina.ValueMember != "")
                AtualizarComboBoxProfessor(telaSelecionada == Tela.Exibir ? null : "1");
            else
                return;
        }

        private void linkLabelVincularProfessorADisciplina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmProfessorDisciplina = new FrmProfessorDisciplina(Tela.Inserir, null);
            if (frmProfessorDisciplina.ShowDialog() == DialogResult.Yes)
            {
                AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString(),
               telaSelecionada == Tela.Exibir ? null : "1");
            }
        }

        private void comboBoxInstituicao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxInstituicao.SelectedValue != null && comboBoxDisciplina.ValueMember != "")
                AtualizarComboBoxDisciplina(comboBoxInstituicao.SelectedValue.ToString(),
               telaSelecionada == Tela.Exibir ? null : "1");
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (comboBoxInstituicao.SelectedIndex == -1)
                MessageBox.Show("Selecione a Instituição.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxDisciplina.SelectedIndex == -1)
                MessageBox.Show("Selecione a Disciplina.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxProfessor.SelectedIndex == -1)
                MessageBox.Show("Selecione a Professor.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (telaSelecionada == Tela.Inserir)
                {
                    var retorno = new PeriodoDisciplinaRegraNegocio().Manipulacoes("1", BuscarDados());
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina Ministrada cadastrada com sucesso.", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível realizar o cadastro da disciplina ministrada. Detalhes: " + retorno,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var retorno = new PeriodoDisciplinaRegraNegocio().Manipulacoes("1", BuscarDados());
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina Ministrada alterada com sucesso.", "Salvar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {

                        MessageBox.Show("Não foi possível realizar a alteração da disciplina ministrada. Detalhes: " + retorno,
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
