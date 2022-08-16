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
    public class TurmaPeriodoDisciplinaAlunosRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaPeriodoDisciplinaAlunos turmaPeriodoDisciplinaAlunos)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", turmaPeriodoDisciplinaAlunos.PeriodoDisciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", turmaPeriodoDisciplinaAlunos.Aluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@MediaFinal", turmaPeriodoDisciplinaAlunos.MediaFinal);
                acessoDadosSqlServer.AdicionarParametros("@Frequencia", turmaPeriodoDisciplinaAlunos.Frequencia);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", turmaPeriodoDisciplinaAlunos.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", turmaPeriodoDisciplinaAlunos.SituacaoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaPeriodoDisciplinaAlunos.UsuarioAlterou);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplinaAlunos").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaPeriodoDisciplinaAlunos ConsultarCodigoUnico(string codigoPeriodoDisciplina, 
                                                                 string codigoAluno,
                                                                 string codigoInstituicao)
        {
            try
            {
                var turmaPeriodoDisciplinaAlunos = new TurmaPeriodoDisciplinaAlunos();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", 2);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", 0);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplinaAlunosConsultar");

                foreach (DataRow turmaPeriodoDisciplinaAlunosLinha in dataTable.Rows)
                {                                        
                    var periodoDisciplina = new PeriodoDisciplina();
                    var professor = new Professor();
                    var aluno = new Aluno();
                    var disciplina = new Disciplina();
                    var instituicao = new Instituicao();
                    var situacaoAlunoDisciplina = new SituacaoAlunoDisciplina();
                    var usuario = new Usuario();

                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;

                    disciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoPeriodoDisciplina"]);
                    turmaPeriodoDisciplinaAlunos.PeriodoDisciplina = periodoDisciplina;

                    aluno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeAluno"]);
                    aluno.Cpf = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["CPFAluno"]);
                    aluno.Matricula = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["MatriculaAluno"]);
                    turmaPeriodoDisciplinaAlunos.Aluno = aluno;

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeUsuario"]);
                    turmaPeriodoDisciplinaAlunos.UsuarioAlterou = usuario;

                    situacaoAlunoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoSituacaoAlunoDisciplina"]); 
                    situacaoAlunoDisciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeSituacaoAlunoDisciplina"]); 
                    turmaPeriodoDisciplinaAlunos.SituacaoDisciplina = situacaoAlunoDisciplina;

                    turmaPeriodoDisciplinaAlunos.MediaFinal = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["MediaFinalAluno"]);
                    turmaPeriodoDisciplinaAlunos.Frequencia = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["FrequenciaAluno"]);
                }
                return turmaPeriodoDisciplinaAlunos;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaPeriodoDisciplinaAlunosColecao Consultar(string opcao,
                                                             string codigoPeriodoDisciplina,
                                                             string codigoDisciplina,
                                                             string nomeDisciplina,
                                                             string codigoAluno,
                                                             string nomeAluno,
                                                             string situacao,
                                                             string situacaoDisciplina,
                                                             string codigoInstituicao,
                                                             string codigoTurmaPeriodo)
        {
            try
            {
                var turmaPeriodoDisciplinaAlunosColecao = new TurmaPeriodoDisciplinaAlunosColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@CodigoPeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoDisciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@NomeDisciplina", nomeDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@CodigoAluno", codigoAluno);
                acessoDadosSqlServer.AdicionarParametros("@NomeAluno", nomeAluno);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@SituacaoDisciplina", situacaoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@CodigoTurmaPeriodo", codigoTurmaPeriodo);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaPeriodoDisciplinaAlunosConsultar");

                foreach (DataRow turmaPeriodoDisciplinaAlunosLinha in dataTable.Rows)
                {
                    var turmaPeriodoDisciplinaAlunos = new TurmaPeriodoDisciplinaAlunos();
                    var periodoDisciplina = new PeriodoDisciplina();
                    var professor = new Professor();
                    var aluno = new Aluno();
                    var disciplina = new Disciplina();
                    var instituicao = new Instituicao();
                    var situacaoAlunoDisciplina = new SituacaoAlunoDisciplina();
                    var usuario = new Usuario();

                    instituicao.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;

                    disciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoPeriodoDisciplina"]);
                    turmaPeriodoDisciplinaAlunos.PeriodoDisciplina = periodoDisciplina;

                    aluno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeAluno"]);
                    aluno.Cpf = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["CPFAluno"]);
                    aluno.Matricula = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["MatriculaAluno"]);
                    turmaPeriodoDisciplinaAlunos.Aluno = aluno;

                    usuario.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaPeriodoDisciplinaAlunosLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeUsuario"]);
                    turmaPeriodoDisciplinaAlunos.UsuarioAlterou = usuario;

                    situacaoAlunoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoSituacaoAlunoDisciplina"]);
                    situacaoAlunoDisciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeSituacaoAlunoDisciplina"]);
                    turmaPeriodoDisciplinaAlunos.SituacaoDisciplina = situacaoAlunoDisciplina;

                    if (turmaPeriodoDisciplinaAlunosLinha["MediaFinalAluno"].ToString() != String.Empty)
                        turmaPeriodoDisciplinaAlunos.MediaFinal = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["MediaFinalAluno"]);
                    turmaPeriodoDisciplinaAlunos.Frequencia = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["FrequenciaAluno"]);
                    turmaPeriodoDisciplinaAlunosColecao.Add(turmaPeriodoDisciplinaAlunos);
                }
                return turmaPeriodoDisciplinaAlunosColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public TurmaPeriodoDisciplinaAlunosColecao ConsultarAlunosDisponiveisParaAulaDaDisciplina(string codigoPeriodoDisciplina)
        {
            try
            {
                var turmaPeriodoDisciplinaAlunosColecao = new TurmaPeriodoDisciplinaAlunosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarAlunosDisponiveisParaAulaDaDisciplina");
                foreach (DataRow turmaPeriodoDisciplinaAlunosLinha in dataTable.Rows)
                {
                    var turmaPeriodoDisciplinaAlunos = new TurmaPeriodoDisciplinaAlunos();
                    var aluno = new Aluno();

                    aluno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeAluno"]);
                    turmaPeriodoDisciplinaAlunos.Aluno = aluno;

                    turmaPeriodoDisciplinaAlunos.TotalFaltas = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["TotalFaltas"]);
                    turmaPeriodoDisciplinaAlunos.TotalAulas = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["TotalAulas"]);
                    turmaPeriodoDisciplinaAlunos.Faltou = false;
                    turmaPeriodoDisciplinaAlunos.QtdFaltas = "0";
                    turmaPeriodoDisciplinaAlunosColecao.Add(turmaPeriodoDisciplinaAlunos);
                }
                return turmaPeriodoDisciplinaAlunosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + ex.Message);
            }
        }

        public TurmaPeriodoDisciplinaAlunosColecao ConsultarAlunosDisponiveisParaAulaDaDisciplinaNaoLancados(string codigoPeriodoDisciplina, string codigoTurmaEtapa)
        {
            try
            {
                var turmaPeriodoDisciplinaAlunosColecao = new TurmaPeriodoDisciplinaAlunosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@TurmaEtapa", codigoTurmaEtapa);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarAlunosDisponiveisParaAulaDaDisciplinaNaoLancados");
                foreach (DataRow turmaPeriodoDisciplinaAlunosLinha in dataTable.Rows)
                {
                    var turmaPeriodoDisciplinaAlunos = new TurmaPeriodoDisciplinaAlunos();
                    var aluno = new Aluno();

                    aluno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeAluno"]);
                    turmaPeriodoDisciplinaAlunos.Aluno = aluno;

                    turmaPeriodoDisciplinaAlunos.TotalFaltas = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["TotalFaltas"]);
                    turmaPeriodoDisciplinaAlunos.TotalAulas = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["TotalAulas"]);
                    turmaPeriodoDisciplinaAlunos.Faltou = false;
                    turmaPeriodoDisciplinaAlunos.QtdFaltas = "0";
                    turmaPeriodoDisciplinaAlunosColecao.Add(turmaPeriodoDisciplinaAlunos);
                }
                return turmaPeriodoDisciplinaAlunosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + ex.Message);
            }
        }

        public TurmaPeriodoDisciplinaAlunosColecao ConsultarAlunosNotaEtapaExameFinal(string codigoPeriodoDisciplina, string codigoDisciplina, string codigoAluno)
        {
            try
            {
                var turmaPeriodoDisciplinaAlunosColecao = new TurmaPeriodoDisciplinaAlunosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Disciplina", codigoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", codigoAluno);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaExameFinalAlunoConsultar");

                foreach (DataRow turmaPeriodoDisciplinaAlunosLinha in dataTable.Rows)
                {
                    var turmaPeriodoDisciplinaAlunos = new TurmaPeriodoDisciplinaAlunos();
                    var aluno = new Aluno();
                    var situacaoAlunoDisciplina = new SituacaoAlunoDisciplina();

                    aluno.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeAluno"]);
                    aluno.Matricula = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["MatriculaAluno"]);
                    turmaPeriodoDisciplinaAlunos.Aluno = aluno;

                    if(turmaPeriodoDisciplinaAlunosLinha["NotaTotalEtapas"].ToString() != string.Empty)
                        turmaPeriodoDisciplinaAlunos.MediaFinal = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["NotaTotalEtapas"]);
                    turmaPeriodoDisciplinaAlunos.Frequencia = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["Frequencia"]);
                    turmaPeriodoDisciplinaAlunos.NotaExameFinal = Convert.ToDouble(turmaPeriodoDisciplinaAlunosLinha["NotaExameFinal"]);
                    turmaPeriodoDisciplinaAlunos.NotaExameFinalGrid = turmaPeriodoDisciplinaAlunos.NotaExameFinal.ToString("F2");
                    if(turmaPeriodoDisciplinaAlunosLinha["CodigoTurmaEtapa"].ToString() != string.Empty)
                        turmaPeriodoDisciplinaAlunos.CodigoExameFinal = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoTurmaEtapa"]);

                    situacaoAlunoDisciplina.Codigo = Convert.ToInt32(turmaPeriodoDisciplinaAlunosLinha["CodigoSituacaoDisciplina"]);
                    situacaoAlunoDisciplina.Nome = Convert.ToString(turmaPeriodoDisciplinaAlunosLinha["NomeSituacaoDisciplina"]);
                    turmaPeriodoDisciplinaAlunos.SituacaoDisciplina = situacaoAlunoDisciplina;

                    turmaPeriodoDisciplinaAlunosColecao.Add(turmaPeriodoDisciplinaAlunos);
                }
                return turmaPeriodoDisciplinaAlunosColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar a turma etapa exame final. Detlahes: " + exception.Message);
            }
        }
    }
}
