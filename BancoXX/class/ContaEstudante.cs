
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class
{
    internal class ContaEstudante : Conta // Herança, Conta estudante é filho de Conta
    {
        public double LimiCheEspe { get; set; }
        public string CPF { get; set; }
        public string NomeInstituicao { get; set; }


        public ContaEstudante()
        {
        }
        public ContaEstudante(double nConta, string agencia, string titularConta, double saldo, double limiteChequeEspecial, string cpf, string instituicaoEnsino)
            : base(nConta, agencia, titularConta, saldo) // os valores recebidos são armazenados e são pegos da classe PAI (CONTA)

        {
            LimiCheEspe = limiteChequeEspecial;
            CPF = cpf;
            NomeInstituicao = instituicaoEnsino;


        }
        public override void Sacar(double valor) // Saque para Estudante.
        {
            
            
           if (valor <= 0)
           {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO valor deve ser maior que 0!");
                Console.ResetColor();
           }
           else if (Saldo >= valor)
           {
               Saldo -= valor; // valor diminuindo do saldo...
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("\n Saque feito com sucesso!");
               Console.ResetColor();
            }
            else if (LimiCheEspe >= valor)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Esta utilizando o Check especial!!");
                Console.ResetColor();
                LimiCheEspe -= valor; // valor diminuindo do o Check especial..
                Saldo =0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nSaldo insuficiente!");
                Console.ResetColor();
            }

        }

    }
}