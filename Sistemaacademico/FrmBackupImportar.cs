using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmBackupImportar : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        string connectionString = "";
        string erro = "";
        public FrmBackupImportar()
        {
            InitializeComponent();
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if((txtServidor.Text == "") || (txtLogon.Text == "") || (txtSenha.Text == ""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connectionString = "Data Source = " + txtServidor.Text + "; User id=" + txtLogon.Text + "; Password" + txtSenha.Text + "";
                groupBoxSQLServerAutenticacao.Enabled = false;
                btnSair.Enabled = false;
                btnRestaurar.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a conexão com o servidor de banco de dados. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowserRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalizacaoRestauracao.Text = openFileDialog.FileName;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxBancoDeDados.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione o banco de dados.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(comboBoxBancoDeDados.Text != "SistemaAcademico")
                {
                    MessageBox.Show("Selecione o banco de dados com o nome SistemaAcademico.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(txtLocalizacaoRestauracao.Text == "")
                {
                    MessageBox.Show("Selecione o diretório do arquivo de restauração.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Deseja importar o backup selecionado?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    sql = "Alter Database" + comboBoxBancoDeDados + "Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "Restore Database" + comboBoxBancoDeDados + "FROM Disk = '" + txtLocalizacaoRestauracao.Text + "'WITH REPLACE;";
                    comboBoxBancoDeDados.Enabled = false;
                    txtLocalizacaoRestauracao.ReadOnly = true;
                    btnBrowserRestaurar.Enabled = false;
                    btnRestaurar.Enabled = false;
                    btnSair.Enabled = false;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show("Não foi possível realizar a importação do backup. " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBackupImportar_Load(object sender, EventArgs e)
        {
            groupBoxSelecionarBaseDeDados.Enabled = false;
            groupBoxRestaurarBaseDeDados.Enabled = false;
            txtServidor.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker1.ReportProgress(40);
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
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
                if(e.Cancelled)
                {
                    MensagemErro(erro);
                    comboBoxBancoDeDados.Enabled = true;
                    txtLocalizacaoRestauracao.ReadOnly = false;
                    btnBrowserRestaurar.Enabled = true;
                    btnRestaurar.Enabled = true;
                    btnSair.Enabled = true;
                    backgroundWorker1.ReportProgress(0);
                }
                else
                {
                    MensagemErro("Restauração de Backup realizada com sucesso.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void MensagemErro(string mensagem)
        {
            try
            {
                if (erro == "")
                    MessageBox.Show(mensagem, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    erro = "";
                    progressBar1.Value = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar o backup. " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker2.ReportProgress(50);
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                backgroundWorker2.ReportProgress(100);
            }
            catch (Exception exception)
            {
                erro = exception.Message.ToString();
                e.Cancel = true;
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Increment(e.ProgressPercentage);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled)
                {
                    MensagemErroConexao(erro);
                    groupBoxSQLServerAutenticacao.Enabled = true;                    
                    btnRestaurar.Enabled = true;
                    btnSair.Enabled = true;                   
                }
                else
                {
                    MensagemErroConexao("Conexão realizada com sucesso.");
                }
            }
            catch (Exception)
            {

            }
        }
        private void MensagemErroConexao(string mensagem)
        {
            try
            {
                if(erro == "")
                {
                    comboBoxBancoDeDados.Items.Clear();
                    while(reader.Read())
                    {
                        comboBoxBancoDeDados.Items.Add(reader[0].ToString());
                    }
                    groupBoxRestaurarBaseDeDados.Enabled = true;
                    groupBoxRestaurarBaseDeDados.Enabled = true;
                    groupBoxSQLServerAutenticacao.Enabled = false;
                    btnRestaurar.Enabled = true;
                    progressBar2.Value = 0;
                    progressBar1.Visible = true;
                    progressBar2.Visible = true;
                    MessageBox.Show(mensagem, "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    erro = "";
                    progressBar2.Value = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a configuração." + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
