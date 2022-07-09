using CrudBasico.Infrastructure.Bussiness.Contacto.CrearContacto;
using System;

#nullable disable

namespace CrudBasico.Infrastructure.Entities
{
    public partial class Contacto
    {
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public bool Eliminado { get; set; }

        public void CrearContacto(CrearContactoRequest request)
        {
            Nombre = request.Nombre;
            Celular = request.Celular;
            Correo = request.Correo;
        }
    }
}
