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
    public class TurmaAlunoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaAluno turmaAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Turma", turmaAluno.Turma.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", turmaAluno.Aluno.Codigo);                
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaAluno.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoCurso", turmaAluno.SituacaoCurso.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaAluno").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaAluno ConsultarCodigoUnico(string codigoTurma, string codigoAluno, string codigoInstituicao)
        {
            try
            {
                var turmaAluno = new TurmaAluno();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurma", codigoTurma);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaAlunoConsultar");

                foreach (DataRow TurmaAlunoLinha in dataTable.Rows)
                {
                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(TurmaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(TurmaAlunoLinha["RazaoSocialInstituicao"]);

                    var turma = new Turma();
                    turma.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(TurmaAlunoLinha["NomeTurma"]);
                    turma.Instituicao = instituicao;
                    turmaAluno.Turma = turma;

                    var aluno = new Aluno();
                    aluno.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(TurmaAlunoLinha["NomeAluno"]);
                    aluno.Matricula = Convert.ToString(TurmaAlunoLinha["MatriculaAluno"]);
                    aluno.Cpf = Convert.ToString(TurmaAlunoLinha["CPFAluno"]);
                    turmaAluno.Aluno = aluno;

                    turmaAluno.DataCadastro = Convert.ToDateTime(TurmaAlunoLinha["DataCadastroTurmaAluno"]);
                    turmaAluno.DataAlteracao = Convert.ToDateTime(TurmaAlunoLinha["DataAlteracaoTurmaAluno"]);

                    var usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(TurmaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(TurmaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(TurmaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(TurmaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(TurmaAlunoLinha["NomeUsuario"]);
                    turmaAluno.UsuarioAlterou = usuario;

                    var situacaoCurso = new SituacaoCurso();
                    situacaoCurso.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoSituacaoCurso"]);
                    situacaoCurso.Nome = Convert.ToString(TurmaAlunoLinha["NomeSituacaoCurso"]);
                    turmaAluno.SituacaoCurso = situacaoCurso;
                }
                return turmaAluno;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaAlunoColecao Consultar(string codigoTurma, 
                                           string nomeTurma, 
                                           string codigoAluno, 
                                           string nomeAluno, 
                                           string codigoSituacaoCurso, 
                                           string codigoInstituicao)
        {
            try
            {
                var turmaAlunoColecao = new TurmaAlunoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurma", codigoTurma);
                acessoDadosSqlServer.AdicionarParametros("@NomeTurma", nomeTurma);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nomeAluno);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoCurso", codigoSituacaoCurso);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaAlunoConsultar");

                foreach (DataRow TurmaAlunoLinha in dataTable.Rows)
                {
                    var turmaAluno = new TurmaAluno();

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(TurmaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(TurmaAlunoLinha["RazaoSocialInstituicao"]);

                    var turma = new Turma();
                    turma.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoTurma"]);
                    turma.Nome = Convert.ToString(TurmaAlunoLinha["NomeTurma"]);
                    turma.Instituicao = instituicao;
                    turmaAluno.Turma = turma;

                    var aluno = new Aluno();
                    aluno.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(TurmaAlunoLinha["NomeAluno"]);
                    aluno.Matricula = Convert.ToString(TurmaAlunoLinha["MatriculaAluno"]);
                    aluno.Cpf = Convert.ToString(TurmaAlunoLinha["CPFAluno"]);
                    turmaAluno.Aluno = aluno;

                    turmaAluno.DataCadastro = Convert.ToDateTime(TurmaAlunoLinha["DataCadastroTurmaAluno"]);
                    turmaAluno.DataAlteracao = Convert.ToDateTime(TurmaAlunoLinha["DataAlteracaoTurmaAluno"]);

                    var usuario = new Usuario();
                    usuario.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(TurmaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(TurmaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(TurmaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(TurmaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(TurmaAlunoLinha["NomeUsuario"]);
                    turmaAluno.UsuarioAlterou = usuario;

                    var situacaoCurso = new SituacaoCurso();
                    situacaoCurso.Codigo = Convert.ToInt32(TurmaAlunoLinha["CodigoSituacaoCurso"]);
                    situacaoCurso.Nome = Convert.ToString(TurmaAlunoLinha["NomeSituacaoCurso"]);
                    turmaAluno.SituacaoCurso = situacaoCurso;

                    turmaAlunoColecao.Add(turmaAluno);
                }
                return turmaAlunoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
