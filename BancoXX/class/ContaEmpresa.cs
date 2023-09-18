﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class // - (private) # (protected - é quando é restringido o acesso as informações de classes de herença, como pai e os filhos) - não precisa no exercício, + (método construtor)
{
    internal class ContaEmpresa : Conta
    {
        public double Anuidade { get; set; }
        public double LimiEmpre { get; set; }
        public double TotEmpre { get; set; }

        public ContaEmpresa()
        {

        }
        public ContaEmpresa(double nConta, string agencia, string titularConta, double saldo, double anuidade, double limiEmpre)
            : base(nConta, agencia, titularConta, saldo)
        {
            Anuidade = anuidade;
            LimiEmpre = limiEmpre;
            TotEmpre = 0;
        }
        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else if (valor <= (Saldo + LimiEmpre))
            {

                Console.WriteLine($"Empréstimo de R$ {valorSacado.ToString("C2")} feito com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para sacar e excede o limite de empréstimo.");
            }
        }
        public void RealizarEmprestimo(double valor)
        {
            if (valor <= LimiEmpre)
            {

                Console.WriteLine($"Empréstimo de R$ {valor:F2} pago com sucesso.");
            }
            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido.");
            }
        }


    }
}
