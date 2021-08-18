using System;

namespace NumeroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerodigitado;
            int numeroaleatorio;
            string opcao = "";
            do
            {
                do
                {
                    Random random = new();

                    numeroaleatorio = random.Next(0, 7);

                    Console.Write("digite um numero entre 0 e 7: ");
                    numerodigitado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Você errou, tente novamente");
                    Console.ReadKey();

                } while (numerodigitado != numeroaleatorio);

                Console.WriteLine("Você acertou!!!!!");
                Console.WriteLine("Deseja jogar novamente?");
                Console.Write("Sim ou não?");
                opcao = Console.ReadLine().ToUpper();
            } while (opcao == "SIM");


            Console.ReadKey();
        }
    }
}
