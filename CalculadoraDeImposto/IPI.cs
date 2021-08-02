using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImposto 
{
    class IPI : Imposto
    {
        public double CalculaImposto(double valor)
        {
            if(valor < 25000)
            {
                return valor * 0.05;
            }
            else
            {
                return valor * 0.11;
            }
        }
    }
}
