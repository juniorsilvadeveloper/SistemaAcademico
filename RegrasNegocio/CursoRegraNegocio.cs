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
    public class CursoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Curso curso)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", curso.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", curso.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DuracaoPeriodo", curso.DuracaoPeriodo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", curso.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", curso.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", curso.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", curso.Instituicao.Codigo);

                String codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCurso").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Curso ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var curso = new Curso();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCursoConsultar");

                foreach (DataRow cursoLinha in dataTable.Rows)
                {
                    curso.Codigo = Convert.ToInt32(cursoLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(cursoLinha["NomeCurso"]);
                    curso.DuracaoPeriodo = Convert.ToInt32(cursoLinha["DuracaoPeriodoCurso"]);
                    curso.Situacao = Convert.ToBoolean(cursoLinha["SituacaoCurso"]);
                    curso.Descricao = Convert.ToString(cursoLinha["DescricaoCurso"]);

                    Instituicao instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(cursoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(cursoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(cursoLinha["RazaoSocialInstituicao"]);
                    curso.Instituicao = instituicao;

                    curso.DataCadastro = Convert.ToDateTime(cursoLinha["DataCadastroCurso"]);
                    curso.DataAlteracao = Convert.ToDateTime(cursoLinha["DataAlteracaoCurso"]);

                    Usuario usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(cursoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(cursoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(cursoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(cursoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(cursoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(cursoLinha["NomeReal"]);
                    curso.UsuarioAlterou = usuario;
                }
                return curso;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public CursoColecao Consultar(string codigoInstituicao,
                                      string codigo,
                                      string nome,
                                      string situacao)
        {
            try
            {
                CursoColecao cursoColecao = new CursoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCursoConsultar");

                foreach (DataRow cursoLinha in dataTable.Rows)
                {
                    Curso curso = new Curso();

                    curso.Codigo = Convert.ToInt32(cursoLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(cursoLinha["NomeCurso"]);
                    curso.DuracaoPeriodo = Convert.ToInt32(cursoLinha["DuracaoPeriodoCurso"]);
                    curso.Situacao = Convert.ToBoolean(cursoLinha["SituacaoCurso"]);
                    curso.Descricao = Convert.ToString(cursoLinha["DescricaoCurso"]);

                    Instituicao instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(cursoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(cursoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(cursoLinha["RazaoSocialInstituicao"]);
                    curso.Instituicao = instituicao;

                    curso.DataCadastro = Convert.ToDateTime(cursoLinha["DataCadastroCurso"]);
                    curso.DataAlteracao = Convert.ToDateTime(cursoLinha["DataAlteracaoCurso"]);

                    Usuario usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(cursoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(cursoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(cursoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(cursoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(cursoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(cursoLinha["NomeReal"]);
                    curso.UsuarioAlterou = usuario;

                    cursoColecao.Add(curso);
                }
                return cursoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
