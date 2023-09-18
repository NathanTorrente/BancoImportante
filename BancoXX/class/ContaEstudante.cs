using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class
{
    internal class ContaEstudante: Conta
    {
        public double limiCheEspe { get; set; }
        public string cpf { get; set; }
        public string nomeInstituicao { get; set; }

    }
}