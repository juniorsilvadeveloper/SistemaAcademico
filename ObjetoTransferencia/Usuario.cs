using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Usuario
    {
        private int codigo;
        private Boolean aluno;
        private Boolean professor;
        private Boolean secretariado;
        private int idUsuario;
        private string nomeUsuario;
        private string senha;
        private Boolean situacao;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Boolean administrador;
        private Usuario usuarioAlterou;
        private Instituicao instituicao;
        private string nomeReal;

        public int Codigo { get => codigo; set => codigo = value; }
        public bool Aluno { get => aluno; set => aluno = value; }
        public bool Professor { get => professor; set => professor = value; }
        public bool Secretariado { get => secretariado; set => secretariado = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public bool Administrador { get => administrador; set => administrador = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public Instituicao Instituicao { get => instituicao; set => instituicao = value; }
        public string NomeReal { get => nomeReal; set => nomeReal = value; }
    }
}
