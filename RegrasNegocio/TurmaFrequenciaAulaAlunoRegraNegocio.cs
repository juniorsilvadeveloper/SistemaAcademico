using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class TurmaFrequenciaAulaAlunoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaFrequenciaAulaAluno turmaFrequenciaAulaAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@TurmaFrequencia", turmaFrequenciaAulaAluno.TurmaFrequenciaAula);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", turmaFrequenciaAulaAluno.Aluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@QuantidadeAulas", turmaFrequenciaAulaAluno.QuantidadeAulas);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaFrequenciaAulaAluno.UsuarioAlterou.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaFrequenciaAulaAluno").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaFrequenciaAulaAluno ConsultarCodigoUnico(string codigoInstituicao,
                                                             string codigoTurmaFrequencia,
                                                             string codigoAluno)
        {
            try
            {
                var turmaFrequenciaAulaAluno = new TurmaFrequenciaAulaAluno();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TurmaFrequencia", codigoTurmaFrequencia);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaFrequenciaAulaAluno");

                foreach (DataRow turmaFrequenciaAulaAlunoLinha in dataTable.Rows)
                {
                    var turmaFrequenciaAula = new TurmaFrequenciaAula();
                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var aluno = new Aluno();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    instituicao.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaFrequenciaAulaAlunoLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;
                    disciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;
                    periodoDisciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoPeriodoDisciplina"]);
                    turmaFrequenciaAula.PeriodoDisciplina = periodoDisciplina;
                    turmaFrequenciaAula.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoTurmaFrequenciaAula"]);
                    turmaFrequenciaAulaAluno.TurmaFrequenciaAula = turmaFrequenciaAula;
                    aluno.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeAluno"]);
                    turmaFrequenciaAulaAluno.Aluno = aluno;
                    turmaFrequenciaAulaAluno.QuantidadeAulas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["QuantidadeAulas"]);
                    turmaFrequenciaAulaAluno.DataCadastro = Convert.ToDateTime(turmaFrequenciaAulaAlunoLinha["DataCadastroTurmaFrequencia"]);
                    turmaFrequenciaAulaAluno.DataAlteracao = Convert.ToDateTime(turmaFrequenciaAulaAlunoLinha["DataAlteracaoTurmaFrequencia"]);
                    turmaFrequenciaAulaAluno.QtdFaltas = Convert.ToString(turmaFrequenciaAulaAlunoLinha["QdtFaltas"]);
                    turmaFrequenciaAulaAluno.TotalAulas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalAulas"]);
                    turmaFrequenciaAulaAluno.TotalFaltas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalFaltas"]);
                    turmaFrequenciaAulaAluno.Faltou = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["Faltou"]);

                    usuario.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeUsuario"]);
                    turmaFrequenciaAulaAluno.UsuarioAlterou = usuario;
                }
                return turmaFrequenciaAulaAluno;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaFrequenciaAulaAlunoColecao Consultar(string codigoTurmaFrequencia,
                                                         string codigoAluno,
                                                         string nomeAluno,
                                                         string codigoDisciplina,
                                                         string nomeDisciplina,
                                                         string dataInicial,
                                                         string dataFinal,
                                                         string codigoInstituicao)
        {
            try
            {
                var turmaFrequenciaAulaAlunoColecao = new TurmaFrequenciaAulaAlunoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TurmaFrequencia", codigoTurmaFrequencia);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nomeAluno);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@DataInicial", dataInicial);
                acessoDadosSqlServer.AdicionarParametros("@DataFinal", dataFinal);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaFrequenciaAulaAluno");

                foreach (DataRow turmaFrequenciaAulaAlunoLinha in dataTable.Rows)
                {
                    var turmaFrequenciaAulaAluno = new TurmaFrequenciaAulaAluno();

                    var turmaFrequenciaAula = new TurmaFrequenciaAula();
                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var aluno = new Aluno();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    instituicao.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaFrequenciaAulaAlunoLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;
                    disciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;
                    periodoDisciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoPeriodoDisciplina"]);
                    turmaFrequenciaAula.PeriodoDisciplina = periodoDisciplina;
                    turmaFrequenciaAula.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoTurmaFrequenciaAula"]);
                    turmaFrequenciaAulaAluno.TurmaFrequenciaAula = turmaFrequenciaAula;
                    aluno.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeAluno"]);
                    turmaFrequenciaAulaAluno.Aluno = aluno;
                    turmaFrequenciaAulaAluno.QuantidadeAulas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["QuantidadeAulas"]);
                    turmaFrequenciaAulaAluno.DataCadastro = Convert.ToDateTime(turmaFrequenciaAulaAlunoLinha["DataCadastroTurmaFrequencia"]);
                    turmaFrequenciaAulaAluno.DataAlteracao = Convert.ToDateTime(turmaFrequenciaAulaAlunoLinha["DataAlteracaoTurmaFrequencia"]);
                    turmaFrequenciaAulaAluno.QtdFaltas = Convert.ToString(turmaFrequenciaAulaAlunoLinha["QdtFaltas"]);
                    turmaFrequenciaAulaAluno.TotalAulas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalAulas"]);
                    turmaFrequenciaAulaAluno.TotalFaltas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalFaltas"]);
                    turmaFrequenciaAulaAluno.Faltou = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["Faltou"]);

                    usuario.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaFrequenciaAulaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeUsuario"]);
                    turmaFrequenciaAulaAluno.UsuarioAlterou = usuario;

                    turmaFrequenciaAulaAlunoColecao.Add(turmaFrequenciaAulaAluno);
                }
                return turmaFrequenciaAulaAlunoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public TurmaFrequenciaAulaAlunoColecao ConsultarAlunosDisponiveisSemRegistroAulaDaDisciplina(string codigoTurmaFrequencia,
                                                                                                     string codigoPeriodoDisciplina)
        {
            try
            {
                var turmaFrequenciaAulaAlunoColecao = new TurmaFrequenciaAulaAlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TurmaFrequencia", codigoTurmaFrequencia);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarAlunosDisponiveisNaoLancadosParaAulaDaDisciplina");
                foreach (DataRow turmaFrequenciaAulaAlunoLinha in dataTable.Rows)
                {
                    var turmaFrequenciaAulaAluno = new TurmaFrequenciaAulaAluno();
                    var aluno = new Aluno();

                    aluno.Codigo = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaFrequenciaAulaAlunoLinha["NomeAluno"]);
                    turmaFrequenciaAulaAluno.Aluno = aluno;

                    turmaFrequenciaAulaAluno.TotalFaltas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalFaltas"]);
                    turmaFrequenciaAulaAluno.TotalAulas = Convert.ToInt32(turmaFrequenciaAulaAlunoLinha["TotalAulas"]);
                    turmaFrequenciaAulaAluno.Faltou = false;
                    turmaFrequenciaAulaAluno.QtdFaltas = "0";
                    turmaFrequenciaAulaAlunoColecao.Add(turmaFrequenciaAulaAluno);
                }
                return turmaFrequenciaAulaAlunoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta selecionado. Detalhes: " + ex.Message);
            }
        }
    }
}
