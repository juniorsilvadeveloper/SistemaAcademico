using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmConsultarInstituicao : Form
    {
        private bool FormatarGrid;
        private void LimparPesquisa()
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
            txtPesquisar.Visible = true;
            maskedTextBoxCNPJ.Visible = false;
        }

        private void AtualizarGrid()
        {
            try
            {
                FormatarGrid = true;

                var instituicaoColecao = new InstituicaoColecao();
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();

                string situacao;

                if (radioButtonSituacaoTodos.Checked)
                    situacao = null;
                else if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else
                    situacao = "0";

                if (radioButtonCodigo.Checked)
                {
                    instituicaoColecao = instituicaoRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null, 
                        null, 
                        null, 
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = instituicaoColecao;
                }
                else if (radioButtonNomeFantasia.Checked)
                {
                    instituicaoColecao = instituicaoRegraNegocio.Consultar(
                        null,
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = instituicaoColecao;
                }
                else if (radioButtonRazaoSocial.Checked)
                {
                    instituicaoColecao = instituicaoRegraNegocio.Consultar(
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        null,
                        situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = instituicaoColecao;
                }
                else // CNPJ
                {
                    instituicaoColecao = instituicaoRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    maskedTextBoxCNPJ.Text.ToString(),
                    situacao);
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = instituicaoColecao;
                }
                dataGridViewResultado.Update();
                dataGridViewResultado.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewResultado.RowCount.ToString();

                //FormatarGrid = false;       
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmConsultarInstituicao()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
            btnNovaInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            btnExcluir.Enabled = LoginSistema.UsuarioLogin.Administrador;
            groupBoxConsultar.Enabled = LoginSistema.UsuarioLogin.Administrador;
            if(!LoginSistema.UsuarioLogin.Administrador)
            {
                radioButtonCodigo.Checked = true;
                txtPesquisar.Text = LoginSistema.UsuarioLogin.Instituicao.Codigo.ToString();
                AtualizarGrid();
            }
        }

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNomeFantasia_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonRazaoSocial_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = false;
            maskedTextBoxCNPJ.Visible = true;
            maskedTextBoxCNPJ.Focus();
            maskedTextBoxCNPJ.Text = "";

        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(radioButtonCodigo.Checked)
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
                    MessageBox.Show("Nenhuma instituição foi selecionada.", "Exibir", MessageBoxButtons.OK, 
                        MessageBoxIcon.Asterisk);
                    return;
                }

                Instituicao instituicao = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Instituicao);
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Exibir, instituicao);
                frmInstituicao.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição da instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma instituição foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                Instituicao instituicao = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Instituicao);
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Alterar, instituicao);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração da instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma instituição foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Excluir a instituição selecioada?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                Instituicao instituicao = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Instituicao);
                InstituicaoRegraNegocio instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                string retorno = instituicaoRegraNegocio.Manipulacoes("3", instituicao);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Instituição excluída com sucesso.", "Excluir", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Instituição selecionada não pode se excluída, pois está sendo utilizada em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão da instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResultado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (FormatarGrid)
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
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
