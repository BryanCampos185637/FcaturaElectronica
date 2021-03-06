using DataPersistence;
using Model;
using Repository.Contratos;
using System.Threading.Tasks;

namespace Repository.Servicios
{
    public class RepositorioFactura : IRepositorioFactura
    {
        private readonly FacturaContext db;
        public RepositorioFactura(FacturaContext context)
        {
            db = context;
        }

        public void Actualizar(Factura model)
        {
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public async Task Insertar(Factura model)
        {
            await db.Factura.AddAsync(model);
        }
    }
}
