using CrudBasico.Infrastructure.Data;
using CrudBasico.Infrastructure.Entities;
using CrudBasico.Infrastructure.Repository.Inteface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudBasico.Infrastructure.Repository
{
    public class ContactoRepository : IContactoRepository
    {
        private readonly CrudBasicoContext Context;
        public ContactoRepository(CrudBasicoContext context)
        {
            Context = context;
        }

        public async Task CrearContacto(Contacto contacto)
        {
            await Context.Contacto.AddAsync(contacto);
        }

        public async Task<List<Contacto>> ListarContactos()
        {
            return await Context.Contacto.Where(c => !c.Eliminado).ToListAsync();
        }
    }
}
