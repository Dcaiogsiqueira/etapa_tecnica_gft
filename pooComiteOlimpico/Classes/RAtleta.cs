using pooComiteOlimpico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooComiteOlimpico.Classes
{
    public class RAtleta : IRepositorio<Atleta>
    {
        private List<Atleta> listaAtleta = new List<Atleta>();
        public void Atualiza(int id, Atleta entidade)
        {
            listaAtleta[id] = entidade;
        }

        public void Insere(Atleta entidade)
        {
            listaAtleta.Add(entidade);
        }

        public List<Atleta> Lista()
        {
            return listaAtleta;
        }

        public List<Atleta> ListaOrdenada()
        {
            listaAtleta.Sort((x, y) => x.Distancia - y.Distancia);
            listaAtleta.Reverse();
            return listaAtleta;
        }

        public int ProximoId()
        {
            return listaAtleta.Count;
        }

        public Atleta RetornaPorNome(int id)
        {
            throw new NotImplementedException();
        }
    }
}
