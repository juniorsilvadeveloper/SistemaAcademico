using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace RegrasNegocios
{
    public class AlunoRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações
        public string Manipulacoes(string opcao, Aluno aluno)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", aluno.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", aluno.Nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", aluno.Cpf);
                acessoDadosSqlServer.AdicionarParametros("@Identidade", aluno.Identidade);
                acessoDadosSqlServer.AdicionarParametros("@CNH", aluno.Cnh);
                acessoDadosSqlServer.AdicionarParametros("@Logradouro", aluno.Logradouro);
                acessoDadosSqlServer.AdicionarParametros("@NumeroLogradouro", aluno.NumeroLogradouro);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", aluno.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", aluno.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@CEP", aluno.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", aluno.Cidade.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", aluno.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", aluno.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@GrauEscolar", aluno.GrauEscolar.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Matricula", aluno.Matricula);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", aluno.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", aluno.Instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Email", aluno.Email);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", aluno.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", aluno.DataNascimento);
                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAluno").ToString();
                return codigo;
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
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAluno");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        // Consultar por código único

        public Aluno ConsultarCodigoUnico(string codigo, 
                                          string cpf, 
                                          string matricula, 
                                          string situacao, 
                                          string codigoInstituicao)
        {
            try
            {
                var aluno = new Aluno();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                acessoDadosSqlServer.AdicionarParametros("@Matricula", matricula);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultar");

                foreach (DataRow alunoLinha in dataTable.Rows)
                {
                    var cidade = new Cidade();
                    var estado = new Estado();
                    var usuarioalterou = new Usuario();
                    var instituicao = new Instituicao();
                    var grauEscolar = new GrauEscolar();

                    aluno.Codigo = Convert.ToInt32(alunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(alunoLinha["NomeAluno"]);
                    aluno.Cpf = Convert.ToString(alunoLinha["CPFAluno"]);
                    aluno.Cnh = Convert.ToString(alunoLinha["CNHAluno"]);
                    aluno.Logradouro = Convert.ToString(alunoLinha["LogradouroAluno"]);
                    aluno.NumeroLogradouro = Convert.ToString(alunoLinha["NumeroLogradouroAluno"]);
                    aluno.Complemento = Convert.ToString(alunoLinha["ComplementoAluno"]);
                    aluno.Bairro = Convert.ToString(alunoLinha["BairroAluno"]);
                    aluno.Cep = Convert.ToString(alunoLinha["CEPAluno"]);
                    aluno.DataNascimento = Convert.ToDateTime(alunoLinha["DataNascimento"]);
                    aluno.Identidade = Convert.ToString(alunoLinha["IdentidadeAluno"]);

                    estado.Codigo = Convert.ToInt32(alunoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(alunoLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(alunoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(alunoLinha["NomeCidade"]);
                    aluno.Cidade = cidade;

                    aluno.Observacao = Convert.ToString(alunoLinha["ObservacaoAluno"]);
                    aluno.Situacao = Convert.ToBoolean(alunoLinha["SituacaoAluno"]);

                    grauEscolar.Codigo = Convert.ToInt32(alunoLinha["CodigoGrauEscolarAluno"]);
                    grauEscolar.Nome = Convert.ToString(alunoLinha["NomeGrauEscolarAluno"]);
                    aluno.GrauEscolar = grauEscolar;

                    aluno.Matricula = Convert.ToString(alunoLinha["MatriculaAluno"]);
                    aluno.DataCadastro = Convert.ToDateTime(alunoLinha["DataCadastroAluno"]);
                    aluno.DataAlteracao = Convert.ToDateTime(alunoLinha["DataAlteracaoAluno"]);

                    instituicao.Codigo = Convert.ToInt32(alunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(alunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(alunoLinha["RazaoSocialInstituicao"]);
                    aluno.Instituicao = instituicao;

                    aluno.Email = Convert.ToString(alunoLinha["EmailAluno"]);
                    aluno.Telefone = Convert.ToString(alunoLinha["TelefoneAluno"]);

                    usuarioalterou.Codigo = Convert.ToInt32(alunoLinha["CodigoUsuario"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(alunoLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(alunoLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(alunoLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(alunoLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(alunoLinha["NomeReal"]);
                    aluno.UsuarioAlterou = usuarioalterou;
                }
                return aluno;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public AlunoColecao Consultar(string codigoInstituicao,
                                      string codigo,
                                      string nome,
                                      string cpf,
                                      string situacao,
                                      string matricula)
        {
            try
            {
                var alunoColecao = new AlunoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);
                acessoDadosSqlServer.AdicionarParametros("@Matricula", matricula);               
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultar");

                foreach (DataRow alunoLinha in dataTable.Rows)
                {
                    var aluno = new Aluno();
                    var cidade = new Cidade();
                    var estado = new Estado();
                    var usuarioalterou = new Usuario();
                    var instituicao = new Instituicao();
                    var grauEscolar = new GrauEscolar();

                    aluno.Codigo = Convert.ToInt32(alunoLinha["CodigoAluno"]);
                    aluno.Nome = Convert.ToString(alunoLinha["NomeAluno"]);
                    aluno.Cpf = Convert.ToString(alunoLinha["CPFAluno"]);
                    aluno.Cnh = Convert.ToString(alunoLinha["CNHAluno"]);
                    aluno.Logradouro = Convert.ToString(alunoLinha["LogradouroAluno"]);
                    aluno.NumeroLogradouro = Convert.ToString(alunoLinha["NumeroLogradouroAluno"]);
                    aluno.Complemento = Convert.ToString(alunoLinha["ComplementoAluno"]);
                    aluno.Bairro = Convert.ToString(alunoLinha["BairroAluno"]);
                    aluno.Cep = Convert.ToString(alunoLinha["CEPAluno"]);
                    aluno.DataNascimento = Convert.ToDateTime(alunoLinha["DataNascimento"]);
                    aluno.Identidade = Convert.ToString(alunoLinha["IdentidadeAluno"]);

                    estado.Codigo = Convert.ToInt32(alunoLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(alunoLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(alunoLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(alunoLinha["NomeCidade"]);
                    aluno.Cidade = cidade;

                    aluno.Observacao = Convert.ToString(alunoLinha["ObservacaoAluno"]);
                    aluno.Situacao = Convert.ToBoolean(alunoLinha["SituacaoAluno"]);

                    grauEscolar.Codigo = Convert.ToInt32(alunoLinha["CodigoGrauEscolarAluno"]);
                    grauEscolar.Nome = Convert.ToString(alunoLinha["NomeGrauEscolarAluno"]);
                    aluno.GrauEscolar = grauEscolar;

                    aluno.Matricula = Convert.ToString(alunoLinha["MatriculaAluno"]);
                    aluno.DataCadastro = Convert.ToDateTime(alunoLinha["DataCadastroAluno"]);
                    aluno.DataAlteracao = Convert.ToDateTime(alunoLinha["DataAlteracaoAluno"]);

                    instituicao.Codigo = Convert.ToInt32(alunoLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(alunoLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(alunoLinha["RazaoSocialInstituicao"]);
                    aluno.Instituicao = instituicao;

                    aluno.Email = Convert.ToString(alunoLinha["EmailAluno"]);
                    aluno.Telefone = Convert.ToString(alunoLinha["TelefoneAluno"]);

                    usuarioalterou.Codigo = Convert.ToInt32(alunoLinha["CodigoUsuario"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(alunoLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(alunoLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(alunoLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(alunoLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(alunoLinha["NomeReal"]);

                    aluno.UsuarioAlterou = usuarioalterou;

                    alunoColecao.Add(aluno);
                }
                return alunoColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}