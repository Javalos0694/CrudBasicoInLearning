using CrudBasico.Infrastructure.Data;
using CrudBasico.Infrastructure.Repository.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudBasico.Infrastructure.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly CrudBasicoContext Context;
        public BaseRepository(CrudBasicoContext context)
        {
            Context = context;
        }
        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
