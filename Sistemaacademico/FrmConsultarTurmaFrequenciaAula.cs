using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmConsultarTurmaFrequenciaAula : Form
    {
        private readonly string emAndamento = "1", finalizado = "2", cancelado = "3";
        private readonly string dataVazia = "  /  /";
        private string log;
        PeriodoDisciplinaColecao periodoDisciplinaColecao;
        private void AtualizarGrid()
        {
            try
            {
                string situacao = null;
                if (radioButtonSituacaoEmAndamento.Checked)
                    situacao = emAndamento;
                else if (radioButtonSituacaoFinalizado.Checked)
                    situacao = finalizado;
                else if (radioButtonSituacaoCancelado.Checked)
                    situacao = cancelado;

                dataGridViewDisciplina.DataSource = null;
                var periodoDisciplinaRegraNegocio = new PeriodoDisciplinaRegraNegocio();

                if (radioButtonCodigo.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null,
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonDisciplina.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    null,                    
                    null,
                    txtPesquisar.Text.ToString(),
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null,
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }               
                else if (radioButtonProfessor.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    txtPesquisar.Text.ToString(),
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                dataGridViewDisciplina.DataSource = periodoDisciplinaColecao;
                dataGridViewDisciplina.Update();
                dataGridViewDisciplina.Refresh();
                lblTotalRegistrosDisciplinas.Text = $"Total Registro(s): {dataGridViewDisciplina.RowCount.ToString()}";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AtualizarGridAulas()
        {
            DateTime? dataInicio = null, dataFim = null;
            ValidarDatasPreenchidas();
            if (maskedTextBoxDataInicio.Text != "  /  /" && maskedTextBoxDataFim.Text != "  /  /")
            {
                dataInicio = Convert.ToDateTime(maskedTextBoxDataInicio.Text);
                dataFim = Convert.ToDateTime(maskedTextBoxDataFim.Text);
                if (dataFim < dataInicio)
                {
                    MessageBox.Show("Período inválido.", "Pesquisar", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                    return;
                }
            }
            var periodoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina;
            dataGridViewAulas.DataSource = null;
            dataGridViewAulas.DataSource = new TurmaFrequenciaAulaRegraNegocio().Consultar(
                null, 
                periodoDisciplina.Codigo.ToString(), 
                dataInicio, 
                dataFim, 
                periodoDisciplina.Disciplina.Instituicao.Codigo.ToString());
            dataGridViewAulas.Update();
            dataGridViewAulas.Refresh();
            lblTotalRegistrosDisciplinas.Text = $"Total Registro(s): {dataGridViewDisciplina.Rows.Count}";
            lblTotalRegistrosAulas.Text = $"Total Registro(s): {dataGridViewAulas.Rows.Count}";
        }
        private void ValidarDatasPreenchidas()
        {
            if (maskedTextBoxDataInicio.Text != dataVazia && maskedTextBoxDataFim.Text == dataVazia)
            {
                MessageBox.Show("Preencha a data fim para realizar a consulta.", "Pesquisar", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
            else if (maskedTextBoxDataInicio.Text == dataVazia && maskedTextBoxDataFim.Text == dataVazia)
            {
                MessageBox.Show("Preencha a data início para realizar a consulta.", "Pesquisar", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonProfessor_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
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

        private void dataGridViewDisciplina_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewDisciplina.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewDisciplina.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewDisciplina.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewDisciplina.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewAulas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewAulas.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewAulas.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewAulas.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewAulas.Columns[e.ColumnIndex].DataPropertyName
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

        private void dataGridViewDisciplina_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDisciplina.SelectedRows.Count != 0)
                AtualizarGridAulas();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLancarAula_Click(object sender, EventArgs e)
        {
            if(dataGridViewDisciplina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma disciplina para realizar o lançamento da aula", "Lançar Aula", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var frmTurmaFrequenciaAula = new FrmTurmaFrequenciaAula(null, 
                (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina), Tela.Inserir);
            if (frmTurmaFrequenciaAula.ShowDialog() == DialogResult.Yes)
                AtualizarGridAulas();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAulas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para exibir com mais detalhes.", "Exibir",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var frmTurmaFrequenciaAula = new FrmTurmaFrequenciaAula(
                (dataGridViewAulas.SelectedRows[0].DataBoundItem as TurmaFrequenciaAula), null, Tela.Exibir);
            if (frmTurmaFrequenciaAula.ShowDialog() == DialogResult.Yes)
                AtualizarGridAulas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAulas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para alterar.", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var frmTurmaFrequenciaAula = new FrmTurmaFrequenciaAula(
                (dataGridViewAulas.SelectedRows[0].DataBoundItem as TurmaFrequenciaAula), null, Tela.Alterar);
            if (frmTurmaFrequenciaAula.ShowDialog() == DialogResult.Yes)
                AtualizarGridAulas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dataGridViewAulas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um registro para excluir.", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var retorno = new TurmaFrequenciaAulaRegraNegocio().Manipulacoes("3", dataGridViewAulas.SelectedRows[0].DataBoundItem as TurmaFrequenciaAula);
            try
            {
                var codigo = Convert.ToInt32(retorno);
                MessageBox.Show("Registro de aula excluido com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch (Exception)
            {
                MessageBox.Show($"Não foi possível excluir o registro de aula selecionada. Detalhes: {retorno}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelVerificarPendencias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log = String.Empty;
            var listaDisciplina = periodoDisciplinaColecao.Where(x => x.SituacaoDisciplina.Codigo == 1).ToList();
            foreach (var periodoDisciplina in listaDisciplina)
            {
                var aulasRegistradas = new TurmaFrequenciaAulaRegraNegocio().Consultar( 
                    null, periodoDisciplina.Codigo.ToString(),null, null, periodoDisciplina.Disciplina.Instituicao.Codigo.ToString());

                if (aulasRegistradas.Count > 0)
                {
                    foreach (var aula in aulasRegistradas)
                    {
                        var alunosSemRegistro = new TurmaFrequenciaAulaAlunoRegraNegocio().
                            ConsultarAlunosDisponiveisSemRegistroAulaDaDisciplina(aula.Codigo.ToString(), 
                            aula.PeriodoDisciplina.Codigo.ToString());
                        if (alunosSemRegistro.Count > 0)
                            InserirAlunosSemRegistroNaAula(alunosSemRegistro, aula);
                       
                    }
                }
            }
            if (log != string.Empty)
            {
                var nomeArquivo = $"Log {DateTime.Now.Day.ToString()}-{DateTime.Now.Month.ToString()} - {DateTime.Now.Ticks.ToString()}.txt";
                var path = Path.Combine(Path.GetTempPath(), nomeArquivo);
                File.WriteAllText(path, log);
                MessageBox.Show($"Alguns alunos estavam disponíveis na disciplina sem registro da aula selecionada." +
                    $"Os registros foram efetuados, sendo lançados com registros de falta.\nLog criado em: " +
                    $"{path}",
                    "Alunos sem registro de aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(path);
            }
        }

        private void InserirAlunosSemRegistroNaAula(TurmaFrequenciaAulaAlunoColecao turmaFrequenciaAlunos, TurmaFrequenciaAula turmaFrequenciaAula)
        {
            var logTurmaFrequenciaAula = $"\n\nCódigo da Disciplina {turmaFrequenciaAula.PeriodoDisciplina.Codigo}\nCódigo Registro Aula: {turmaFrequenciaAula.Codigo}\n";
            var logAlunoSucesso = "\nCódigo do Aluno(s) com aula registrada com sucesso:\n";
            var logAlunoErro = "\nCódigo do Aluno(s) com ocorrência de erro:\n";
            foreach (var turmaFrequenciaAluno in turmaFrequenciaAlunos)
            {
                turmaFrequenciaAluno.QuantidadeAulas = turmaFrequenciaAula.QuantidadeAulas;
                turmaFrequenciaAluno.UsuarioAlterou = LoginSistema.UsuarioLogin;
                turmaFrequenciaAluno.TurmaFrequenciaAula = turmaFrequenciaAula;
                var retorno = new TurmaFrequenciaAulaAlunoRegraNegocio().Manipulacoes("1", turmaFrequenciaAluno);
                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logAlunoSucesso = string.Concat(logAlunoSucesso, turmaFrequenciaAluno.Aluno.Codigo.ToString(), "  ");
                }
                catch
                {
                    logAlunoErro = string.Concat(logAlunoErro, turmaFrequenciaAluno.Aluno.Codigo.ToString(), " - \n", retorno);
                }
            }
            log = string.Concat(log, logTurmaFrequenciaAula, logAlunoSucesso, logAlunoErro, "\n");
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }
        public FrmConsultarTurmaFrequenciaAula()
        {
            InitializeComponent();
            dataGridViewDisciplina.AutoGenerateColumns = false;
            dataGridViewAulas.AutoGenerateColumns = false;
            linkLabelVerificarPendencias.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnLancarAula.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnAlterar.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnExcluir.Visible = !LoginSistema.UsuarioLogin.Aluno;
        }
    }
}
