﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class
{
    internal class Conta
    {
        public double nConta { get; set; }
        public string Agencia { get; set; }
        public string TitularConta { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
        }
        public Conta(double nConta, string agencia, string titularConta, double saldo)
        {
            this.nConta = nConta;
            Agencia = agencia;
            TitularConta = titularConta;
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor; 
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
