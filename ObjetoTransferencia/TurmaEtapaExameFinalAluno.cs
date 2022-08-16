using System;

namespace ObjetoTransferencia
{
    public class TurmaEtapaExameFinalAluno
    {
        public TurmaEtapaExameFinal TurmaEtapaExameFinal { get; set; }
        public Aluno Aluno { get; set; }
        public double Nota { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
    }
}
