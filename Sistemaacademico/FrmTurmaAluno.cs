using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmTurmaAluno : Form
    {
        public FrmTurmaAluno()
        {
            InitializeComponent();
        }		
		Turma turmaSelecionada;
        List<TurmaAluno> turmaAlunoColecao, turmaAlunoColecaoAlterar;
        bool controle = true;
        Tela telaSelecionada;
		public FrmTurmaAluno(Turma turma, Tela tela, TurmaAlunoColecao turmaAlunoColecaoSelecionado)
		{
			InitializeComponent();
            dataGridViewAluno.AutoGenerateColumns = false;
			turmaSelecionada = turma;
            turmaAlunoColecao = new TurmaAlunoColecao();
            turmaAlunoColecaoAlterar = new TurmaAlunoColecao();
			txtCodigo.Text = turma.Codigo.ToString();
			txtNome.Text = turma.Nome.ToString();
			txtInstituicao.Text = turma.Instituicao.NomeFantasia.ToString();
			txtCurso.Text = turma.Curso.Nome.ToString();
			txtTurno.Text = turma.Turno.Nome.ToString();
			switch (turma.SituacaoTurma.Codigo)
			{
				case 1:
					radioButtonSituacaoEmAndamento.Checked = true;
					break;
				case 2:
					radioButtonSituacaoFinalizado.Checked = true;
					break;
				case 3:
					radioButtonSituacaoCancelado.Checked = true;
					break;

			}
            if(tela == Tela.Alterar)
            {                
                turmaAlunoColecaoAlterar = turmaAlunoColecaoSelecionado.ToList();
                turmaAlunoColecao = turmaAlunoColecaoSelecionado.ToList();                
                dataGridViewAluno.DataSource = null;
                dataGridViewAluno.DataSource = turmaAlunoColecao;
                dataGridViewAluno.Update();
                dataGridViewAluno.Refresh();     
            }
		}     

        private Aluno PesquisarAluno (int tipo, string dados)
        {
            try
            {                
                Aluno aluno = new Aluno();
                switch (tipo)
                {
                    case 1: //CPF
                        var frmConsultarAlunoCPF = new FrmConsultarAluno(Tela.TurmaAluno, Consulta.CPF, maskedTextBoxCPF.Text); 
                        if (frmConsultarAlunoCPF.ShowDialog() == DialogResult.Yes)
                                aluno = frmConsultarAlunoCPF.alunoSelecionado;
                        break;
                    case 2://Matricula
                        var frmConsultarAlunoMatricula = new FrmConsultarAluno(Tela.TurmaAluno, Consulta.Matricula, txtPesquisarMatricula.Text);
                            if (frmConsultarAlunoMatricula.ShowDialog() == DialogResult.Yes)
                            aluno = frmConsultarAlunoMatricula.alunoSelecionado;
                        break;
                    case 3://Nome
                        var frmConsultarAlunoNome = new FrmConsultarAluno(Tela.TurmaAluno, Consulta.Nome, txtPesquisarNome.Text); 
                        if (frmConsultarAlunoNome.ShowDialog() == DialogResult.Yes)
                        aluno = frmConsultarAlunoNome.alunoSelecionado;
                        break;
                }
                maskedTextBoxCPF.Text = string.Empty;
                txtPesquisarMatricula.Text = string.Empty;
                txtPesquisarNome.Text = string.Empty;
                return aluno;
            }
            catch (Exception exception)
            {
                throw new Exception("Erro. Detalhes: " + exception.Message);
            }
        }

        private void maskedTextBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (maskedTextBoxCPF.Text.Equals(string.Empty))
                        return;
                    AlimentarGrid(PesquisarAluno(1, maskedTextBoxCPF.Text.ToString()));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxCPF_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCPF.Text.Length < 11)
                return;
            AlimentarGrid(PesquisarAluno(1,  maskedTextBoxCPF.Text.ToString()));
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtPesquisarMatricula.Text.Equals(string.Empty))
                    return;
                AlimentarGrid(PesquisarAluno(2, maskedTextBoxCPF.Text.ToString()));
            }
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarMatricula.Text.Equals(string.Empty))
                return;
            AlimentarGrid(PesquisarAluno(2, maskedTextBoxCPF.Text.ToString()));
        }

        private void AlimentarGrid(Aluno aluno)        
        {
            if (aluno.Codigo.ToString() != "0")
            {
                if (turmaAlunoColecao.Any(x => x.Aluno.Codigo == aluno.Codigo))
                {
                    MessageBox.Show("Aluno já está inserido na turma selecionada.", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var turmaAluno = new TurmaAluno();
                turmaAluno.Aluno = aluno;
                turmaAluno.Turma = turmaSelecionada;
                turmaAluno.UsuarioAlterou = LoginSistema.UsuarioLogin;
                turmaAluno.SituacaoCurso = new SituacaoCurso { Codigo = 1 };
                turmaAlunoColecao.Add(turmaAluno);
                dataGridViewAluno.DataSource = null;
                dataGridViewAluno.DataSource = turmaAlunoColecao;
                dataGridViewAluno.Refresh();
                dataGridViewAluno.Update();
            }           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {            
            AlimentarGrid(PesquisarAluno(3, ""));
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {            
            if (dataGridViewAluno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno foi selecionado.", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var alunoGrid = dataGridViewAluno.SelectedRows[0].DataBoundItem as TurmaAluno;
            if (telaSelecionada == Tela.Alterar)
            {
                if (turmaAlunoColecaoAlterar.Any(x => x.Aluno.Codigo == alunoGrid.Aluno.Codigo))
                    MessageBox.Show("Não é possível remover um aluino que já estava cadastrado na turma, faça alteração da sua situação na tela anterior.", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }            
            if (turmaAlunoColecao.Any(x => x.Aluno.Codigo == alunoGrid.Aluno.Codigo))
            {
                controle = false;                
                turmaAlunoColecao.Remove(alunoGrid);
                dataGridViewAluno.DataSource = null;                
                dataGridViewAluno.DataSource = turmaAlunoColecao;
                controle = true;
                dataGridViewAluno.Update();
                dataGridViewAluno.Refresh();
            }
        }

        private void dataGridViewAluno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (!controle)
                    return;
                if ((dataGridViewAluno.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewAluno.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewAluno.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewAluno.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void txtPesquisarNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtPesquisarNome.Text.Equals(string.Empty))
                    return;
                AlimentarGrid(PesquisarAluno(3, txtPesquisarNome.Text.ToString()));
            }
        }

        private void txtPesquisarNome_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarNome.Text.Equals(string.Empty))
                return;
            AlimentarGrid(PesquisarAluno(3, txtPesquisarNome.Text.ToString()));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
         {
            try
            {

                if (dataGridViewAluno.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum Aluno foi selecionado.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(telaSelecionada == Tela.Alterar)
                    {
                        var turmaAlunoColecaoDiferente = turmaAlunoColecao.Except(turmaAlunoColecaoAlterar).ToList();
                        turmaAlunoColecao = turmaAlunoColecaoDiferente;
                    }                    
                    var turmaAlunoRegraNegocio = new TurmaAlunoRegraNegocio();
                    foreach (var turmaAluno in turmaAlunoColecao)
                    {                        
                        var retorno = turmaAlunoRegraNegocio.Manipulacoes("1", turmaAluno);
                        try
                        {
                            var codigo = Convert.ToInt32(retorno);
                        }
                        catch 
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Alunos cadastrados na turma com sucesso.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }   
   
}
