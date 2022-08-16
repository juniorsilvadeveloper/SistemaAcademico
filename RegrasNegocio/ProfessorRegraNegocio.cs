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
    public class ProfessorRegraNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        // Manipulações

        public string Manipulacoes(string opcao, Professor professor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Opcao", opcao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", professor.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", professor.Nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", professor.Cpf);
                acessoDadosSqlServer.AdicionarParametros("@Identidade", professor.Identidade);
                acessoDadosSqlServer.AdicionarParametros("@CNH", professor.Cnh);
                acessoDadosSqlServer.AdicionarParametros("@Logradouro", professor.Logradouro);
                acessoDadosSqlServer.AdicionarParametros("@NumeroLogradouro", professor.NumeroLogradouro);
                acessoDadosSqlServer.AdicionarParametros("@Complemento", professor.Complemento);
                acessoDadosSqlServer.AdicionarParametros("@Bairro", professor.Bairro);
                acessoDadosSqlServer.AdicionarParametros("@CEP", professor.Cep);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", professor.Cidade.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Observacao", professor.Observacao);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", professor.Situacao);
                acessoDadosSqlServer.AdicionarParametros("@UsuarioAlterou", professor.UsuarioAlterou.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", professor.Instituicao.Codigo);
                acessoDadosSqlServer.AdicionarParametros("@Email", professor.Email);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", professor.Telefone);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", professor.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@GrauEscolar", professor.GrauEscolar.Codigo);

                string codigo = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProfessor").ToString();
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
                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessor");
                return dataTable;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        // Consultar por código único

        public Professor ConsultarCodigoUnico(string codigo, string codigoInstituicao)
        {
            try
            {
                var professor = new Professor();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultar");

                foreach (DataRow professorLinha in dataTable.Rows)
                {
                    var cidade = new Cidade();
                    var estado = new Estado();
                    var usuarioalterou = new Usuario();
                    var instituicao = new Instituicao();
                    var grauEscolar = new GrauEscolar();

                    professor.Codigo = Convert.ToInt32(professorLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(professorLinha["NomeProfessor"]);
                    professor.Cpf = Convert.ToString(professorLinha["CPFProfessor"]);
                    professor.Identidade = Convert.ToString(professorLinha["IdentidadeProfessor"]);
                    professor.Cnh = Convert.ToString(professorLinha["CNHProfessor"]);
                    professor.Logradouro = Convert.ToString(professorLinha["LogradouroProfessor"]);
                    professor.NumeroLogradouro = Convert.ToString(professorLinha["NumeroLogradouroProfessor"]);
                    professor.Complemento = Convert.ToString(professorLinha["ComplementoProfessor"]);
                    professor.Bairro = Convert.ToString(professorLinha["BairroProfessor"]);
                    professor.Cep = Convert.ToString(professorLinha["CEPProfessor"]);

                    estado.Codigo = Convert.ToInt32(professorLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(professorLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(professorLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(professorLinha["NomeCidade"]);

                    professor.Cidade = cidade;

                    professor.Observacao = Convert.ToString(professorLinha["ObservacaoProfessor"]);
                    professor.Situacao = Convert.ToBoolean(professorLinha["SituacaoProfessor"]);
                    professor.Email = Convert.ToString(professorLinha["EmailProfessor"]);
                    professor.Telefone = Convert.ToString(professorLinha["TelefoneProfessor"]);
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimentoProfessor"]);

                    grauEscolar.Codigo = Convert.ToInt32(professorLinha["CodigoGrauEscoloarProfessor"]);
                    grauEscolar.Nome = Convert.ToString(professorLinha["NomeGrauEscolarProfessor"]);

                    professor.GrauEscolar = grauEscolar;

                    instituicao.Codigo = Convert.ToInt32(professorLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(professorLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(professorLinha["RazaoSocialInstituicao"]);

                    professor.Instituicao = instituicao;

                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastroProfessor"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracaoProfessor"]);

                    usuarioalterou.Codigo = Convert.ToInt32(professorLinha["CodigoUsuarioAlterou"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(professorLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(professorLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(professorLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(professorLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(professorLinha["NomeRealAlterou"]);

                    professor.UsuarioAlterou = usuarioalterou;
                }
                return professor;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }

        // Consultar por vários códigos

        public ProfessorColecao Consultar(string codigoInstituicao,
                                          string codigo,
                                          string nome,
                                          string cpf,
                                          string situacao)
        {
            try
            {
                var professorColecao = new ProfessorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Instituicao", codigoInstituicao);
                acessoDadosSqlServer.AdicionarParametros("@Codigo", codigo);
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", situacao);

                var dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProfessorConsultar");

                foreach (DataRow professorLinha in dataTable.Rows)
                {
                    var professor = new Professor();

                    var cidade = new Cidade();
                    var estado = new Estado();
                    var usuarioalterou = new Usuario();
                    var instituicao = new Instituicao();
                    var grauEscolar = new GrauEscolar();

                    professor.Codigo = Convert.ToInt32(professorLinha["CodigoProfessor"]);
                    professor.Nome = Convert.ToString(professorLinha["NomeProfessor"]);
                    professor.Cpf = Convert.ToString(professorLinha["CPFProfessor"]);
                    professor.Identidade = Convert.ToString(professorLinha["IdentidadeProfessor"]);
                    professor.Cnh = Convert.ToString(professorLinha["CNHProfessor"]);
                    professor.Logradouro = Convert.ToString(professorLinha["LogradouroProfessor"]);
                    professor.NumeroLogradouro = Convert.ToString(professorLinha["NumeroLogradouroProfessor"]);
                    professor.Complemento = Convert.ToString(professorLinha["ComplementoProfessor"]);
                    professor.Bairro = Convert.ToString(professorLinha["BairroProfessor"]);
                    professor.Cep = Convert.ToString(professorLinha["CEPProfessor"]);

                    estado.Codigo = Convert.ToInt32(professorLinha["CodigoEstado"]);
                    estado.Sigla = Convert.ToString(professorLinha["SiglaEstado"]);
                    cidade.Estado = estado;

                    cidade.Codigo = Convert.ToInt32(professorLinha["CodigoCidade"]);
                    cidade.Nome = Convert.ToString(professorLinha["NomeCidade"]);

                    professor.Cidade = cidade;

                    professor.Observacao = Convert.ToString(professorLinha["ObservacaoProfessor"]);
                    professor.Situacao = Convert.ToBoolean(professorLinha["SituacaoProfessor"]);
                    professor.Email = Convert.ToString(professorLinha["EmailProfessor"]);
                    professor.Telefone = Convert.ToString(professorLinha["TelefoneProfessor"]);
                    professor.DataNascimento = Convert.ToDateTime(professorLinha["DataNascimentoProfessor"]);

                    grauEscolar.Codigo = Convert.ToInt32(professorLinha["CodigoGrauEscoloarProfessor"]);
                    grauEscolar.Nome = Convert.ToString(professorLinha["NomeGrauEscolarProfessor"]);

                    professor.GrauEscolar = grauEscolar;

                    instituicao.Codigo = Convert.ToInt32(professorLinha["CodigoInstituicao"]);
                    instituicao.NomeFantasia = Convert.ToString(professorLinha["NomeFantasiaInstituicao"]);
                    instituicao.RazaoSocial = Convert.ToString(professorLinha["RazaoSocialInstituicao"]);

                    professor.Instituicao = instituicao;

                    professor.DataCadastro = Convert.ToDateTime(professorLinha["DataCadastroProfessor"]);
                    professor.DataAlteracao = Convert.ToDateTime(professorLinha["DataAlteracaoProfessor"]);

                    usuarioalterou.Codigo = Convert.ToInt32(professorLinha["CodigoUsuarioAlterou"]);
                    usuarioalterou.Aluno = Convert.ToBoolean(professorLinha["UsuarioAluno"]);
                    usuarioalterou.Professor = Convert.ToBoolean(professorLinha["UsuarioProfessor"]);
                    usuarioalterou.Secretariado = Convert.ToBoolean(professorLinha["UsuarioSecretariado"]);
                    usuarioalterou.Administrador = Convert.ToBoolean(professorLinha["UsuarioAdministrador"]);
                    usuarioalterou.NomeReal = Convert.ToString(professorLinha["NomeRealAlterou"]);

                    professor.UsuarioAlterou = usuarioalterou;

                    professorColecao.Add(professor);
                }
                return professorColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível realizar a consulta selecionada. Detalhes: " + exception.Message);
            }
        }
    }
}
