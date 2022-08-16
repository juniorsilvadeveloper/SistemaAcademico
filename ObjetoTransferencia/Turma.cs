using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Turma
    {
        private int codigo;
        private string nome;
        private Curso curso;
        private DateTime dataInicio;
        private DateTime ? dataFim;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private Instituicao instituicao;
        private Turno turno;
        private SituacaoTurma situacaoTurma;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public Curso Curso { get => curso; set => curso = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime ? DataFim { get => dataFim; set => dataFim = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public Instituicao Instituicao { get => instituicao; set => instituicao = value; }
        public Turno Turno { get => turno; set => turno = value; }
        public SituacaoTurma SituacaoTurma { get => situacaoTurma; set => situacaoTurma = value; }
    }
}
