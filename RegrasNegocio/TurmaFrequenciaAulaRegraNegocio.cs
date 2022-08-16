using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class TurmaFrequenciaAulaRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, TurmaFrequenciaAula turmaFrequenciaAula)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaFrequenciaAula.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", turmaFrequenciaAula.PeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@Data", turmaFrequenciaAula.Data);
                acessoDadosSqlServer.AdicionarParametros("@QuantidadeAulas", turmaFrequenciaAula.QuantidadeAulas);
                acessoDadosSqlServer.AdicionarParametros("@Avaliacao", turmaFrequenciaAula.Avaliacao);
                acessoDadosSqlServer.AdicionarParametros("@ConteudoVivenciado", turmaFrequenciaAula.ConteudoVivenciado);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", turmaFrequenciaAula.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaFrequenciaAula.UsuarioAlterou.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaFrequenciaAula").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public TurmaFrequenciaAula ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var turmaFrequenciaAula = new TurmaFrequenciaAula();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", 2);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaFrequenciaAulaConsultar");

                foreach (DataRow turmaFrequenciaAulaLinha in dataTable.Rows)
                {
                    turmaFrequenciaAula.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoTurmaFrequenciaAula"]);

                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var professor = new Professor();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoPeriodoDisciplina"]);

                    instituicao.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaFrequenciaAulaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaFrequenciaAulaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;

                    disciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaFrequenciaAulaLinha["NomeDisciplina"]);
                    disciplina.CargaHoraria = Convert.ToInt32(turmaFrequenciaAulaLinha["CargaHorariaDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaFrequenciaAulaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    turmaFrequenciaAula.PeriodoDisciplina = periodoDisciplina;

                    turmaFrequenciaAula.Data = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.QuantidadeAulas = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAulas"]);
                    turmaFrequenciaAula.Avaliacao = Convert.ToBoolean(turmaFrequenciaAulaLinha["AvaliacaoTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.ConteudoVivenciado = Convert.ToString(turmaFrequenciaAulaLinha["ConteudoVivenciadoFrequenciaAula"]);
                    turmaFrequenciaAula.Situacao = Convert.ToBoolean(turmaFrequenciaAulaLinha["SituacaoTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.DataCadastro = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataCadastroTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.DataAlteracao = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataAlteracaoTurmaFrequenciaAula"]);

                    usuario.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaFrequenciaAulaLinha["NomeUsuario"]);
                    turmaFrequenciaAula.UsuarioAlterou = usuario;

                    turmaFrequenciaAula.QuantidadeAlunos = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAluno"]);
                    turmaFrequenciaAula.QuantidadeAusentes = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAusentes"]);
                }
                return turmaFrequenciaAula;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public TurmaFrequenciaAulaColecao Consultar(string codigo,
                                                    string codigoPeriodoDisciplina,
                                                    DateTime ? dataInicial,
                                                    DateTime ? dataFinal,
                                                    string codigoInstituicao)
        {
            try
            {
                var turmaFrequenciaAulaColecao = new TurmaFrequenciaAulaColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                acessoDadosSqlServer.AdicionarParametros("@DataInicial", dataInicial);
                acessoDadosSqlServer.AdicionarParametros("@DataFinal", dataFinal);
                acessoDadosSqlServer.AdicionarParametros("@Instiuicao", codigoInstituicao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaFrequenciaAulaConsultar");

                foreach (DataRow turmaFrequenciaAulaLinha in dataTable.Rows)
                {
                    var turmaFrequenciaAula = new TurmaFrequenciaAula();

                    turmaFrequenciaAula.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoTurmaFrequenciaAula"]);

                    var periodoDisciplina = new PeriodoDisciplina();
                    var disciplina = new Disciplina();
                    var professor = new Professor();
                    var instituicao = new Instituicao();
                    var usuario = new Usuario();

                    periodoDisciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoPeriodoDisciplina"]);

                    instituicao.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(turmaFrequenciaAulaLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(turmaFrequenciaAulaLinha["RazaoSocialInstituicao"]);
                    disciplina.Instituicao = instituicao;

                    disciplina.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoDisciplina"]);
                    disciplina.Nome = Convert.ToString(turmaFrequenciaAulaLinha["NomeDisciplina"]);
                    disciplina.CargaHoraria = Convert.ToInt32(turmaFrequenciaAulaLinha["CargaHorariaDisciplina"]);
                    periodoDisciplina.Disciplina = disciplina;

                    professor.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(turmaFrequenciaAulaLinha["NomeProfessor"]);
                    periodoDisciplina.Professor = professor;

                    turmaFrequenciaAula.PeriodoDisciplina = periodoDisciplina;

                    turmaFrequenciaAula.Data = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.QuantidadeAulas = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAulas"]);
                    turmaFrequenciaAula.Avaliacao = Convert.ToBoolean(turmaFrequenciaAulaLinha["AvaliacaoTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.ConteudoVivenciado = Convert.ToString(turmaFrequenciaAulaLinha["ConteudoVivenciadoFrequenciaAula"]);
                    turmaFrequenciaAula.Situacao = Convert.ToBoolean(turmaFrequenciaAulaLinha["SituacaoTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.DataCadastro = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataCadastroTurmaFrequenciaAula"]);
                    turmaFrequenciaAula.DataAlteracao = Convert.ToDateTime(turmaFrequenciaAulaLinha["DataAlteracaoTurmaFrequenciaAula"]);

                    usuario.Codigo = Convert.ToInt32(turmaFrequenciaAulaLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(turmaFrequenciaAulaLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(turmaFrequenciaAulaLinha["NomeUsuario"]);
                    turmaFrequenciaAula.UsuarioAlterou = usuario;
                    turmaFrequenciaAulaColecao.Add(turmaFrequenciaAula);

                    turmaFrequenciaAula.QuantidadeAlunos = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAluno"]);
                    turmaFrequenciaAula.QuantidadeAusentes = Convert.ToInt32(turmaFrequenciaAulaLinha["QuantidadeAusentes"]);
                }
                return turmaFrequenciaAulaColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

    }
}
