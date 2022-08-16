using ObjetoTransferencia;
using RegrasNegocio;
using SistemaAcademico.Módulos.Acadêmico.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmConsultarTurma : Form
    {
        private readonly string emAndamento = "1", finalizado = "2", cancelado = "3";
        private readonly string dataVazia = "  /  /";
        TurmaAlunoColecao turmaAlunoColecao;
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
        private void LimparPesquisa()
        {
            if (radioButtonCodigo.Checked)
            {
                comboBoxCurso.Visible = true;
                comboBoxCurso.Enabled = false;
                txtPesquisar.Text = string.Empty;
                txtPesquisar.Enabled = true;
                txtPesquisar.Focus();
                return;
            }
            else if (radioButtonCurso.Checked)
            {
                comboBoxCurso.Enabled = true;
                txtPesquisar.Enabled = false;
                comboBoxCurso.Visible = true;
                comboBoxCurso.Focus();
                return;
            }
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
            txtPesquisar.Enabled = true;
            comboBoxCurso.Enabled = false;
            comboBoxCurso.Visible = true;
        }
        private void ValidarDatasPreenchidas()
        {
            if (maskedTextBoxDataInicio.Text != dataVazia && maskedTextBoxDataFim.Text == dataVazia)
            {
                MessageBox.Show("Preencha a data fim para realizar a consulta. ", "Pesquisar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (maskedTextBoxDataInicio.Text == dataVazia && maskedTextBoxDataFim.Text != dataVazia)
            {
                MessageBox.Show("Preencha a data início para realizar a consulta. ", "Pesquisar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void AtualizarGrid()
        {
            try
            {
                DateTime? datainicio = null, datafim = null;
                var cursoRegraNegocio = new CursoRegraNegocio();
                string situacao = null;
                if (radioButtonSituacaoEmAndamento.Checked)
                    situacao = emAndamento;
                else if (radioButtonSituacaoFinalizado.Checked)
                    situacao = finalizado;
                else if (radioButtonSituacaoCancelado.Checked)
                    situacao = cancelado;
                ValidarDatasPreenchidas();
                if (maskedTextBoxDataInicio.Text != "  /  /" && maskedTextBoxDataFim.Text != "  /  /")
                {
                    datainicio = Convert.ToDateTime(maskedTextBoxDataInicio.Text);
                    datafim = Convert.ToDateTime(maskedTextBoxDataFim.Text);
                    if (datafim <= datainicio)
                    {
                        MessageBox.Show("Período inválido.", "Pesquisar", MessageBoxButtons.OK,
                         MessageBoxIcon.Warning);
                        return;
                    }
                }
                var turmaRegraNegocio = new TurmaRegraNegocio();               
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewTurma.DataSource = null;
                    dataGridViewTurma.DataSource = turmaRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null,
                        null,
                        datainicio,
                        datafim,
                        situacao,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                }
                else if (radioButtonNome.Checked)
                {
                    dataGridViewTurma.DataSource = null;
                    dataGridViewTurma.DataSource = turmaRegraNegocio.Consultar(
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        datainicio,
                        datafim,
                        situacao,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                }
                else
                {
                    if (comboBoxCurso.SelectedIndex == -1)
                    {
                        MessageBox.Show("Selecione a turma para realizar a consulta. ", "Pesquisar",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                    dataGridViewTurma.DataSource = null;
                    dataGridViewTurma.DataSource = turmaRegraNegocio.Consultar(
                        null,
                        null,
                        comboBoxCurso.SelectedValue.ToString(),
                        datainicio,
                        datafim,
                        situacao,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                }
                dataGridViewTurma.Update();
                dataGridViewTurma.Refresh();
                lblTotalRegistros.Text = $"Total Registro(s): {dataGridViewTurma.RowCount.ToString()}";
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmConsultarTurma()
        {
            InitializeComponent();
            dataGridViewTurma.AutoGenerateColumns = false;
            dataGridViewAluno.AutoGenerateColumns = false;
            comboBoxCurso.Enabled = false;
            AtualizarComboBoxCurso(
                LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNomeAluno_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCurso_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
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
                if (!ValidadorDados.ValidarData(maskedTextBoxDataInicio.Text))
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
                if (!ValidadorDados.ValidarData(maskedTextBoxDataFim.Text))
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

        private void btnNovaTurma_Click(object sender, EventArgs e)
        {            
            try
            {
                var frmTurma = new FrmTurma(Tela.Inserir, null);
                if (frmTurma.ShowDialog() == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realzar o cadastro da turma. Detalhes: " + exception.Message, "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma turma foi selecionada.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }                
                var turma = (dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma);
                var frmTurma = new FrmTurma(Tela.Exibir, turma);
                frmTurma.ShowDialog();               
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma turma foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                var turma = (dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma);
                var frmTurma = new FrmTurma(Tela.Alterar, turma);
                DialogResult dialogResult = frmTurma.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração da turma. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma turma foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                var turma = (dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma);
                if (MessageBox.Show("Deseja Excluir a turma selecionada?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == 
                    DialogResult.Yes)
                {                   
                    var turmaRegraNegocio = new TurmaRegraNegocio();
                    string retorno = turmaRegraNegocio.Manipulacoes("3", turma);
                    try
                    {
                        int codigo = Convert.ToInt32(retorno);
                        if (codigo != 0)
                            MessageBox.Show("Turma selecionada excluída com sucesso.", "Excluir", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Turma selecionada não pode se excluída, pois está sendo utilizado em outras tabelas.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AtualizarGrid();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Turma selecionada não pode se excluída, pois está sendo utilizada em outras tabelas.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão da turma. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmConsultarTurma_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
                {
                    if (radioButtonCodigo.Checked)
                    {
                        string keyInput = e.KeyChar.ToString();
                        if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                            e.Handled = true;
                    }
                    if (e.KeyChar == 13)
                        AtualizarGrid();
                }
                catch (Exception exception)
                {

                    MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma turma foi selecionada.", "Aluno(s)",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var turma = dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma;
            if (dataGridViewAluno.Rows.Count == 0)
            {
                var frmTurmaAluno = new FrmTurmaAluno(turma, Tela.Inserir, null);
                frmTurmaAluno.ShowDialog();
            }
            else
            {
                var frmTurmaAluno = new FrmTurmaAluno(turma, Tela.Alterar, turmaAlunoColecao);
                frmTurmaAluno.ShowDialog();
            }
        }

        private void dataGridViewTurma_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewTurma.SelectedRows.Count != 0)
            {
                var turmaAlunoRegraNegocio = new TurmaAlunoRegraNegocio();
                var turma = dataGridViewTurma.SelectedRows[0].DataBoundItem as Turma;
                turmaAlunoColecao = turmaAlunoRegraNegocio.Consultar(turma.Codigo.ToString(), null, null, null, null,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                if(turmaAlunoColecao != null)
                {
                    dataGridViewAluno.DataSource = null;
                    dataGridViewAluno.DataSource = turmaAlunoColecao;
                    dataGridViewAluno.Update();
                    dataGridViewAluno.Refresh();
                }
            }
        }

        private void dataGridViewAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewAluno.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewAluno.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewAluno.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewAluno.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewAluno_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var alunoRegraNegocio = new AlunoRegraNegocio();
                var aluno = alunoRegraNegocio.ConsultarCodigoUnico((
                        (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno).Codigo.ToString()),
                         null, null, null, null);

                //var aluno = (dataGridViewAluno.SelectedRows[0].DataBoundItem as Aluno);
                var frmAluno = new FrmAluno(Tela.Exibir, aluno);
                frmAluno.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}
