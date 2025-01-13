using DatingApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
    public class DataContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<AppUser> ApplicationUsers { get; set; }
    }
}
