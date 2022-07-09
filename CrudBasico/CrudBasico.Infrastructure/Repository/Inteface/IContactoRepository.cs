using CrudBasico.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBasico.Infrastructure.Repository.Inteface
{
    public interface IContactoRepository
    {
        Task CrearContacto(Contacto contacto);
        Task<List<Contacto>> ListarContactos();
    }
}
