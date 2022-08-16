using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmConsultarTurmaPeriodo : Form
    {
        private readonly string dataVazia = "  /  /";
        TurmaPeriodoColecao turmaPeriodoColecao;
        TurmaPeriodoDisciplinaColecao turmaPeriodoDisciplinaColecao;
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

        private void AtualizarComboBoxPeriodo()
        {
            try
            {
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

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void ValidarDatasPreenchidas()
        {
            if (maskedTextBoxDataInicio.Text != dataVazia && maskedTextBoxDataFim.Text == dataVazia)
            {
                MessageBox.Show("Preencha a data fim para realizar a consulta.", "Pesquisar", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);                
                    maskedTextBoxDataFim.Focus();
                return;
            }
            else if (maskedTextBoxDataInicio.Text == dataVazia && maskedTextBoxDataFim.Text != dataVazia)
            {
                MessageBox.Show("Preencha a data início para realizar a consulta.", "Pesquisar", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                maskedTextBoxDataInicio.Focus();
                    return;
            }
        }

        public FrmConsultarTurmaPeriodo()
        {
            InitializeComponent();
            txtPesquisar.Focus();
            comboBoxCurso.Visible = false;
            comboBoxPeriodo.Visible = false;
            dataGridViewDisciplinaProfessor.AutoGenerateColumns = false;
            dataGridViewPeriodo.AutoGenerateColumns = false;
            dataGridViewTurma.AutoGenerateColumns = false;
            AtualizarComboBoxCurso(LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
            AtualizarComboBoxPeriodo();
            comboBoxCurso.SelectedIndex = -1;
            comboBoxPeriodo.SelectedIndex = -1;
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            comboBoxCurso.Visible = false;
            comboBoxPeriodo.Visible = false;

        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            comboBoxCurso.Visible = false;
            comboBoxPeriodo.Visible = false;
        }

        private void radioButtonCurso_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            comboBoxCurso.Visible = true;
            comboBoxPeriodo.Visible = false;
        }

        private void radioButtonPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            comboBoxCurso.Visible = false;
            comboBoxPeriodo.Visible = true;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (radioButtonCodigo.Checked)
                {
                    string KeyInput = e.KeyChar.ToString();
                    if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                        e.Handled = true;
                }
                if (e.KeyChar == 13)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string AtribuirSituacao()
        {
            string situacao = null;
            if (radioButtonSituacaoAtivo.Checked)
                situacao = "1";
            else if (radioButtonSituacaoInativo.Checked)
                situacao = "0";
            return situacao;
        }

        private void AtualizarGrid()
        {
            try
            {
                DateTime? datainicio = null, datafim = null;
                ValidarDatasPreenchidas();
                if (maskedTextBoxDataInicio.Text != "  /  /" && maskedTextBoxDataFim.Text != "  /  /")
                {
                    datainicio = Convert.ToDateTime(maskedTextBoxDataInicio.Text);
                    datafim = Convert.ToDateTime(maskedTextBoxDataFim.Text);
                    if (datafim < datainicio)
                    {
                        MessageBox.Show("Período inválido.", "Pesquisar", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                        return;
                    }
                }
                dataGridViewTurma.DataSource = null;
                var turmaRegraNegocio = new TurmaRegraNegocio();
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewTurma.DataSource = null;
                    dataGridViewTurma.DataSource = turmaRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null, 
                        comboBoxCurso.SelectedIndex == -1 ? null : comboBoxCurso.SelectedValue.ToString(),
                        datainicio,
                        datafim,
                        AtribuirSituacao(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                }
                else
                {
                    dataGridViewTurma.DataSource = null;
                    dataGridViewTurma.DataSource = turmaRegraNegocio.Consultar(
                        null,
                        txtPesquisar.Text.ToString(),
                        comboBoxCurso.SelectedIndex == -1 ? null : comboBoxCurso.SelectedValue.ToString(),
                        datainicio,
                        datafim,
                        AtribuirSituacao(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                }
                dataGridViewTurma.Update();
                dataGridViewTurma.Refresh();
                lblTotalRegistroPeriodo.Text = $"Total Registro(s): {dataGridViewPeriodo.RowCount.ToString()}";
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dataGridViewTurma_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewTurma.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewTurma.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewTurma.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewTurma.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewPeríodo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewPeriodo.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewPeriodo.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewPeriodo.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewPeriodo.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewDisciplinaProfessor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewDisciplinaProfessor.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewDisciplinaProfessor.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewDisciplinaProfessor.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewDisciplinaProfessor.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (text == string.Empty)
                    return;
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

        private void comboBoxPeriodo_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxPeriodo.Text;
                if (text == string.Empty)
                {
                    AtualizarGridTurma();
                    return;
                }
                if (string.IsNullOrWhiteSpace(text) || comboBoxPeriodo.FindStringExact(text) < 0)
                {
                    this.comboBoxPeriodo.SelectedIndex = -1;
                    if (comboBoxPeriodo.Items.Count > 0)
                        this.comboBoxPeriodo.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewTurma_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGridTurma();
        }

        private void AtualizarGridTurma()
        {
            if (dataGridViewTurma.SelectedRows.Count != 0)
            {
                var turmaPeriodoRegraNegocio = new TurmaPeriodoRegraNegocio();
                var turma = dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma;
                turmaPeriodoColecao = turmaPeriodoRegraNegocio.Consultar(null, turma.Codigo.ToString(), null, null, null,
                    comboBoxPeriodo.SelectedIndex == -1 ? null : comboBoxPeriodo.SelectedValue.ToString(), null,
                    AtribuirSituacao(), null);
                if (turmaPeriodoColecao != null)
                {
                    dataGridViewPeriodo.DataSource = null;
                    dataGridViewPeriodo.DataSource = turmaPeriodoColecao;
                    dataGridViewPeriodo.Update();
                    dataGridViewPeriodo.Refresh();
                    lblTotalRegistrosTurma.Text = $"Total Registro(s): " +
                        $"{dataGridViewTurma.RowCount.ToString()}";
                }
            }
        }

        private void dataGridViewPeriodo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPeriodo.SelectedRows.Count != 0)
                AtualizarGridDisciplinaProfessor();      
        }
        private void AtualizarGridDisciplinaProfessor()
        {
            var turmaPeriodoDisciplinaRegraNegocio = new TurmaPeriodoDisciplinaRegraNegocio();
            var turmaPeriodo = dataGridViewPeriodo.SelectedRows[0].DataBoundItem as TurmaPeriodo;
            turmaPeriodoDisciplinaColecao = turmaPeriodoDisciplinaRegraNegocio.Consultar(null, null, null, null, null,
                turmaPeriodo.Codigo.ToString(), null, null, AtribuirSituacao(), null, null);
            if (turmaPeriodoDisciplinaColecao != null)
            {
                dataGridViewDisciplinaProfessor.DataSource = null;
                dataGridViewDisciplinaProfessor.DataSource = turmaPeriodoColecao;
                dataGridViewDisciplinaProfessor.Update();
                dataGridViewDisciplinaProfessor.Refresh();
                lblTotalRegistroDisciplinaProfessor.Text = $"Total Registro(s): " +
                    $"{dataGridViewDisciplinaProfessor.RowCount.ToString()}";
            }
        }
        private void btnNovoPeriodo_Click(object sender, EventArgs e)
        {
            try
            {
                var frmTurmaPeriodo = new FrmTurmaPeriodo(Tela.Inserir, null);
                //if (frmTurmaPeriodo.ShowDialog() == DialogResult.Yes)
                var dialogResult = frmTurmaPeriodo.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realzar o cadastro da turma período. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma turma período foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                var turmaPeriodo = (dataGridViewTurma.SelectedRows[0].DataBoundItem as TurmaPeriodo);
                var frmTurmaPeriodo = new FrmTurmaPeriodo(Tela.Alterar, turmaPeriodo);
                DialogResult dialogResult = frmTurmaPeriodo.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração da turma período. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            AtualizarGridTurma();
        }

        private void radioButtonSituacaoTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridTurma();
        }

        private void radioButtonSituacaoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridTurma();
        }

        private void radioButtonSituacaoInativo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridTurma();
        }
        private void btnVincularDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewPeriodo.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum período selecionado.", "Vincular", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var turmaPeriodo = dataGridViewPeriodo.SelectedRows[0].DataBoundItem as TurmaPeriodo;
                var frmPeriodoDisciplina = new FrmPeriodoDisciplina(turmaPeriodo);
                if (frmPeriodoDisciplina.ShowDialog() == DialogResult.Yes)
                    AtualizarGridDisciplinaProfessor();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realzar a vinculação. Detalhes: " + exception.Message, "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }        
        private void btnAtivarInativarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDisciplinaProfessor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Disciplina/Professor foi selecionada.", "Vincular", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                var turmaPeriodoDisciplina = (dataGridViewDisciplinaProfessor.SelectedRows[0].DataBoundItem as TurmaPeriodoDisciplina);
                var frmTurmaPeriodoDisciplina = LoginSistema.UsuarioLogin;
                turmaPeriodoDisciplina.Situacao = !turmaPeriodoDisciplina.Situacao;
                var retorno = new TurmaPeriodoDisciplinaRegraNegocio().Manipulacoes("2", turmaPeriodoDisciplina);
                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Alteração realizada com sucesso.", "Vincular", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridDisciplinaProfessor();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível realizar a alteração. Detalhes: {retorno}", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração da turma. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarAlunos_Click(object sender, EventArgs e)        
        {

         if(dataGridViewDisciplinaProfessor.SelectedRows.Count == 0)
         {
           MessageBox.Show("Nenhuma disciplina foi selecionada.", "Consulta Alunos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return; 
         }
            var turmaPeriodoDisciplina = dataGridViewDisciplinaProfessor.SelectedRows[8].DataBoundItem as TurmaPeriodoDisciplina;

            var frmDisciplinaAluno = new FrmDisciplinaAluno(turmaPeriodoDisciplina, Tela.Inserir);
            frmDisciplinaAluno.ShowDialog();
        }
    }
}
