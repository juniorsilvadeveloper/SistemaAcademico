using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pessoa
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string identidade;
        private string cnh;
        private string logradouro;
        private string numeroLogradouro;
        private string complemento;
        private string bairro;
        private string cep;
        private Cidade cidade;
        private string observacao;
        private Boolean situacao;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private Instituicao instituicao;
        private string email;
        private string telefone;
        private DateTime dataNascimento;
        private GrauEscolar grauEscolar;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Identidade { get => identidade; set => identidade = value; }
        public string Cnh { get => cnh; set => cnh = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string NumeroLogradouro { get => numeroLogradouro; set => numeroLogradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public Instituicao Instituicao { get => instituicao; set => instituicao = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public GrauEscolar GrauEscolar { get => grauEscolar; set => grauEscolar = value; }
    }
}
