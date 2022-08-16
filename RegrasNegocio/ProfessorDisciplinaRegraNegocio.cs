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
    public class ProfessorDisciplinaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, ProfessorDisciplina professorDisciplina)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Professor", professorDisciplina.Professor.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Disciplina", professorDisciplina.Disciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", professorDisciplina.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", professorDisciplina.Situacao);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProfessorDisciplina").ToString();
                return codigo;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }

        // Consultar código único

        public ProfessorDisciplina ConsultarCodigoUnico(string codigoProfessor,
                                                        string codigoDisciplina,
                                                        string codigoInstituicao)
        {
            try
            {
                var professorDisciplina = new ProfessorDisciplina();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoProfessor", codigoProfessor);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorDisciplinaConsultar");

                foreach (DataRow professorDisciplinaLinha in dataTable.Rows)
                {
                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(professorDisciplinaLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(professorDisciplinaLinha["NomeFantasiaInstituicao"]);

                    var professor = new Professor();
                    professor.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoProfessorDisciplina"]);
                    professor.Nome = Convert.ToString(professorDisciplinaLinha["NomeProfessorDisciplina"]);
                    professor.Instituicao = instituicao;
                    professorDisciplina.Professor = professor;

                    var disciplina = new Disciplina();
                    disciplina.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(professorDisciplinaLinha["NomeDisciplina"]);
                    professorDisciplina.Disciplina = disciplina;

                    professorDisciplina.Situacao = Convert.ToBoolean(professorDisciplinaLinha["SituacaoProfessorDisciplina"]);
                    professorDisciplina.DataCadastro = Convert.ToDateTime(professorDisciplinaLinha["DataCadastroProfessorDisciplina"]);
                    professorDisciplina.DataAlteracao = Convert.ToDateTime(professorDisciplinaLinha["DataAlteracaoProfessorDisciplina"]);

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(professorDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(professorDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(professorDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(professorDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(professorDisciplinaLinha["NomeUsuario"]);
                    professorDisciplina.UsuarioAlterou = usuarioAlterou;
                }
                return professorDisciplina;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vário códigos

        public ProfessorDisciplinaColecao Consultar(string codigoProfessor,
                                                    string nomeProfessor,
                                                    string codigoDisciplina,
                                                    string nomeDisciplina,
                                                    string situacao,
                                                    string codigoInstituicao)
        {
            try
            {
                var professorDisciplinaColecao = new ProfessorDisciplinaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoProfessor", codigoProfessor);
                acessoDadosSqlServer.AdicionarParametros("@NomeProfessor", nomeProfessor);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorDisciplinaConsultar");

                foreach (DataRow professorDisciplinaLinha in dataTable.Rows)
                {
                    var professorDisciplina = new ProfessorDisciplina();

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(professorDisciplinaLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(professorDisciplinaLinha["NomeFantasiaInstituicao"]);

                    var professor = new Professor();
                    professor.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoProfessorDisciplina"]);
                    professor.Nome = Convert.ToString(professorDisciplinaLinha["NomeProfessorDisciplina"]);
                    professor.Instituicao = instituicao;
                    professorDisciplina.Professor = professor;

                    var disciplina = new Disciplina();
                    disciplina.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(professorDisciplinaLinha["NomeDisciplina"]);
                    professorDisciplina.Disciplina = disciplina;

                    professorDisciplina.Situacao = Convert.ToBoolean(professorDisciplinaLinha["SituacaoProfessorDisciplina"]);
                    professorDisciplina.DataCadastro = Convert.ToDateTime(professorDisciplinaLinha["DataCadastroProfessorDisciplina"]);
                    professorDisciplina.DataAlteracao = Convert.ToDateTime(professorDisciplinaLinha["DataAlteracaoProfessorDisciplina"]);

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(professorDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(professorDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(professorDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(professorDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(professorDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(professorDisciplinaLinha["NomeUsuario"]);
                    professorDisciplina.UsuarioAlterou = usuarioAlterou;

                    professorDisciplinaColecao.Add(professorDisciplina);
                }
                return professorDisciplinaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
