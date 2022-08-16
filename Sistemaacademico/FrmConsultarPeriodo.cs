using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegrasNegocio;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmConsultarPeriodo : Form
    {
        public FrmConsultarPeriodo()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void AtualizarGrid()
        {
            try
            {
                var periodoRegraNegocio = new PeriodoRegraNegocio();
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = periodoRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null);
                }
                else if (radioButtonNome.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = periodoRegraNegocio.Consultar(
                        null,
                        txtPesquisar.Text.ToString());
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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum período foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var periodo = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Periodo);
                FrmPeriodo frmPeriodo = new FrmPeriodo(Tela.Exibir, periodo);
                frmPeriodo.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição do período. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPeriodo frmPeriodo = new FrmPeriodo(Tela.Inserir, null);
                DialogResult dialogResult = frmPeriodo.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo período. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum período foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                Periodo periodo = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Periodo);
                FrmPeriodo frmPeriodo = new FrmPeriodo(Tela.Alterar, periodo);
                DialogResult dialogResult = frmPeriodo.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração do periodo. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum período foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Excluir o período selecioado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                Periodo periodo = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Periodo);
                PeriodoRegraNegocio periodoRegraNegocio = new PeriodoRegraNegocio();
                string retorno = periodoRegraNegocio.Manipulacoes("3", periodo);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("período selecionado excluído com sucesso.", "Excluir", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("período selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão do período. Detalhes: " + exception.Message,
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
    }
}
