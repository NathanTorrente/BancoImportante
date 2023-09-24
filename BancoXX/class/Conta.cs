using System;
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
        public virtual void Sacar(double valor) // polimorfimo, o pai tem uma ação e o filho tambem, porem são difentes.
                                                // a ação vai ser subescrever., ou seja, estou subescrevendo o método da classe Pai.
                                                // Ou melhor, VIRTUAL É USADA NA CLASSE PAI (CONTA)
        {
            if (valor <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO valor deve ser maior que 0!");
                Console.ResetColor();
            }
            else if (valor <= Saldo)
            {

                    Saldo -= valor;                      
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente.");
                Console.ResetColor();
            }

        }
        public virtual void Depositar(double valor) // virtual é quando a classe é a principal
        {
            if (valor <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nO valor deve ser maior que 0!");
                Console.ResetColor();
            }
            else
            {
                if (valor > 0)
                {
                    Saldo += valor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n Depositado com sucesso! Seu Novo Saldo R$: {Saldo}");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Saldo abaixo do limite para depositar!!");
                    Console.ResetColor();

                }
            }    
        }
    }
}
