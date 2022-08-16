using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBancoDados;
namespace RegrasNegocio
{
    public class EstadoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public DataTable ComboBoxEstado()
        {
            try
            {
                var dataTable = new DataTable();
                acessoDadosSqlServer.LimparParametros();
                dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEstadoConsultar");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Sem dados. " + exception.Message);
            }
        }
    }
}
