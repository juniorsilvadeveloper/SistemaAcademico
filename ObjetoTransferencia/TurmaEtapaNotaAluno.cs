using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class TurmaEtapaNotaAluno
    { 
        public int Codigo { get; set; }
        public TurmaEtapa TurmaEtapa { get; set; }
        public Aluno Aluno { get; set; }
        public string NotaTrabalhoGrid { get; set; }
        public string NotaAvaliacaoGrid { get; set; }
        public double NotaTrabalho { get; set; }       
        public double NotaAvaliacao { get; set; }       
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public bool Situacao { get; set; }
        public string Total { get; set; }
    }
}
