using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class TurmaPeriodoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaPeriodo turmaPeriodo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaPeriodo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Turma", turmaPeriodo.Turma.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Periodo", turmaPeriodo.Periodo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", turmaPeriodo.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@DataInicio", turmaPeriodo.DataInicio);
                acessoDadosSqlServer.AdicionarParametros("@DataFim", turmaPeriodo.DataFim);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaPeriodo.UsuarioAlterou.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaPeriodo").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaPeriodo ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var turmaPeriodo = new TurmaPeriodo();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoConsultar");

                foreach (DataRow turmaPeriodoLinha in dataTable.Rows)
                {
                    var turma = new Turma();
                    var curso = new Curso();
                    var periodo = new Periodo();
                    var usuario = new Usuario();
                    var instituicao = new Instituicao();

                    turmaPeriodo.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoTurmaPeriodo"]);
                    turmaPeriodo.Situacao = Convert.ToBoolean(turmaPeriodoLinha["SituacaoTurmaPeriodo"]);
                    turmaPeriodo.DataInicio = Convert.ToDateTime(turmaPeriodoLinha["DataInicioTurmaPeriodo"]);
                    turmaPeriodo.DataFim = Convert.ToDateTime(turmaPeriodoLinha["DataFimTurmaPeriodo"]);
                    turmaPeriodo.DataCadastro = Convert.ToDateTime(turmaPeriodoLinha["DataCadastroTurmaPeriodo"]);
                    turmaPeriodo.DataAlteracao = Convert.ToDateTime(turmaPeriodoLinha["DataAlteracaoTurmaPeriodo"]);

                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;
                    curso.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(turmaPeriodoLinha["NomeCurso"]);
                    turma.Curso = curso;
                    turma.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(turmaPeriodoLinha["NomeTurma"]);
                    turmaPeriodo.Turma = turma;
                    periodo.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoPeriodo"]);
                    periodo.Nome = Convert.ToString(turmaPeriodoLinha["NomePeriodo"]);
                    turmaPeriodo.Periodo = periodo;

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoLinha["NomeUsuario"]);
                    turmaPeriodo.UsuarioAlterou = usuario;
                }
                return turmaPeriodo;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaPeriodoColecao Consultar(string codigo,
                                            string codigoTurma,
                                            string nomeTurma,
                                            string codigoCurso,
                                            string nomeCurso,
                                            string codigoPeriodo,
                                            string nomePeriodo,
                                            string situacao,
                                            string codigoInstituicao)
        {
            try
            {
                var turmaPeriodoColecao = new TurmaPeriodoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurma", codigoTurma);
                acessoDadosSqlServer.AdicionarParametros("@NomeTurma", nomeTurma);
                acessoDadosSqlServer.AdicionarParametros("@CodigoCurso", codigoCurso);
                acessoDadosSqlServer.AdicionarParametros("@NomeCurso", nomeCurso);
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodo", codigoPeriodo);
                acessoDadosSqlServer.AdicionarParametros("@NomePeriodo", nomePeriodo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoConsultar");

                foreach (DataRow turmaPeriodoLinha in dataTable.Rows)
                {
                    var turmaPeriodo = new TurmaPeriodo();

                    var turma = new Turma();
                    var curso = new Curso();
                    var periodo = new Periodo();
                    var usuario = new Usuario();
                    var instituicao = new Instituicao();

                    turmaPeriodo.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoTurmaPeriodo"]);
                    turmaPeriodo.Situacao = Convert.ToBoolean(turmaPeriodoLinha["SituacaoTurmaPeriodo"]);
                    turmaPeriodo.DataInicio = Convert.ToDateTime(turmaPeriodoLinha["DataInicioTurmaPeriodo"]);
                    turmaPeriodo.DataFim = Convert.ToDateTime(turmaPeriodoLinha["DataFimTurmaPeriodo"]);
                    turmaPeriodo.DataCadastro = Convert.ToDateTime(turmaPeriodoLinha["DataCadastroTurmaPeriodo"]);
                    turmaPeriodo.DataAlteracao = Convert.ToDateTime(turmaPeriodoLinha["DataAlteracaoTurmaPeriodo"]);

                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoLinha["RazaoSocialInstituicao"]);
                    turma.Instituicao = instituicao;
                    curso.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(turmaPeriodoLinha["NomeCurso"]);
                    turma.Curso = curso;
                    turma.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(turmaPeriodoLinha["NomeTurma"]);
                    turmaPeriodo.Turma = turma;
                    periodo.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoPeriodo"]);
                    periodo.Nome = Convert.ToString(turmaPeriodoLinha["NomePeriodo"]);
                    turmaPeriodo.Periodo = periodo;

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoLinha["NomeUsuario"]);
                    turmaPeriodo.UsuarioAlterou = usuario;

                    turmaPeriodoColecao.Add(turmaPeriodo);
                }
                return turmaPeriodoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
