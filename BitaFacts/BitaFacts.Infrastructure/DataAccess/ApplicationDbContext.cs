using BitaFacts.Core.Entities.Modeles;
using Microsoft.EntityFrameworkCore;

namespace BitaFacts.Infrastructure.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
    }
}
