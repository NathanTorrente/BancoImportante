using BancoXX.@class;

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
                      
                        Console.WriteLine($"\nSaldo Existente: {empre.Saldo}");

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

                        Console.WriteLine($"\nSaldo existente: {empre.Saldo}");
                        Console.WriteLine($"Limite de seu empréstimo: {empre.LimiEmpre}");
                        Console.Write("\n Digite o valor para empréstimo: ");

                        double valor = Convert.ToDouble(Console.ReadLine());
                        empre.RealizarEmprestimo(valor);
                        Console.WriteLine($"\nSaldo atual: {empre.Saldo}");
                        Console.WriteLine($"O valor atual do limite é: {empre.LimiEmpre} ");
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
                    Console.WriteLine($"\nSaldo Atual: {estu.Saldo}");
                    Console.WriteLine($"Limite de Check Especial: {estu.LimiCheEspe}");
                    Console.WriteLine("\n 1- Fazer Saque\n");
                   
                    Console.Write("Opção: ");
                    int esco = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (esco == 1) // Fazer saque
                    {
                        Console.Write("\nDigite o valor para o Saque: ");
                        int valosaq = Convert.ToInt32(Console.ReadLine());
                        estu.Sacar(valosaq);

                        Console.WriteLine($"Seu Novo Saldo {estu.Saldo} ");
                    }

                }
            }
            else if (escolhadomenu == 3) // Normal
            {
                Console.Write("Digite o nome do títular:");
                string nomeTitular = Console.ReadLine();

                Conta c = new Conta(Nconta, "1404-1", "Carioca", 0);
                ContaEmpresa empre = new ContaEmpresa(Nconta, "1404-4", nomeTitular, 0, 0.35, 1000);

                Nconta += 1;
                while (true)
                {
                    Console.WriteLine($" Numero da conta: {Nconta}\n");
                    Console.Write("\nEscolha uma das funções:\n");
                    Console.WriteLine("1- Fazer Saque.");
                    Console.WriteLine("2- Depositar");
                    Console.WriteLine("3- Empréstimo");
                    Console.WriteLine("4- Sair");

                    Console.Write("Opção: ");

                    int escos = Convert.ToInt32(Console.ReadLine());

                    if (escos == 1) // Fazer Saque
                    {
                        Console.WriteLine($"\nSaldo existente: {c.Saldo}");
                        Console.Write("\nDigite o valor para o Saque: ");


                        int valor = Convert.ToInt32(Console.ReadLine());

                        if (valor < empre.Saldo)
                        {
                            empre.Sacar(valor);
                            Console.WriteLine($"Foi Sacado com sucesso: {valor}");
                            Console.WriteLine($"Saldo atual: {empre.Saldo}");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para o saque.");
                        }

                    }
                    else if (escos == 2) // Fazer Depósito
                    {
                        Console.Clear();
                        Console.WriteLine($"\nSaldo existente: {c.Saldo}");
                        Console.WriteLine("\n Digite o valor para Depositar: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valor);
                        Console.WriteLine($"Seu Novo Saldo {c.Saldo} ");
                    }
                    else if (escos == 3) // Fazer Empréstimo
                    {
                        Console.Clear();
                        Console.WriteLine($"Limite de seu empréstimo: {empre.LimiEmpre}");
                        Console.WriteLine("\n Digite o valor para Empréstimo: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        empre.RealizarEmprestimo(valor);
                        Console.WriteLine($"Seu Novo Saldo {c.Saldo} ");
                    }
                    else if (escos == 4) // Sair das opções
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            else if (escolhadomenu == 4)
            {
                Console.WriteLine("\nFechando o programa!");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção Inválida!");
                  Console.ResetColor();
               
            }
        }
    }
}