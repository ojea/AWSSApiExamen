using AWSSApiExamen.Data;
using AWSSApiExamen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AWSSApiExamen.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;

        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<CategoriasEvento>> GetCategoriasAsync()
        {
            return await this.context.CategoriaEventos.ToListAsync();
        }

        public async Task<List<Evento>> FindEventoCategoriaAsync(int id)
        {

            List<Evento> cubos = await this.context.Eventos.Where(x => x.IdCategoria == id).ToListAsync();
            return cubos;
        }
    }
}
