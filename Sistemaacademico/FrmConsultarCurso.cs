using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmConsultarCurso : Form
    {
        public FrmConsultarCurso()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
        }

        private void LimparCampos()
        {
            txtPesquisar.Text = "";
            txtPesquisar.Focus();
        }

        private void AtualizarGrid()

        {
            try
            {
                var cursoRegraNegocio = new CursoRegraNegocio();
                string situacao = null;
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";               
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = cursoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null, situacao);
                }
                else
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = cursoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,txtPesquisar.Text.ToString(), situacao);
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

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
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
                    MessageBox.Show("Nenhum curso foi selecionado.", "Exibir",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                var curso = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Curso);
                var frmCurso = new FrmCurso(Tela.Exibir, curso);
                frmCurso.ShowDialog();



            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a exibição. Detalhes: " + exception.Message, "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            try
            {
                var frmcurso = new FrmCurso(Tela.Inserir, null);
                if (frmcurso.ShowDialog() == DialogResult.Yes)
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
                    MessageBox.Show("Nenhum curso foi selecionado.", "Alterar", 
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                var curso = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Curso);
                var frmCurso = new FrmCurso(Tela.Alterar, curso);
                if (frmCurso.ShowDialog() == DialogResult.Yes)
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
                    MessageBox.Show("Nenhum curso foi selecionado.", "Excluir",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                } 
                if (MessageBox.Show("Deseja excluir o curso selecionado?", "Excluir", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var cursoRegraNegocio = new CursoRegraNegocio();
                    var retorno = cursoRegraNegocio.Manipulacoes("3", 
                        (dataGridViewResultado.SelectedRows[0].DataBoundItem as Curso));
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Curso selecionado excluido com sucesso", "Excluir", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Não foi possível excluir o curso selecionado, " +
                            "pois o mesmo está sendo utilizado em outras tabelas.", "Erro", 
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
