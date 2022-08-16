using System;
using System.Windows.Forms;
using RegrasNegocio;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmConsultarDisciplina : Form
    {
        private void AtualizarGrid()
        {
            try
            {
                var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                string situacao = null;
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = disciplinaRegraNegocio.Consultar(
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null,
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        situacao);
                }
                else
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = disciplinaRegraNegocio.Consultar(
                        null,
                        txtPesquisar.Text.ToString(),
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
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
        private void LimparCampos()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }
        public FrmConsultarDisciplina()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
        }      

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
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

        private void FrmConsultarDisciplina_KeyPress(object sender, KeyPressEventArgs e)
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
                    AtualizarGrid();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina foi selecionada.", "Exibir",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                var disciplina = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Disciplina);
                var frmDisciplina = new FrmDisciplina(Tela.Exibir, disciplina);
                frmDisciplina.ShowDialog();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a exibição. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                var frmDisciplina = new FrmDisciplina(Tela.Inserir, null);
                if (frmDisciplina.ShowDialog() == DialogResult.Yes)
                    AtualizarGrid();

            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar o novo cadastro. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma Disciplina foi selecionada.", "Alterar",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                var disciplina = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Disciplina);
                var frmDisciplina = new FrmDisciplina(Tela.Alterar, disciplina);
                if (frmDisciplina.ShowDialog() == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a alteração. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhuma disciplina foi selecionada.", "Excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja excluir a disciplina selecionada?", "Excluir",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var disciplinaRegraNegocio = new DisciplinaRegraNegocio();
                    var retorno = disciplinaRegraNegocio.Manipulacoes("3",
                        (dataGridViewResultado.SelectedRows[0].DataBoundItem as Disciplina));
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Disciplina selecionada excluida com sucesso", "Excluir",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Não foi possível excluir a disciplina selecionado, " +
                            "pois a mesma está sendo utilizada em outras tabelas.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a exclusão. Detalhes: " + exception.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
