using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
    public class PeriodoDisciplina
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public SituacaoTurma SituacaoDisciplina { get; set; }

        public string NomeDisciplina
        {
            get
            {
                return Disciplina.Nome;
            }
        }
    }
}