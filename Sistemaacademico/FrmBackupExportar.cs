using AcessoBancoDados;
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
    public partial class FrmBackupExportar : Form
    {
        public FrmBackupExportar()
        {
            InitializeComponent();
        }
        string erro = ""; 

        private void btnBrowserBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLocalizacaoBackup.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLocalizacaoBackup.Text == "")
                    MessageBox.Show("Escolha o diretório para salvar o Backup.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (MessageBox.Show("Deseja realizar o backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtLocalizacaoBackup.ReadOnly = true;
                    btnBrowserBackup.Enabled = false;
                    btnBackup.Enabled = false;
                    btnSair.Enabled = false;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível exportar os dados do backup. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sejesa sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmBackupExportar_Load(object sender, EventArgs e)
        {
            btnBrowserBackup.Focus();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorker1.ReportProgress(40);
                AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
                acessoDadosSqlServer.Backup(Convert.ToString(txtLocalizacaoBackup.Text));
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
                    txtLocalizacaoBackup.ReadOnly = false;
                    btnBrowserBackup.Enabled = true;
                    btnBackup.Enabled = true;
                    btnSair.Enabled = true;
                }
                else
                {
                    MensagemErro("Backup realizado com sucesso");
                    this.Close();
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
    }
}
