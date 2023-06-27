using EstagioInicialDAEETarde.Models;
using Microsoft.EntityFrameworkCore;

namespace EstagioInicialDAEETarde.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Git> Git { get; set; }

    }
}
