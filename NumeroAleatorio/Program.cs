using System;

namespace NumeroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodigitado;
            int numeroaleatorio;
            do
            {

                Random random = new();

                numeroaleatorio = random.Next(0, 7);

                Console.Write("digite um numero entre 0 e 7: ");
                numerodigitado = Convert.ToInt32(Console.ReadLine());
                
            } while (numerodigitado != numeroaleatorio);

            Console.ReadKey();
        }
    }
}
