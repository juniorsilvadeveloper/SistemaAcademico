using System;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocios
{
    public class SecretariadoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Secretariado secretariado)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", secretariado.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", secretariado.Nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", secretariado.Cpf);
                acessoDadosSqlServer.AdicionarParametros("@Identidade", secretariado.Identidade);
                acessoDadosSqlServer.AdicionarParametros("@CNH", secretariado.Cnh);
                acessoDadosSqlServer.AdicionarParametros("@Logradouro", secretariado.Logradouro);
                acessoDadosSqlServer.AdicionarParametros("@NumeroLogradouro", secretariado.NumeroLogradouro);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", secretariado.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", secretariado.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@CEP", secretariado.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", secretariado.Cidade.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", secretariado.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", secretariado.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@Cargo", secretariado.Cargo.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", secretariado.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", secretariado.Instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Email", secretariado.Email);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", secretariado.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", secretariado.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@GrauEscolar", secretariado.GrauEscolar.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspSecretariado").ToString();
                return codigo; ;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public DataTable CarregarComboUsuarioInserir()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 4);
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSecretariado");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        // Consultar por código único

        public Secretariado ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var secretariado = new Secretariado();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSecretariadoConsultar");

                foreach (DataRow secretariadoLinha in dataTable.Rows)
                {
                    secretariado.Codigo = Convert.ToInt32(secretariadoLinha["CodigoSecretariado"]);
                    secretariado.Nome = Convert.ToString(secretariadoLinha["NomeSecretariado"]);
                    secretariado.Cpf = Convert.ToString(secretariadoLinha["CPFSecretariado"]);
                    secretariado.Identidade = Convert.ToString(secretariadoLinha["IdentidadeSecretariado"]);
                    secretariado.Cnh = Convert.ToString(secretariadoLinha["CNHSecretariado"]);
                    secretariado.DataNascimento = Convert.ToDateTime(secretariadoLinha["DataNascimentoSecretariado"]);
                    secretariado.Logradouro = Convert.ToString(secretariadoLinha["LogradouroSecretariado"]);
                    secretariado.NumeroLogradouro = Convert.ToString(secretariadoLinha["NumeroLogradouroSecretariado"]);
                    secretariado.Complemento = Convert.ToString(secretariadoLinha["ComplementoSecretariado"]);
                    secretariado.Bairro = Convert.ToString(secretariadoLinha["BairroSecretariado"]);
                    secretariado.Cep = Convert.ToString(secretariadoLinha["CEPSecretariado"]);

                    var estado = new Estado();
                    var cidade = new Cidade();

                    cidade.Codigo = Convert.ToInt32(secretariadoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(secretariadoLinha["NomeCidade"]);

                    estado.Codigo = Convert.ToInt32(secretariadoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(secretariadoLinha["SiglaEstado"]);
                    cidade.Estado = estado;                   

                    secretariado.Cidade = cidade;

                    secretariado.Email = Convert.ToString(secretariadoLinha["EmailSecretariado"]);
                    secretariado.Telefone = Convert.ToString(secretariadoLinha["TelefoneSecretariado"]);

                    var grauEscolar = new GrauEscolar();
                    grauEscolar.Codigo = Convert.ToInt32(secretariadoLinha["CodigoGrauEscolar"]);
                    grauEscolar.Nome = Convert.ToString(secretariadoLinha["NomeGrauEscolar"]);

                    secretariado.GrauEscolar = grauEscolar;
                    secretariado.Situacao = Convert.ToBoolean(secretariadoLinha["SituacaoSecretariado"]);

                    var cargo = new Cargo();
                    cargo.Codigo = Convert.ToInt32(secretariadoLinha["CodigoCargo"]);
                    cargo.Nome = Convert.ToString(secretariadoLinha["NomeCargo"]);

                    secretariado.Cargo = cargo;
                    secretariado.Observacao = Convert.ToString(secretariadoLinha["ObservacaoSecretariado"]);

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(secretariadoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(secretariadoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(secretariadoLinha["RazaoSocialInstituicao"]);

                    secretariado.Instituicao = instituicao;
                    secretariado.DataCadastro = Convert.ToDateTime(secretariadoLinha["DataCadastroSecretariado"]);
                    secretariado.DataAlteracao = Convert.ToDateTime(secretariadoLinha["DataAlteracaoSecretariado"]);

                    var usuarioalterou = new Usuario();
                    usuarioalterou.Codigo = Convert.ToInt32(secretariadoLinha["CodigoUsuarioAlterou"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(secretariadoLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(secretariadoLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(secretariadoLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(secretariadoLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(secretariadoLinha["NomeReal"]);

                    secretariado.UsuarioAlterou = usuarioalterou;
                }
                return secretariado;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public SecretariadoColecao Consultar(string codigoInstituicao,
                                             string codigo,
                                             string nome,
                                             string cpf,
                                             string situacao)
        {
            try
            {
                var secretariadoColecao = new SecretariadoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSecretariadoConsultar");

                foreach (DataRow secretariadoLinha in dataTable.Rows)
                {
                    var secretariado = new Secretariado();

                    secretariado.Codigo = Convert.ToInt32(secretariadoLinha["CodigoSecretariado"]);
                    secretariado.Nome = Convert.ToString(secretariadoLinha["NomeSecretariado"]);
                    secretariado.Cpf = Convert.ToString(secretariadoLinha["CPFSecretariado"]);
                    secretariado.Identidade = Convert.ToString(secretariadoLinha["IdentidadeSecretariado"]);
                    secretariado.Cnh = Convert.ToString(secretariadoLinha["CNHSecretariado"]);
                    secretariado.DataNascimento = Convert.ToDateTime(secretariadoLinha["DataNascimentoSecretariado"]);
                    secretariado.Logradouro = Convert.ToString(secretariadoLinha["LogradouroSecretariado"]);
                    secretariado.NumeroLogradouro = Convert.ToString(secretariadoLinha["NumeroLogradouroSecretariado"]);
                    secretariado.Complemento = Convert.ToString(secretariadoLinha["ComplementoSecretariado"]);
                    secretariado.Bairro = Convert.ToString(secretariadoLinha["BairroSecretariado"]);
                    secretariado.Cep = Convert.ToString(secretariadoLinha["CEPSecretariado"]);

                    var estado = new Estado();
                    var cidade = new Cidade();

                    cidade.Codigo = Convert.ToInt32(secretariadoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(secretariadoLinha["NomeCidade"]);

                    estado.Codigo = Convert.ToInt32(secretariadoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(secretariadoLinha["SiglaEstado"]);
                    cidade.Estado = estado;                   

                    secretariado.Cidade = cidade;

                    secretariado.Email = Convert.ToString(secretariadoLinha["EmailSecretariado"]);
                    secretariado.Telefone = Convert.ToString(secretariadoLinha["TelefoneSecretariado"]);

                    var grauEscolar = new GrauEscolar();
                    grauEscolar.Codigo = Convert.ToInt32(secretariadoLinha["CodigoGrauEscolar"]);
                    grauEscolar.Nome = Convert.ToString(secretariadoLinha["NomeGrauEscolar"]);

                    secretariado.GrauEscolar = grauEscolar;

                    secretariado.Situacao = Convert.ToBoolean(secretariadoLinha["SituacaoSecretariado"]);

                    var cargo = new Cargo();
                    cargo.Codigo = Convert.ToInt32(secretariadoLinha["CodigoCargo"]);
                    cargo.Nome = Convert.ToString(secretariadoLinha["NomeCargo"]);

                    secretariado.Cargo = cargo;

                    secretariado.Observacao = Convert.ToString(secretariadoLinha["ObservacaoSecretariado"]);

                    var instituicao = new Instituicao();
                    instituicao.Codigo = Convert.ToInt32(secretariadoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(secretariadoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(secretariadoLinha["RazaoSocialInstituicao"]);

                    secretariado.Instituicao = instituicao;

                    secretariado.DataCadastro = Convert.ToDateTime(secretariadoLinha["DataCadastroSecretariado"]);
                    secretariado.DataAlteracao = Convert.ToDateTime(secretariadoLinha["DataAlteracaoSecretariado"]);

                    var usuarioalterou = new Usuario();
                    usuarioalterou.Codigo = Convert.ToInt32(secretariadoLinha["CodigoUsuarioAlterou"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(secretariadoLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(secretariadoLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(secretariadoLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(secretariadoLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(secretariadoLinha["NomeReal"]);

                    secretariado.UsuarioAlterou = usuarioalterou;

                    secretariadoColecao.Add(secretariado);
                }
                return secretariadoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
