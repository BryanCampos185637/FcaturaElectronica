using System.Threading.Tasks;

namespace Repository.Contratos.ContratosGenericos
{
    interface IEliminar
    {
        Task Eliminar(long pId);
    }
}
