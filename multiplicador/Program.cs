using System;

namespace multiplicador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gerador de Tabuada para multilicação";
            Console.ForegroundColor = ConsoleColor.Green;
            int entrada;
            int multiplicando = 0;
            int iniciointervalo = 0;
            int fimintervalo = 0;
            int intervalomaior = 0;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("--------Tabuada da Multiplicação-------");
            Console.WriteLine("---------------------------------------\n");

            Console.Write("Digite um multiplicador entre 0 e 1000\n\n");
            entrada = Convert.ToInt32(Console.ReadLine());
            if(entrada < 1000)
            {
                multiplicando = entrada;
            }
            Console.WriteLine("\n\n------------------------------------------------------");
            Console.WriteLine("------------Digite um inicio para a tabuada-----------");
            Console.WriteLine("--- O numero deve ser maior que 0 e menor que 1000 ---");
            Console.WriteLine("------------------------------------------------------\n");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada > 0 && entrada < 1000)
            {
                iniciointervalo = entrada;
                intervalomaior = iniciointervalo + 9;
            }

            Console.WriteLine("\n\n---------------------------------------------------------------");
            Console.WriteLine("------------------Digite um fim para a tabuada-----------------");
            Console.WriteLine("\tO numero deve ser maior que o inicio e menor que " + intervalomaior.ToString());
            Console.WriteLine("---------------------------------------------------------------\n");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada > 0 && entrada < 1000 && entrada <= intervalomaior)
            {
                fimintervalo = entrada;
            }

            Console.Clear();
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("-------Tabuada do " + multiplicando + "-------");
            Console.WriteLine("-------Inicio " + iniciointervalo + "-------");
            Console.WriteLine("-------Fim " + fimintervalo + "-------\n");
            for ( int i = iniciointervalo; i <= fimintervalo; i++)
            {
                Console.WriteLine(multiplicando + " X " + i + " = " + multiplicando * i);
            }

        }
    }
}
