using Microsoft.EntityFrameworkCore;
using MyFirstdotNET.Models.Entities;

namespace MyFirstdotNET.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }

    }
}
