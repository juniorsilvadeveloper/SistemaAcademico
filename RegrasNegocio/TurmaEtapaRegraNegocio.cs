using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class TurmaEtapaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaEtapa turmaEtapa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaEtapa.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", turmaEtapa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", turmaEtapa.PeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Nota", turmaEtapa.Nota);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaEtapa.UsuarioAlterou);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaEtapa").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaEtapa ConsultarCodigoUnico(string codigo, string codigoInstituicao, string codigoAluno)
        {
            try
            {
                var turmaEtapa = new TurmaEtapa();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", codigoAluno);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaConsultar");
                foreach (DataRow turmaEtapaLinha in dataTable.Rows)
                {
                    turmaEtapa.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoTurmaEtapa"]);
                    turmaEtapa.Nome = Convert.ToString(turmaEtapaLinha["NomeTurmaEtapa"]);

                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var instituicao = new Instituicao();
                    
                    instituicao.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaEtapaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaEtapaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;
                    disciplina.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaEtapaLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoPeriodoDiscipçina"]);
                    turmaEtapa.PeriodoDisciplina = periodoDisciplina;

                    turmaEtapa.Nota = Convert.ToDouble(turmaEtapaLinha["NotaTurmaEtapa"]);
                    turmaEtapa.DataCadastro = Convert.ToDateTime(turmaEtapaLinha["DataCadastroTurmaEtapa"]);
                    turmaEtapa.DataAlteracao = Convert.ToDateTime(turmaEtapaLinha["DataAlteracaoTurmaEtapa"]);

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(turmaEtapaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(turmaEtapaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(turmaEtapaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(turmaEtapaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(turmaEtapaLinha["NomeUsuario"]);
                    turmaEtapa.UsuarioAlterou = usuarioAlterou;
                }
                return turmaEtapa;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaEtapaColecao Consultar(string codigo,
                                           string nome,
                                           string codigoInstituicao,
                                           string codigoPeriodoDisciplina)
        {
            try
            {
                var turmaEtapaColecao = new TurmaEtapaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaConsultar");

                foreach (DataRow turmaEtapaLinha in dataTable.Rows)
                {
                    var turmaEtapa = new TurmaEtapa();
                    turmaEtapa.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoTurmaEtapa"]);
                    turmaEtapa.Nome = Convert.ToString(turmaEtapaLinha["NomeTurmaEtapa"]);

                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var instituicao = new Instituicao();

                    instituicao.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaEtapaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaEtapaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;
                    disciplina.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaEtapaLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoPeriodoDiscipçina"]);
                    turmaEtapa.PeriodoDisciplina = periodoDisciplina;

                    turmaEtapa.Nota = Convert.ToDouble(turmaEtapaLinha["NotaTurmaEtapa"]);
                    turmaEtapa.DataCadastro = Convert.ToDateTime(turmaEtapaLinha["DataCadastroTurmaEtapa"]);
                    turmaEtapa.DataAlteracao = Convert.ToDateTime(turmaEtapaLinha["DataAlteracaoTurmaEtapa"]);

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(turmaEtapaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(turmaEtapaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(turmaEtapaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(turmaEtapaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(turmaEtapaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(turmaEtapaLinha["NomeUsuario"]);
                    turmaEtapa.UsuarioAlterou = usuarioAlterou;

                    turmaEtapaColecao.Add(turmaEtapa);
                }
                if (turmaEtapaColecao.Count == 0)
                    return null;
                return turmaEtapaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
