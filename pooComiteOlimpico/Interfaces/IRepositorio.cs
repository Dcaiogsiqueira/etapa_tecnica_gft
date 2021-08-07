using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooComiteOlimpico.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorNome(int id);
        void Insere(T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
