using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaFrequenciaAula
    {
        public int Codigo { get; set; }
        public PeriodoDisciplina PeriodoDisciplina { get; set; }
        public DateTime Data { get; set; }
        public int QuantidadeAulas { get; set; }
        public bool Avaliacao { get; set ; }
        public string ConteudoVivenciado { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public int QuantidadeAlunos { get; set; }
        public int QuantidadeAusentes { get; set; }
    }
}
