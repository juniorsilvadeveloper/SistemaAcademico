using ObjetoTransferencia;
using System;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmAcademico : Form
    {
        public FrmAcademico()
        {
            InitializeComponent();
            alunoToolStripMenuItem.Visible = LoginSistema.UsuarioLogin.Aluno;
            pedagogicoToolStripMenuItem.Visible = !LoginSistema.UsuarioLogin.Aluno;
            manutencaoToolStripMenuItem.Visible = !LoginSistema.UsuarioLogin.Aluno && !LoginSistema.UsuarioLogin.Professor;
            parametrosToolStripMenuItem.Visible = !LoginSistema.UsuarioLogin.Aluno && !LoginSistema.UsuarioLogin.Professor;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarTurma frmConsultarTurma = new FrmConsultarTurma();
                frmConsultarTurma.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta da nova turma. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void turmaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultarTurma frmConsultarTurma = new FrmConsultarTurma();
                frmConsultarTurma.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta da turma. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void disciplinaMinistradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarDisciplinasMinistradas = new FrmConsultarDisciplinasMinistradas();
                frmConsultarDisciplinasMinistradas.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta da disciplinas ministradas. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void períodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarPeriodo = new FrmConsultarPeriodo();
                frmConsultarPeriodo.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta do período. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void períodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarTurmaPeriodo = new FrmConsultarTurmaPeriodo();
                frmConsultarTurmaPeriodo.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta da turma período. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }    

        private void faltasToolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            var frmConsultarTurmaFrequenciaAula = new FrmConsultarTurmaFrequenciaAula();
            frmConsultarTurmaFrequenciaAula.ShowDialog();
        }

        private void notasToolStripMenuItemAluno_Click(object sender, EventArgs e)
        {
            var frmTurmaEtapaNotaAluno = new FrmTurmaEtapaNotaAluno();
            frmTurmaEtapaNotaAluno.ShowDialog();
        }

        private void faltasToolStripMenuItemPedagogico_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConsultarTurmaFrequenciaAula = new FrmConsultarTurmaFrequenciaAula();
                frmConsultarTurmaFrequenciaAula.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a consulta. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void notasToolStripMenuItemPedagogico_Click(object sender, EventArgs e)
        {
            var frmTurmaEtapaNotaAluno = new FrmTurmaEtapaNotaAluno();
            frmTurmaEtapaNotaAluno.ShowDialog();
        }
    }
}
