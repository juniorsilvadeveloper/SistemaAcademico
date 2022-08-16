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
    public class PeriodoDisciplinaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, PeriodoDisciplina periodoDisciplina)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", periodoDisciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Disciplina", periodoDisciplina.Disciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Professor", periodoDisciplina.Professor.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", periodoDisciplina.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", periodoDisciplina.SituacaoDisciplina.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPeriodoDisciplina").ToString();
                return codigo;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }

        // Consultar código único

        public PeriodoDisciplina ConsultarCodigoUnico(string codigo)
        {
            try
            {
                var periodoDisciplina = new PeriodoDisciplina();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPeriodoDisciplinaConsultar");

                foreach (DataRow periodoDisciplinaLinha in dataTable.Rows)
                {
                    periodoDisciplina.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoPeriodoDisciplina"]);

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(periodoDisciplinaLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(periodoDisciplinaLinha["NomeFantasiaInstituicao"]);

                    var disciplina = new Disciplina();
                    disciplina.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(periodoDisciplinaLinha["NomeDisciplina"]);
                    disciplina.Instituicao = instituicao;
                    periodoDisciplina.Disciplina = disciplina;

                    var professor = new Professor();
                    professor.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(periodoDisciplinaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.DataCadastro = Convert.ToDateTime(periodoDisciplinaLinha["DataCadastroPeriodoDisciplina"]);
                    periodoDisciplina.DataAlteracao = Convert.ToDateTime(periodoDisciplinaLinha["DataAlteracaoPeriodoDisciplina"]);

                    periodoDisciplina.SituacaoDisciplina = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoSituacaoDisciplina"]),
                        Nome = Convert.ToString(periodoDisciplinaLinha["NomeSituacaoDisciplina"])
                    };

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(periodoDisciplinaLinha["NomeUsuario"]);
                    periodoDisciplina.UsuarioAlterou = usuarioAlterou;
                }
                return periodoDisciplina;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public PeriodoDisciplinaColecao Consultar(string codigo,
                                                  string codigoDisciplina,
                                                  string nomeDisciplina,
                                                  string codigoProfessor,
                                                  string nomeProfessor,
                                                  string situacao,
                                                  string codigoInstituicao,
                                                  string codigoAluno)
        {
            try
            {
                var periodoDisciplinaColecao = new PeriodoDisciplinaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoProfessor", codigoProfessor);
                acessoDadosSqlServer.AdicionarParametros("@NomeProfessor", nomeProfessor);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", codigoAluno);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPeriodoDisciplinaConsultar");

                foreach (DataRow periodoDisciplinaLinha in dataTable.Rows)
                {
                    var periodoDisciplina = new PeriodoDisciplina();

                    periodoDisciplina.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoPeriodoDisciplina"]);

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(periodoDisciplinaLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(periodoDisciplinaLinha["NomeFantasiaInstituicao"]);

                    var disciplina = new Disciplina();
                    disciplina.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(periodoDisciplinaLinha["NomeDisciplina"]);
                    disciplina.Instituicao = instituicao;
                    periodoDisciplina.Disciplina = disciplina;

                    var professor = new Professor();
                    professor.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(periodoDisciplinaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.DataCadastro = Convert.ToDateTime(periodoDisciplinaLinha["DataCadastroPeriodoDisciplina"]);
                    periodoDisciplina.DataAlteracao = Convert.ToDateTime(periodoDisciplinaLinha["DataAlteracaoPeriodoDisciplina"]);

                    periodoDisciplina.SituacaoDisciplina = new SituacaoTurma
                    {
                        Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoSituacaoDisciplina"]),
                        Nome = Convert.ToString(periodoDisciplinaLinha["NomeSituacaoDisciplina"])
                    };

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(periodoDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(periodoDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(periodoDisciplinaLinha["NomeUsuario"]);
                    periodoDisciplina.UsuarioAlterou = usuarioAlterou;

                    periodoDisciplinaColecao.Add(periodoDisciplina);
                }
                return periodoDisciplinaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
