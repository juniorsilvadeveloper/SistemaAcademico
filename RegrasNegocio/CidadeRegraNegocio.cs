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
    public class CidadeRegraNegocio
    {
        private AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public DataTable ComboBoxCidade(string estado)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Estado", estado);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCidadeConsultar");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Sem dados. " + exception.Message);
            }
        }
    }
}
