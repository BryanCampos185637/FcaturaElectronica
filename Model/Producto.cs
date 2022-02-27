using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Producto
    {
        public int Id { get; set; }
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
