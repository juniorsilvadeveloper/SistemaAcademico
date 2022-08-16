using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegrasNegocio;
using RegrasNegocios;

namespace SistemaAcademico
{
    public partial class FrmGrauEscolar : Form
    {
        private void PreencherDados(GrauEscolar grauEscolar)
        {
            try
            {
                txtCodigo.Text = grauEscolar.Codigo.ToString();
                txtNome.Text = grauEscolar.Nome.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public FrmGrauEscolar()
        {
            InitializeComponent();
        }

        private Tela telaSelecionada;
        private GrauEscolar grauEscolarSelecionado = new GrauEscolar();

        public FrmGrauEscolar(Tela tela, GrauEscolar grauEscolar)
        {
            InitializeComponent();
            telaSelecionada = tela;
            grauEscolarSelecionado = grauEscolar;
            if (tela == Tela.Inserir)
            {
                this.Text = "Grau Escolar - Novo";
                txtNome.Focus();
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Grau Escolar - Alterar";
                txtNome.Focus();
                PreencherDados(grauEscolar);
            }
            else // Exibição
            {
                this.Text = "GrauEscolar - Exibir";
                PreencherDados(grauEscolar);
                txtNome.ReadOnly = true;
                btnSalvar.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                    MessageBox.Show("Digite o nome.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else if (MessageBox.Show("Deseja salvar?.", "Salvar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (telaSelecionada == Tela.Inserir)
                    {
                        GrauEscolar grauEscolar = BuscarDados();
                        GrauEscolarRegraNegocio grauEscolarRegraNegocio = new GrauEscolarRegraNegocio();
                        string retorno = grauEscolarRegraNegocio.Manipulacoes("1", grauEscolar);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Grau Escolar cadastrado com sucesso.", "Salvar", MessageBoxButtons.OK,
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
                        GrauEscolar grauEscolar = BuscarDados();
                        GrauEscolarRegraNegocio grauEscolarRegraNegocio = new GrauEscolarRegraNegocio();
                        string retorno = grauEscolarRegraNegocio.Manipulacoes("2", grauEscolar);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Grau Escolar Alterado com sucesso.", "Salvar", MessageBoxButtons.OK,
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

        private GrauEscolar BuscarDados()
        {
            try
            {
                GrauEscolar grauEscolar = new GrauEscolar();
                if (txtCodigo.Text != "")
                    grauEscolar.Codigo = Convert.ToInt32(txtCodigo.Text);
                grauEscolar.Nome = txtNome.Text.ToString();
                return grauEscolar;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void FrmGrauEscolar_FormClosing(object sender, FormClosingEventArgs e)
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
