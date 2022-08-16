using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Disciplina
    {
        private int codigo;
        private string nome;
        private string descricao;
        private int cargaHoraria;
        private Boolean situacao;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private Usuario usuarioAlterou;
        private Instituicao instituicao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        public bool Situacao { get => situacao; set => situacao = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public DateTime DataAlteracao { get => dataAlteracao; set => dataAlteracao = value; }
        public Usuario UsuarioAlterou { get => usuarioAlterou; set => usuarioAlterou = value; }
        public Instituicao Instituicao { get => instituicao; set => instituicao = value; }
    }
}
