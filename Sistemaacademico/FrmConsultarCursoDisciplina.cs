using System;
using System.Windows.Forms;
using RegrasNegocio;
using RegrasNegocios;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmConsultarCursoDisciplina : Form
    {
        private void AtualizarPropertyName()
        {
            if (radioButtonDisciplina.Checked)
            {
                colCodigoDisciplina.DataPropertyName = "Codigo";
                colNomeDisciplina.DataPropertyName = "Nome";
                colCodigoCurso.DataPropertyName = "Curso.Codigo";
                colNomeCurso.DataPropertyName = "Curso.Nome";
                colSituacaoDisciplina.Visible = false;
                colSituacaoCurso.Visible = true;
            }
            else
            {
                colCodigoDisciplina.DataPropertyName = "Disciplina.Codigo";
                colNomeDisciplina.DataPropertyName = "Disciplina.Nome";
                colCodigoCurso.DataPropertyName = "Codigo";
                colNomeCurso.DataPropertyName = "Nome";
                colSituacaoDisciplina.Visible = true;
                colSituacaoCurso.Visible = false;
            }
        }

        private string SituacaoG()
        {
            string situacao = null;
            if (radioButtonSituacaoAtivo.Checked)
                situacao = "1";
            else if (radioButtonSituacaoInativo.Checked)
                situacao = "0";
            return situacao;
        }

        private void AtualizarGrids()
        {
            try
            {
                AtualizarPropertyName();
                if (radioButtonCurso.Checked)
                {
                    //Consultar Curso
                    var cursoRegraNegocio = new CursoRegraNegocio();

                    if (radioButtonCodigo.Checked)
                    {
                        dataGridViewCurso.DataSource = null;
                        dataGridViewCurso.DataSource = cursoRegraNegocio.Consultar(
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                            null,
                            "1");

                    }
                    else // Nome
                    {
                        dataGridViewCurso.DataSource = null;
                        dataGridViewCurso.DataSource = cursoRegraNegocio.Consultar(
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),                           
                            null,
                            txtPesquisar.Text.ToString(),
                            "1");

                    }
                    dataGridViewCurso.Update();
                    dataGridViewCurso.Refresh();
                }
                else
                {
                    var disciplinaRegraNegocio = new DisciplinaRegraNegocio();

                    if (radioButtonCodigo.Checked)
                    {
                        dataGridViewDisciplina.DataSource = null;
                        dataGridViewDisciplina.DataSource = disciplinaRegraNegocio.Consultar(
                            txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                            null,
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            "1");
                    }
                    else
                    {
                        dataGridViewDisciplina.DataSource = null;
                        dataGridViewDisciplina.DataSource = disciplinaRegraNegocio.Consultar(
                            null,
                            txtPesquisar.Text.ToString(),
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            "1");
                    }
                    dataGridViewDisciplina.Update();
                    dataGridViewDisciplina.Refresh();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        private void LimparCampos()
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
            //txtPesquisar.Visible = true;
        }
        public FrmConsultarCursoDisciplina()
        {
            InitializeComponent();
            dataGridViewDisciplina.AutoGenerateColumns = false;
            dataGridViewCurso.AutoGenerateColumns = false;
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void radioButtonCurso_CheckedChanged(object sender, EventArgs e)
        {          
            LimparCampos();
            AtualizarGrids();
        }

        private void radioButtonDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
            AtualizarGrids();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrids();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AtualizarGridCursoSelectionChangedSituacao()
        {
            try
            {
                if (radioButtonCurso.Checked && dataGridViewCurso.SelectedRows.Count > 0)
                {
                    var curso = (dataGridViewCurso.SelectedRows[0].DataBoundItem as Curso);
                    var cursoDisciplinaRegraNegocio = new CursoDisciplinaRegraNegocio();
                    dataGridViewDisciplina.DataSource = null;
                    dataGridViewDisciplina.DataSource =
                        cursoDisciplinaRegraNegocio.Consultar(curso.Codigo.ToString(),
                        null, null, null, SituacaoG(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                    dataGridViewDisciplina.Update();
                    dataGridViewDisciplina.Refresh();
                    AtualizarPropertyName();
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        private void AtualizarGridDisciplinaSelectionChangedSituacao()
        {
            try
            {
                if (radioButtonDisciplina.Checked && dataGridViewDisciplina.SelectedRows.Count > 0)
                {
                    var disciplina = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as Disciplina);
                    var cursoDisciplinaRegraNegocio = new CursoDisciplinaRegraNegocio();
                    dataGridViewCurso.DataSource = null;
                    dataGridViewCurso.DataSource =
                       cursoDisciplinaRegraNegocio.Consultar(null, null, disciplina.Codigo.ToString(), 
                       null, SituacaoG(),
                       LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                    dataGridViewCurso.Update();
                    dataGridViewCurso.Refresh();
                    AtualizarPropertyName();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        private void dataGridViewCurso_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarGridCursoSelectionChangedSituacao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDisciplina_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarGridDisciplinaSelectionChangedSituacao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCurso_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewCurso.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewCurso.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewCurso.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewCurso.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
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
                    AtualizarGrids();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        private void dataGridViewCurso_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Curso curso;
                if (radioButtonDisciplina.Checked)
                {
                    var cursoRegraNegocio = new CursoRegraNegocio();
                    curso = cursoRegraNegocio.ConsultarCodigoUnico((
                        (dataGridViewCurso.SelectedRows[0].DataBoundItem as CursoDisciplina).Curso.Codigo
                        .ToString()), null);
                }
                else
                    curso = (dataGridViewCurso.SelectedRows[0].DataBoundItem as Curso);
                var frmCurso = new FrmCurso(Tela.Exibir, curso);
                frmCurso.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewDisciplina_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Disciplina disciplina;
                if (radioButtonCurso.Checked)
                {
                    var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                    disciplina = disciplinaRegraNegocio.ConsultarCodigoUnico((
                        (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as CursoDisciplina).Disciplina.Codigo
                        .ToString()), null);
                }
                else
                    disciplina = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as Disciplina);
                var frmDisciplina = new FrmDisciplina(Tela.Exibir, disciplina);
                frmDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string MensagemBox()
        {
            string mensagem = string.Empty;
            if (radioButtonCurso.Checked)
            {
                var situacao =
                    (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as CursoDisciplina).Situacao == true
                    ? "inativar"
                    : "ativar";
                mensagem = $"Deseja {situacao} o curso {(dataGridViewCurso.SelectedRows[0].DataBoundItem as Curso).Nome.ToString()}" +
                           $" da disciplina {(dataGridViewDisciplina.SelectedRows[0].DataBoundItem as CursoDisciplina).Disciplina.Nome.ToString()}?";
            }
            else
            {
                var situacao =
                    (dataGridViewCurso.SelectedRows[0].DataBoundItem as CursoDisciplina).Situacao == true
                    ? "inativar"
                    : "ativar";
                mensagem = $"Deseja {situacao} a disciplina {(dataGridViewDisciplina.SelectedRows[0].DataBoundItem as Disciplina).Nome.ToString()}" +
                           $" do curso {(dataGridViewCurso.SelectedRows[0].DataBoundItem as CursoDisciplina).Curso.Nome.ToString()}?";
            }
            return mensagem;
        }
        private void btnAtivarInativar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCurso.RowCount == 0 || dataGridViewDisciplina.RowCount == 0)
                return;
            try
            {
                if (MessageBox.Show(MensagemBox(), "Ativar/Inativar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CursoDisciplina cursoDisciplina;
                    if (radioButtonCurso.Checked)
                        cursoDisciplina = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as CursoDisciplina);
                    else
                        cursoDisciplina = (dataGridViewCurso.SelectedRows[0].DataBoundItem as CursoDisciplina);
                    cursoDisciplina.Situacao = cursoDisciplina.Situacao == true ? false : true;
                    cursoDisciplina.UsuarioAlterou = LoginSistema.UsuarioLogin;
                    var cursoDisciplinaRegraNegocio = new CursoDisciplinaRegraNegocio();
                    var retorno = cursoDisciplinaRegraNegocio.Manipulacoes("2", cursoDisciplina);
                    try
                    {
                        var codigo = int.Parse(retorno);
                        MessageBox.Show("Alteração realizada com sucesso.", "Ativa/Inativar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGridDisciplinaSelectionChangedSituacao();
                        AtualizarGridCursoSelectionChangedSituacao();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Não foi possível realizar a alteração. Detalhes: {retorno}", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void radioButtonSituacaoTodos_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridDisciplinaSelectionChangedSituacao();
            AtualizarGridCursoSelectionChangedSituacao();
        }

        private void radioButtonSituacaoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridDisciplinaSelectionChangedSituacao();
            AtualizarGridCursoSelectionChangedSituacao();
        }

        private void radioButtonSituacaoInativo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridDisciplinaSelectionChangedSituacao();
            AtualizarGridCursoSelectionChangedSituacao();
        }
        private void btnVincular_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCursoDisciplina = new FrmCursoDisciplina(Tela.Inserir, null);
                var dialogResult = frmCursoDisciplina.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    AtualizarGrids();
                    AtualizarGridDisciplinaSelectionChangedSituacao();
                    AtualizarGridCursoSelectionChangedSituacao();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEixibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDisciplina.SelectedRows.Count == 0 || dataGridViewCurso.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione o curso e a disciplina para realizar a consulta. ", "Exibir",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                CursoDisciplina cursoDisciplina;
                if (radioButtonCurso.Checked)
                    cursoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as CursoDisciplina;
                else
                    cursoDisciplina = dataGridViewCurso.SelectedRows[0].DataBoundItem as CursoDisciplina;
                var frmCursoDisciplina = new FrmCursoDisciplina(Tela.Exibir, cursoDisciplina);
                frmCursoDisciplina.ShowDialog();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
