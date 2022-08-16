using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaFrequenciaAulaAluno
    {
        public TurmaFrequenciaAula TurmaFrequenciaAula { get; set; }
        public Aluno Aluno { get; set; }
        public int QuantidadeAulas { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public int TotalFaltas { get; set; }
        public int TotalAulas { get; set; }
        public string QtdFaltas { get; set; }       
        public bool Faltou { get; set; }
    }
}
