using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancaN3
{
    public class LerPeso
    {
        public string LerPesoBalanca()
        {
            //Esse é o valor recebido através da comunicação com a balança.
            //Não pode ser alterado.

            var buffer = "#200." + string.Format("{00:00.000##}", new Random().NextDouble() * 10);            
            return buffer;
        }
    }
}
