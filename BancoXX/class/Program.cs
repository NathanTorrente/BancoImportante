using BancoXX.@class;


while (true)
{
    Console.WriteLine("\nEscolha uma ação:\n");

    Console.WriteLine("1- Conta Empresarial.");
    Console.WriteLine("2- Conta Estudante.\n");
    Console.Write("Opção: ");

    ContaEmpresa empre = new ContaEmpresa(12224343434434, "1404-4", "Usuário Anonimo", 3000, 50, 1000);
    ContaEstudante estu = new ContaEstudante(931323232, "1404-4", "Usuário Feliz", 2000,5000, "364.768.160-12", "Instituto Federal (IFRO)");

    int esco = Convert.ToInt32(Console.ReadLine());
    if (esco == 1) // Empresarial
    {
 
        Console.WriteLine("\nEscolha uma das funções:");
        Console.WriteLine("1- Fazer Saque.");
        Console.WriteLine("2- Fazer Empréstico\n");
    
        int escolha = Convert.ToInt32(Console.ReadLine());
        if (escolha == 1)
        {
            Console.WriteLine();
            Console.Write("\nDigite o valor para o Saque: ");
            int valo = Convert.ToInt32(Console.ReadLine());
            empre.Sacar(valo);
            Console.WriteLine($"Foi Sacado com sucesso: {valo}");
      
        }
  
    }

    else if (esco == 2) // Estudante
    {
        Console.WriteLine("\nEscolha uma das funções:\n");
        Console.WriteLine("1- Fazer Saque.");
        Console.WriteLine("2- Fazer Empréstico.");
       
        if (esco == 1)
        {
            Console.Write("\nDigite o valor para o Saque: ");
            int valosaq = Convert.ToInt32(Console.ReadLine());
            estu.Sacar(valosaq);
            Console.WriteLine($"Foi Sacado com sucesso: {valosaq}");
        }
        else if (esco == 2)
        {
            Console.WriteLine("\nDigite o valor para o Empréstimo: \n");
            int valoempres = Convert.ToInt32(Console.ReadLine());
            empre.RealizarEmprestimo(valoempres);
            Console.WriteLine($"Foi realizado empréstimo com sucesso: {valoempres}");
        }
        Console.Clear();
    }

   

}
