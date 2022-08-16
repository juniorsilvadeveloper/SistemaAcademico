using ObjetoTransferencia;
using RegrasNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class FrmTurmaEtapaNotaAluno : Form
    {
        private readonly string emAndamento = "1", finalizado = "2", cancelado = "3";
        private string logErro;
        private TurmaEtapa turmaEtapa;
        PeriodoDisciplinaColecao periodoDisciplinaColecao;
        TurmaEtapaNotaAlunoColecao turmaEtapaNotaAlunoLista;
        TurmaPeriodoDisciplinaAlunosColecao turmaPeriodoDisciplinaAlunosLista;
        private string log;
        private bool verificarPendencia = false;

        private void radioButtonCodigo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonDisciplina_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void radioButtonProfessor_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
            if(!verificarPendencia) VerificarPendencias();
        }

        private void AtualizarGrid()
        {
            try
            {
                string situacao = null;
                if (radioButtonSituacaoEmAndamento.Checked)
                    situacao = emAndamento;
                else if (radioButtonSituacaoFinalizado.Checked)
                    situacao = finalizado;
                else if (radioButtonSituacaoCancelado.Checked)
                    situacao = cancelado;

                dataGridViewDisciplina.DataSource = null;
                var periodoDisciplinaRegraNegocio = new PeriodoDisciplinaRegraNegocio();
                if (radioButtonCodigo.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    txtPesquisar.Text == "" ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null,
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonDisciplina.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text.ToString(),
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    null,
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                else if (radioButtonProfessor.Checked)
                {
                    periodoDisciplinaColecao = periodoDisciplinaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    LoginSistema.UsuarioLogin.Professor ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null,
                    txtPesquisar.Text.ToString(),
                    situacao,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                }
                dataGridViewDisciplina.DataSource = periodoDisciplinaColecao;
                dataGridViewDisciplina.Update();
                dataGridViewDisciplina.Refresh();
                lblTotalRegistrosDisciplinas.Text = $"Total Registro(s): {dataGridViewDisciplina.RowCount.ToString()}";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDisciplina_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewDisciplina.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewDisciplina.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewDisciplina.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewDisciplina.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }       

        private void groupBoxCriarEtapas_Leave(object sender, EventArgs e)
        {
            EsconderGroupBoxCriarEtapas();
        }

        private void EsconderGroupBoxCriarEtapas()
        {
            groupBoxCriarEtapas.Visible = false;
            numericUpDownQuantidadeEtapa.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            EsconderGroupBoxCriarEtapas();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if(numericUpDownQuantidadeEtapa.Value == 0)
            {
                MessageBox.Show("Quantidade deve maior que 0 (zero)", "Criar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownNotaPorEtapa.Value == 0)
            {
                MessageBox.Show("Nota por etapa deve maior que 0 (zero)", "Criar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Deseja criar a quantidade de etapas informada?", "Criar Etapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            CriarEtapas();
            CarregarComboBoxEtapas((dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).Codigo);
            AlterarVisibilidadeDoControleEtapa();
        }

        private void CriarEtapas()
        {
            logErro = string.Empty;
            try
            {
                var turmaPeriodoDisciplinaAlunosLista = new TurmaPeriodoDisciplinaAlunosRegraNegocio()
                    .ConsultarAlunosDisponiveisParaAulaDaDisciplina((dataGridViewDisciplina.SelectedRows[0]
                    .DataBoundItem as PeriodoDisciplina).Codigo.ToString());
                var turmaEtapa = new TurmaEtapa
                {
                    PeriodoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina,
                    Nota = Convert.ToDouble(numericUpDownNotaPorEtapa.Value),
                    UsuarioAlterou = LoginSistema.UsuarioLogin,
                };
                for(int i = 1; i <= numericUpDownNotaPorEtapa.Value; i++)
                {
                    turmaEtapa.Nome = string.Concat(i, "ª Etapa");
                    var retorno = new TurmaEtapaRegraNegocio().Manipulacoes("1", turmaEtapa);
                    try
                    {
                        var codigo = Convert.ToInt32(retorno);
                        turmaEtapa.Codigo = codigo;
                        VincularAlunosNaEtapa(turmaPeriodoDisciplinaAlunosLista.Select(x => x.Aluno).ToList(), turmaEtapa);
                    }
                    catch (Exception)
                    {
                        logErro = string.Concat(logErro,turmaEtapa.Nome, "ª Etapa - Erro: ", retorno, "\n");
                    }
                }
                if(logErro == string.Empty)         
                    MessageBox.Show("Etapas criadas com sucesso.", "Criar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(string.Concat("Foi gerado exceções durante a criação das etapas abaixo.\n", logErro),"Criar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                EsconderGroupBoxCriarEtapas();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível criar etapas. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VincularAlunosNaEtapa(List<Aluno> alunosDisciplinaLista, TurmaEtapa turmaEtapa)
        {
            foreach (var aluno in alunosDisciplinaLista)
            {
                var retornoEtapaNota = new TurmaEtapaNotaAlunoRegraNegocio().Manipulacoes("1", new TurmaEtapaNotaAluno
                {
                    Aluno = aluno,
                    TurmaEtapa = turmaEtapa,
                    UsuarioAlterou = LoginSistema.UsuarioLogin
                });
                try
                {
                    var codigoTurmaEtapaAluno = Convert.ToInt32(retornoEtapaNota);
                }
                catch
                {
                    logErro = string.Concat(logErro, turmaEtapa.Nome, "ª Etapa - Erro na vinculação dos alunos,", aluno.Codigo.ToString(), " - ",
                        aluno.Nome.ToString(), " na etapa. Detalhes: ", retornoEtapaNota, "\n");
                }
            }
        }
        private void btnCriarEtapas_Click(object sender, EventArgs e)
        {
            if(dataGridViewDisciplina.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma disciplina para criar etapas.", "Criar Etapas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            groupBoxCriarEtapas.Visible = true;
            numericUpDownQuantidadeEtapa.Focus();
        }

        private void dataGridViewDisciplina_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewAlunos.DataSource = null;
            dataGridViewAlunos.Refresh();
            if(dataGridViewDisciplina.SelectedRows.Count != 0)           
                CarregarComboBoxEtapas((dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).Codigo);
            AlterarVisibilidadeDoControleEtapa();
        }

        private void AlterarVisibilidadeDoControleEtapa()
        {
            var visivel = (comboBoxEtapa.DataSource != null);
            btnAdicionarEtapa.Visible = visivel;
            btnAlterarEtapa.Visible = visivel;
            btnExcluirEtapa.Visible = visivel;
            linkLabelInfoAuditoria.Visible = visivel;
            btnCriarEtapas.Visible = !visivel;
            HabilitaEnabledDoControleEtapa();
        }

        private void HabilitaEnabledDoControleEtapa()
        {
            var habilita = (comboBoxEtapa.SelectedIndex != -1);
            btnAdicionarEtapa.Enabled = habilita;
            btnAlterarEtapa.Enabled = habilita;
            btnExcluirEtapa.Enabled = habilita;
            linkLabelInfoAuditoria.Enabled = habilita;
        }

        private void CarregarComboBoxEtapas(int codigo)
        {
            try
            {
                comboBoxEtapa.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxEtapa.DataSource = new TurmaEtapaRegraNegocio().Consultar(null, null, LoginSistema.Instituicao.Codigo == 1 ?
                    null : LoginSistema.Instituicao.Codigo.ToString(), codigo.ToString());
                comboBoxEtapa.ValueMember = "Codigo";
                comboBoxEtapa.DisplayMember = "Nome";
                comboBoxEtapa.Update();
                comboBoxEtapa.Refresh();
                comboBoxEtapa.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxEtapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int index = comboBoxEtapa.FindString(comboBoxEtapa.Text);
                    comboBoxEtapa.SelectedIndex = index;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxEtapa_Leave(object sender, EventArgs e)
        {
            try
            {
                
                if (comboBoxEtapa.SelectedIndex == -1)
                    AtualizarEtapa();
                HabilitaEnabledDoControleEtapa();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }

        private void comboBoxEtapa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEtapa.SelectedValue != null && comboBoxEtapa.ValueMember != "")
                AtualizarEtapa(comboBoxEtapa.SelectedValue.ToString());
            else           
                AtualizarEtapa();
            if(!LoginSistema.UsuarioLogin.Aluno)
                HabilitaEnabledDoControleEtapa();
            lblTotalRegistrosAulas.Text = "Total Registro(s): " + dataGridViewAlunos.RowCount.ToString();
        }

        private void AtualizarEtapa(string etapa = null)
        {
            if (etapa != null)
            {
                turmaEtapa = new TurmaEtapaRegraNegocio().ConsultarCodigoUnico(etapa,
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString(), 
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                if (turmaEtapa == null)
                    return;
                txtCodigoEtapa.Text = turmaEtapa.Codigo.ToString();
                txtEtapa.Text = turmaEtapa.Nome.ToString();
                txtNota.Text = turmaEtapa.Nota.ToString();

                //Carregar Grid com a Etapa
                colNotaTrabalho.Visible = true;
                colNotaAvaliacao.Visible = true;
                colNotaTotalFinal.Visible = false;
                colNotaExameFinal.Visible = false;
                colSituacaoDisciplina.Visible = false;
                colFrequencia.Visible = false;
                colTotal.Visible = true;

                dataGridViewAlunos.DataSource = null;
                turmaEtapaNotaAlunoLista = new TurmaEtapaNotaAlunoRegraNegocio().Consultar(comboBoxEtapa.SelectedValue.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null, null, null, 
                    LoginSistema.Instituicao.Codigo == 1 ? null : LoginSistema.Instituicao.Codigo.ToString());
                dataGridViewAlunos.DataSource = turmaEtapaNotaAlunoLista;
                dataGridViewAlunos.Update();
                dataGridViewAlunos.Refresh();

            }
            else
            {
                var turmaEtapaExameFinal = new TurmaEtapaExameFinalRegraNegocio().Consultar(null, (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).
                    ToString());
                if(turmaEtapaExameFinal != null)
                {
                    txtCodigoEtapa.Text = turmaEtapaExameFinal.Codigo.ToString();                    
                    txtEtapa.Text = turmaEtapaExameFinal.Nota.ToString();
                }
                else
                {
                    txtCodigoEtapa.Text = string.Empty;                    
                    txtNota.Text = string.Empty;
                }
                txtEtapa.Text = string.Empty;           
                //Carregar Grid sem filtro de Etapa
                colNotaTrabalho.Visible = false;
                colNotaAvaliacao.Visible = false;
                colNotaTotalFinal.Visible = true;
                colNotaExameFinal.Visible = true;
                colSituacaoDisciplina.Visible = true;
                colFrequencia.Visible = true;
                colTotal.Visible = false;
                dataGridViewAlunos.DataSource = null;
                var periodoDisciplinaSelecionado = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina);
               turmaPeriodoDisciplinaAlunosLista = new TurmaPeriodoDisciplinaAlunosRegraNegocio().
                    ConsultarAlunosNotaEtapaExameFinal(periodoDisciplinaSelecionado.ToString(), periodoDisciplinaSelecionado.Disciplina.Codigo.ToString(),
                    LoginSistema.UsuarioLogin.Aluno ? LoginSistema.UsuarioLogin.IdUsuario.ToString() : null);
                dataGridViewAlunos.DataSource = turmaPeriodoDisciplinaAlunosLista;
                dataGridViewAlunos.Update();
                dataGridViewAlunos.Refresh();
            }
        }

        private void btnAdicionarEtapa_Click(object sender, EventArgs e)
        {
            if(txtEtapa.ReadOnly)
            {
                txtCodigoEtapa.Text = string.Empty;
                txtEtapa.Text = string.Empty;
                txtNota.Text = "0";
                txtEtapa.ReadOnly = false;
                txtNota.ReadOnly = false;
                btnAlterarEtapa.Enabled = false;
                btnExcluirEtapa.Text = "Cancelar";
                txtEtapa.Focus();
                return;
            }

            if (txtEtapa.Text == string.Empty)
            {
                MessageBox.Show("O campo etapa deve ser preenchido.", "Adicionar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (Convert.ToDouble(txtNota.Text) == 0)
            {
                MessageBox.Show("O campo nota deve ser maior que 0", "Adicionar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }                
            if (MessageBox.Show("Deseja criar a etapa informada?", "Adicionar Etapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                return;

            var turmaEtapa = new TurmaEtapa
            {
                PeriodoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina,
                Nome = txtEtapa.Text,
                Nota = Convert.ToDouble(txtNota.Text),
                UsuarioAlterou = LoginSistema.UsuarioLogin,
            };
            logErro = string.Empty;
            var retorno = new TurmaEtapaRegraNegocio().Manipulacoes("1", turmaEtapa);
            try
            {
                var codigo = Convert.ToInt32(retorno);
                turmaEtapa.Codigo = codigo;
                var turmaPeriodoDisciplinaAlunosLista = new TurmaPeriodoDisciplinaAlunosRegraNegocio()
                    .ConsultarAlunosDisponiveisParaAulaDaDisciplina((dataGridViewDisciplina.SelectedRows[0]
                    .DataBoundItem as PeriodoDisciplina).Codigo.ToString());
                VincularAlunosNaEtapa(turmaPeriodoDisciplinaAlunosLista.Select(x => x.Aluno).ToList(), turmaEtapa);                
                LimparCamposEtapa();
                CarregarComboBoxEtapas((dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).Codigo);
            }
            catch (Exception)
            {
                logErro = string.Concat(logErro, "Não foi possível realizar o cadastro. Detalhes: ", retorno, "\n");
            }
            if (logErro == string.Empty)
                MessageBox.Show("Etapa cadastrada com sucesso", "Adicionar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(logErro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimparCamposEtapa()
        {
            txtCodigoEtapa.Text = string.Empty;
            txtEtapa.Text = string.Empty;
            txtNota.Text = string.Empty;
            txtEtapa.ReadOnly = true;
            txtNota.ReadOnly = true;
            btnAlterarEtapa.Enabled = true;
            btnExcluirEtapa.Text = "Excluir Etapa";
        }

        private void btnExcluirEtapa_Click(object sender, EventArgs e)
        {
            if (btnExcluirEtapa.Text == "Cancelar")
            {
                LimparCamposEtapa();
                return;
            }

            if (comboBoxEtapa.SelectedIndex == -1)
                return;

            if (MessageBox.Show("Deseja criar a etapa selecionada? A exclusão implicará também nos registros dos alunos nesta etapa. Deseja continuar?", "Excluir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var retorno = new TurmaEtapaRegraNegocio().Manipulacoes("3",
                new TurmaEtapa { Codigo = Convert.ToInt32(txtCodigoEtapa.Text) ,
                                PeriodoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina,
                                UsuarioAlterou = LoginSistema.UsuarioLogin
                });

            try
            {
                var codigo = Convert.ToInt32(retorno);
                MessageBox.Show("Etapa excluída com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarComboBoxEtapas((dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).Codigo);

            }
            catch (Exception)
            {
                MessageBox.Show(string.Concat("Não foi possível realizar a exclusão. Detalhes: ", retorno), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnAlterarEtapa_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterarEtapa.Text == "Alterar Etapa")
                {
                    btnAlterarEtapa.Text = "Salvar";
                    txtEtapa.ReadOnly = false;
                    txtNota.ReadOnly = false;
                    btnAlterarSalvar.Enabled = false;
                    dataGridViewAlunos.Enabled = false;                    
                    BloquearDesbloquearCampos(false);
                    btnAlterarEtapa.Enabled = true;
                    btnSair.Text = "Cancelar";
                    return;
                }
                if (comboBoxEtapa.SelectedIndex == -1)
                    return;

                if (txtEtapa.Text == string.Empty)
                {
                    MessageBox.Show("O campo etapa deve ser preenchido.", "Adicionar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToDouble(txtNota.Text) == 0)
                {
                    MessageBox.Show("O campo nota deve ser maior que 0", "Adicionar Etapa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Deseja alterar a etapa informada?", "Adicionar Etapa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                    return;

                var turmaEtapa = new TurmaEtapa
                {
                    Codigo = Convert.ToInt32(txtCodigoEtapa.Text),
                    Nome = txtEtapa.Text.ToString(),
                    Nota = Convert.ToDouble(txtNota.Text),
                    PeriodoDisciplina = new PeriodoDisciplina { Codigo = (dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina).Codigo },

                };
                var retorno = new TurmaEtapaRegraNegocio().Manipulacoes("2", turmaEtapa);

                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAlterarEtapa.Text = "Alterar Etapa";
                    txtEtapa.ReadOnly = true;
                    txtNota.ReadOnly = true;
                    btnAlterarSalvar.Enabled = true;
                    dataGridViewAlunos.Enabled = true;
                    btnSair.Text = "Sair";
                    RestaurarTela();
                }
                catch 
                {
                    MessageBox.Show($"Não foi possível realizar a alteração. Detalhes: {retorno}", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível realizar a alteração. Detalhes: {exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string KeyInput = e.KeyChar.ToString();
                if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == ',') && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                    e.Handled = true;
                if (e.KeyChar == ',' && txtNota.Text == "")
                    e.Handled = true;
                if ((e.KeyChar == ',') && (sender as TextBox).Text.IndexOf(',') > -1)
                    e.Handled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtNota_Leave(object sender, EventArgs e)
        {
            if (txtNota.Text == "")
                txtNota.Text = "0";
        }

        private void linkLabelInfoAuditoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBoxEtapa.SelectedIndex == -1)
                return;
            var infoAuditoria = string.Empty;
            infoAuditoria = string.Concat(infoAuditoria, "Usuário", turmaEtapa.UsuarioAlterou.NomeReal.ToString(), "\n");
            infoAuditoria = string.Concat(infoAuditoria, "Tipo", RetornarTipoUsuario(turmaEtapa.UsuarioAlterou), "\n");
            infoAuditoria = string.Concat(infoAuditoria, "Data Cadastro", turmaEtapa.DataCadastro.ToString(), "\n");            
            infoAuditoria = string.Concat(infoAuditoria, "Data Alteracao", turmaEtapa.DataAlteracao.ToString(), "\n");

            MessageBox.Show(infoAuditoria, "Informações de Auditoria", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private string RetornarTipoUsuario(Usuario usuario)
        {           
            if (usuario.Administrador)
                return "Administrador";
            else if (usuario.Aluno)
                return "Aluno";
            else if (usuario.Professor)
                return "Professor";
            else
                return "Secretariado";
        }

        private void dataGridViewAulas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewAlunos.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewAlunos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewAlunos.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewAlunos.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            groupBoxAluno.Visible = true;
            comboBoxPesquisa.SelectedIndex = 0;
            txtPesquisar.Focus();
        }

        private void groupBoxPesquisaAluno_Leave(object sender, EventArgs e)
        {
            groupBoxPesquisaAluno.Visible = false;
        }

        private void txtPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisaAluno.Text == "")
                return;
            foreach (DataGridViewRow linha in dataGridViewAlunos.Rows)
            {
                if (comboBoxPesquisa.SelectedIndex == 0)
                {
                    if (linha.Cells[1].Value.ToString().Contains(txtPesquisaAluno.Text.ToString()))
                    {
                        dataGridViewAlunos.Rows[linha.Index].Selected = true;
                        dataGridViewAlunos.CurrentCell = dataGridViewAlunos.Rows[linha.Index].Cells[0];
                        return;
                    }
                }
                else
                {
                    if (linha.Cells[2].Value.ToString().Contains(txtPesquisaAluno.Text.ToString()))
                    {
                        dataGridViewAlunos.Rows[linha.Index].Selected = true;
                        dataGridViewAlunos.CurrentCell = dataGridViewAlunos.Rows[linha.Index].Cells[0];
                        return;
                    }
                }

            }
        }

        private void BloquearDesbloquearCampos(bool habilitar)
        {
            btnPesquisar.Enabled = habilitar;
            dataGridViewDisciplina.Enabled = habilitar;
            comboBoxEtapa.Enabled = habilitar;
            linkLabelVerificarPendencias.Enabled = habilitar;
            btnCriarEtapas.Enabled = habilitar;
            btnAdicionarEtapa.Enabled = habilitar; 
            btnAlterarEtapa.Enabled = habilitar;
            btnExcluirEtapa.Enabled = habilitar;
            linkLabelVerificarPendencias.Enabled = habilitar;
            colNotaTrabalho.ReadOnly = habilitar;
            colNotaAvaliacao.ReadOnly = habilitar;
            colNotaExameFinal.ReadOnly = habilitar;
        }

        private void btnAlterarSalvar_Click(object sender, EventArgs e)
        {
            if(btnAlterarSalvar.Text == "Alterar")
            {
                if (dataGridViewAlunos.SelectedRows.Count == 0)
                    return;
                btnAlterarSalvar.Text = "Salvar";
                btnSair.Text = "Cancelar";
                BloquearDesbloquearCampos(false);
                if (comboBoxEtapa.SelectedIndex == -1)
                    txtNota.ReadOnly = false;
            }
            else
            {
                if(comboBoxEtapa.SelectedIndex == -1)//Exame Final
                {
                    ProcessarExameFinal();
                }
                else//Etapas
                {
                    ProcessarEtapas();
                }
                RestaurarTela();
            }
        }

        private void ProcessarExameFinal()
        {
            try
            {
                if (!ValidarExame()) return;

                if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                if (txtCodigoEtapa.Text.Equals("0"))
                    InserirExameFinal();
                else
                    InserirExameFinalAluno(new TurmaEtapaExameFinal { Codigo = Convert.ToInt32(txtCodigoEtapa.Text)});
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível realizar a operação. Detalhes: {exception.Message }", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InserirExameFinalAluno(TurmaEtapaExameFinal turmaEtapaExameFinal)
        {
            var logAlunoSucesso = "Código do(s) Aluno(s) com nota registrada com sucesso:\n";
            var logAlunoErro = "Código do(s) Aluno(s) com ocorrência de erro:\n";

            var listaExameFinal = turmaPeriodoDisciplinaAlunosLista.Where(x => x.SituacaoDisciplina.Codigo == 3 || x.CodigoExameFinal == 1).ToList();

            foreach (var exameFinal in listaExameFinal)
            {
                var turmaEtapaExameFinalAluno = new TurmaEtapaExameFinalAluno
                {
                    Aluno = exameFinal.Aluno,
                    Nota = Convert.ToDouble(exameFinal.NotaExameFinalGrid),
                    TurmaEtapaExameFinal = turmaEtapaExameFinal,
                    UsuarioAlterou = LoginSistema.UsuarioLogin
                };
                var retorno = new TurmaEtapaExameFinalAlunoRegraNegocio().Manipulacoes("1", turmaEtapaExameFinalAluno);

                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logAlunoSucesso = string.Concat(logAlunoSucesso, turmaEtapaExameFinalAluno.Aluno.Codigo.ToString(), " ");
                }
                catch (Exception)
                {
                    logAlunoErro = string.Concat(logAlunoErro, turmaEtapaExameFinalAluno.Aluno.Codigo.ToString(), " - {0}\n", retorno);
                }
            }
            MessageBox.Show($"Notas registradas com sucesso.\nlog:\n{logAlunoSucesso}\n{logAlunoErro}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestaurarTela();
        }

        private void InserirExameFinal()
        {
            
            var turmaEtapaExameFinal = new TurmaEtapaExameFinal
            {
                PeriodoDisciplina = dataGridViewDisciplina.SelectedRows[0].DataBoundItem as PeriodoDisciplina,
                Nota = Convert.ToDouble(txtNota.Text),
                UsuarioAlterou = LoginSistema.UsuarioLogin
            };
            var retorno = new TurmaEtapaExameFinalRegraNegocio().Manipulacoes("1", turmaEtapaExameFinal);
            try
            {
                turmaEtapaExameFinal.Codigo = Convert.ToInt32(retorno);

                InserirExameFinalAluno(turmaEtapaExameFinal);
            }
            catch
            {
                MessageBox.Show($"Não foi possivel realizar o cadastro. Detalhes: {retorno}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarExameFinal()
        {
            //Verifica se existe, se sim, exclui e cria de novo
        }       

        private void ProcessarEtapas()
        {
           
            try
            {
                if (!ValidarEtapas()) return;

                if (MessageBox.Show("Deseja Salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                AlterarNotasEtapas();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Não foi possível realizar a operação. Detalhes: {exception.Message }", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void AlterarNotasEtapas()
        {
            var logAlunoSucesso = "Código do(s) Aluno(s) com nota registrada com sucesso:\n";
            var logAlunoErro = "Código do(s) Aluno(s) com ocorrência de erro:\n";

            foreach (var turmaEtapaNotaAluno in turmaEtapaNotaAlunoLista)
            {
                turmaEtapaNotaAluno.NotaAvaliacao = Convert.ToDouble(turmaEtapaNotaAluno.NotaAvaliacaoGrid);
                turmaEtapaNotaAluno.NotaTrabalho = Convert.ToDouble(turmaEtapaNotaAluno.NotaTrabalhoGrid);
                var retorno = new TurmaEtapaNotaAlunoRegraNegocio().Manipulacoes("2", turmaEtapaNotaAluno);
                try
                {
                    var codigo = Convert.ToInt32(retorno);
                    logAlunoSucesso = string.Concat(logAlunoSucesso, turmaEtapaNotaAluno.Aluno.Codigo.ToString()," ");
                }
                catch (Exception)
                {
                    logAlunoErro = string.Concat(logAlunoErro, turmaEtapaNotaAluno.Aluno.Codigo.ToString(), " - {0}\n", retorno);
                }
            }
            MessageBox.Show($"Notas registradas com sucesso.\nlog:\n{logAlunoSucesso}\n{logAlunoErro}", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestaurarTela();
        }

        private bool ValidarEtapas()
        {
            if (dataGridViewAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno na disciplina", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            //Validar notas lançadas maior que nota total da etapa.
            if ((dataGridViewAlunos.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToDouble(x.Cells[3].Value) +
             Convert.ToDouble(x.Cells[4].Value) > Convert.ToDouble(txtNota.Text))).Any())
            {
                MessageBox.Show("Existem alunos com a soma total do trabalho e avaliação maior do que a nota total da etapa.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }
        private bool ValidarExame()
        {
            if (dataGridViewAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno na disciplina", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            //Validar se existe registro com situação igual a Exame Final.
            if (txtCodigoEtapa.Text == string.Empty)
            {
                if (dataGridViewAlunos.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[9].Value.ToString().Equals("2")).Any())
                {
                    MessageBox.Show("Nenhum aluno está com a situação Exame Final.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
            }

            //validar nota exame final maior que nota total.
            if(dataGridViewAlunos.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToDouble(x.Cells[7].Value) > Convert.ToDouble(txtNota.Text)).Any())
            {
                MessageBox.Show("Existem alunos com nota no exame final, maior que a nota total.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Text == "Sair")
            {
                this.Close();
                return;
            }                
            if (MessageBox.Show("Deseja cancelar as alterações?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;
            RestaurarTela();
        }

        private void RestaurarTela()
        {
            BloquearDesbloquearCampos(true);
            if (comboBoxEtapa.SelectedValue != null && comboBoxEtapa.ValueMember != "")
                AtualizarEtapa(comboBoxEtapa.SelectedValue.ToString());
            else
                AtualizarEtapa();
            txtNota.ReadOnly = true;
            btnSair.Text = "Sair";
            btnAlterarSalvar.Text = "Alterar";
            if(btnAlterarEtapa.Text == "Salvar")
            {
                btnAlterarEtapa.Text = "Alterar Etapa";
                txtEtapa.ReadOnly = true;
                txtNota.ReadOnly = true;
                btnAlterarSalvar.Enabled = true;
                dataGridViewAlunos.Enabled = true;
            }
        }

        private void dataGridViewAulas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaTrabalho"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[3].EditedFormattedValue.ToString() != "")
                    dataGridViewAlunos.SelectedRows[0].Cells[3].Value = Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[3].EditedFormattedValue).ToString("F2");
                dataGridViewAlunos.SelectedRows[0].Cells[9].Value = (Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[3].EditedFormattedValue) +
                    Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[4].EditedFormattedValue)).ToString();
            }

            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaAvaliacao"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[4].EditedFormattedValue.ToString() != "")
                    dataGridViewAlunos.SelectedRows[0].Cells[4].Value = Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[4].EditedFormattedValue).ToString("F2");
                dataGridViewAlunos.SelectedRows[0].Cells[9].Value = (Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[3].EditedFormattedValue) +
                   Convert.ToDouble(dataGridViewAlunos.SelectedRows[0].Cells[4].EditedFormattedValue)).ToString();
            }

            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaExameFinal"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[7].EditedFormattedValue.ToString() != "")
                    dataGridViewAlunos.SelectedRows[0].Cells[7].Value = Convert.ToDouble
                        (dataGridViewAlunos.SelectedRows[0].Cells[7].EditedFormattedValue).ToString("F2");
            }
        }

        private void dataGridViewAulas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxEtapa.SelectedIndex == -1 && 
                (!dataGridViewAlunos.CurrentRow.Cells[8].FormattedValue.ToString().Equals("Exame Final")) &&
                (!dataGridViewAlunos.CurrentRow.Cells[10].FormattedValue.ToString().Equals("1")))
            {
                e.Handled = true;
                return;
            }
          if(!char.IsNumber(e.KeyChar))
            {
                if(!char.IsControl(e.KeyChar))
                {
                    if(!dataGridViewAlunos.CurrentCell.EditedFormattedValue.ToString().Contains(",") && 
                        (e.KeyChar == '.' || e.KeyChar == ','))
                        e.KeyChar = ',';                   
                    else
                        e.Handled = true;
                }                                
            }        
        }

        private void MyDataGridViewInitializationMethod()
        {
            dataGridViewAlunos.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridViewAulas_EditingControlShowing);
        }

        private void FrmTurmaEtapaNotaAluno_Load(object sender, EventArgs e)
        {
            MyDataGridViewInitializationMethod();
        }

        private void dataGridViewAulas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaTrabalho"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[3].EditedFormattedValue.ToString() == "")
                    dataGridViewAlunos.SelectedRows[0].Cells[3].Value = "0,00";
            }

            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaAvaliacao"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[4].EditedFormattedValue.ToString() == "")
                    dataGridViewAlunos.SelectedRows[0].Cells[4].Value = "0,00";
            }

            if (dataGridViewAlunos.Columns[e.ColumnIndex].Name.Equals("colNotaExameFinal"))
            {
                if (dataGridViewAlunos.SelectedRows[0].Cells[7].EditedFormattedValue.ToString() == "")
                    dataGridViewAlunos.SelectedRows[0].Cells[7].Value = "0,00";
            }
        }

        private void VerificarPendencias()
        {
            log = string.Empty;
            var listaDisciplina = periodoDisciplinaColecao.Where(x => x.SituacaoDisciplina.Codigo == 1).ToList();
            foreach (var periodoDisciplina in listaDisciplina)
            {
                var etapasRegistradas = new TurmaEtapaRegraNegocio().Consultar(null, null, periodoDisciplina.Disciplina.Instituicao.Codigo.ToString(),
                    periodoDisciplina.Codigo.ToString());
                if (etapasRegistradas != null)
                {
                    if (etapasRegistradas.Count > 0)
                    {
                        foreach (var etapa in etapasRegistradas)
                        {
                            var turmaPeriodoDisciplinaAlunosSemRegistroLista = new TurmaPeriodoDisciplinaAlunosRegraNegocio().
                                ConsultarAlunosDisponiveisParaAulaDaDisciplinaNaoLancados(periodoDisciplina.Codigo.ToString(), etapa.Codigo.ToString());
                            if (turmaPeriodoDisciplinaAlunosSemRegistroLista.Count > 0)
                            {
                                var logTurmaEtapa = $"\n\nCódigo da Disciplina {turmaEtapa.PeriodoDisciplina.Codigo}\nCódigo Turma Etapa: {turmaEtapa.Codigo}\n";
                                VincularAlunosNaEtapa(turmaPeriodoDisciplinaAlunosSemRegistroLista.Select(x => x.Aluno).ToList(), etapa);
                                log = string.Concat(log, logTurmaEtapa, logErro, "\n");
                            }
                        }
                    }
                }
            }
            if (log != string.Empty)
            {
                var nomeArquivo = $"Log Notas {DateTime.Now.Day.ToString()}-{DateTime.Now.Month.ToString()} - {DateTime.Now.Ticks.ToString()}.txt";
                var path = Path.Combine(Path.GetTempPath(), nomeArquivo);
                File.WriteAllText(path, log);
                MessageBox.Show($"Alguns alunos estavam disponíveis na disciplina sem registro das notas nas etapas." +
                    $"Os registros foram efetuados, sendo lançados com notas zeradas.\nLog criado em: " +
                    $"{path}",
                    "Alunos sem registro de nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(path);
            }
        }

        private void linkLabelVerificarPendencias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VerificarPendencias();
        }

        public FrmTurmaEtapaNotaAluno()
        {
            InitializeComponent();
            dataGridViewDisciplina.AutoGenerateColumns = false;
            dataGridViewAlunos.AutoGenerateColumns = false;
            linkLabelInfoAuditoria.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnAdicionarEtapa.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnAlterarEtapa.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnExcluirEtapa.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnPesquisarAluno.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnCriarEtapas.Visible = !LoginSistema.UsuarioLogin.Aluno;
            btnAlterarSalvar.Visible = !LoginSistema.UsuarioLogin.Aluno;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (radioButtonCodigo.Checked)
                {
                    string KeyInput = e.KeyChar.ToString();
                    if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
                        e.Handled = true;
                }
                if (e.KeyChar == 13)
                    AtualizarGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
