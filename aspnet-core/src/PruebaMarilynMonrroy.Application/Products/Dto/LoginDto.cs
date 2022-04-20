using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMarilynMonrroy.Products.Dto
{
    public class LoginDto
    {
        public string CodigoRetorno { get; set; }
        public string MensajeRetorno { get; set; }
        public Usuario Usuario { get; set; }
        public string Token { get; set; }

    }
    public class Usuario
    {
        public string Email { get; set; }
        public string Nombre { get; set; }
        public int Plan { get; set; }
        public string Telefono { get; set; }
    }
}
