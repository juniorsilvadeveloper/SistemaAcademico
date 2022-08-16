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
    public class TurmaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, Turma turma)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turma.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", turma.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Curso", turma.Curso.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@DataInicio", turma.DataInicio);
                acessoDadosSqlServer.AdicionarParametros("@DataFim", turma.DataFim);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoTurma", turma.SituacaoTurma.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turma.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", turma.Instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Turno", turma.Turno.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurma").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Turma ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var turma = new Turma();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", 2);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTurmaConsultar");

                foreach (DataRow TurmaLinha in dataTable.Rows)
                {
                    turma.Codigo = Convert.ToInt32(TurmaLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(TurmaLinha["NomeTurma"]);

                    var curso = new Curso();
                    curso.Codigo = Convert.ToInt32(TurmaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(TurmaLinha["NomeCurso"]);
                    turma.Curso = curso;

                    turma.DataInicio = Convert.ToDateTime(TurmaLinha["DataInicioTurma"]);                   
                    turma.DataFim = Convert.ToDateTime(TurmaLinha["DataFimTurma"]);                  
                    turma.DataCadastro = Convert.ToDateTime(TurmaLinha["DataCadastroTurma"]);
                    turma.DataAlteracao = Convert.ToDateTime(TurmaLinha["DataAlteracaoTurma"]);

                    var situacaoTurma = new SituacaoTurma();
                    situacaoTurma.Codigo = Convert.ToInt32(TurmaLinha["CodigoSituacaoTurma"]);
                    situacaoTurma.Nome = Convert.ToString(TurmaLinha["NomeSituacaoTurma"]);
                    turma.SituacaoTurma = situacaoTurma;

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(TurmaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(TurmaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(TurmaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(TurmaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(TurmaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(TurmaLinha["NomeUsuario"]);
                    turma.UsuarioAlterou = usuarioAlterou;

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(TurmaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(TurmaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(TurmaLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;

                    var turno = new Turno();
                    turno.Codigo = Convert.ToInt32(TurmaLinha["CodigoTurno"]);
                    turno.Nome = Convert.ToString(TurmaLinha["NomeTurno"]);
                    turma.Turno = turno;
                }
                return turma;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaColecao Consultar(string codigo,
                                      string nome,
                                      string codigoCurso,
                                      DateTime? dataInicio,
                                      DateTime? dataFim,
                                      string codigoSituacaoTurma,
                                      string codigoInstituicao)
        {
            try
            {
                var turmaColecao = new TurmaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@CodigoCurso", codigoCurso);
                acessoDadosSqlServer.AdicionarParametros("@DataInicio", dataInicio);
                acessoDadosSqlServer.AdicionarParametros("@DataFim", dataFim);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoTurma", codigoSituacaoTurma);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaConsultar");

                foreach (DataRow TurmaLinha in dataTable.Rows)
                {
                    var turma = new Turma();

                    turma.Codigo = Convert.ToInt32(TurmaLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(TurmaLinha["NomeTurma"]);

                    var curso = new Curso();
                    curso.Codigo = Convert.ToInt32(TurmaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(TurmaLinha["NomeCurso"]);
                    turma.Curso = curso;

                    turma.DataInicio = Convert.ToDateTime(TurmaLinha["DataInicioTurma"]);
                    if (ValidarData(TurmaLinha["DataFimTurma"].ToString()))
                        turma.DataFim = Convert.ToDateTime(TurmaLinha["DataFimTurma"]);
                    else
                        turma.DataFim = null;
                    turma.DataCadastro = Convert.ToDateTime(TurmaLinha["DataCadastroTurma"]);
                    turma.DataAlteracao = Convert.ToDateTime(TurmaLinha["DataAlteracaoTurma"]);

                    var situacaoTurma = new SituacaoTurma();
                    situacaoTurma.Codigo = Convert.ToInt32(TurmaLinha["CodigoSituacaoTurma"]);
                    situacaoTurma.Nome = Convert.ToString(TurmaLinha["NomeSituacaoTurma"]);
                    turma.SituacaoTurma = situacaoTurma;

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(TurmaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(TurmaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(TurmaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(TurmaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(TurmaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(TurmaLinha["NomeUsuario"]);
                    turma.UsuarioAlterou = usuarioAlterou;

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(TurmaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(TurmaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(TurmaLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;

                    var turno = new Turno();
                    turno.Codigo = Convert.ToInt32(TurmaLinha["CodigoTurno"]);
                    turno.Nome = Convert.ToString(TurmaLinha["NomeTurno"]);
                    turma.Turno = turno;

                    turmaColecao.Add(turma);
                }
                return turmaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
        public static bool ValidarData(string data)
        {
            //var dataOk = new Regex(@"(\d{2}\/\d{2}\/\d{4})");
            //return dataOk.Match(data).Success;
            DateTime dataOK;
            return DateTime.TryParse(data, out dataOK);
        }
    }
}
