using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;

namespace SistemaAcademico
{
    public partial class FrmCargo : Form
    {
        private void PreencherDados(Cargo cargo)
        {
            try
            {
                txtCodigo.Text = cargo.Codigo.ToString();
                txtNome.Text = cargo.Nome.ToString();
                txtDescricao.Text = cargo.Descricao.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public FrmCargo()
        {
            InitializeComponent();
        }

        private Tela telaSelecionada;
        private Cargo cargoSelecionado = new Cargo();

        public FrmCargo(Tela tela, Cargo cargo)
        {
            InitializeComponent();
            telaSelecionada = tela;
            cargoSelecionado = cargo;
            if (tela == Tela.Inserir)
            {
                this.Text = "Cargo - Novo";
                txtNome.Focus();
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Cargo - Alterar";
                txtNome.Focus();
                PreencherDados(cargo);
            }
            else // Exibição
            {
                this.Text = "Cargo - Exibir";
                PreencherDados(cargo);
                txtNome.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                btnSalvar.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                    MessageBox.Show("Digite o nome.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        Cargo cargo = BuscarDados();
                        CargoRegraNegocio cargoRegraNegocio = new CargoRegraNegocio();
                        string retorno = cargoRegraNegocio.Manipulacoes("1", cargo);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Cargo cadastrado com sucesso.", "Salvar",MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else // Alterar
                    {
                        Cargo cargo = BuscarDados();
                        CargoRegraNegocio cargoRegraNegocio = new CargoRegraNegocio();
                        string retorno = cargoRegraNegocio.Manipulacoes("2", cargo);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Cargo Alterado com sucesso.", "Salvar", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Não foi possível realizar o cadastro. Detalhes: " + retorno, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a operação selecionada. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cargo BuscarDados()
        {
            try
            {
                Cargo cargo = new Cargo();
                if (txtCodigo.Text != "")
                    cargo.Codigo = Convert.ToInt32(txtCodigo.Text);
                cargo.Nome = txtNome.Text.ToString();
                cargo.Descricao = txtDescricao.Text.ToString();
                return cargo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void FrmCargo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (telaSelecionada == Tela.Exibir)
                    btnSair.DialogResult = DialogResult.None;
                else
                    if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
                    txtNome.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
