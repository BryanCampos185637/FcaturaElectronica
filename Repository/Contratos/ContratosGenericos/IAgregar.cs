using System.Threading.Tasks;

namespace Repository.Contratos.ContratosGenericos
{
    interface IAgregar<T> where T: class
    {
        Task Insertar(T model);
    }
}
