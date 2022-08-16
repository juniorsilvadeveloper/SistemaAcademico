using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class PeriodoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

       public string Manipulacoes(string opcao, Periodo periodo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", periodo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", periodo.Nome);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPeriodo").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Periodo ConsultarCodigoUnico(string codigo)
        {
            try
            {
                var periodo = new Periodo();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPeriodoConsultar");

                foreach (DataRow periodoLinha in dataTable.Rows)
                {
                    periodo.Codigo = Convert.ToInt32(periodoLinha["Codigo"]);
                    periodo.Nome = Convert.ToString(periodoLinha["Nome"]);
                }
                return periodo;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public PeriodoColecao Consultar(string codigo,
                                        string nome)
        {
            try
            {
                var periodoColecao = new PeriodoColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPeriodoConsultar");

                foreach (DataRow periodoLinha in dataTable.Rows)
                {
                    var periodo = new Periodo();

                    periodo.Codigo = Convert.ToInt32(periodoLinha["Codigo"]);
                    periodo.Nome = Convert.ToString(periodoLinha["Nome"]);

                    periodoColecao.Add(periodo);
                }
                return periodoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
