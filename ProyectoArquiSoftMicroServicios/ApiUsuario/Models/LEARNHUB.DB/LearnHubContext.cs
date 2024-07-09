using Microsoft.EntityFrameworkCore;
namespace ApiUsuario.Models.LEARNHUB.DB
{
    public partial class LearnHubContext : DbContext
    {
        public LearnHubContext()
        {
        }

        public LearnHubContext(DbContextOptions<LearnHubContext> options)
            : base(options)
        {
        }
        public DbSet<ObtenerTodosLosValoresResult> ObtenerTodosLosValores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObtenerTodosLosValoresResult>().HasNoKey().ToView(null);
        }
    }
}
