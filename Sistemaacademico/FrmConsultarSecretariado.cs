using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmConsultarSecretariado : Form
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
                var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                string situacao = null;
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = secretariadoRegraNegocio.Consultar( 
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null,
                        null,
                        situacao);                     
                }
                else if (radioButtonNome.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = secretariadoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        situacao);                    
                }
                else // CPF
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = secretariadoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        null,
                        maskedTextBoxCPF.Text.ToString(),
                        situacao);                                        
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
        public FrmConsultarSecretariado()
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

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum secretariado foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var secretariado = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Secretariado);
                var frmSecretariado = new FrmSecretariado(Tela.Exibir, secretariado);
                frmSecretariado.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição do secretariado. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum secretariado foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var secretariado = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Secretariado);
                var frmSecretariado = new FrmSecretariado(Tela.Alterar, secretariado);
                DialogResult dialogResult = frmSecretariado.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração do secretariado. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum secretariado foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Excluir o secretariado selecioado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var secretariado = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Secretariado);
                var secretariadoRegraNegocio = new SecretariadoRegraNegocio();
                string retorno = secretariadoRegraNegocio.Manipulacoes("3", secretariado);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    if (codigo != 0)
                        MessageBox.Show("secretariado selecionado excluído com sucesso.", "Excluir", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("secretariado selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("secretariado selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão do secretariado. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoSecretariado_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSecretariado frmSecretariado = new FrmSecretariado(Tela.Inserir, null);
                DialogResult dialogResult = frmSecretariado.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo secretariado. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
