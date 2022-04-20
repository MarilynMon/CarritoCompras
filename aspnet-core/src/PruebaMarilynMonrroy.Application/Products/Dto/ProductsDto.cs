using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PruebaMarilynMonrroy.ProductsEntity;

namespace PruebaMarilynMonrroy.Products.Dto
{
    public class ProductsDto 
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public bool Estado { get; set; }
        public string Detalle { get; set; }
        public string Imagen { get; set; }
    }
}
