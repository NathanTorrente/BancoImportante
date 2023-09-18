using BancoXX.@class;


while (true)
{
    Console.WriteLine("Escolha uma ação:");

    Console.WriteLine("1- Conta Empresarial.");
    Console.WriteLine("2- Conta Estudante.");
    int esco = Convert.ToInt32(Console.ReadLine());

    ContaEmpresa a = new ContaEmpresa(12224343434434, "1404-4", "Usuário Anonimo", 3000, 50, 1000);
    ContaEstudante b = new ContaEstudante(931323232, "1404-4", "Usuário Feliz", 2000,5000, "364.768.160-12", "Instituto Federal (IFRO)");


    if (esco == 1)
    {

        int escol = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escolha uma das funções:\n");
        Console.WriteLine("1- Fazer Saque.\n");
        Console.WriteLine("2- Fazer Depósito\n");
        Console.WriteLine("3- Fazer Empréstico");

        if (escol == 1)
        {
            a.Sacar(1000);
        }
        else if (escol == 2) 
        { 
        }
        else if(escol == 3)
        {

        }
      
       
    }
    else if (esco == 2)
    {
        Console.WriteLine("Escolha uma das funções:\n");
        Console.WriteLine("1- Fazer Saque.\n");
        Console.WriteLine("2- Fazer Empréstico");
    }

   

}
