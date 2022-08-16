using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaPeriodo
    {
        public int Codigo { get; set; }
        public Turma Turma { get; set; }
        public Periodo Periodo { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
    }
}
