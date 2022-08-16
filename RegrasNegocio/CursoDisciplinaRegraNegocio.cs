using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBancoDados;
using System.Data;

namespace RegrasNegocios
{
    public class CursoDisciplinaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //Manipulações

        public string Manipulacoes(string opcao, CursoDisciplina cursoDisciplina)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Curso", cursoDisciplina.Curso.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Disciplina", cursoDisciplina.Disciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", cursoDisciplina.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", cursoDisciplina.UsuarioAlterou.Codigo);
                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCursoDisciplina").ToString();
                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Consultar por código único

        public CursoDisciplina ConsultarCodigoUnico(string codigoCurso,
                                                    string codigoDisciplina,
                                                    string codigoInstituicao)
        {
            try
            {
                var cursoDisciplina = new CursoDisciplina();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoCurso", codigoCurso);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
               
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCursoDisciplinaConsultar");
                
                foreach (DataRow cursoDisciplinaLinha in dataTable.Rows)
                {
                    var curso = new Curso();
                    var disciplina = new Disciplina();
                    var usuarioAlterou = new Usuario();
                    var instituicao = new Instituicao();

                    instituicao.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(cursoDisciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(cursoDisciplinaLinha["RazaoSocialInstituicao"]);
                    curso.Instituicao = instituicao;
                    curso.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(cursoDisciplinaLinha["NomeCurso"]);
                    cursoDisciplina.Curso = curso;

                    disciplina.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(cursoDisciplinaLinha["NomeDisciplina"]);
                    cursoDisciplina.Disciplina = disciplina;

                    cursoDisciplina.Situacao = Convert.ToBoolean(cursoDisciplinaLinha["SituacaoCursoDisciplina"]);
                    cursoDisciplina.DataCadastro = Convert.ToDateTime(cursoDisciplinaLinha["DataCadastroCursoDisciplina"]);
                    cursoDisciplina.DataAlteracao = Convert.ToDateTime(cursoDisciplinaLinha["DataAlteracaoCursoDisciplina"]);

                    usuarioAlterou.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(cursoDisciplinaLinha["NomeReal"]);
                    cursoDisciplina.UsuarioAlterou = usuarioAlterou;
                }
                return cursoDisciplina;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + ex.Message);
            }
        }

        // Consultar por vários códigos

        public CursoDisciplinaColecao Consultar(string codigoCurso,
                                                string nomeCurso,
                                                string codigoDisciplina,
                                                string nomeDisciplina,
                                                string situacao,
                                                string codigoInstituicao)
        {
            try
            {
                var cursoDisciplinaColecao = new CursoDisciplinaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoCurso", codigoCurso);
                acessoDadosSqlServer.AdicionarParametros("@NomeCurso", nomeCurso);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCursoDisciplinaConsultar");
                foreach (DataRow cursoDisciplinaLinha in dataTable.Rows)
                {
                    var cursoDisciplina = new CursoDisciplina();
                    var curso = new Curso();
                    var disciplina = new Disciplina();
                    var usuarioAlterou = new Usuario();
                    var instituicao = new Instituicao();

                    instituicao.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(cursoDisciplinaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(cursoDisciplinaLinha["RazaoSocialInstituicao"]);
                    curso.Instituicao = instituicao;
                    curso.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoCurso"]);
                    curso.Nome = Convert.ToString(cursoDisciplinaLinha["NomeCurso"]);
                    cursoDisciplina.Curso = curso;

                    disciplina.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(cursoDisciplinaLinha["NomeDisciplina"]);
                    cursoDisciplina.Disciplina = disciplina;

                    cursoDisciplina.Situacao = Convert.ToBoolean(cursoDisciplinaLinha["SituacaoCursoDisciplina"]);
                    cursoDisciplina.DataCadastro = Convert.ToDateTime(cursoDisciplinaLinha["DataCadastroCursoDisciplina"]);
                    cursoDisciplina.DataAlteracao = Convert.ToDateTime(cursoDisciplinaLinha["DataAlteracaoCursoDisciplina"]);

                    usuarioAlterou.Codigo = Convert.ToInt32(cursoDisciplinaLinha["CodigoUsuario"]);
                    usuarioAlterou.Aluno = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioAluno"]);
                    usuarioAlterou.Professor = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioProfessor"]);
                    usuarioAlterou.Secretariado = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioSecretariado"]);
                    usuarioAlterou.Administrador = Convert.ToBoolean(cursoDisciplinaLinha["UsuarioAdministrador"]);
                    usuarioAlterou.NomeReal = Convert.ToString(cursoDisciplinaLinha["NomeReal"]);
                    cursoDisciplina.UsuarioAlterou = usuarioAlterou;

                    cursoDisciplinaColecao.Add(cursoDisciplina);
                }
                return cursoDisciplinaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + ex.Message);
            }
        }
    }
}