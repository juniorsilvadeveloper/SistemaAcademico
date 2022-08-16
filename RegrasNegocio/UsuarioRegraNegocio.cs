using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class UsuarioRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", usuario.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", usuario.Aluno);
                acessoDadosSqlServer.AdicionarParametros("@Professor", usuario.Professor);
                acessoDadosSqlServer.AdicionarParametros("@Secretariado", usuario.Secretariado);
                acessoDadosSqlServer.AdicionarParametros("@IdUsuario", usuario.IdUsuario);
                acessoDadosSqlServer.AdicionarParametros("@NomeUsuario", usuario.NomeUsuario);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", usuario.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@Administrador", usuario.Administrador);
                acessoDadosSqlServer.AdicionarParametros("@usuarioAlterou", usuario.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", usuario.Instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", usuario.NomeReal);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.Senha);

                var codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuario").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string validarLogin(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 4);
                acessoDadosSqlServer.AdicionarParametros("@NomeUsuario", usuario.NomeUsuario);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioSenha", usuario.Senha);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuario").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Usuario ConsultarCodigoUnico(string codigo)
        {
            try
            {
                Usuario usuario = new Usuario();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultar");

                foreach (DataRow usuarioLinha in dataTable.Rows)
                {
                    usuario.Codigo = Convert.ToInt32(usuarioLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(usuarioLinha["TipoAluno"]);
                    usuario.Professor = Convert.ToBoolean(usuarioLinha["TipoProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(usuarioLinha["TipoSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(usuarioLinha["TipoAdministrador"]);
                    usuario.IdUsuario = Convert.ToInt32(usuarioLinha["IdUsuario"]);
                    usuario.NomeUsuario = Convert.ToString(usuarioLinha["NomeUsuario"]);
                    usuario.NomeReal = Convert.ToString(usuarioLinha["NomeReal"]);
                    usuario.Senha = Convert.ToString(usuarioLinha["SenhaUsuario"]);
                    usuario.Situacao = Convert.ToBoolean(usuarioLinha["SituacaoUsuario"]);
                    usuario.DataCadastro = Convert.ToDateTime(usuarioLinha["DataCadastroUsuario"]);
                    usuario.DataAlteracao = Convert.ToDateTime(usuarioLinha["DataAlteracaoUsuario"]);

                    Instituicao instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(usuarioLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(usuarioLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(usuarioLinha["RazaoSocialInstituicao"]);

                    usuario.Instituicao = instituicao;

                    Usuario usuariolterou = new Usuario();
                    usuariolterou.Codigo = Convert.ToInt32(usuarioLinha["CodigoUsuario"]);
                    usuariolterou.Aluno = Convert.ToBoolean(usuarioLinha["UsuarioAluno"]);
                    usuariolterou.Professor = Convert.ToBoolean(usuarioLinha["UsuarioProfessor"]);
                    usuariolterou.Secretariado = Convert.ToBoolean(usuarioLinha["UsuarioSecretariado"]);
                    usuariolterou.Administrador = Convert.ToBoolean(usuarioLinha["UsuarioAdministrador"]);
                    usuariolterou.NomeReal = Convert.ToString(usuarioLinha["NomeReal"]);

                    usuario.UsuarioAlterou = usuariolterou;
                }
                return usuario;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta do usuário por código. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public UsuarioColecao Consultar(string codigo, 
                                        string codigoInstituicao, 
                                        string aluno, 
                                        string professor, 
                                        string secretariado, 
                                        string administrador,
                                        string idUsuario,
                                        string nomeUsuario,
                                        string situacao,
                                        string nome)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", aluno);
                acessoDadosSqlServer.AdicionarParametros("@Professor", professor);
                acessoDadosSqlServer.AdicionarParametros("@Secretariado", secretariado);
                acessoDadosSqlServer.AdicionarParametros("@Administrador", administrador);
                acessoDadosSqlServer.AdicionarParametros("@IdUsuario", idUsuario);
                acessoDadosSqlServer.AdicionarParametros("@NomeUsuario", nomeUsuario);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspUsuarioConsultar");

                foreach (DataRow usuarioLinha in dataTable.Rows)
                {
                    Usuario usuario = new Usuario();

                    usuario.Codigo = Convert.ToInt32(usuarioLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(usuarioLinha["TipoAluno"]);
                    usuario.Professor = Convert.ToBoolean(usuarioLinha["TipoProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(usuarioLinha["TipoSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(usuarioLinha["TipoAdministrador"]);
                    usuario.IdUsuario = Convert.ToInt32(usuarioLinha["IdUsuario"]);
                    usuario.NomeUsuario = Convert.ToString(usuarioLinha["NomeUsuario"]);
                    usuario.NomeReal = Convert.ToString(usuarioLinha["NomeReal"]);
                    usuario.Senha = Convert.ToString(usuarioLinha["SenhaUsuario"]);
                    usuario.Situacao = Convert.ToBoolean(usuarioLinha["SituacaoUsuario"]);
                    usuario.DataCadastro = Convert.ToDateTime(usuarioLinha["DataCadastroUsuario"]);
                    usuario.DataAlteracao = Convert.ToDateTime(usuarioLinha["DataAlteracaoUsuario"]);

                    Instituicao instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(usuarioLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(usuarioLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(usuarioLinha["RazaoSocialInstituicao"]);

                    usuario.Instituicao = instituicao;

                    Usuario usuariolterou = new Usuario();
                    usuariolterou.Codigo = Convert.ToInt32(usuarioLinha["CodigoUsuarioAlterou"]);
                    usuariolterou.Aluno = Convert.ToBoolean(usuarioLinha["UsuarioAluno"]);
                    usuariolterou.Professor = Convert.ToBoolean(usuarioLinha["UsuarioProfessor"]);
                    usuariolterou.Secretariado = Convert.ToBoolean(usuarioLinha["UsuarioSecretariado"]);
                    usuariolterou.Administrador = Convert.ToBoolean(usuarioLinha["UsuarioAdministrador"]);
                    usuariolterou.NomeReal = Convert.ToString(usuarioLinha["NomeRealAlterou"]);

                    usuario.UsuarioAlterou = usuariolterou;

                    usuarioColecao.Add(usuario);
                }
                return usuarioColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
