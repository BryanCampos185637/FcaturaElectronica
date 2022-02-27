using DataPersistence;
using Microsoft.EntityFrameworkCore;
using Model.ViewModels;
using Repository.Contratos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Servicios
{
    public class RepositorioProducto : IRepositorioProducto
    {
        private readonly FacturaContext db;
        public RepositorioProducto(FacturaContext context)
        {
            db = context;
        }
        public async Task<List<vmProducto>> ObtenerTodos()
        {
            return await db.vmProducto.FromSqlRaw("EXEC usp_ObtenerProductos").ToListAsync();
        }
    }
}
