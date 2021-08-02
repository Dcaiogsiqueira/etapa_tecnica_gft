using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImposto
{
    class ICMS : Imposto
    {

        public double CalculaImposto(double valor)
        {
            return valor * 0.27;
        }
    }
}
