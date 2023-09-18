﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class
{
    internal class ContaEstudante : Conta
    {
        public double LimiCheEspe { get; set; }
        public string CPF { get; set; }
        public string NomeInstituicao { get; set; }


        public ContaEstudante()
        {

        }
        public ContaEstudante(double nConta, string agencia, string titularConta, double saldo, double limiteChequeEspecial, string cpf, string instituicaoEnsino)
            : base(nConta, agencia, titularConta, saldo)
        {
            LimiCheEspe = limiteChequeEspecial;
            CPF = cpf;
            NomeInstituicao = NomeInstituicao;


        }
        public override void Sacar(double valor)
        {
            if (valor <= (Saldo + LimiCheEspe))
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                }
                else
                {
                    double valorSacado = valor - Saldo;
                    Saldo = 0;
                 
                }
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, foi atingido limite de cheque especial.");
            }
        }

    }
}