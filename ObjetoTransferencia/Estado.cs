using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Estado
    {
        private int codigo;
        private string nome;
        private string sigla;
        private Pais pais;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sigla { get => sigla; set => sigla = value; }
        public Pais Pais { get => pais; set => pais = value; }
    }
}
