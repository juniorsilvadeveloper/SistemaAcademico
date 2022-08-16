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
    public class TurmaPeriodoDisciplinaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaPeriodoDisciplina turmaPeriodoDisciplina)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaPeriodoDisciplina.PeriodoDisciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@TurmaPeriodo", turmaPeriodoDisciplina.TurmaPeriodo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", turmaPeriodoDisciplina.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaPeriodoDisciplina.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", turmaPeriodoDisciplina.SituacaoDisciplina.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplina").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        // Consultar por código único

        public TurmaPeriodoDisciplina ConsultarCodigoUnico(string codigoPeriodoDisciplina,
                                                           string codigoTurmaPeriodo,
                                                           string codigoInstituicao)
        {
            try
            {
                var turmaPeriodoDisciplina = new TurmaPeriodoDisciplina();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurmaPeriodo", codigoTurmaPeriodo);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplinaConsultar");

                foreach (DataRow turmaPeriodoDisciplinaLinha in dataTable.Rows)
                {
                    var periodoDisciplina = new PeriodoDisciplina();
                    var turmaPeriodo = new TurmaPeriodo();
                    var disciplina = new Disciplina();
                    var turma = new Turma();
                    var periodo = new Periodo();
                    var usuario = new Usuario();
                    var instituicao = new Instituicao();
                    var professor = new Professor();
                    var curso = new Curso();

                    disciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;
                    professor.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;
                    periodoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.PeriodoDisciplina = periodoDisciplina;
                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoDisciplinaLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;
                    turma.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurma"]);
                    turmaPeriodo.Turma = turma;
                    periodo.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoPeriodo"]);
                    periodo.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomePeriodo"]);
                    turmaPeriodo.Periodo = periodo;
                    turmaPeriodo.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTrumaPeriodo"]);
                    turmaPeriodoDisciplina.TurmaPeriodo = turmaPeriodo;
                    curso.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeCurso"]);
                    turma.Curso = curso;
                    turma.Turno = new Turno
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurno"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurno"])
                    };
                    turma.SituacaoTurma = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoSituacaoTurma"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeSituacaoTurma"])
                    };
                    turmaPeriodoDisciplina.SituacaoDisciplina = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoSituacaoDisciplina"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeSituacaoDisciplina"])
                    };

                    turmaPeriodoDisciplina.Situacao = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["SituacaoTurmaPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.DataCadastro = Convert.ToDateTime(turmaPeriodoDisciplinaLinha["DataCadastroTurmaPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.DataAlteracao = Convert.ToDateTime(turmaPeriodoDisciplinaLinha["DataAlteracaoTurmaPeriodoDisciplina"]);

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeUsuario"]);
                    turmaPeriodoDisciplina.UsuarioAlterou = usuario;
                }
                return turmaPeriodoDisciplina;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaPeriodoDisciplinaColecao Consultar(string codigoPeriodoDisciplina,
                                                       string codigoDisciplina,
                                                       string nomeDisciplina,
                                                       string codigoTurma,
                                                       string nomeTurma,
                                                       string codigoTurmaPeriodo,
                                                       string codigoPeriodo,
                                                       string nomePeriodo,
                                                       string situacao,
                                                       string codigoInstituicao,
                                                       string situacaoDisciplina)
        {
            try
            {
                var turmaPeriodoDisciplinaColecao = new TurmaPeriodoDisciplinaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurma", codigoTurma);
                acessoDadosSqlServer.AdicionarParametros("@NomeTurma", nomeTurma);
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurmaPeriodo", codigoTurmaPeriodo);
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodo", codigoPeriodo);
                acessoDadosSqlServer.AdicionarParametros("@NomePeriodo", nomePeriodo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", situacaoDisciplina);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplinaConsultar");

                foreach (DataRow turmaPeriodoDisciplinaLinha in dataTable.Rows)
                {
                    var turmaPeriodoDisciplina = new TurmaPeriodoDisciplina();

                    var periodoDisciplina = new PeriodoDisciplina();
                    var turmaPeriodo = new TurmaPeriodo();
                    var disciplina = new Disciplina();
                    var turma = new Turma();
                    var periodo = new Periodo();
                    var usuario = new Usuario();
                    var instituicao = new Instituicao();
                    var professor = new Professor();
                    var curso = new Curso();

                    disciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;
                    professor.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;
                    periodoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.PeriodoDisciplina = periodoDisciplina;
                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoDisciplinaLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;
                    turma.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurma"]);
                    turmaPeriodo.Turma = turma;
                    periodo.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoPeriodo"]);
                    periodo.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomePeriodo"]);
                    turmaPeriodo.Periodo = periodo;
                    turmaPeriodo.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTrumaPeriodo"]);
                    turmaPeriodoDisciplina.TurmaPeriodo = turmaPeriodo;
                    curso.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeCurso"]);
                    turma.Curso = curso;
                    turma.Turno = new Turno
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurno"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurno"])
                    };
                    turma.SituacaoTurma = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoSituacaoTurma"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeSituacaoTurma"])
                    };
                    turmaPeriodoDisciplina.SituacaoDisciplina = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoSituacaoDisciplina"]),
                        Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeSituacaoDisciplina"])
                    };

                    turmaPeriodoDisciplina.Situacao = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["SituacaoTurmaPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.DataCadastro = Convert.ToDateTime(turmaPeriodoDisciplinaLinha["DataCadastroTurmaPeriodoDisciplina"]);
                    turmaPeriodoDisciplina.DataAlteracao = Convert.ToDateTime(turmaPeriodoDisciplinaLinha["DataAlteracaoTurmaPeriodoDisciplina"]);

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoDisciplinaLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeUsuario"]);
                    turmaPeriodoDisciplina.UsuarioAlterou = usuario;

                    turmaPeriodoDisciplinaColecao.Add(turmaPeriodoDisciplina);
                }
                return turmaPeriodoDisciplinaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public TurmaPeriodoDisciplina ConsultarDadosDoAlunoNaDisciplina(String codigoPeriodoDisciplina, string codigoAluno)
        {
            try
            {
                TurmaPeriodoDisciplina turmaPeriodoDisciplina = null;
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarDadosDoAlunoNaDisciplina");

                foreach (DataRow turmaPeriodoDisciplinaLinha in dataTable.Rows)
                {
                    turmaPeriodoDisciplina = new TurmaPeriodoDisciplina();
                    var turmaPeriodo = new TurmaPeriodo();
                    var turma = new Turma();
                    var periodo = new Periodo();
                    var curso = new Curso();
                    var turno = new Turno();
                    var instituicao = new Instituicao();

                    curso.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeCurso"]);
                    turma.Curso = curso;

                    turno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurno"]);
                    turno.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurno"]);
                    turma.Turno = turno;

                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoDisciplinaLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;

                    turma.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomeTurma"]);
                    turmaPeriodo.Turma = turma;

                    periodo.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaLinha["CodigoPeriodo"]);
                    periodo.Nome = Convert.ToString(turmaPeriodoDisciplinaLinha["NomePeriodo"]);
                    turmaPeriodo.Periodo = periodo;

                    turmaPeriodoDisciplina.TurmaPeriodo = turmaPeriodo;
                }
                return turmaPeriodoDisciplina;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}

 



   

