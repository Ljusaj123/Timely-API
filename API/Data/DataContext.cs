using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataaContext :DbContext
    {
        public DataaContext(DbContextOptions<DataaContext> options) : base(options) { }

        public DbSet<Project> Projects => Set<Project>();
    }
}
