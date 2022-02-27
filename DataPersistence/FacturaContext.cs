using DataPersistence.ModelConfig;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.ViewModels;

namespace DataPersistence
{
    public class FacturaContext:DbContext
    {
        public FacturaContext(DbContextOptions<FacturaContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProveedorConfig(modelBuilder.Entity<Proveedor>());
            new ProductoConfig(modelBuilder.Entity<Producto>());
            new FacturaConfig(modelBuilder.Entity<Factura>());
            new DetalleFacturaConfig(modelBuilder.Entity<DetalleFactura>());
        }

        #region Modelo
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<DetalleFactura> DetalleFactura { get; set; }
        #endregion

        #region stored procedure
        public DbSet<vmProducto> vmProducto { get; set; }
        #endregion
       
    }
}
