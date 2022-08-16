using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmConsultarProfessor : Form
    {
        private void LimparPesquisa()
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
            txtPesquisar.Visible = true;
            maskedTextBoxCPF.Visible = false;
        }

        private void AtualizarGrid()
        {
            try
            {
                var professorRegraNegocio = new ProfessorRegraNegocio();
                var professorColecao = new ProfessorColecao();
                string situacao = null;                
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";
                if (radioButtonCodigo.Checked)
                {
                    professorColecao = professorRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null,
                        null,
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = professorColecao;
                }
                else if (radioButtonNome.Checked)
                {
                    professorColecao = professorRegraNegocio.Consultar(LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = professorColecao;
                }
                else // CPF
                {
                    professorColecao = professorRegraNegocio.Consultar(LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        null,
                        maskedTextBoxCPF.Text.ToString(),
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = professorColecao;
                }
                dataGridViewResultado.Update();
                dataGridViewResultado.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewResultado.RowCount.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmConsultarProfessor()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = false;
            maskedTextBoxCPF.Visible = true;
            maskedTextBoxCPF.Focus();
            maskedTextBoxCPF.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void btnNovoProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProfessor frmProfessor = new FrmProfessor(Tela.Inserir, null);
                DialogResult dialogResult = frmProfessor.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo professor. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                Professor professor = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Professor);
                FrmProfessor frmProfessor = new FrmProfessor(Tela.Exibir, professor);
                frmProfessor.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição do Professor. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                Professor professor = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Professor);
                FrmProfessor frmProfessor = new FrmProfessor(Tela.Alterar, professor);
                DialogResult dialogResult = frmProfessor.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração do professor. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum professor foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Excluir o professor selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                Professor professor = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Professor);
                ProfessorRegraNegocio professorRegraNegocio = new ProfessorRegraNegocio();
                string retorno = professorRegraNegocio.Manipulacoes("3", professor);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    if (codigo != 0)
                        MessageBox.Show("Professor selecionado excluído com sucesso.", "Excluir", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Professor selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Professor selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão do professor. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewResultado.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewResultado.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewResultado.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewResultado.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FrmConsultarProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
