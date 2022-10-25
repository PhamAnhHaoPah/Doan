using Microsoft.EntityFrameworkCore ; 

namespace webapp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
    }
}