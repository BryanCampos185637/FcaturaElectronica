using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Contratos.ContratosGenericos
{
    interface IListarTodos<T> where T : class
    {
        Task<List<T>> ObtenerTodos();
    }
}
