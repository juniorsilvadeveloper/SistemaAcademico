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
    public class DisciplinaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, Disciplina disciplina)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", disciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", disciplina.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", disciplina.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@CargaHoraria", disciplina.CargaHoraria);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", disciplina.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", disciplina.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", disciplina.Instituicao.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDisciplina").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Disciplina ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var disciplina = new Disciplina();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultar");

                foreach (DataRow disciplinaLinha in dataTable.Rows)
                {
                    disciplina.Codigo = Convert.ToInt32(disciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(disciplinaLinha["NomeDisciplina"]);
                    disciplina.Descricao = Convert.ToString(disciplinaLinha["DescricaoDisciplina"]);
                    disciplina.CargaHoraria = Convert.ToInt32(disciplinaLinha["CargaHorariaDisciplina"]);
                    disciplina.Situacao = Convert.ToBoolean(disciplinaLinha["SituacaoDisciplina"]);
                    disciplina.DataCadastro = Convert.ToDateTime(disciplinaLinha["DataCadastroDisciplina"]);
                    disciplina.DataAlteracao = Convert.ToDateTime(disciplinaLinha["DataAlteracaoDisciplina"]);

                    var usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(disciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(disciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(disciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(disciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(disciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(disciplinaLinha["NomeReal"]);
                    disciplina.UsuarioAlterou = usuarioAlterou;

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(disciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(disciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(disciplinaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;
                }
                return disciplina;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public DisciplinaColecao Consultar(string codigo,
                                           string nome,
                                           string codigoInstituicao,
                                           string situacao)
        {
            try
            {
                var disciplinaColecao = new DisciplinaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDisciplinaConsultar");

                foreach (DataRow disciplinaLinha in dataTable.Rows)
                {
                    Disciplina disciplina = new Disciplina();

                    disciplina.Codigo = Convert.ToInt32(disciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(disciplinaLinha["NomeDisciplina"]);
                    disciplina.Descricao = Convert.ToString(disciplinaLinha["DescricaoDisciplina"]);
                    disciplina.CargaHoraria = Convert.ToInt32(disciplinaLinha["CargaHorariaDisciplina"]);
                    disciplina.Situacao = Convert.ToBoolean(disciplinaLinha["SituacaoDisciplina"]);
                    disciplina.DataCadastro = Convert.ToDateTime(disciplinaLinha["DataCadastroDisciplina"]);
                    disciplina.DataAlteracao = Convert.ToDateTime(disciplinaLinha["DataAlteracaoDisciplina"]);

                    Usuario usuarioAlterou = new Usuario();
                    usuarioAlterou.Codigo = Convert.ToInt32(disciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(disciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(disciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(disciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(disciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(disciplinaLinha["NomeReal"]);
                    disciplina.UsuarioAlterou = usuarioAlterou;

                    Instituicao instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(disciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(disciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(disciplinaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;

                    disciplinaColecao.Add(disciplina);
                }
                return disciplinaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
