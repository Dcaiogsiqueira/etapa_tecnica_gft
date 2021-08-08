using System;

namespace CalculadoraDeImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de impostos";
            Console.ForegroundColor = ConsoleColor.Green;
            double valor;
            IPI ipi = new IPI();
            COFINS cofins = new COFINS();
            ICMS icms = new ICMS();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---Insira o valor para ser Calculado---");
            Console.WriteLine("---------------------------------------\n");
            Console.Write("R$");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("------------------IPI------------------"); ;
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("O valor de IPI para este o valor de R$" + valor + " é de R$" + ipi.CalculaImposto(valor) );
            Console.WriteLine("Object valor total com IPI fica em R$" + (valor + ipi.CalculaImposto(valor)));
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("-----------------COFINS----------------");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("O valor de COFINS para este o valor de R$" + valor + " é de R$" + cofins.CalculaImposto(valor));
            Console.WriteLine("Object valor total com COFINS fica em R$" + (valor + cofins.CalculaImposto(valor)));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n------------------ICMS-----------------"); ;
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("O valor de ICMS para este o valor de R$" + valor + " é de R$" + icms.CalculaImposto(valor));
            Console.WriteLine("Object valor total com ICMS fica em R$" + (valor + icms.CalculaImposto(valor)));

        }
    }
}
