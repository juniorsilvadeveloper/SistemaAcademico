using System;
using System.Data;
using AcessoBancoDados;


namespace RegrasNegocio
{
    public class TurnoRegraNegocio
    {
        private AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public DataTable ConsultarTurno()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTurnoConsultar");
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
        }
    }
}