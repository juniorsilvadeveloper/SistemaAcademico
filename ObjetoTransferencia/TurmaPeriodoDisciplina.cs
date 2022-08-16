using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaPeriodoDisciplina
    { 
        public PeriodoDisciplina PeriodoDisciplina { get ; set ; }
        public TurmaPeriodo TurmaPeriodo { get ; set; }
        public bool Situacao { get; set ; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public SituacaoTurma SituacaoDisciplina { get; set; }
    }
}
