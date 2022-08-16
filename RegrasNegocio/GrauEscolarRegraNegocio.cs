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
    public class GrauEscolarRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, GrauEscolar grauEscolar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", grauEscolar.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", grauEscolar.Nome);
                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, 
                    "uspGrauEscolar").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public GrauEscolar ConsultarCodigoUnico(string codigo)
        {
            try
            {
                var grauEscolar = new GrauEscolar();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspGrauEscolarConsultar");

                foreach (DataRow grauEscolarLinha in dataTable.Rows)
                {
                    grauEscolar.Codigo = Convert.ToInt32(grauEscolarLinha["CodigoGrauEscolar"]);
                    grauEscolar.Nome = Convert.ToString(grauEscolarLinha["NomeGrauEscolar"]);
                }
                return grauEscolar;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public GrauEscolarColecao Consultar(string codigo,
                                            string nome)
        {
            try
            {
                var grauEscolarColecao = new GrauEscolarColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspGrauEscolarConsultar");

                foreach (DataRow grauEscolarLinha in dataTable.Rows)
                {
                    var grauEscolar = new GrauEscolar();
                    grauEscolar.Codigo = Convert.ToInt32(grauEscolarLinha["CodigoGrauEscolar"]);
                    grauEscolar.Nome = Convert.ToString(grauEscolarLinha["NomeGrauEscolar"]);

                    grauEscolarColecao.Add(grauEscolar);
                }
                return grauEscolarColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public DataTable CarregarComboBox()
        {
            try
            {
                var dataTable = new DataTable();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 2);

                return dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, 
                    "uspGrauEscolarConsultar");
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
