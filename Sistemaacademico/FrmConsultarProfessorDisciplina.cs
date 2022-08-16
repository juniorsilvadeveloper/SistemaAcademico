using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmConsultarProfessorDisciplina : Form
    {
        private void AtualizarPropertyName()
        {
            if (radioButtonDisciplina.Checked)
            {
                colCodigoDisciplina.DataPropertyName = "Codigo";
                colNomeDisciplina.DataPropertyName = "Nome";
                colCodigoProfessor.DataPropertyName = "Professor.Codigo";
                colNomeProfessor.DataPropertyName = "Professor.Nome";
                colSituacaoDisciplina.Visible = false;
                colSituacaoProfessor.Visible = true;
            }
            else
            {
                colCodigoDisciplina.DataPropertyName = "Disciplina.Codigo";
                colNomeDisciplina.DataPropertyName = "Disciplina.Nome";
                colCodigoProfessor.DataPropertyName = "Codigo";
                colNomeProfessor.DataPropertyName = "Nome";
                colSituacaoDisciplina.Visible = true;
                colSituacaoProfessor.Visible = false;
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
                if (radioButtonProfessor.Checked)
                {
                    //Consultar Professor
                    var professorRegraNegocio = new ProfessorRegraNegocio();                    
                   
                    if (radioButtonCodigo.Checked)
                    {
                        dataGridViewProfessor.DataSource = null;
                        dataGridViewProfessor.DataSource = professorRegraNegocio.Consultar(
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                            null,
                            null,
                            "1");
                        
                    }
                    else if (radioButtonNome.Checked)
                    {
                        dataGridViewProfessor.DataSource = null;
                        dataGridViewProfessor.DataSource = professorRegraNegocio.Consultar(
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            null,
                            txtPesquisar.Text.ToString(),
                            null,
                            "1");
                    }
                    else // CPF
                    {
                        dataGridViewProfessor.DataSource = null;
                        dataGridViewProfessor.DataSource = professorRegraNegocio.Consultar(
                            LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                            null,
                            null,
                            maskedTextBoxCPF.Text.ToString(),
                            "1");
                    }
                    dataGridViewProfessor.Update();
                    dataGridViewProfessor.Refresh();
                }
                else
                {
                    var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                   
                    if (radioButtonCodigo.Checked)
                    {
                        dataGridViewDisciplina.DataSource = null;
                        dataGridViewDisciplina.DataSource = disciplinaRegraNegocio.Consultar(
                            txtPesquisar.Text.ToString(),
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
            txtPesquisar.Visible = true;
            maskedTextBoxCPF.Visible = false;
        }
        public FrmConsultarProfessorDisciplina()
        {
            InitializeComponent();
            dataGridViewDisciplina.AutoGenerateColumns = false;
            dataGridViewProfessor.AutoGenerateColumns = false;
        }
       
        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = false;
            maskedTextBoxCPF.Visible = true;
            maskedTextBoxCPF.Text = "";
        }

        private void radioButtonProfessor_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonCPF.Visible = true;
            radioButtonNome.Checked = true;
            if (radioButtonCPF.Checked)
                maskedTextBoxCPF.Visible = true;
            LimparCampos();
            AtualizarGrids();
        }

        private void radioButtonDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonCPF.Visible = false;
            maskedTextBoxCPF.Visible = false;
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

        private void AtualizarGridProfessorSelectionChangedSituacao()
        {
            try
            {
                if (radioButtonProfessor.Checked && dataGridViewProfessor.SelectedRows.Count > 0)
                {
                    var professor = (dataGridViewProfessor.SelectedRows[0].DataBoundItem as Professor);
                    var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                    dataGridViewDisciplina.DataSource = null;
                    dataGridViewDisciplina.DataSource =
                        professorDisciplinaRegraNegocio.Consultar(professor.Codigo.ToString(),
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

        private void dataGridViewProfessor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarGridProfessorSelectionChangedSituacao();
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
                    var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                    dataGridViewProfessor.DataSource = null;
                    dataGridViewProfessor.DataSource =
                        professorDisciplinaRegraNegocio.Consultar(null,null,disciplina.Codigo.ToString(),
                        null, SituacaoG(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                    dataGridViewProfessor.Update();
                    dataGridViewProfessor.Refresh();
                    AtualizarPropertyName();
                }
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

        private void dataGridViewProfessor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewProfessor.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewProfessor.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewProfessor.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewProfessor.Columns[e.ColumnIndex].DataPropertyName
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

        private void btnPesquisar_KeyPress(object sender, KeyPressEventArgs e)
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

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProfessor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Professor professor;                
                if (radioButtonDisciplina.Checked)
                {
                    var professorRegraNegocio = new ProfessorRegraNegocio();
                    professor = professorRegraNegocio.ConsultarCodigoUnico((
                        (dataGridViewProfessor.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Professor.Codigo
                        .ToString()), null);
                }
                else
                    professor = (dataGridViewProfessor.SelectedRows[0].DataBoundItem as Professor);
                var frmProfessor = new FrmProfessor(Tela.Exibir, professor);
                frmProfessor.ShowDialog();
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
                if (radioButtonProfessor.Checked)
                {
                    var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                    disciplina = disciplinaRegraNegocio.ConsultarCodigoUnico((
                        (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Disciplina.Codigo
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
            if (radioButtonProfessor.Checked)
            {
                var situacao =
                    (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Situacao == true
                    ? "inativar"
                    : "ativar";
                mensagem = $"Deseja {situacao} o professor {(dataGridViewProfessor.SelectedRows[0].DataBoundItem as Professor).Nome.ToString()}" +
                           $" da disciplina {(dataGridViewDisciplina.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Disciplina.Nome.ToString()}?";
            }
            else
            {
                var situacao =
                    (dataGridViewProfessor.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Situacao == true
                    ? "inativar"
                    : "ativar";
                mensagem = $"Deseja {situacao} a disciplina {(dataGridViewDisciplina.SelectedRows[0].DataBoundItem as Disciplina).Nome.ToString()}" +
                           $" do professor {(dataGridViewProfessor.SelectedRows[0].DataBoundItem as ProfessorDisciplina).Professor.Nome.ToString()}?";
            }
            return mensagem;
        }

        private void btnAtivarInativar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDisciplina.RowCount == 0 || dataGridViewProfessor.RowCount == 0)
                    return;
                if (MessageBox.Show(MensagemBox(), "Ativar/Inativar", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProfessorDisciplina professorDisciplina;
                    if (radioButtonProfessor.Checked)
                        professorDisciplina = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as ProfessorDisciplina);
                    else
                        professorDisciplina = (dataGridViewProfessor.SelectedRows[0].DataBoundItem as ProfessorDisciplina);
                    professorDisciplina.Situacao = professorDisciplina.Situacao == true ? false : true;
                    professorDisciplina.UsuarioAlterou = LoginSistema.UsuarioLogin;
                    var professorDisciplinaRegraNegocio = new ProfessorDisciplinaRegraNegocio();
                    var retorno = professorDisciplinaRegraNegocio.Manipulacoes("2", professorDisciplina);
                    try
                    {
                        var codigo = int.Parse(retorno);
                        MessageBox.Show("Alteração realizada com sucesso.", "Ativa/Inativar", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGridDisciplinaSelectionChangedSituacao();
                        AtualizarGridProfessorSelectionChangedSituacao();
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
            AtualizarGridProfessorSelectionChangedSituacao();
        }

        private void radioButtonSituacaoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridDisciplinaSelectionChangedSituacao();
            AtualizarGridProfessorSelectionChangedSituacao();
        }

        private void radioButtonSituacaoInativo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarGridDisciplinaSelectionChangedSituacao();
            AtualizarGridProfessorSelectionChangedSituacao();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            try
            {
                var frmProfessorDisciplina = new FrmProfessorDisciplina(Tela.Inserir, null);
                var dialogResult = frmProfessorDisciplina.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    AtualizarGrids();
                    AtualizarGridDisciplinaSelectionChangedSituacao();
                    AtualizarGridProfessorSelectionChangedSituacao();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDisciplina.SelectedRows.Count == 0 || dataGridViewProfessor.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecione o professor e a disciplina para realizar a consulta. ", "Exibir",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }

                ProfessorDisciplina professorDisciplina;
                if (radioButtonProfessor.Checked)
                    professorDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as ProfessorDisciplina;
                else
                    professorDisciplina = dataGridViewProfessor.SelectedRows[0].DataBoundItem as ProfessorDisciplina;
                var frmProfessorDisciplina = new FrmProfessorDisciplina(Tela.Exibir, professorDisciplina);
                frmProfessorDisciplina.ShowDialog();
                
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
