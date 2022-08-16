using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaEtapa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public PeriodoDisciplina PeriodoDisciplina { get; set; }
        public double Nota { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }       
    }
}
