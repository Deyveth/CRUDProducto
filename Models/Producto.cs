namespace CrudAPI.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public string? FechaCreacion { get; set; }

    }
}
