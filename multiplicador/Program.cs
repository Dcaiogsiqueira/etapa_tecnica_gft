using System;

namespace multiplicador
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            int multiplicando = 0;
            int iniciointervalo = 0;
            int fimintervalo = 0;
            int intervalomaior = 0;
           

            Console.Write("Digite um multiplicador entre 0 e 1000: ");
            entrada = Convert.ToInt32(Console.ReadLine());
            if(entrada < 1000)
            {
                multiplicando = entrada;
            }

            Console.Write("Digite o inicio do intervalo: ");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada > 0 && entrada < 1000)
            {
                iniciointervalo = entrada;
                entrada = 0;
                intervalomaior = iniciointervalo + 10;
            }

            Console.Write("Digite o fim do entervalo até " + intervalomaior.ToString() + " : ");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada > 0 && entrada < 1000)
            {
                fimintervalo = entrada;
            }

            for ( int i = iniciointervalo; i <= fimintervalo; i++)
            {
                Console.WriteLine(multiplicando + " X " + i + " = " + multiplicando * i);
            }

        }
    }
}
