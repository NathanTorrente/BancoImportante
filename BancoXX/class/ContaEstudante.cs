
using System;
using System.Collections.Generic;
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
            if (valor <= Saldo)
            {
                Saldo -= valor; // valor diminuindo do saldo...

                if(Saldo > 0) 
                {
                    double valorSacado = Saldo - valor;

                    Saldo = 0;
                    LimiCheEspe -= valorSacado;// valor diminuindo do LimiCheEspecial...
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nO valor deve ser maior que 0!");
                    Console.ResetColor();
                }
            }
            else if (valor <= (Saldo + LimiCheEspe))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Saque de {valor.ToString("C2")} feito com sucesso.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, foi atingido limite de cheque especial.");
            }
        }

    }
}