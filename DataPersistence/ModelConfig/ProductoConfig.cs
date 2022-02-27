using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataPersistence.ModelConfig
{
    public class ProductoConfig
    {
        public ProductoConfig(EntityTypeBuilder<Producto> entity)
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.PrecioVenta).IsRequired().HasColumnType("decimal(10,2)");
            entity.Property(p => p.DescripcionProducto).IsRequired().HasMaxLength(200);
            entity.Property(p => p.IdProveedor).IsRequired();
        }
    }
}
