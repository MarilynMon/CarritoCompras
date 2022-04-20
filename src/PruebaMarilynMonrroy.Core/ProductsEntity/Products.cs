using Abp.Domain.Entities;

namespace PruebaMarilynMonrroy.ProductsEntity
{
    public class Productos : Entity<long>
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Estado { get; set; }
        public string Detalle { get; set; }
        public string Imagen { get; set; }
    }
}
