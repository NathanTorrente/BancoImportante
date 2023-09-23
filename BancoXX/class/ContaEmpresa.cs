using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class // - (private) # (protected - é quando é restringido o acesso as informações de classes de herença, como pai e os filhos) - não precisa no exercício, + (método construtor)
{
    internal class ContaEmpresa : Conta //Herança
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
        public override void Sacar(double valor) // Saque para Empresa., é override pois é filho da classe conta
        {
            if (valor <= Saldo) 
            {
                Saldo -= valor;

                if (Saldo <= 5000) // este saldo se refere ao total, ex: 5500, saquei 5100, valor 400
                                   // como o valor é menor, -5 desse valor total = 395
                {
                    Saldo -= 5;
                    Console.WriteLine("valor acima de 5000, (R$ - 5,00)");
                }

            }
            else if (valor <= (Saldo + LimiEmpre))
            {
                Console.WriteLine($"Empréstimo de {valor.ToString("C2")} feito com sucesso.");

                
            }
           
            else
            {
                Console.WriteLine("Saldo insuficiente, limite de empréstimo atingido.");
            }
            
        }
        public void RealizarEmprestimo(double valor)
        {
            if (valor <= LimiEmpre)
            {


                LimiEmpre -= valor; // diminui o limite emprestimo
                Saldo += valor; // soma Saldo (atual) com o valor estipulado EX: 6000 - 5000 = 995
              
                Console.WriteLine($"Empréstimo de {valor.ToString("C2")} pago com sucesso.");
              
            }
            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido.");
            }
        }

    }
}
