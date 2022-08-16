using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmConsultarDisciplinasMinistradas : Form
    {
        private readonly string emAndamento = "1", finalizado = "2", cancelado = "3";

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void AtualizarGrid()
        {
            try
            {
                string situacao = null;

                if (radioButtonSituacaoEmAndamento.Checked)
                    situacao = emAndamento;
                else if (radioButtonSituacaoFinalizado.Checked)
                    situacao = finalizado;
                else 
                    situacao = cancelado;

                dataGridViewTurma.DataSource = null;
                var periodoDisciplinaRegraNegocio = new PeriodoDisciplinaRegraNegocio();

                if (radioButtonCodigo.Checked)
                {
                    dataGridViewTurma.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    txtPesquisar.Text.ToString(), 
                    null, 
                    null, 
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null, 
                    null, 
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString(): null);
                }
                else if (radioButtonCodigoDisciplina.Checked)
                {
                    dataGridViewTurma.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    null, 
                    txtPesquisar.Text.ToString(), 
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null, 
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonNomeDisciplina.Checked)
                {
                    dataGridViewTurma.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    null, 
                    null,
                    txtPesquisar.Text.ToString(),
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null, 
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonCodigoProfessor.Checked)
                {
                    dataGridViewTurma.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    null, 
                    null, 
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : txtPesquisar.Text.ToString(),
                    null,                      
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonNomeProfessor.Checked)
                {
                    dataGridViewTurma.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    null, 
                    null, 
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null, 
                    txtPesquisar.Text.ToString(), 
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                dataGridViewTurma.Update();
                dataGridViewTurma.Refresh();
                lblTotalRegistros.Text = $"Total Registro(s): {dataGridViewTurma.RowCount.ToString()}";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public FrmConsultarDisciplinasMinistradas()
        {
            InitializeComponent();
            dataGridViewTurma.AutoGenerateColumns = false;
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCodigoDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNomeDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCodigoProfessor_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNomeProfessor_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina ministrada foi selecionada.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var periodoDisciplina = (dataGridViewTurma.SelectedRows[0].DataBoundItem as PeriodoDisciplina);
                var frmDisciplinaMinistrada = new FrmDisciplinasMinistradas(Tela.Exibir, periodoDisciplina);
                frmDisciplinaMinistrada.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição da disciplina ministrada. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {                
                var frmDisciplinaMinistrada = new FrmDisciplinasMinistradas(Tela.Inserir, null);
                frmDisciplinaMinistrada.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar o cadastro da disciplina ministrada. Detalhes: " + exception.Message,
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

                var periodoDisciplina = (dataGridViewTurma.SelectedRows[0].DataBoundItem as PeriodoDisciplina);
                var frmDisciplinaMinistrada = new FrmDisciplinasMinistradas(Tela.Alterar, periodoDisciplina);
                if (frmDisciplinaMinistrada.ShowDialog() == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTurma.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina ministrada foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                var periodoDisciplina = (dataGridViewTurma.SelectedRows[0].DataBoundItem as PeriodoDisciplina);
                if (MessageBox.Show("Deseja Excluir a disciplina ministrada selecionada?", "Excluir", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var retorno = new PeriodoDisciplinaRegraNegocio().Manipulacoes("3", periodoDisciplina);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina Ministrada selecionada excluída com sucesso.", "Excluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Disciplina Ministrada selecionada não pode se excluída, pois está sendo utilizada em outras tabelas.",
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnVincularAlunos_Click(object sender, EventArgs e)
        {
            if (dataGridViewTurma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma disciplina foi selecionada.", "Consulta Alunos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var periodoDisciplina = dataGridViewTurma.SelectedRows[8].DataBoundItem as PeriodoDisciplina;

            var frmDisciplinaAluno = new FrmDisciplinaAluno(periodoDisciplina);
            frmDisciplinaAluno.ShowDialog();
        }

        private void btnPesquisar_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
