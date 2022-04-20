using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Security;
using PruebaMarilynMonrroy.Products.Dto;
using PruebaMarilynMonrroy.Products.Input;
using PruebaMarilynMonrroy.ProductsEntity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PruebaMarilynMonrroy.Business
{
    public class ProductBusiness : DomainService
    {
        private readonly IRepository<Persona, long> personaRepository;
        private readonly IRepository<Usuarios, long> usuariosRepository;
        private readonly IRepository<Productos, long> productosRepository;

        public ProductBusiness(IRepository<Persona, long> _persona, IRepository<Usuarios, long> _usuariosRepository)
        {
            personaRepository = _persona;
            usuariosRepository = _usuariosRepository;
        }
        public async Task<LoginDto> Login(LoginInput input)
        {
            var passEncry = SimpleStringCipher.Instance.Encrypt(input.DatosUsarios.Password);

            var loginDto = new LoginDto()
            { CodigoRetorno = "0001",
                MensajeRetorno = "Consulta Correcta",
                Usuario = new Usuario()
                { Email = "danielsilvaorrego@gmail.com",
                    Nombre = "Daniel Silva Orrego",
                    Plan = 6,
                    Telefono = "0968123019"
                },
                Token = passEncry
            };

            return loginDto;
        }

        public async Task<List<ProductsDto>> CreateProducts (List<ProductsDto> input)
        {
            var listProductos = new List<ProductsDto>();
            var productos = new ProductsDto();
            listProductos.Add(productos);
            return listProductos;
        }
    }
}
