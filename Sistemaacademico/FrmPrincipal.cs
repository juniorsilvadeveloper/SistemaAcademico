using System;
using System.Windows.Forms;
using ObjetoTransferencia;

namespace SistemaAcademico
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            toolStripStatusLabelVersao.Text = "Versão - " + Application.ProductVersion;
            toolStripStatusLabelUsuario.Text = "Usuário - " + LoginSistema.UsuarioLogin.NomeReal;
            // Permissões iniciais
            if(LoginSistema.UsuarioLogin.Aluno || LoginSistema.UsuarioLogin.Professor)
            {
                cadastroToolStripMenuItem.Visible = false;
                consultaToolStripMenuItem.Visible = false;
                backupToolStripMenuItem.Visible = false;
            }
            
            if(LoginSistema.UsuarioPermissao != null)
            {
                exportarToolStripMenuItem.Enabled = LoginSistema.UsuarioPermissao.ExportarBackup;
                importarToolStripMenuItem.Enabled = LoginSistema.UsuarioPermissao.ImportarBackup;
            }

            instituiçãoToolStripMenuItem.Visible = LoginSistema.UsuarioLogin.Administrador;
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabelDataHora.Text =
                    DateTime.Now.ToShortTimeString() + " - " + DateTime.Now.ToShortDateString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerVerificarInstituicao_Tick(object sender, EventArgs e)
        {
            try
            {
                timerVerificarInstituicao.Enabled = false;
                if (LoginSistema.Instituicao == null)
                {
                    FrmSelecionarInstituicao frmSelecionarInstituicao = new FrmSelecionarInstituicao();
                    frmSelecionarInstituicao.ShowDialog();
                }
                toolStripStatusLabelInstituicao.Text = "Instituição - " + LoginSistema.Instituicao.NomeFantasia;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonTrocarInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSelecionarInstituicao frmSelecionarInstituicao = new FrmSelecionarInstituicao();
                frmSelecionarInstituicao.ShowDialog();
                timerVerificarInstituicao.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instituiçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarInstituicao frmConsultarInstituicao = new FrmConsultarInstituicao();
                frmConsultarInstituicao.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta da instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void instituiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarAluno frmConsultarAluno = new FrmConsultarAluno();
                frmConsultarAluno.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do aluno. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAluno frmAluno = new FrmAluno(Tela.Inserir, null);
                frmAluno.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo aluno. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarProfessor frmConsultarProfessor = new FrmConsultarProfessor();
                frmConsultarProfessor.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do professor. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProfessor frmProfessor = new FrmProfessor(Tela.Inserir, null);
                frmProfessor.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo professor. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void secretariadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarSecretariado frmConsultarSecretariado = new FrmConsultarSecretariado();
                frmConsultarSecretariado.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do secretariado. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void secretariadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSecretariado frmSecretariado = new FrmSecretariado(Tela.Inserir, null);
                frmSecretariado.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo secretariado. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAluno frmAluno = new FrmAluno(Tela.Inserir, null);
                frmAluno.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo aluno. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonCadastrarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProfessor frmProfessor = new FrmProfessor(Tela.Inserir, null);
                frmProfessor.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo professor. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonCadastrarSecretariado_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSecretariado frmSecretariado = new FrmSecretariado(Tela.Inserir, null);
                frmSecretariado.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo secretariado. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonCadastrarInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInstituicao frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarCargo frmConsultarCargo = new FrmConsultarCargo();
                frmConsultarCargo.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do cargo. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCargo frmCargo = new FrmCargo(Tela.Inserir, null);
                frmCargo.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo cargo. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void grauEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGrauEscolar frmGrauEscolar = new FrmGrauEscolar(Tela.Inserir, null);
                frmGrauEscolar.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro do novo grau Escolar. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void grauEscolarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarGrauEscolar frmConsultarGrauEscolar = new FrmConsultarGrauEscolar();
                frmConsultarGrauEscolar.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do novo grau Escolar. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCurso = new FrmCurso(Tela.Inserir, null);
                frmCurso.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar o cadastro do novo curso. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarCurso = new FrmConsultarCurso();
                frmConsultarCurso.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta do curso. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarUsuario = new FrmConsultarUsuario();
                frmConsultarUsuario.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta do usuário. Detalhes: " + exception.Message,
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disciplinaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarDisciplina = new FrmConsultarDisciplina();
                frmConsultarDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta da disciplina. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmDisciplina = new FrmDisciplina(Tela.Inserir, null);
                frmDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta da disciplina. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vincularProfessorDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarProfessorDisciplina = new FrmConsultarProfessorDisciplina();
                frmConsultarProfessorDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta . Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vincularCursoDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarCursoDisciplina = new FrmConsultarCursoDisciplina();
                frmConsultarCursoDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a consulta . Detalhes: " + exception.Message,
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cursoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var frmCursoDisciplina = new FrmCursoDisciplina(Tela.Inserir, null);
                frmCursoDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível fazer a vinculação . Detalhes: " + exception.Message,
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void professorDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmProfessorDisciplina = new FrmProfessorDisciplina(Tela.Inserir, null);
                frmProfessorDisciplina.ShowDialog();
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarTurma = new FrmConsultarTurma();
                frmConsultarTurma.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " +
                            exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void acadêmicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmAcademico = new FrmAcademico();
                frmAcademico.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível abrir módulo Acadêmico. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void períodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmPeriodoDisciplina = new FrmPeriodoDisciplina();
                frmPeriodoDisciplina.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do período. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmBackupExportar = new FrmBackupExportar();
                frmBackupExportar.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível abrir a tela de exportar backup. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmBackupImportar = new FrmBackupImportar();
                frmBackupImportar.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível abrir a tela de importar backup. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
