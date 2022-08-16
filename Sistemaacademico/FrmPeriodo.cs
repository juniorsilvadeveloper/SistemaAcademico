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

namespace SistemaAcademico
{
    public partial class FrmPeriodo : Form
    {
        public FrmPeriodo()
        {
            InitializeComponent();
        }

        private void PreencherDados(Periodo perido)
        {
            try
            {
                txtCodigo.Text = perido.Codigo.ToString();
                txtNome.Text = perido.Nome.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Tela telaSelecionada;
        private Periodo periodoSelecionado = new Periodo();

        public FrmPeriodo(Tela tela, Periodo periodo)
        {
            InitializeComponent();
            telaSelecionada = tela;
            periodoSelecionado = periodo;
            if (tela == Tela.Inserir)
            {
                this.Text = "Período - Novo";
                txtNome.Focus();
            }
            else if (tela == Tela.Alterar)
            {
                this.Text = "Período - Alterar";
                txtNome.Focus();
                PreencherDados(periodo);
            }
            else // Exibição
            {
                this.Text = "Período - Exibir";
                PreencherDados(periodo);
                txtNome.ReadOnly = true;
                btnSalvar.Visible = false;
            }
        }

        private Periodo BuscarDados()
        {
            try
            {
                var periodo = new Periodo();
                if (txtCodigo.Text != "")
                    periodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                periodo.Nome = txtNome.Text.ToString();
                return periodo;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
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
                        Periodo periodo = BuscarDados();
                        var periodoRegraNegocio = new PeriodoRegraNegocio();
                        string retorno = periodoRegraNegocio.Manipulacoes("1", periodo);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Período cadastrado com sucesso.", "Salvar", MessageBoxButtons.OK,
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
                        Periodo periodo = BuscarDados();
                        var periodoRegraNegocio = new PeriodoRegraNegocio();
                        string retorno = periodoRegraNegocio.Manipulacoes("2", periodo);
                        try
                        {
                            int codigo = Convert.ToInt32(retorno);
                            MessageBox.Show("Período Alterado com sucesso.", "Salvar", MessageBoxButtons.OK,
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

        private void FrmPeriodo_FormClosing(object sender, FormClosingEventArgs e)
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
