using Model.ViewModels;
using Repository.Contratos.ContratosGenericos;
using System.Threading.Tasks;

namespace Repository.Contratos
{
    interface IRepositorioProducto:IListarTodos<vmProducto>
    {
    }
}
