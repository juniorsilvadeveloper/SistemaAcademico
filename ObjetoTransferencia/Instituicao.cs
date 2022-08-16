using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Instituicao
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Logradouro { get; set; }
        public string NumeroLogradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Cidade Cidade { get; set; }
        public string Observacao { get; set; }
        public bool Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlterou { get; set; }
        public double PorcentagemAprovacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Boolean MediaNotaFinal { get; set; }
        public double PorcentagemExameFinal { get; set; }
        public double PorcentagemReprovacaoDireta { get; set; }
        public Boolean ConsiderarNotaTotalEtapaResultadoFinal { get; set; }
    }
}
