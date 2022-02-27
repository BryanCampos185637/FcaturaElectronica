using Model;
using Repository.Contratos.ContratosGenericos;

namespace Repository.Contratos
{
    interface IRepositorioFactura:IAgregar<Factura>
    {
        void Actualizar(Factura model);
    }
}
