using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class CursoDisciplina
    {
        private Curso curso;
        private Disciplina disciplina;
        private Boolean situacao;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;

        public Curso Curso { get => curso; set => curso = value; }
        public Disciplina Disciplina { get => disciplina; set => disciplina = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
    }
}
