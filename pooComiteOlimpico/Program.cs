using pooComiteOlimpico.Classes;
using System.Linq;
using System.Collections.Generic;
using System;

namespace pooComiteOlimpico
{
    class Program
    {
        static RAtleta repositorio = new RAtleta();
        static void Main(string[] args)
        {
            Console.Title = "Quadro de Medalhistas em Dardo";
            Console.ForegroundColor = ConsoleColor.Green;
            string opcaoUsuario = ObterOpcaoUsuario();
          
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        InserirAtleta();
                        break;
                    case "2":
                        ListarAtletas();
                        break;
                    case "3":
                        ListarMedalhistas();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Até logo!");
            Console.ReadLine();
        }

       

        private static void InserirAtleta()
        {
            
            for (int index = 0; repositorio.Lista().Count < 9; index++)
            {
                Console.WriteLine("Você está cadastrando o " + (repositorio.Lista().Count + 1) + "° Atleta");
                Console.WriteLine("\nInserir novo atleta\n\n");

                    Console.Write("Digite o nome do atleta: ");
                    string entradaNome = Console.ReadLine();

                    Console.Write("\nDigite o Pais do atleta: ");
                    string entradaPais = Console.ReadLine();

                    Console.Write("\nDigite a distancia do arremesso: ");
                    int entradaDistancia = int.Parse(Console.ReadLine());


                    Atleta novoAtleta = new Atleta(id: repositorio.ProximoId(),
                                                nome: entradaNome,
                                                pais: entradaPais,
                                                distancia: entradaDistancia);

                    repositorio.Insere(novoAtleta);
            }
        }
        
        private static void ListarAtletas()
        {
            
            Console.WriteLine("\t\tLista de atletas\n\n ");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("\t\tNenhuma Atleta cadastrado.");
            }
            foreach (var atleta in lista)
            {
                Console.WriteLine("\n\t\t Atleta: {0} \n Pais: {1} \n Distancia: {2} metros", atleta.retornaNome(), atleta.retornaPais(), atleta.retornaDistancia());
            }
            Console.ReadKey();
        }

        private static void ListarMedalhistas()
        {
           
            Console.WriteLine("\t\tLista de medalhistas\n\n ");

            if (repositorio.ListaOrdenada().Count == 0)
            {
                Console.WriteLine("\t\tNenhuma Atleta cadastrado.");
            }

            for (int index = 0; index <= 2; index++)
            {
                
                if (index == 0)
                {
                    
                    Console.WriteLine("O medalhista de ouro é \n" + repositorio.ListaOrdenada().ElementAt(index));
                }
                else if (index ==1)
                {
                    Console.WriteLine("O medalhista de prata é \n" + repositorio.ListaOrdenada().ElementAt(index));
                }
                else
                {
                    Console.WriteLine("O medalhista de bronze é \n" + repositorio.ListaOrdenada().ElementAt(index));
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine();
            Console.WriteLine(String.Format("Cadastro de alteta\n"));
            Console.WriteLine(String.Format("Informe a opção desejada: \n"));

            Console.WriteLine(String.Format("1 - Inserir Atletas"));
            Console.WriteLine(String.Format("2 - Listar Atletas"));
            Console.WriteLine(String.Format("3 - Listar Medalhistas"));
            Console.WriteLine(String.Format("C - Limpar a Tela"));
            Console.WriteLine(String.Format("X - Sair."));
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
