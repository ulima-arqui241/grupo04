using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace ApiGrupo.Models.LEARNHUB.DB
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
