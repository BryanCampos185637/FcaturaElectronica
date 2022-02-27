using System.Threading.Tasks;

namespace Repository.Contratos.ContratosGenericos
{
    interface IObtenerPorId<T> where T :class
    {
        Task<T> ObtenerPorId(long pId);
    }
}
