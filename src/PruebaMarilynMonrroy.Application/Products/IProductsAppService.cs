using PruebaMarilynMonrroy.Products.Dto;
using PruebaMarilynMonrroy.Products.Input;
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
        Task<List<ProductsDto>> CreateProducts(List<ProductsDto> input);
    }
}
