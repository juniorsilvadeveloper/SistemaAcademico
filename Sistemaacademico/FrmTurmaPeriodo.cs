using ObjetoTransferencia;
using RegrasNegocio;
using SistemaAcademico.Módulos.Acadêmico.Principal;
using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmTurmaPeriodo : Form
    {
        private TurmaPeriodo turmaPeriodoSelecionada;
        private Tela telaSelecionada;
        private void AtualizarComboBoxInstituicao()
        {
            try
            {
                comboBoxInstituicao.Text = string.Empty;
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
                comboBoxInstituicao.Text = string.Empty;
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
                comboBoxCurso.Text = string.Empty;
                var cursoRegraNegocio = new CursoRegraNegocio();
                comboBoxCurso.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxCurso.DataSource = cursoRegraNegocio.Consultar(
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
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

        private void AtualizarComboBoxTurma(string curso)
        {
            try
            {
                comboBoxTurma.Text = string.Empty;
                var turmaRegraNegocio = new TurmaRegraNegocio();
                comboBoxTurma.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxTurma.DataSource = turmaRegraNegocio.Consultar(                     
                    null, null, curso, null, null, "1", null);
                comboBoxTurma.ValueMember = "Codigo";
                comboBoxTurma.DisplayMember = "Nome";
                comboBoxTurma.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AtualizarComboBoxPeriodo()
        {
            try
            {
                comboBoxPeriodo.Text = string.Empty;
                var periodoRegraNegocio = new PeriodoRegraNegocio();
                comboBoxPeriodo.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxPeriodo.DataSource = periodoRegraNegocio.Consultar(null, "");
                comboBoxPeriodo.ValueMember = "Codigo";
                comboBoxPeriodo.DisplayMember = "Nome";
                comboBoxPeriodo.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmTurmaPeriodo()
        {
            InitializeComponent();
        }

        public FrmTurmaPeriodo(Tela tela, TurmaPeriodo turmaPeriodo)
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            telaSelecionada = tela;
            turmaPeriodoSelecionada = turmaPeriodo;
            if (telaSelecionada == Tela.Inserir)
                AtualizarComboBoxInstituicao();
            else
                AtualizarComboBoxInstituicaoTodas();
            AtualizarComboBoxPeriodo();

            if (tela == Tela.Inserir)
            {
                this.Text = "Turma - Período - Inserir";
                comboBoxPeriodo.SelectedValue = 1;
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
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Turma - Período -  Alterar";
                comboBoxInstituicao.Enabled = false;
                comboBoxTurma.Enabled = false;
                comboBoxTurma.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarCurso.Enabled = false;
                btnAdicionarTurma.Enabled = false;
                PreencherDados(turmaPeriodo);

            }
            else // Exibir
            {
                this.Text = "Turma - Período - Consultar";
                PreencherDados(turmaPeriodo);
                comboBoxInstituicao.Enabled = false;
                comboBoxCurso.Enabled = false;
                comboBoxPeriodo.Enabled = false;
                comboBoxTurma.Enabled = false;
                maskedTextBoxDataInicio.Enabled = false;
                btnAdicionarInstituicao.Enabled = false;
                btnAdicionarTurma.Enabled = false;
                btnAdicionarPeriodo.Enabled = false;
                btnAdicionarCurso.Enabled = false;
                btnSalvar.Visible = false;
                radioButtonSituacaoAtivo.Enabled = false;
                radioButtonSituacaoInativo.Enabled = false;
            }
        }

        private void PreencherDados(TurmaPeriodo turmaPeriodo)
        {
            txtCodigo.Text = turmaPeriodo.Codigo.ToString();
            comboBoxInstituicao.SelectedValue = turmaPeriodo.Turma.Instituicao.Codigo;
            comboBoxCurso.SelectedValue = turmaPeriodo.Turma.Curso.Codigo;
            comboBoxTurma.SelectedValue = turmaPeriodo.Turma.Codigo;
            comboBoxPeriodo.SelectedValue = turmaPeriodo.Periodo.Codigo;
            maskedTextBoxDataInicio.Text = turmaPeriodo.Turma.DataInicio.ToString("dd/mm/yyyy");
            maskedTextBoxDataFim.Text = turmaPeriodo.Turma.DataFim.ToString();
            dateTimePickerDataCadastro.Text = turmaPeriodo.Turma.DataCadastro.ToString();
            dateTimePickerDataAlteracao.Text = turmaPeriodo.Turma.DataAlteracao.ToString();
            txtCodigoUsuarioAlterou.Text = turmaPeriodo.Turma.UsuarioAlterou.Codigo.ToString();
            txtNomeUsuarioAlterou.Text = turmaPeriodo.Turma.UsuarioAlterou.NomeReal.ToString();
            if (turmaPeriodo.Turma.UsuarioAlterou.Administrador)
                checkBoxAdministrador.Checked = true;
            else if (turmaPeriodo.Turma.UsuarioAlterou.Aluno)
                checkBoxAluno.Checked = true;
            else if (turmaPeriodo.Turma.UsuarioAlterou.Professor)
                checkBoxProfessor.Checked = true;
            else
                checkBoxSecretariado.Checked = true;
            radioButtonSituacaoAtivo.Checked = turmaPeriodo.Situacao;
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
        private void maskedTextBoxDataInicio_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDataInicio.Text != "  /  /")
            {
                if (!RegrasNegocio.ValidadorDados.ValidarData(maskedTextBoxDataInicio.Text))
                {
                    MessageBox.Show("Data início inválida.", "Data início", MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    maskedTextBoxDataInicio.Focus();
                    return;
                }
                if (maskedTextBoxDataFim.Text == "  /  /")
                    maskedTextBoxDataFim.Focus();
            }
        }

        private void maskedTextBoxDataFim_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDataFim.Text != "  /  /")
            {
                if (!RegrasNegocio.ValidadorDados.ValidarData(maskedTextBoxDataFim.Text))
                {
                    MessageBox.Show("Data início inválida.", "Data início", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                    maskedTextBoxDataFim.Focus();
                    return;
                }

                if (maskedTextBoxDataInicio.Text == "  /  /")
                    maskedTextBoxDataInicio.Focus();
            }
        }

        private void btnAdicionarTurma_Click(object sender, EventArgs e)
        {
            var frmTurma = new FrmTurma(Tela.Inserir, null);
            if (frmTurma.ShowDialog() == DialogResult.Yes)
            {
                if (comboBoxCurso.SelectedValue != null && comboBoxCurso.ValueMember != "")
                    AtualizarComboBoxTurma(comboBoxCurso.SelectedValue.ToString());
            }
        }

        private void btnAdicionarPeriodo_Click(object sender, EventArgs e)
        {

            var frmPeriodo = new FrmPeriodo(Tela.Inserir, null);
            if (frmPeriodo.ShowDialog() == DialogResult.Yes)
                AtualizarComboBoxPeriodo();

        }

        private void comboBoxTurma_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxTurma.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxTurma.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxTurma.SelectedIndex = -1;
                    if (comboBoxTurma.Items.Count > 0)
                        this.comboBoxTurma.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxTurma_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxTurma.FindString(comboBoxTurma.Text);
                    comboBoxTurma.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxPeriodo_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxPeriodo.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxPeriodo.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxPeriodo.SelectedIndex = -1;
                    if (comboBoxPeriodo.Items.Count > 0)
                        this.comboBoxPeriodo.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxPeriodo.FindString(comboBoxPeriodo.Text);
                    comboBoxPeriodo.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituicao_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxInstituicao.SelectedValue != null && comboBoxInstituicao.ValueMember != "")
                    AtualizarComboBoxCurso(comboBoxInstituicao.SelectedValue.ToString());
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void comboBoxCurso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCurso.SelectedValue != null && comboBoxCurso.ValueMember != "")
                    AtualizarComboBoxTurma(comboBoxCurso.SelectedValue.ToString());
                else
                    return;
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

                if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione a Instituição.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxCurso.SelectedIndex == -1)
                    MessageBox.Show("Selecione o curso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxTurma.SelectedIndex == -1)
                    MessageBox.Show("Selecione a turma", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxPeriodo.SelectedIndex == -1)
                    MessageBox.Show("Selecione o período", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (maskedTextBoxDataInicio.Text == "  /  /")
                    MessageBox.Show("Selecione a data de início.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var retorno = new TurmaPeriodoRegraNegocio().Manipulacoes("1", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma período cadastrada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar o cadastro da turma período. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var retorno = new TurmaPeriodoRegraNegocio().Manipulacoes("2", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma período alterada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar a alteração da turma período. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private TurmaPeriodo BuscarDados()
        {
            DateTime? datafim = null;
            if (maskedTextBoxDataFim.Text != "  /  /")
                datafim = Convert.ToDateTime(maskedTextBoxDataFim.Text);
            return new TurmaPeriodo()
            {
                Codigo = txtCodigo.Text != "" ? Convert.ToInt32(txtCodigo.Text) : 0,
                Turma = new Turma { Codigo = Convert.ToInt32(comboBoxTurma.SelectedValue) },
                Periodo = new Periodo { Codigo = Convert.ToInt32(comboBoxPeriodo.SelectedValue) },
                Situacao = radioButtonSituacaoAtivo.Checked,
                DataInicio = Convert.ToDateTime(maskedTextBoxDataInicio),
                DataFim = datafim,
                UsuarioAlterou = LoginSistema.UsuarioLogin
            };
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione a Instituição.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxCurso.SelectedIndex == -1)
                    MessageBox.Show("Selecione o curso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxTurma.SelectedIndex == -1)
                    MessageBox.Show("Selecione a turma", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (comboBoxPeriodo.SelectedIndex == -1)
                    MessageBox.Show("Selecione o período", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (maskedTextBoxDataInicio.Text == "  /  /")
                    MessageBox.Show("Selecione a data de início.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        var retorno = new TurmaPeriodoRegraNegocio().Manipulacoes("1", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma período cadastrada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Não foi possível realizar o cadastro da turma período. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        var retorno = new TurmaPeriodoRegraNegocio().Manipulacoes("2", BuscarDados());
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Turma período alterada com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Não foi possível realizar a alteração da turma período. Detalhes: " + retorno,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTurma_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTurma.SelectedValue != null && comboBoxTurma.ValueMember != "")
                    AtualizarComboBoxTurma(comboBoxTurma.SelectedValue.ToString());
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }

        private void comboBoxPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPeriodo.SelectedValue != null && comboBoxPeriodo.ValueMember != "")
                    AtualizarComboBoxPeriodo();
                else
                    return;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }
    }
}
