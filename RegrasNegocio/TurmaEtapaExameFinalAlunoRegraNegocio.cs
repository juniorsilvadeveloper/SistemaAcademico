using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBancoDados;
using System.Data;

namespace RegrasNegocio
{
    public class TurmaEtapaExameFinalAlunoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Manipulacoes(string opcao, TurmaEtapaExameFinalAluno turmaEtapaExameFinalAluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@TurmaEtapaExameFinal", turmaEtapaExameFinalAluno.TurmaEtapaExameFinal.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Aluno", turmaEtapaExameFinalAluno.Aluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nota", turmaEtapaExameFinalAluno.Nota);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", turmaEtapaExameFinalAluno.UsuarioAlterou.Codigo);
                return acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTurmaEtapaExameFinalAluno").ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }        
    }
}
