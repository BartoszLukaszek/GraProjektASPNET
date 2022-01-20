using Gra_Projekt_ASP.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Gra_Projekt_ASP.NET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
