using System;
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Criar Conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        public void AlterarDataSource(string connectionString)
        {
            Settings.Default.stringConexao = connectionString;
            Settings.Default.Save();
        }

        //Parâmetros que vão para o banco de dados
        private SqlParameterCollection sqlParameterCollection =
            new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }


        public void AdicionarParametros(string nomeParametro,
            object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro,
                valorParametro));
        }

        //Manipulação - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType,
            string nomeStoredProcedureOuTextoSql)
        {
            //Tratar Erros
            try
            {
                //Criar Conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexão
                sqlConnection.Open();
                //Criar o comando que vai levar as informações para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocar informações dentro do comando 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em Segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName,
                        sqlParameter.Value));
                }

                //Executar o comando, ou seja, mandar o comando ir ao
                //banco de dados e tentar fazer alguma execução.
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }


        //Consultar Registros no Banco de Dados
        public DataTable ExecutarConsulta(CommandType commnadType,
            string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexao
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocar Informações dentro do comando
                sqlCommand.CommandType = commnadType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; // Em segundos

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName,
                        sqlParameter.Value));
                }

                //Criar um adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable = tabela de dados vazia onde vamos colocar os dados que
                //serão retornados do SGBD
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco de dados e retornar os dados da consulta
                //O Adaptador vai preencher o dataTable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public object Backup(string Diretorio)
        {
            try
            {
                SqlConnection sqlConnection = CriarConexao();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                string sql = "";
                sql = "BACKUP DATABASE \"SISTEMAACADEMICO\" TO DISK='" + Diretorio + "\\SISTEMAACADEMICO - " + DateTime.Now.Ticks.ToString() + ".bak'";

                sqlCommand.CommandText = sql;

                sqlCommand.ExecuteNonQuery();
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
    }
}