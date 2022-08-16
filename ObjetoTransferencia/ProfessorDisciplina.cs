using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoTransferencia
{
    public class ProfessorDisciplina
    {
        private Professor professor;
        private Disciplina disciplina;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private Boolean situacao;

        public Professor Professor { get => professor; set => professor = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public bool Situacao { get => situacao; set => situacao = value; }

        public static implicit operator ProfessorDisciplina(PeriodoDisciplina v)
        {
            throw new NotImplementedException();
        }
    }
}