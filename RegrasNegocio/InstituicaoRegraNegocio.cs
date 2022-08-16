using System;
using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace RegrasNegocio
{
    public class InstituicaoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Instituicao instituicao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@RazaoSocial", instituicao.RazaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@NomeFantasia", instituicao.NomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", instituicao.Cnpj);
                acessoDadosSqlServer.AdicionarParametros("@InscricaoEstadual", instituicao.InscricaoEstadual);
                acessoDadosSqlServer.AdicionarParametros("@Logradouro", instituicao.Logradouro);
                acessoDadosSqlServer.AdicionarParametros("@NumeroLogradouro", instituicao.NumeroLogradouro);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", instituicao.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", instituicao.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@CEP", instituicao.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", instituicao.Cidade.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", instituicao.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", instituicao.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", instituicao.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@PorcentagemAprovacao", instituicao.PorcentagemAprovacao);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", instituicao.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@Email", instituicao.Email);
                acessoDadosSqlServer.AdicionarParametros("@MediaNotaFinal", instituicao.MediaNotaFinal);
                acessoDadosSqlServer.AdicionarParametros("@PorcentagemExameFinal", instituicao.PorcentagemExameFinal);
                acessoDadosSqlServer.AdicionarParametros("@PorcentagemReprovacaoDireta", instituicao.PorcentagemReprovacaoDireta);
                acessoDadosSqlServer.AdicionarParametros("@ConsiderarNotaTotalEtapaResultadoFinal", instituicao.ConsiderarNotaTotalEtapaResultadoFinal);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspInstituicao").ToString();
                return codigo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public DataTable CarregarComboBox(string instituicao)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 2);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", instituicao);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspInstituicaoConsultar");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por código único

        public Instituicao ConsultarCodigoUnico(string codigo)
        {
            try
            {
                Instituicao instituicao = new Instituicao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspInstituicaoConsultar");

                foreach (DataRow instituicaoLinha in dataTable.Rows)
                {
                    instituicao.Codigo = Convert.ToInt32(instituicaoLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(instituicaoLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(instituicaoLinha["NomeFantasiaInstituicao"]);
                    instituicao.Cnpj = Convert.ToString(instituicaoLinha["CNPJInstituicao"]);
                    instituicao.InscricaoEstadual = Convert.ToString(instituicaoLinha["InscricaoEstadualInstituicao"]);
                    instituicao.Logradouro = Convert.ToString(instituicaoLinha["LogradouroInstituicao"]);
                    instituicao.NumeroLogradouro = Convert.ToString(instituicaoLinha["NumeroLogradouroInstituicao"]);
                    instituicao.Complemento = Convert.ToString(instituicaoLinha["ComplementoInstituicao"]);
                    instituicao.Bairro = Convert.ToString(instituicaoLinha["BairroInstituicao"]);
                    instituicao.Cep = Convert.ToString(instituicaoLinha["CEPInstituicao"]);

                    Estado estado = new Estado();
                    Cidade cidade = new Cidade();

                    estado.Codigo = Convert.ToInt32(instituicaoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(instituicaoLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(instituicaoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(instituicaoLinha["NomeCidade"]);

                    instituicao.Cidade = cidade;

                    instituicao.Observacao = Convert.ToString(instituicaoLinha["ObservacaoInstituicao"]);
                    instituicao.PorcentagemAprovacao = Convert.ToDouble(instituicaoLinha["PorcentagemAprovacaoInstituicao"]);
                    instituicao.Situacao = Convert.ToBoolean(instituicaoLinha["SituacaoInstituicao"]);
                    instituicao.DataCadastro = Convert.ToDateTime(instituicaoLinha["DataCadastroInstituicao"]);
                    instituicao.DataAlteracao = Convert.ToDateTime(instituicaoLinha["DataAlteracaoInstituicao"]);

                    Usuario usuario = new Usuario();

                    usuario.Codigo = Convert.ToInt32(instituicaoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(instituicaoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(instituicaoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(instituicaoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(instituicaoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(instituicaoLinha["NomeReal"]);
                    instituicao.UsuarioAlterou = usuario;

                    instituicao.Telefone = Convert.ToString(instituicaoLinha["TelefoneInstituicao"]);
                    instituicao.Email = Convert.ToString(instituicaoLinha["EmailInstituicao"]);
                    instituicao.MediaNotaFinal = Convert.ToBoolean(instituicaoLinha["MediaNotaFinalInstituicao"]);
                    instituicao.PorcentagemExameFinal = Convert.ToDouble(instituicaoLinha["PorcentagemExameFinalInstituicao"]);
                    instituicao.PorcentagemReprovacaoDireta = Convert.ToDouble(instituicaoLinha["PorcentagemReprovacaoDiretaInstituicao"]);
                    instituicao.ConsiderarNotaTotalEtapaResultadoFinal = Convert.ToBoolean(instituicaoLinha["ConsiderarNotaTotalEtapaResultadoFinalInstituicao"]);
                }
                return instituicao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public InstituicaoColecao Consultar(string codigo,
                                            string razaoSocial,
                                            string nomeFantasia,
                                            string cnpj,
                                            string situacao)
        {
            try
            {
                InstituicaoColecao instituicaoColecao = new InstituicaoColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Opcao", 1);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@RazaoSocial", razaoSocial);
                acessoDadosSqlServer.AdicionarParametros("@NomeFantasia", nomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@CNPJ", cnpj);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspInstituicaoConsultar");

                foreach (DataRow instituicaoLinha in dataTable.Rows)
                {
                    Instituicao instituicao = new Instituicao();

                    instituicao.Codigo = Convert.ToInt32(instituicaoLinha["CodigoInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(instituicaoLinha["RazaoSocialInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(instituicaoLinha["NomeFantasiaInstituicao"]);
                    instituicao.Cnpj = Convert.ToString(instituicaoLinha["CNPJInstituicao"]);
                    instituicao.InscricaoEstadual = Convert.ToString(instituicaoLinha["InscricaoEstadualInstituicao"]);
                    instituicao.Logradouro = Convert.ToString(instituicaoLinha["LogradouroInstituicao"]);
                    instituicao.NumeroLogradouro = Convert.ToString(instituicaoLinha["NumeroLogradouroInstituicao"]);
                    instituicao.Complemento = Convert.ToString(instituicaoLinha["ComplementoInstituicao"]);
                    instituicao.Bairro = Convert.ToString(instituicaoLinha["BairroInstituicao"]);
                    instituicao.Cep = Convert.ToString(instituicaoLinha["CEPInstituicao"]);

                    Estado estado = new Estado();
                    Cidade cidade = new Cidade();

                    estado.Codigo = Convert.ToInt32(instituicaoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(instituicaoLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(instituicaoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(instituicaoLinha["NomeCidade"]);

                    instituicao.Cidade = cidade;

                    instituicao.Observacao = Convert.ToString(instituicaoLinha["ObservacaoInstituicao"]);
                    instituicao.PorcentagemAprovacao = Convert.ToDouble(instituicaoLinha["PorcentagemAprovacaoInstituicao"]);
                    instituicao.Situacao = Convert.ToBoolean(instituicaoLinha["SituacaoInstituicao"]);
                    instituicao.DataCadastro = Convert.ToDateTime(instituicaoLinha["DataCadastroInstituicao"]);
                    instituicao.DataAlteracao = Convert.ToDateTime(instituicaoLinha["DataAlteracaoInstituicao"]);

                    Usuario usuario = new Usuario();

                    usuario.Codigo = Convert.ToInt32(instituicaoLinha["CodigoUsuario"]);
                    usuario.Aluno = Convert.ToBoolean(instituicaoLinha["UsuarioAluno"]);
                    usuario.Professor = Convert.ToBoolean(instituicaoLinha["UsuarioProfessor"]);
                    usuario.Secretariado = Convert.ToBoolean(instituicaoLinha["UsuarioSecretariado"]);
                    usuario.Administrador = Convert.ToBoolean(instituicaoLinha["UsuarioAdministrador"]);
                    usuario.NomeReal = Convert.ToString(instituicaoLinha["NomeReal"]);
                    instituicao.UsuarioAlterou = usuario;

                    instituicao.Telefone = Convert.ToString(instituicaoLinha["TelefoneInstituicao"]);
                    instituicao.Email = Convert.ToString(instituicaoLinha["EmailInstituicao"]);
                    instituicao.MediaNotaFinal = Convert.ToBoolean(instituicaoLinha["MediaNotaFinalInstituicao"]);
                    instituicao.PorcentagemExameFinal = Convert.ToDouble(instituicaoLinha["PorcentagemExameFinalInstituicao"]);
                    instituicao.PorcentagemReprovacaoDireta = Convert.ToDouble(instituicaoLinha["PorcentagemReprovacaoDiretaInstituicao"]);
                    instituicao.ConsiderarNotaTotalEtapaResultadoFinal = Convert.ToBoolean(instituicaoLinha["ConsiderarNotaTotalEtapaResultadoFinalInstituicao"]);

                    instituicaoColecao.Add(instituicao);
                }
                return instituicaoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
