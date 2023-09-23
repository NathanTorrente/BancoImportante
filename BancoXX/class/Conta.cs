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
            if (valor >= Saldo)
            {
                Saldo -= valor; 
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        public virtual void Depositar(double valor) // virtual é quando a classe é a principal
        {

            if (Saldo >= 0)
            {
                Saldo += valor;

            }
            else 
            {
                Console.WriteLine("Saldo abaixo do limite para depositar!!");
            }
        }
    }
}
