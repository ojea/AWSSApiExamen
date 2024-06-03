using AWSSApiExamen.Models;
using AWSSApiExamen.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSSApiExamen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<CategoriasEvento>>> GetCategoria()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<Evento>>> Find(int id)
        {
            return await this.repo.FindEventoCategoriaAsync(id);
        }
    }
}
