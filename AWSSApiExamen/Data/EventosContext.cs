using AWSSApiExamen.Models;
using Microsoft.EntityFrameworkCore;

namespace AWSSApiExamen.Data
{
    public class EventosContext: DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options): base(options) { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<CategoriasEvento> CategoriaEventos { get; set; }
    }
}
