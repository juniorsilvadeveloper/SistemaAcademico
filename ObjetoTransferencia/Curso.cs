using System;

namespace ObjetoTransferencia
{
    public class Curso
    {
        private int codigo;
        private string nome;
        private int duracaoPeriodo;
        private Boolean situacao;
        private string descricao;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private Instituicao instituicao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int DuracaoPeriodo { get => duracaoPeriodo; set => duracaoPeriodo = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public Instituicao Instituicao { get => instituicao; set => instituicao = value; }
    }
}
