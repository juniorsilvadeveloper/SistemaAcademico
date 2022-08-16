using ObjetoTransferencia;
using RegrasNegocio;
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
    public partial class FrmPeriodoDisciplina : Form
    {
        private readonly TurmaPeriodo turmaPeriodo;
        private void AtualizarComboBoxDisciplina(string instituicao)
        {
            try
            {
                var periodoDisciplinaRegraNegocio = new PeriodoDisciplinaRegraNegocio();
                comboBoxDisciplina.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxDisciplina.DataSource = periodoDisciplinaRegraNegocio.Consultar(
                    null, null, null, null, null, "1", instituicao, null);
                comboBoxDisciplina.ValueMember = "Codigo";
                comboBoxDisciplina.DisplayMember = "NomeDisciplina";
                comboBoxDisciplina.Update();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
       
        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            try
            {
                var frmDsciplinasMinistradas = new FrmDisciplinasMinistradas(Tela.Inserir, null);
                if (frmDsciplinasMinistradas.ShowDialog() == DialogResult.Yes)
                    AtualizarComboBoxDisciplina(turmaPeriodo.Turma.Instituicao.Codigo.ToString());
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar o cadastro da nova disciplina ministrada. Detalhes: " + exception.Message,
                     "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxDisciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxDisciplina.FindString(comboBoxDisciplina.Text);
                    comboBoxDisciplina.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxDisciplina_Leave(object sender, EventArgs e)
        {
            try
            {
                string text = comboBoxDisciplina.Text;
                if (string.IsNullOrWhiteSpace(text) || comboBoxDisciplina.FindStringExact(text) < 0)
                {
                    this.comboBoxDisciplina.SelectedIndex = -1;
                    if (comboBoxDisciplina.Items.Count > 0)
                        this.comboBoxDisciplina.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxDisciplina_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDisciplina.SelectedValue != null && comboBoxDisciplina.ValueMember != "")
                    txtProfessor.Text = new PeriodoDisciplinaRegraNegocio().ConsultarCodigoUnico(comboBoxDisciplina.SelectedValue.ToString())
                        .Professor.Nome.ToString();
                else
                {
                    txtProfessor.Name = string.Empty;
                    return;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
            }
        }
        public FrmPeriodoDisciplina()
        {
            InitializeComponent();
        }
        public FrmPeriodoDisciplina(TurmaPeriodo turmaPeriodo)
        {
            InitializeComponent();
            this.turmaPeriodo = turmaPeriodo;
            txtCurso.Text = turmaPeriodo.Turma.Curso.Nome.ToString();
            txtTurma.Text = turmaPeriodo.Turma.Nome.ToString();
            txtPeriodo.Text = turmaPeriodo.Periodo.Nome.ToString();
            AtualizarComboBoxDisciplina(turmaPeriodo.Turma.Instituicao.Codigo.ToString());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxDisciplina.SelectedIndex == -1)
                    MessageBox.Show("Preencha todos os dados acima.", "Salvar", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);
                else if(MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var turmaPeriodoDisciplina = new TurmaPeriodoDisciplina
                    {
                        PeriodoDisciplina = new PeriodoDisciplina
                        {
                            Codigo = Convert.ToInt32(comboBoxDisciplina.SelectedValue)
                        },
                        TurmaPeriodo = turmaPeriodo,
                        UsuarioAlterou = LoginSistema.UsuarioLogin
                    };
                    var retorno = new TurmaPeriodoDisciplinaRegraNegocio().Manipulacoes("1", turmaPeriodoDisciplina);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        MessageBox.Show("Vinculação realizada com sucesso.", "Salvar", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível realizar a vinculação. Detalhes: " + retorno, "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
