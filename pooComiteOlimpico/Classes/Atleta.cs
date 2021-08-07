using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooComiteOlimpico.Classes
{
    public class Atleta : EntidadeBase
    {
        // Atributos do Atleta
        public string Nome { get; set; }
        public string Pais { get; set; }
        public int Distancia { get; set; }

        // Método construtor que recebe os atributos quando instanciado
        public Atleta(int id, string nome, string pais, int distancia)
        {
            this.Id = id;
            this.Nome = nome;
            this.Pais = pais;
            this.Distancia = distancia;
        }

        // Método de sobreescrita
        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Pais: " + this.Pais + Environment.NewLine;
            retorno += "Distancia: " + this.Distancia + Environment.NewLine;
            return retorno;
        }

        // Método para retornar o atleta por nome
        public string retornaNome()
        {
            return this.Nome;
        }

        // Método para retornar o pais do atleta
        public string retornaPais()
        {
            return this.Pais;
        }

        // Método para retornar a distancia do arremesso
        public int retornaDistancia()
        {
            return this.Distancia;
        }

    }
}
