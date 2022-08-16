using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmTurmaFrequenciaAula : Form
    {
        TurmaFrequenciaAula turmaFrequenciaAulaSelecionada;
        PeriodoDisciplina periodoDisciplinaSelecionada;
        TurmaPeriodoDisciplinaAlunosColecao turmaPeriodoDisciplinaAlunosLista;
        TurmaFrequenciaAulaAlunoColecao turmaFrequenciaAulaAlunoLista;
        Tela telaSelecionada;
        public FrmTurmaFrequenciaAula()
        {
            InitializeComponent();
        }

        public FrmTurmaFrequenciaAula (TurmaFrequenciaAula turmaFrequenciaAula, PeriodoDisciplina periodoDisciplina, Tela tela)
        {
            InitializeComponent();
            dataGridViewAlunos.AutoGenerateColumns = false;
            this.turmaFrequenciaAulaSelecionada = turmaFrequenciaAula;
            this.periodoDisciplinaSelecionada = periodoDisciplina; 
            this.telaSelecionada = tela;

            if (tela == Tela.Inserir)
            {
                txtCodigoDisciplina.Text = periodoDisciplina.Codigo.ToString(); 
                txtDisciplina.Text = periodoDisciplina.Disciplina.Nome.ToString(); 
                txtProfessor.Text = periodoDisciplina.Professor.Nome.ToString();
                CarregarGrid();
            }
            else if(tela == Tela.Alterar)
            {
                CarregarTurmaFrequencia();
                VerificarAlunoDisponivelSemRegistroNaAula();
                CarregarGrid();
            }
            else
            {
                CarregarTurmaFrequencia();
                CarregarGrid();
                BloquearCampos();
            }
                
        }

        private void VerificarAlunoDisponivelSemRegistroNaAula()
        {
            var alunosSemRegistro = new TurmaFrequenciaAulaAlunoRegraNegocio().
                ConsultarAlunosDisponiveisSemRegistroAulaDaDisciplina(turmaFrequenciaAulaSelecionada.Codigo.ToString(),
                turmaFrequenciaAulaSelecionada.PeriodoDisciplina.Codigo.ToString());
            if (alunosSemRegistro.Count == 0)
                return;
            InserirAlunosSemRegistroNaAula(alunosSemRegistro);
        }

        private void InserirAlunosSemRegistroNaAula (TurmaFrequenciaAulaAlunoColecao turmaFrequenciaAlunos)
        {
            var logAlunoSucesso = "Código do Aluno(s) com aula refistrada com sucesso:\n";
            var logAlunoErro = "Código do Aluno(s) com ocorrência de erro:\n";
            foreach (var turmaFrequenciaAluno in turmaFrequenciaAlunos)
            {
                turmaFrequenciaAluno.QuantidadeAulas = turmaFrequenciaAulaSelecionada.QuantidadeAulas;
                turmaFrequenciaAluno.UsuarioAlterou = LoginSistema.UsuarioLogin;
                turmaFrequenciaAluno.TurmaFrequenciaAula = turmaFrequenciaAulaSelecionada;

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
            MessageBox.Show($"Alguns alunos estavam disponíveis na disciplina sem registro da aula selecionada." +
                $"Os registros foram efetuados, sendo lançados com registros de falta.\n{logAlunoSucesso}\n{logAlunoErro}", 
                "Alunos sem registro de aula", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CarregarTurmaFrequencia()
        {
            txtCodigoDisciplina.Text = turmaFrequenciaAulaSelecionada.PeriodoDisciplina.Codigo.ToString();
            txtDisciplina.Text = turmaFrequenciaAulaSelecionada.PeriodoDisciplina.Disciplina.Nome.ToString();
            txtProfessor.Text = turmaFrequenciaAulaSelecionada.PeriodoDisciplina.Professor.Nome.ToString();

            txtCodigoFrequencia.Text = turmaFrequenciaAulaSelecionada.Codigo.ToString();
            dateTimeDataFrequencia.Value = turmaFrequenciaAulaSelecionada.Data;
            txtQuantidadeAulas.Text = turmaFrequenciaAulaSelecionada.QuantidadeAulas.ToString();
            checkBoxAvaliação.Checked = turmaFrequenciaAulaSelecionada.Avaliacao;
            txtConteudoVivenciado.Text = turmaFrequenciaAulaSelecionada.ConteudoVivenciado.ToString();
        }

        private void CarregarGrid()
        {
            dataGridViewAlunos.DataSource = null;
            if (telaSelecionada == Tela.Inserir)
            {
                turmaPeriodoDisciplinaAlunosLista = new TurmaPeriodoDisciplinaAlunosRegraNegocio().ConsultarAlunosDisponiveisParaAulaDaDisciplina(periodoDisciplinaSelecionada.Codigo.ToString());
                dataGridViewAlunos.DataSource = turmaPeriodoDisciplinaAlunosLista;
            }
            else
            {
                turmaFrequenciaAulaAlunoLista = new TurmaFrequenciaAulaAlunoRegraNegocio().Consultar(turmaFrequenciaAulaSelecionada.Codigo.ToString(),                
                   LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null, null, null, null, null, null, null);
                dataGridViewAlunos.DataSource = turmaFrequenciaAulaAlunoLista;
            } 
                dataGridViewAlunos.Update();
                dataGridViewAlunos.Refresh();
        }

        private void BloquearCampos()
        {
            dateTimeDataFrequencia.Enabled = false;
            txtQuantidadeAulas.ReadOnly = true;
            checkBoxAvaliação.Enabled = false;
            txtConteudoVivenciado.ReadOnly = true;
            colQtdFaltas.ReadOnly = true;
            colFaltou.ReadOnly = true;
            btnSalvar.Visible = false;
            dataGridViewAlunos.ReadOnly = true;
        }

        private void dataGridViewAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewAlunos.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewAlunos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewAlunos.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewAlunos.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewAlunos_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewAlunos.SelectedRows.Count != 0)
            {             
                PreencherCampoTurmaPorPeriodoDisciplina(dataGridViewAlunos.SelectedRows[0].Cells[0].Value.ToString(), 
                        txtCodigoDisciplina.Text.ToString());
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

        private void dataGridViewAlunos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridViewAlunos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                if(!char.IsControl(e.KeyChar))
                 e.Handled = true;                 
            }          
        }

        private void txtQuantidadeAulas_Leave(object sender, EventArgs e)
        {
            if (txtQuantidadeAulas.Text == string.Empty || Convert.ToInt32(txtQuantidadeAulas.Text) == 0)
                txtQuantidadeAulas.Text = "1";

            if (telaSelecionada == Tela.Alterar && Convert.ToInt32(txtQuantidadeAulas.Text) != turmaFrequenciaAulaSelecionada.QuantidadeAulas)
            {
                if (MessageBox.Show("Deseja reajustar os alunos com falta igual a quantidade anterior para a quantidade atual?", "Reajuste de Faltas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                    return;
                ReajustarFaltas();
                dataGridViewAlunos.Update();
                dataGridViewAlunos.Refresh();
            }
        }

        private void ReajustarFaltas()
        {
            foreach (var turmaFrequenciaAulaAluno in turmaFrequenciaAulaAlunoLista)
            {
                if (turmaFrequenciaAulaAluno.QuantidadeAulas == turmaFrequenciaAulaSelecionada.QuantidadeAulas)
                {
                    turmaFrequenciaAulaAluno.QuantidadeAulas = Convert.ToInt32(txtQuantidadeAulas.Text);
                    turmaFrequenciaAulaAluno.QtdFaltas = txtQuantidadeAulas.Text;
                }
            }
            turmaFrequenciaAulaSelecionada.QuantidadeAulas = Convert.ToInt32(txtQuantidadeAulas.Text);
        }

        private void txtQuantidadeAulas_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyInput = e.KeyChar.ToString();
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar == '\b'))
                e.Handled = true;
        }

        private void FrmTurmaFrequenciaAula_Load(object sender, EventArgs e)
        {
            MyDataGridViewInitializationMethod();
        }
        private void MyDataGridViewInitializationMethod()
        {
            dataGridViewAlunos.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewAlunos_EditingControlShowing);
        }       

        private void dataGridViewAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colFaltou"))
                dataGridViewAlunos.SelectedRows[0].Cells[2].Value = !(bool)dataGridViewAlunos.SelectedRows[0].Cells[3].Value ?
             txtQuantidadeAulas.Text : "0";
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewAlunos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno na disciplina", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if ((dataGridViewAlunos.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToInt32(x.Cells[2].Value) > 
                Convert.ToInt32(txtQuantidadeAulas.Text))).Any())
                {
                    MessageBox.Show("Existem alunos com faltas registradas que o número de aulas.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                switch(telaSelecionada)
                {
                    case Tela.Inserir:
                        Inserir();
                        break;
                    case Tela.Alterar:
                        Alterar();
                        break;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível realizar a operação. Detalhes:{ exception.Message}", "Salvar", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inserir()
        {
            var logAlunoSucesso = "Código do Aluno(s) com aula refistrada com sucesso:\n";
            var logAlunoErro = "Código do Aluno(s) com ocorrência de erro:\n";
            var turmaFrequenciaAula = GravarTurmaFrequenciaAula();
            var retorno = new TurmaFrequenciaAulaRegraNegocio().Manipulacoes("1", turmaFrequenciaAula);
            try
            {                
                var codigo = Convert.ToInt32(retorno);
                turmaFrequenciaAula.Codigo = codigo;
            }
            catch (Exception)
            {
                throw new Exception(retorno);               
            }

            ///Percorrer o grid para lançar a frequencia por aluno
            foreach (var turmaPeriodoDisciplinaAlunos in turmaPeriodoDisciplinaAlunosLista)
            {
                retorno = new TurmaFrequenciaAulaAlunoRegraNegocio().Manipulacoes("1", GravarTurmaFrequenciaAulaAluno(turmaPeriodoDisciplinaAlunos, turmaFrequenciaAula));
                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logAlunoSucesso = string.Concat(logAlunoSucesso, turmaPeriodoDisciplinaAlunos.Aluno.Codigo.ToString(), "  ");                    
                }
                catch
                {
                    logAlunoErro = string.Concat(logAlunoErro, turmaPeriodoDisciplinaAlunos.Aluno.Codigo.ToString(), "- {0}\n", retorno);
                }
            }
            MessageBox.Show($"Aula registrada com sucesso.\nLog:\n{logAlunoSucesso}\n{logAlunoErro}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.Yes;
        }

        private void Alterar()
        {
            var logAlunoSucesso = "Código do Aluno(s) com aula refistrada com sucesso:\n";
            var logAlunoErro = "Código do Aluno(s) com ocorrência de erro:\n";
            turmaFrequenciaAulaSelecionada.Data = dateTimeDataFrequencia.Value;
            turmaFrequenciaAulaSelecionada.QuantidadeAulas = Convert.ToInt32(txtQuantidadeAulas.Text);
            turmaFrequenciaAulaSelecionada.Avaliacao = checkBoxAvaliação.Checked;
            turmaFrequenciaAulaSelecionada.ConteudoVivenciado = txtConteudoVivenciado.Text;
            turmaFrequenciaAulaSelecionada.UsuarioAlterou = LoginSistema.UsuarioLogin;

            var retorno = new TurmaFrequenciaAulaRegraNegocio().Manipulacoes("2", turmaFrequenciaAulaSelecionada);
            try
            {
                var codigo = Convert.ToInt32(retorno);
               
            }
            catch (Exception)
            {
                throw new Exception(retorno);
            }

            ///Percorrer o grid para lançar a frequencia por aluno
            foreach (var turmaFrequenciaAulaAluno in turmaFrequenciaAulaAlunoLista)
            {
                turmaFrequenciaAulaAluno.QuantidadeAulas = Convert.ToInt32(turmaFrequenciaAulaAluno.QtdFaltas);
                turmaFrequenciaAulaAluno.UsuarioAlterou = LoginSistema.UsuarioLogin;
                retorno = new TurmaFrequenciaAulaAlunoRegraNegocio().Manipulacoes("2", turmaFrequenciaAulaAluno);
                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logAlunoSucesso = string.Concat(logAlunoSucesso, turmaFrequenciaAulaAluno.Aluno.Codigo.ToString(), "  ");
                }
                catch
                {
                    logAlunoErro = string.Concat(logAlunoErro, turmaFrequenciaAulaAluno.Aluno.Codigo.ToString(), "- {0}\n", retorno);
                }
            }
            MessageBox.Show($"Aula alterada com sucesso.\nLog:\n{logAlunoSucesso}\n{logAlunoErro}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.Yes;
        }

        private TurmaFrequenciaAulaAluno GravarTurmaFrequenciaAulaAluno(TurmaPeriodoDisciplinaAlunos turmaPeriodoDisciplinaAlunos, TurmaFrequenciaAula turmaFrequenciaAula)
        {
            return new TurmaFrequenciaAulaAluno
            {
                TurmaFrequenciaAula = turmaFrequenciaAula, 
                Aluno = turmaPeriodoDisciplinaAlunos.Aluno, 
                QuantidadeAulas = Convert.ToInt32(turmaPeriodoDisciplinaAlunos.QtdFaltas),
                UsuarioAlterou = LoginSistema.UsuarioLogin

            };
        }

        private TurmaFrequenciaAula GravarTurmaFrequenciaAula()
        {
            return new TurmaFrequenciaAula
            {
                PeriodoDisciplina = periodoDisciplinaSelecionada,
                Data = dateTimeDataFrequencia.Value,
                QuantidadeAulas = Convert.ToInt32(txtQuantidadeAulas.Text),
                Avaliacao = checkBoxAvaliação.Checked,
                ConteudoVivenciado = txtConteudoVivenciado.Text.ToString(),
                UsuarioAlterou = LoginSistema.UsuarioLogin
            };
        }

        private void dataGridViewAlunos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colFaltou"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[2].EditedFormattedValue.ToString() == "")
                    dataGridViewAlunos.SelectedRows[0].Cells[2].Value = "0";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (telaSelecionada == Tela.Exibir)
                this.Close();
            else if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
