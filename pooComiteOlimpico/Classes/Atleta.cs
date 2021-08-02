using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooComiteOlimpico.Classes
{
    public class Atleta
    {
        // Atributos do Atleta
        public string Nome { get; set; }
        public string Pais { get; set; }
        public int Distancia { get; set; }

        public Atleta()
        {
            this.Nome = "";
            this.Pais = "";
            this.Distancia = 0;
        }

        //Métodos da classe atleta
        public void CriarAtleta1(Atleta atleta1)
        {
            //leitura de dados do primeiro Atleta
            Console.Write("Digite o nome do primeiro atleta: ");
            
            atleta1.Nome = Console.ReadLine();
            Console.Write("Digite o país do primeiro atleta: ");
            atleta1.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do primeiro Atleta:");
            atleta1.Distancia = Convert.ToInt32(Console.ReadLine());
                      
        }

        public void CriarAtleta2(Atleta atleta2)
        {
            //leitura de dados do segundo Atleta
            Console.Write("Digite o nome do segundo atleta: ");

            atleta2.Nome = Console.ReadLine();
            Console.Write("Digite o país do segundo atleta: ");
            atleta2.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do segundo Atleta:");
            atleta2.Distancia = Convert.ToInt32(Console.ReadLine());

        }

        public void CriarAtleta3(Atleta atleta3)
        {
            //leitura de dados do terceiro Atleta
            Console.Write("Digite o nome do terceiro atleta: ");

            atleta3.Nome = Console.ReadLine();
            Console.Write("Digite o país do terceiro atleta: ");
            atleta3.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do terceiro Atleta:");
            atleta3.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void CriarAtleta4(Atleta atleta4)
        {
            //leitura de dados do quarto Atleta
            Console.Write("Digite o nome do quarto atleta: ");

            atleta4.Nome = Console.ReadLine();
            Console.Write("Digite o país do quarto atleta: ");
            atleta4.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do quarto Atleta:");
            atleta4.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void CriarAtleta5(Atleta atleta5)
        {
            //leitura de dados do quinto Atleta
            Console.Write("Digite o nome do quinto atleta: ");

            atleta5.Nome = Console.ReadLine();
            Console.Write("Digite o país do quinto atleta: ");
            atleta5.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do quinto Atleta:");
            atleta5.Distancia = Convert.ToInt32(Console.ReadLine());

        }

        public void CriarAtleta6(Atleta atleta6)
        {
            //leitura de dados do sexto Atleta
            Console.Write("Digite o nome do sexto atleta: ");
            atleta6.Nome = Console.ReadLine();
            Console.Write("Digite o país do sexto atleta: ");
            atleta6.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do sexto Atleta:");
            atleta6.Distancia = Convert.ToInt32(Console.ReadLine());

        }

        public void CriarAtleta7(Atleta atleta7)
        {
            //leitura de dados do sétimo Atleta
            Console.Write("Digite o nome do sétimo atleta: ");
            atleta7.Nome = Console.ReadLine();
            Console.Write("Digite o país do sétimo atleta: ");
            atleta7.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do sétimo Atleta:");
            atleta7.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void CriarAtleta8(Atleta atleta8)
        {
            //leitura de dados do oitavo Atleta
            Console.Write("Digite o nome do oitavo atleta: ");
            atleta8.Nome = Console.ReadLine();
            Console.Write("Digite o país do oitavo atleta: ");
            atleta8.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do oitavo Atleta:");
            atleta8.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void CriarAtleta9(Atleta atleta9)
        {
            //leitura de dados do nono Atleta
            Console.Write("Digite o nome do nono atleta: ");
            atleta9.Nome = Console.ReadLine();
            Console.Write("Digite o país do nono atleta: ");
            atleta9.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do nono Atleta:");
            atleta9.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void CriarAtleta10(Atleta atleta10)
        {
            //leitura de dados do decimo Atleta
            Console.Write("Digite o nome do decimo atleta: ");
            atleta10.Nome = Console.ReadLine();
            Console.Write("Digite o país do decimo atleta: ");
            atleta10.Pais = Console.ReadLine();
            Console.Write("Digite o resultado (em metros) do decimo Atleta:");
            atleta10.Distancia = Convert.ToInt32(Console.ReadLine());
        }

        public void VerificarMedalhistas(Atleta atleta1, Atleta atleta2, Atleta atleta3, Atleta atleta4,
                                        Atleta atleta5, Atleta atleta6, Atleta atleta7, Atleta atleta8,
                                        Atleta atleta9, Atleta atleta10)
        {
            

        }

    }
}
