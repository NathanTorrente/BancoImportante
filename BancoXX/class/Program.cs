using BancoXX.@class;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        int Nconta = 0;
        while (true)
        {
            Console.WriteLine("\nEscolha uma ação:\n");

            Console.WriteLine("1- Conta Empresarial.");
            Console.WriteLine("2- Conta Estudante.");
            Console.WriteLine("3- Conta Normal.");
            Console.WriteLine("4- Sair.\n");
            Console.Write("Opção: ");

            int escolhadomenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (escolhadomenu == 1) // Empresarial
            {
                Console.Write("\nDigite o nome do títular: ");
                string nomeTitular = Console.ReadLine();

                Console.Write("Digite a agencia: ");
                string agencia = Convert.ToString(Console.ReadLine());

                ContaEmpresa empre = new ContaEmpresa(Nconta, agencia, nomeTitular, 0, 5, 6000);
                Nconta += 1;

                while (true)
                {
                    Console.WriteLine($" Numero da conta: {Nconta}\n");
                    Console.Write("\nEscolha uma das funções: \n");
                    Console.WriteLine("\n1- Fazer Saque.");
                    Console.WriteLine("2- Fazer Empréstimo.");
                    Console.WriteLine("3- Sair\n");

                    Console.Write("Opção: ");

                    int escolh = Convert.ToInt32(Console.ReadLine());

                    if (escolh == 1) // Fazer saque
                    {
                        Console.Clear();
                      
                        Console.WriteLine($"\nSaldo Existente R$: {empre.Saldo}");

                        Console.Write("\nDigite o valor para o saque R$: ");
                        int valor = Convert.ToInt32(Console.ReadLine());

                        if (valor <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nO valor do saque deve ser maior do que zero!!");
                            Console.ResetColor();
                        }
                        else if (valor > empre.Saldo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nSaldo insuficiente!");
                            Console.ResetColor();
                        }
                        else 
                        {
                            empre.Sacar(valor);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n  Saque Realizado! -- Saldo Atual: {empre.Saldo.ToString("C2")} ");
                            Console.ResetColor();
                        } 
                    }
                    else if (escolh == 2) // Fazer empréstimo
                    {
                        Console.Clear();
                        Console.WriteLine($"\nSaldo existente R$: {empre.Saldo}");
                        Console.WriteLine($"Limite de seu empréstimo R$: {empre.LimiEmpre}");
                        Console.Write("\n Digite o valor para empréstimo: ");

                        double valor = Convert.ToDouble(Console.ReadLine());
                        empre.RealizarEmprestimo(valor);
                        Console.WriteLine($"\nSaldo atual R$: {empre.Saldo}");
                        Console.WriteLine($"O valor atual do limite é R$: {empre.LimiEmpre} ");
                    }
                    else if (escolh == 3) // Sair das opções
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (escolhadomenu == 2) // Estudante
            {
               
                Console.Write("\nDigite o nome do títular: ");
                string nomeTitular = Console.ReadLine();
                Console.Write("Digite seu CPF: ");
                string cpf = Convert.ToString(Console.ReadLine());
                Console.Write("Digite a agencia: ");
                string agencia = Convert.ToString(Console.ReadLine());
                
                ContaEstudante estu = new ContaEstudante(Nconta, agencia, nomeTitular, 2000, 5000, cpf, "Instituto Federal (IFRO)");
                Nconta += 1;
                Console.WriteLine($"Nome do Instituto: {estu.NomeInstituicao}");
                Console.WriteLine($"Numero da conta: {Nconta}");
               
                while (true)
                {
                  
                    Console.Write("\nEscolha uma das funções:\n");
                    Console.WriteLine($"\nSaldo Atual R$: {estu.Saldo}");
                    Console.WriteLine($"Limite de Check Especial R$: {estu.LimiCheEspe}");
                    Console.WriteLine("\n 1- Fazer Saque");
                    Console.WriteLine(" 2- Sair\n");

                    Console.Write("Opção: ");
                    int esco = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (esco == 1) // Fazer saque
                    {
                        Console.WriteLine($"\nSaldo Existente R$: {estu.Saldo}");
                        Console.Write("\nDigite o valor para o Saque: ");
                        int valosaq = Convert.ToInt32(Console.ReadLine());
                        estu.Sacar(valosaq);                        
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (escolhadomenu == 3) // Normal
            {
                Console.Write("Digite o nome do títular: ");
                string nomeTitular = Console.ReadLine();

                Conta c = new Conta(Nconta, "1404-1", "Carioca", 0);
                

                Nconta += 1;
                while (true)
                {
                    Console.WriteLine($" Numero da conta: {Nconta}\n");
                    Console.Write("\nEscolha uma das funções:\n");
                    Console.WriteLine("1- Fazer Saque.");
                    Console.WriteLine("2- Depositar");
                    Console.WriteLine("3- Sair");

                    Console.Write("Opção: ");

                    int escos = Convert.ToInt32(Console.ReadLine());

                    if (escos == 1) // Fazer Saque
                    {
                        Console.Clear();
                        Console.WriteLine($"\nSaldo existente: {c.Saldo}");
                        Console.Write("Digite o valor para o Saque R$: ");


                        int valor = Convert.ToInt32(Console.ReadLine());

                        if (valor <= c.Saldo)
                        {
                            c.Sacar(valor);
                            
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Saldo atual: {c.Saldo}");
                           Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nSaldo insuficiente para o saque.");
                            Console.ResetColor();
                        }
                      
                    }
                    else if (escos == 2) // Fazer Depósito
                    {
                        Console.Clear();
                        
                        Console.WriteLine($"\nSaldo existente R$: {c.Saldo}");
                        Console.Write("\n Digite o valor para Depositar R$: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                      
                    }
                    else if (escolhadomenu == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("\nFechando o programa!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção Inválida!");
                        Console.ResetColor();
                    }
                }
            }          
        }
    }
}