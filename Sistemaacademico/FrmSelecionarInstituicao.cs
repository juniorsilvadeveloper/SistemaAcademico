using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmSelecionarInstituicao : Form
    {
        public FrmSelecionarInstituicao()
        {
            InitializeComponent();
            btnAdicionarInstituicao.Enabled = LoginSistema.UsuarioLogin.Administrador;
            AtualizarComboBoxInstituicao();
        }

        private void AtualizarComboBoxInstituicao()
        {
            try
            {
                var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                var dataTable = instituicaoRegraNegocio.CarregarComboBox(LoginSistema.UsuarioLogin.Administrador ? null : 
                    LoginSistema.UsuarioLogin.Codigo.ToString());
                comboBoxInstituicao.DropDownStyle = ComboBoxStyle.DropDown;
                comboBoxInstituicao.DataSource = dataTable;
                comboBoxInstituicao.ValueMember = "Codigo";
                comboBoxInstituicao.DisplayMember = "NomeFantasia";
                comboBoxInstituicao.Update();
                comboBoxInstituicao.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxInstituicao.SelectedIndex == -1)
                    MessageBox.Show("Selecione uma instituição.", "Selecionar Instituição", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                else
                {
                    var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                    LoginSistema.Instituicao = 
                        instituicaoRegraNegocio.ConsultarCodigoUnico(comboBoxInstituicao.SelectedValue.ToString());
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituicao_Leave(object sender, EventArgs e)
        {
            try
            {
                string textoCombo = comboBoxInstituicao.Text;
                if (string.IsNullOrWhiteSpace(textoCombo) || comboBoxInstituicao.FindStringExact(textoCombo) < 0)
                {
                    this.comboBoxInstituicao.SelectedIndex = -1;
                    if (comboBoxInstituicao.Items.Count > 0)
                        this.comboBoxInstituicao.SelectedIndex = 0;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == 13)
                {
                    int index = comboBoxInstituicao.FindString(comboBoxInstituicao.Text);
                    comboBoxInstituicao.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmSelecionarInstituicao_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (LoginSistema.Instituicao == null)
                {
                    if (MessageBox.Show("A seleção da instituição é obrigatória. " +
                                                                "Caso não seja selecionada, automaticamente você será" +
                                                                "direcionada para sua instituição. Deseja continuar?",
                                 "Selecionar instituição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var instituicaoRegraNegocio = new InstituicaoRegraNegocio();
                        LoginSistema.Instituicao =
                            instituicaoRegraNegocio.ConsultarCodigoUnico(LoginSistema.UsuarioLogin.Instituicao.Codigo
                                .ToString());
                        this.Close();
                    }
                    else
                        e.Cancel = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarInstituicao_Click(object sender, EventArgs e)
        {
            try
            {
                var frmInstituicao = new FrmInstituicao(Tela.Inserir, null);
                DialogResult dialogResult = frmInstituicao.ShowDialog();
                AtualizarComboBoxInstituicao();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o cadastro da nova instituição. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxInstituicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSelecionarInstituicao_Load(object sender, EventArgs e)
        {

        }
    }
}
