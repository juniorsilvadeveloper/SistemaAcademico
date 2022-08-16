using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocios;
using System.Linq;

namespace SistemaAcademico
{
    public partial class FrmConsultarAluno : Form
    {
        
        public List<Aluno> listaAlunoSelecionados;
        private ObservableCollection<Aluno> alunosSelecionados;
        public ObservableCollection<Aluno> AlunosSelecionados
        {
            get { return alunosSelecionados; }
        }

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
                var alunoRegraNegocio = new AlunoRegraNegocio();
                string situacao = null;
                if (radioButtonSituacaoAtivo.Checked)
                    situacao = "1";
                else if (radioButtonSituacaoInativo.Checked)
                    situacao = "0";
                if (radioButtonCodigo.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = alunoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                        null,
                        null,
                        situacao,
                        null);
                }
                else if (radioButtonNome.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = alunoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        txtPesquisar.Text.ToString(),
                        null,
                        situacao,
                        null);
                }
                else if (radioButtonMatricula.Checked)
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = alunoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        null,
                        null,
                        situacao,
                        txtPesquisar.Text.ToString());
                }
                else // CPF
                {
                    dataGridViewResultado.DataSource = null;
                    dataGridViewResultado.DataSource = alunoRegraNegocio.Consultar(
                        LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                        null,
                        null,
                        maskedTextBoxCPF.Text.ToString(),
                        situacao,
                        null);
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
        public FrmConsultarAluno()
        {
            InitializeComponent();
            dataGridViewResultado.AutoGenerateColumns = false;
        }

        Tela telaSelecionada;
        public Aluno alunoSelecionado;
        public FrmConsultarAluno(Tela tela, Consulta consulta, string texto)
        {
            InitializeComponent();
            listaAlunoSelecionados = new List<Aluno>();
            alunosSelecionados = new ObservableCollection<Aluno>();
            dataGridViewResultado.AutoGenerateColumns = false;
            btnVincular.Visible = true;
            if (tela == Tela.DisciplinaAluno)
                dataGridViewResultado.MultiSelect = true;
            telaSelecionada = tela;                                 
            radioButtonSituacaoAtivo.Checked = true;
            radioButtonSituacaoTodos.Enabled = false;
            radioButtonSituacaoInativo.Enabled = false;
            switch (consulta)
            {
                case Consulta.Nome:
                    radioButtonNome.Checked = true;
                    txtPesquisar.Text = texto;
                    break;

                case Consulta.Matricula:
                    radioButtonMatricula.Checked = true;
                    txtPesquisar.Text = texto;
                    break;

                case Consulta.CPF:
                    radioButtonCPF.Checked = true;
                    maskedTextBoxCPF.Text = texto;
                    break;
            }
            AtualizarGrid();
            
        }


        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonMatricula_CheckedChanged(object sender, EventArgs e)
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

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            try
            {
                var frmAluno = new FrmAluno(Tela.Inserir, null);
                DialogResult dialogResult = frmAluno.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo aluno. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno foi selecionado.", "Exibir", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var aluno = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Aluno);
                var frmAluno = new FrmAluno(Tela.Exibir, aluno);
                frmAluno.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exibição do aluno. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno foi selecionado.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }

                var aluno = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Aluno);
                var frmAluno = new FrmAluno(Tela.Alterar, aluno);
                DialogResult dialogResult = frmAluno.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a alteração do aluno. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum aluno foi selecionada.", "Alterar", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Deseja Excluir o aluno selecioado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var aluno = (dataGridViewResultado.SelectedRows[0].DataBoundItem as Aluno);
                var alunoRegraNegocio = new AlunoRegraNegocio();
                string retorno = alunoRegraNegocio.Manipulacoes("3", aluno);
                try
                {
                    int codigo = Convert.ToInt32(retorno);
                    if (codigo != 0)
                        MessageBox.Show("Aluno selecionado excluído com sucesso.", "Excluir", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Aluno selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AtualizarGrid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Aluno selecionado não pode se excluído, pois está sendo utilizado em outras tabelas.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão do aluno. Detalhes: " + exception.Message,
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

        private void dataGridViewResultado_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private List<Aluno> PreencherIdentificadores()
        {
            var listaAlunosSelecionados = new List<Aluno>();
            foreach (var aluno in dataGridViewResultado.SelectedRows)
                listaAlunoSelecionados.Add((aluno as DataGridViewRow).DataBoundItem as Aluno);
            return listaAlunosSelecionados.ToList();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            if(dataGridViewResultado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno foi selecionado.", "Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (telaSelecionada == Tela.TurmaAluno)
            {              
                alunoSelecionado = dataGridViewResultado.SelectedRows[0].DataBoundItem as Aluno;
                this.DialogResult = DialogResult.Yes;
            }
            else if (telaSelecionada == Tela.DisciplinaAluno)
            {
                if (MessageBox.Show("Deseja vincular os alunos selecionado?", "Vincular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listaAlunoSelecionados = PreencherIdentificadores();
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }
    }
}
