using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMarilynMonrroy.ProductsEntity
{
    public class Usuarios : Entity<long>
    {
        public long IdPersona { get; set; }
        public virtual Persona Persona { get; set; } // relacion persona
        public string Usuario { get; set; }
        public string Password{ get; set; }

    }

    public class Persona : Entity<long>
    {
        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Email { get; set; }

        public int Plan { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }

    }
}
