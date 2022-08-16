using AcessoBancoDados;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmConfigurarConexaoBD : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";
        string erro = "";
        public FrmConfigurarConexaoBD()
        {
            InitializeComponent();
            txtServidor.Focus();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtServidor.Text == "") || (txtLogon.Text == "") || (txtSenha.Text == ""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connectionString = "Data Source = " + txtServidor.Text + "; User id=" + txtLogon.Text + "; Password=" + txtSenha.Text + ";";
                groupBoxSQLServerAutenticacao.Enabled = false;
                btnSair.Enabled = false;
                btnSalvar.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o servidor de banco de dados. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxBancoDeDados.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione o banco de dados.", "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                connectionString = "Data Source = " + txtServidor.Text + "; Initial Catalog=" + 
                    comboBoxBancoDeDados.Text + "; User Id=" + txtLogon.Text + "; Password=" + txtSenha.Text + ";";
                if(MessageBox.Show("Deseja Alterar o local de acesso a dados para o caminho: "+ connectionString,  "Configuração", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
                    acessoDadosSqlServer.AlterarDataSource(connectionString);
                    MessageBox.Show("Local do banco de dados alerado com sucesso.\nLocal: " + connectionString, "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível alterar o local de acesso a dados. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmConfigurarConexaoBD_Load(object sender, EventArgs e)
        {
            groupBoxSelecionarBaseDeDados.Enabled = false;
            txtServidor.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker1.ReportProgress(50);
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                backgroundWorker1.ReportProgress(100);
            }
            catch (Exception exception)
            {
                erro = exception.Message.ToString();
                e.Cancel = true;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Increment(e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MensagemErro(erro);
                    groupBoxSQLServerAutenticacao.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnSair.Enabled = true;
                }
                else
                {
                    MensagemErro("Conexão realizada com sucesso.");
                }
            }
            catch (Exception)
            {

            }
        }
        private void MensagemErro(string mensagem)
        {
            try
            {
                if (erro == "")
                {
                    comboBoxBancoDeDados.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxBancoDeDados.Items.Add(reader[0].ToString());
                    }                    
                    groupBoxSelecionarBaseDeDados.Enabled = true;
                    groupBoxSQLServerAutenticacao.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnSair.Enabled = true;
                    progressBar1.Value = 0;                   
                    MessageBox.Show(mensagem, "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erro = "";
                    progressBar1.Value = 0;                
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a configuração." + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
