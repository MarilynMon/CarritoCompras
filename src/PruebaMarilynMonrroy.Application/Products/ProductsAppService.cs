using Abp.Application.Services;
using Abp.Runtime.Security;
using PruebaMarilynMonrroy.Business;
using PruebaMarilynMonrroy.Products.Dto;
using PruebaMarilynMonrroy.Products.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMarilynMonrroy.Products
{
    public class ProductsAppService : ApplicationService, IProductsAppService
    {
        private readonly ProductBusiness productBusiness;

        public ProductsAppService (ProductBusiness _productBusiness)
        {
            productBusiness = _productBusiness;
        }
        public Task<List<ProductsDto>> CreateProducts(List<ProductsDto> input)
        {
            var x = productBusiness.CreateProducts(input);
            return x;
        }

        public Task<LoginDto> LoginUser(LoginInput input)
        {
            var loginDto = productBusiness.Login(input);
            return loginDto;
        }
    }
}
