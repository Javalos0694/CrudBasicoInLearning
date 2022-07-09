using CrudBasico.Infrastructure.Bussiness.Contacto.CrearContacto;
using CrudBasico.Infrastructure.Entities;
using CrudBasico.Infrastructure.Repository.Inteface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrudBasico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController : ControllerBase
    {
        private readonly IContactoRepository ContactoRepository;
        private readonly IBaseRepository BaseRepository;
        public ContactoController(IContactoRepository contactoRepository, IBaseRepository baseRepository)
        {
            ContactoRepository = contactoRepository;
            BaseRepository = baseRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetContactos()
        {
            try
            {
                var contactos = await ContactoRepository.ListarContactos();
                return Ok(contactos);
            }
            catch (Exception ex)
            {
                return BadRequest(new { value = ex.Message, status = false });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CrearContacto(CrearContactoRequest request)
        {
            try
            {
                var contacto = new Contacto();
                contacto.CrearContacto(request);
                await ContactoRepository.CrearContacto(contacto);
                await BaseRepository.SaveChangesAsync();
                return Ok(new { value = "Contacto creado correctamente", status = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new { value = $"Error {ex.Message} al crear el contacto.", status = false });
            }
        }
    }
}
