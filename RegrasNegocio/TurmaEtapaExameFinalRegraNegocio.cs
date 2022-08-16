using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;


namespace RegrasNegocio
{
    public class TurmaEtapaExameFinalRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, TurmaEtapaExameFinal turmaEtapaExameFinal)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", turmaEtapaExameFinal.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", turmaEtapaExameFinal.PeriodoDisciplina.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nota", turmaEtapaExameFinal.Nota);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaEtapaExameFinal.UsuarioAlterou.Codigo);
                return acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaEtapaExameFinal").ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public TurmaEtapaExameFinal Consultar(string codigo, string codigoPeriodoDisciplina)
        {
            try
            {
                var turmaEtapaExameFinal = new TurmaEtapaExameFinal();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@PeriodoDisciplina", codigoPeriodoDisciplina);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurmaEtapaExameFinalConsultar");

                foreach (DataRow turmaEtapaExameFinalLinha in dataTable.Rows)
                {
                    turmaEtapaExameFinal.Codigo = Convert.ToInt32(turmaEtapaExameFinalLinha["Codigo"]);
                    turmaEtapaExameFinal.Nota = Convert.ToDouble(turmaEtapaExameFinalLinha["Nota"]);
                    turmaEtapaExameFinal.PeriodoDisciplina = 
                        new PeriodoDisciplina { Codigo = Convert.ToInt32(turmaEtapaExameFinalLinha["CodigoPeriodoDisciplina"])};
                }
                return turmaEtapaExameFinal;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar a turma etapa exame final. Detlahes: " + exception.Message);
            }
        }      
    }
}
