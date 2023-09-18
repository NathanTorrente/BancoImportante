using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXX.@class // - (private) # (protected - é quando é restringido o acesso as informações de classes de herença, como pai e os filhos) - não precisa no exercício, + (método construtor)
{
    internal class ContaEmpresa: Conta
    {
           public double anuidade { get; set; }
           public double LimiEmpre { get; set; }
           public double  totEmpre { get; set; }




    }
}
