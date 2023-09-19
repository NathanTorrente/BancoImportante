using BancoXX.@class;


while (true)
{
    Console.WriteLine("\nEscolha uma ação:\n");

    Console.WriteLine("1- Conta Empresarial.");
    Console.WriteLine("2- Conta Estudante.");
    Console.WriteLine("3- Conta Normal.\n");
    Console.Write("Opção: ");
   
    
    int esco = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEscolha uma das funções:");
        Console.WriteLine("1- Fazer Saque.");
        Console.WriteLine("2- Fazer Empréstico\n");
    
        int escolha = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome do títular: ");
        string nomeTitular = Console.ReadLine();

    if (esco == 1) // Empresarial
    {
        ContaEmpresa empre = new ContaEmpresa(12224343434434, "1404-4", "Usuário Anonimo", 3000, 50, 1000);

        Console.Write("\nEscolha uma das funções:\n");
        Console.WriteLine("1- Fazer Saque.");
        Console.WriteLine("2- Depositar");
        Console.WriteLine("3- Sair");

        Console.Write("Opção: ");

        int escos = Convert.ToInt32(Console.ReadLine());

        if (escos == 1)
        {
            Console.Write("\nDigite o valor para o Saque: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            empre.Sacar(valor);
            Console.WriteLine($"Seu Novo Saldo {empre.Saldo} ");
        }
        else if (escos == 2)
        {
            Console.Clear();
            Console.WriteLine("\n Digite o valor para empréstimo: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            empre.RealizarEmprestimo(valor);
            Console.WriteLine($"Seu Novo Saldo {empre.Saldo} ");
        }
        else if (escos == 3)
        {
            Console.Clear();
            break;
        }

    }
    
    else if (esco == 2) // Estudante
    {
        ContaEstudante estu = new ContaEstudante(931323232, "1404-4", "Usuário Feliz", 2000, 5000, "364.768.160-12", "Instituto Federal (IFRO)");

        Console.Write("\nEscolha uma das funções:\n");
        Console.WriteLine("1- Fazer Saque.");
            
       
        if (esco == 1)
        {
            Console.Write("\nDigite o valor para o Saque: ");
            int valosaq = Convert.ToInt32(Console.ReadLine()); 
            estu.Sacar(valosaq);
         
            Console.WriteLine($"Foi Sacado com sucesso: {valosaq}");
          
        }
    }

    else if (esco == 3) // Normal
    {
        Conta c = new Conta(23333, "1404-1", "Carioca", 0);
        while (true)
        {
            Console.Write("\nEscolha uma das funções:\n");
            Console.WriteLine("1- Fazer Saque.");
            Console.WriteLine("2- Depositar");
            Console.WriteLine("3- Sair");

            Console.Write("Opção: ");

            int escos = Convert.ToInt32(Console.ReadLine());

            if (escos == 1)
            {
                Console.Write("\nDigite o valor para o Saque: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                c.Sacar(valor);
                Console.WriteLine($"Seu Novo Saldo {c.Saldo} ");
            }
            else if (escos == 2)
            {
                Console.Clear();    
                Console.WriteLine("\n Digite o valor para Depositar: ");
                double valor = Convert.ToDouble(Console.ReadLine());
                c.Depositar(valor);
                Console.WriteLine($"Seu Novo Saldo {c.Saldo} " );
            }
            else if (escos == 3)
            {
                Console.Clear();
                break;
            }
        }
    }
}
