using System;
using System.Collections.Generic;

#nullable disable

namespace CrudBasico.Infrastructure.Entities
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaActualizacion { get; set; }
        public bool Eliminado { get; set; }
    }
}
