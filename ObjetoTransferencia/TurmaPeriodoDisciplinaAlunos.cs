using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaPeriodoDisciplinaAlunos
    {
        public PeriodoDisciplina PeriodoDisciplina { get; set; }
        public Aluno Aluno { get; set; }
        public double MediaFinal { get; set; }
        public double Frequencia { get; set; }
        public bool Situacao { get; set; }
        public SituacaoAlunoDisciplina SituacaoDisciplina { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public int TotalFaltas { get; set; }
        public int TotalAulas { get; set; }
        public bool Faltou { get; set; }
        public string QtdFaltas { get; set; }
        public string NotaExameFinalGrid { get; set; }
        public double NotaExameFinal { get; set; }
        public int? CodigoExameFinal { get; set; }
    }
}
