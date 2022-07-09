using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBasico.Infrastructure.Bussiness.Contacto.CrearContacto
{
    public class CrearContactoRequest
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
    }
}
