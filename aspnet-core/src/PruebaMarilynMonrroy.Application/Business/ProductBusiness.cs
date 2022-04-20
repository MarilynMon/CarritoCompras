using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Security;
using PruebaMarilynMonrroy.Products.Dto;
using PruebaMarilynMonrroy.Products.Input;
using PruebaMarilynMonrroy.ProductsEntity;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PruebaMarilynMonrroy.Business
{
    public class ProductBusiness : DomainService
    {
        private readonly IRepository<Persona, long> personaRepository;
        private readonly IRepository<Usuarios, long> usuariosRepository;
        private readonly IRepository<Productos, long> productosRepository;

        public ProductBusiness(IRepository<Persona, long> _persona, IRepository<Usuarios, long> _usuariosRepository,
            IRepository<Productos, long> _productosRepository)
        {
            personaRepository = _persona;
            usuariosRepository = _usuariosRepository;
            productosRepository = _productosRepository;
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

        public async Task<string> CreateProducts (ProductsDto input)
        {
            var productos = new Productos()
            {  Descripcion = input.Descripcion,
               Precio = input.Precio,
               Detalle = input.Detalle,
               Estado = input.Estado,
               Imagen = input.Imagen
            };
            await productosRepository.InsertAsync(productos);
            return "ok";
        }

        public async Task<List<Productos>> GetProducts(string transaccion, int tipo)
        {

            return await productosRepository.GetAll().ToListAsync();
            
        }
    }
}
