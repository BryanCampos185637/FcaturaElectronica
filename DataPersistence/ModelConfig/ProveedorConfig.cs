using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace DataPersistence.ModelConfig
{
    public class ProveedorConfig
    {
        public ProveedorConfig(EntityTypeBuilder<Proveedor> entity)
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.NombreProveedor).IsRequired().HasMaxLength(1000);
            entity.Property(p => p.Correo).IsRequired().HasMaxLength(1000);
            entity.Property(p => p.NumeroTelefono).IsRequired();
        }
    }
}
