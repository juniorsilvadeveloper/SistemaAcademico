using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cidade
    {
        private int codigo;
        private string nome;
        private Estado estado;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public Estado Estado { get => estado; set => estado = value; }
    }
}
