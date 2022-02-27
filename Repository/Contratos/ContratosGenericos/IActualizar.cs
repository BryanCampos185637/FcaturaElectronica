using System.Threading.Tasks;

namespace Repository.Contratos.ContratosGenericos
{
    interface IActualizar<T> where T: class
    {
        Task Actualizar(T model);
    }
}
