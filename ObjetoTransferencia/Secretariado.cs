using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Secretariado : Pessoa
    {
        private Cargo cargo;

        public Cargo Cargo { get => cargo; set => cargo = value; }
    }
}
