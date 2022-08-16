using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocio
{
    public class CargoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Cargo cargo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", cargo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cargo.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", cargo.Descricao);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCargo").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        // Consultar por código único

        public Cargo ConsultarCodigoUnico(string codigo)
        {
            try
            {
                Cargo cargo = new Cargo();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCargoConsultar");

                foreach (DataRow cargoLinha in dataTable.Rows)
                {
                    cargo.Codigo = Convert.ToInt32(cargoLinha["CodigoCargo"]);
                    cargo.Nome = Convert.ToString(cargoLinha["NomeCargo"]);
                    cargo.Descricao = Convert.ToString(cargoLinha["DescricaoCargo"]);
                }
                return cargo;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public CargoColecao Consultar(string codigo,
                                      string nome)
        {
            try
            {
                var cargoColecao = new CargoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCargoConsultar");

                foreach (DataRow cargoLinha in dataTable.Rows)
                {
                    var cargo = new Cargo();
                    cargo.Codigo = Convert.ToInt32(cargoLinha["CodigoCargo"]);
                    cargo.Nome = Convert.ToString(cargoLinha["NomeCargo"]);
                    cargo.Descricao = Convert.ToString(cargoLinha["DescricaoCargo"]);

                    cargoColecao.Add(cargo);
                }
                return cargoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        public DataTable ComboBoxCargo()
        {
            try
            {
                var dataTable = new DataTable();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("Opcao", 2);
                return dataTable = 
                    acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCargoConsultar");
            }
            catch (Exception exception)
            {
                throw new Exception("Sem dados." + exception.Message);
            }
        }
    }
}
