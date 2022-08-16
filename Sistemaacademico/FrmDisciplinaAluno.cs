using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;
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
    public partial class FrmDisciplinaAluno : Form
    {
        PeriodoDisciplina periodoDisciplinaSelecionada;
        TurmaPeriodoDisciplina turmaPeriodoDisciplinaSelecionada;
        bool controle = true;
        Tela telaSelecionada;
        Classe classeSelecionada;
        public FrmDisciplinaAluno()
        {
            InitializeComponent();
        }

        private void AtualizarGrid()
        {
            dataGridViewAluno.DataSource = null;
            dataGridViewAluno.DataSource = new TurmaPeriodoDisciplinaAlunosRegraNegocio().Consultar(classeSelecionada == Classe.PeriodoDisciplina ? periodoDisciplinaSelecionada.Codigo.ToString() : turmaPeriodoDisciplinaSelecionada.PeriodoDisciplina.Codigo.ToString(),
            null, null, null, null, null, null, null,
            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(), classeSelecionada == Classe.TurmaPeriodoDisciplina ? turmaPeriodoDisciplinaSelecionada.TurmaPeriodo.Codigo.ToString() : null);
            dataGridViewAluno.Refresh();
            dataGridViewAluno.Update();
        }
        public FrmDisciplinaAluno(TurmaPeriodoDisciplina turmaPeriodoDisciplina, Tela tela)
        {
            InitializeComponent();
            dataGridViewAluno.AutoGenerateColumns = false;
            this.turmaPeriodoDisciplinaSelecionada = turmaPeriodoDisciplina;
            telaSelecionada = tela;
            this.classeSelecionada = Classe.TurmaPeriodoDisciplina;
            btnAdicionar.Visible = false;
            btnRemover.Visible = false;
            AtualizarGrid();

            PreencherCamposPeriodoDisciplina(turmaPeriodoDisciplina.PeriodoDisciplina);
            PreencherGrupoTurma(turmaPeriodoDisciplina);
        }

        public FrmDisciplinaAluno(PeriodoDisciplina periodoDisciplina)
        {
            InitializeComponent();
            dataGridViewAluno.AutoGenerateColumns = false;
            this.periodoDisciplinaSelecionada = periodoDisciplina;
            this.classeSelecionada = Classe.PeriodoDisciplina;
            AtualizarGrid();
            PreencherCamposPeriodoDisciplina(periodoDisciplina);
        }

        private void PreencherCamposPeriodoDisciplina(PeriodoDisciplina periodoDisciplina)
        {
            txtCodigoDisciplina.Text = periodoDisciplina.Codigo.ToString();
            txtDisciplina.Text = periodoDisciplina.Disciplina.Nome.ToString();
            txtProfessor.Text = periodoDisciplina.Professor.ToString();
        }

        private void dataGridViewAluno_Click(object sender, EventArgs e)
        {

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

        private void dataGridViewAluno_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count != 0)
            {
                var alunoSelecionado = dataGridViewAluno.SelectedRows[0].DataBoundItem as TurmaPeriodoDisciplinaAlunos;
                if (classeSelecionada == Classe.PeriodoDisciplina)
                    PreencherCampoTurmaPorPeriodoDisciplina(alunoSelecionado.Aluno.Codigo.ToString(), alunoSelecionado.PeriodoDisciplina.Codigo.ToString());
            }
        }

        private void PreencherCampoTurmaPorPeriodoDisciplina(string codigoAluno, string codigoPeriodoDisciplina)
        {
            var dadosAlunoDisciplina = new TurmaPeriodoDisciplinaRegraNegocio().ConsultarDadosDoAlunoNaDisciplina(codigoPeriodoDisciplina, codigoAluno);
            if (dadosAlunoDisciplina == null)
                return;
            PreencherGrupoTurma(dadosAlunoDisciplina);
        }

        private void PreencherGrupoTurma(TurmaPeriodoDisciplina turmaPeriodoDisciplina)
        {
            txtCodigo.Text = turmaPeriodoDisciplina.TurmaPeriodo.Turma.Codigo.ToString();
            txtNome.Text = turmaPeriodoDisciplina.TurmaPeriodo.Turma.Nome.ToString();
            txtInstituicao.Text = turmaPeriodoDisciplina.TurmaPeriodo.Turma.Instituicao.NomeFantasia.ToString();
            txtCurso.Text = turmaPeriodoDisciplina.TurmaPeriodo.Turma.Curso.Nome.ToString();
            txtTurno.Text = turmaPeriodoDisciplina.TurmaPeriodo.Turma.Turno.Nome.ToString();
            txtPeriodo.Text = turmaPeriodoDisciplina.TurmaPeriodo.Periodo.Nome.ToString();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var listaAlunos = (PesquisarAlunos(3, ""));
            var logImportacaoSucesso = "Código Aluno(s) vinculado(s):\n";
            var logImportacaoErro = "Codigo e Mensagem de Ocorrência Aluno(s) não vinculado(s):\n";

            foreach (var aluno in listaAlunos)
            {
                var turmaPeriodoDisciplinaAluno = new TurmaPeriodoDisciplinaAlunos
                {
                    Aluno = aluno,
                    PeriodoDisciplina = classeSelecionada == Classe.PeriodoDisciplina ? periodoDisciplinaSelecionada : turmaPeriodoDisciplinaSelecionada.PeriodoDisciplina,
                    Situacao = true,
                    UsuarioAlterou = LoginSistema.UsuarioLogin,
                    SituacaoDisciplina = new SituacaoAlunoDisciplina { Codigo = 1}
                };

                var retorno = new TurmaPeriodoDisciplinaAlunosRegraNegocio().Manipulacoes("1", turmaPeriodoDisciplinaAluno);

                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logImportacaoSucesso = string.Concat(logImportacaoSucesso, aluno.Codigo.ToString(), "  ");
                }
                catch
                {
                    logImportacaoErro = string.Concat(logImportacaoErro, aluno.Codigo.ToString(), " - {0}\n", retorno);
                }
            }

            MessageBox.Show(string.Format("Vinculação Realizada - Log de Ocorrências\nTotal: {0}\n{1}\n{2}",listaAlunos.Count.ToString(), logImportacaoSucesso, logImportacaoErro), "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGrid();
        }

        public List<Aluno> PesquisarAlunos(int tipo, string dados)
        {
            try
            {
                var listaAlunos = new List<Aluno>();
                switch (tipo)
                {
                    case 1://CPF
                        var frmConsultarAlunoCPF = new FrmConsultarAluno(Tela.DisciplinaAluno, Consulta.CPF, maskedTextBoxCPF.Text);
                        if (frmConsultarAlunoCPF.ShowDialog() == DialogResult.Yes)
                            listaAlunos = frmConsultarAlunoCPF.listaAlunoSelecionados;
                        break;
                    case 2://matricula
                        var frmConsultarAlunoMatricula = new FrmConsultarAluno(Tela.DisciplinaAluno, Consulta.Matricula, txtPesquisarMatricula.Text);
                        if (frmConsultarAlunoMatricula.ShowDialog() == DialogResult.Yes)
                            listaAlunos = frmConsultarAlunoMatricula.listaAlunoSelecionados;
                        break;
                    case 3://Nome
                        var frmConsultarAlunoNome = new FrmConsultarAluno(Tela.DisciplinaAluno, Consulta.Nome, txtPesquisarNome.Text);
                        if (frmConsultarAlunoNome.ShowDialog() == DialogResult.Yes)
                            listaAlunos = frmConsultarAlunoNome.listaAlunoSelecionados;

                        break;
                }
                maskedTextBoxCPF.Text = string.Empty;
                txtPesquisarMatricula.Text = string.Empty;
                txtPesquisarNome.Text = string.Empty;
                return listaAlunos;
            }
            catch (Exception exception)
            {
                throw new Exception("Errs. Detalhes: " + exception.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno foi selecionado.", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var turmaPeriodoDisciplinaAluno = dataGridViewAluno.SelectedRows[0].DataBoundItem as TurmaPeriodoDisciplinaAlunos;

            if (MessageBox.Show("Nenhum aluno foi selecionado.", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var retorno = new TurmaPeriodoDisciplinaAlunosRegraNegocio().Manipulacoes("3", turmaPeriodoDisciplinaAluno);

            try
            {
                var codigo = Convert.ToInt32(retorno);
                MessageBox.Show("Aluno removido da disciplina com sucesso.", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                MessageBox.Show(retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
