using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaAluno
    {
        private Turma turma;
        private Aluno aluno;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private SituacaoCurso situacaoCurso;

        public Turma Turma { get; set; }
        public Aluno Aluno { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public SituacaoCurso SituacaoCurso { get; set; }
    }
}
