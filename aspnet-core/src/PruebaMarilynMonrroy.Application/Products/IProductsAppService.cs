using PruebaMarilynMonrroy.Products.Dto;
using PruebaMarilynMonrroy.Products.Input;
using PruebaMarilynMonrroy.ProductsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMarilynMonrroy.Products
{
    public interface IProductsAppService
    {
        Task<LoginDto> LoginUser(LoginInput input);
        Task<string> CreateProducts(ProductsDto input);
        Task<List<Productos>> GetProducts(string transaccion, int tipo);
    }
}
