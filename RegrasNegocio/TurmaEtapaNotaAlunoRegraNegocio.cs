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
    public class TurmaEtapaNotaAlunoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaEtapaNotaAluno turmaEtapaNotaAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaEtapaNotaAluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@TurmaEtapa", turmaEtapaNotaAluno.TurmaEtapa.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", turmaEtapaNotaAluno.Aluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@NotaTrabalho", turmaEtapaNotaAluno.NotaTrabalho);
                acessoDadosSqlServer.AdicionarParametros("@NotaAvaliacao", turmaEtapaNotaAluno.NotaAvaliacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaEtapaNotaAluno.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", turmaEtapaNotaAluno.Situacao);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaEtapaNotaAluno").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaEtapaNotaAluno ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var turmaEtapaNotaAluno = new TurmaEtapaNotaAluno();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", 2);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaNotaAluno");

                foreach (DataRow turmaEtapaNotaAlunoLinha in dataTable.Rows)
                {
                    var turmaEtapa = new TurmaEtapa();
                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var professor = new Professor();
                    var aluno = new Aluno();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    turmaEtapaNotaAluno.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoTurmaEtapaNotaAluno"]);

                    turmaEtapa.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoTurmaEtapa"]);
                    turmaEtapa.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeTurmaEtapa"]);
                    turmaEtapa.Nota = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaTurmaEtapa"]);
                    turmaEtapaNotaAluno.TurmaEtapa = turmaEtapa;

                    disciplina.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoPeriodoDisciplina"]);
                    turmaEtapa.PeriodoDisciplina = periodoDisciplina;

                    aluno.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeAluno"]);
                    turmaEtapaNotaAluno.Aluno = aluno;

                    turmaEtapaNotaAluno.NotaTrabalho = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaTrabalhoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.NotaAvaliacao = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaAvalicaoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.Total = (turmaEtapaNotaAluno.NotaTrabalho + turmaEtapaNotaAluno.NotaAvaliacao).ToString("F2");
                    turmaEtapaNotaAluno.NotaTrabalhoGrid = turmaEtapaNotaAluno.NotaTrabalho.ToString("F2");
                    turmaEtapaNotaAluno.NotaAvaliacaoGrid = turmaEtapaNotaAluno.NotaAvaliacao.ToString("F2");
                    turmaEtapaNotaAluno.DataCadastro = Convert.ToDateTime(turmaEtapaNotaAlunoLinha["DataCadastroTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.DataAlteracao = Convert.ToDateTime(turmaEtapaNotaAlunoLinha["DataAlteracaoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.Situacao = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["SituacaoTurmaEtapaNotaAluno"]);

                    instituicao.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaEtapaNotaAlunoLinha["RazaoSocialInstituicao"]);
                    aluno.Instituicao = instituicao;

                    usuario.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeUsuario"]);
                    turmaEtapaNotaAluno.UsuarioAlterou = usuario;
                }
                return turmaEtapaNotaAluno;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaEtapaNotaAlunoColecao Consultar(string codigoTurmaEtapa,
                                                    string codigoAluno,
                                                    string nomeAluno,
                                                    string situacao,
                                                    string codigoInstituicao)
        {
            try
            {
                var turmaEtapaNotaAlunoColecao = new TurmaEtapaNotaAlunoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@TurmaEtapa", codigoTurmaEtapa);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nomeAluno);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaNotaAlunoConsultar");

                foreach (DataRow turmaEtapaNotaAlunoLinha in dataTable.Rows)
                {
                    var turmaEtapaNotaAluno = new TurmaEtapaNotaAluno();

                    var turmaEtapa = new TurmaEtapa();
                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var professor = new Professor();
                    var aluno = new Aluno();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    turmaEtapaNotaAluno.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoTurmaEtapaNotaAluno"]);

                    turmaEtapa.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoTurmaEtapa"]);
                    turmaEtapa.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeTurmaEtapa"]);
                    turmaEtapa.Nota = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaTurmaEtapa"]);
                    turmaEtapaNotaAluno.TurmaEtapa = turmaEtapa;

                    disciplina.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoPeriodoDisciplina"]);
                    turmaEtapa.PeriodoDisciplina = periodoDisciplina;

                    aluno.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeAluno"]);
                    aluno.Matricula = Convert.ToString(turmaEtapaNotaAlunoLinha["MatriculaAluno"]);
                    turmaEtapaNotaAluno.Aluno = aluno;

                    turmaEtapaNotaAluno.NotaTrabalho = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaTrabalhoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.NotaAvaliacao = Convert.ToDouble(turmaEtapaNotaAlunoLinha["NotaAvalicaoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.Total = (turmaEtapaNotaAluno.NotaTrabalho + turmaEtapaNotaAluno.NotaAvaliacao).ToString("F2");
                    turmaEtapaNotaAluno.NotaTrabalhoGrid = turmaEtapaNotaAluno.NotaTrabalho.ToString("F2");
                    turmaEtapaNotaAluno.NotaAvaliacaoGrid = turmaEtapaNotaAluno.NotaAvaliacao.ToString("F2");
                    turmaEtapaNotaAluno.DataCadastro = Convert.ToDateTime(turmaEtapaNotaAlunoLinha["DataCadastroTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.DataAlteracao = Convert.ToDateTime(turmaEtapaNotaAlunoLinha["DataAlteracaoTurmaEtapaNotaAluno"]);
                    turmaEtapaNotaAluno.Situacao = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["SituacaoTurmaEtapaNotaAluno"]);

                    instituicao.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaEtapaNotaAlunoLinha["RazaoSocialInstituicao"]);
                    aluno.Instituicao = instituicao;

                    usuario.Codigo = Convert.ToInt32(turmaEtapaNotaAlunoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaEtapaNotaAlunoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaEtapaNotaAlunoLinha["NomeUsuario"]);
                    turmaEtapaNotaAluno.UsuarioAlterou = usuario;

                    turmaEtapaNotaAlunoColecao.Add(turmaEtapaNotaAluno);
                }
                return turmaEtapaNotaAlunoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
