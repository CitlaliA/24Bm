using Microsoft.EntityFrameworkCore;
using proyecto_24bm.Models;

namespace proyecto_24bm.Context
{
    public class ApplicationDbContext : DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        { }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
