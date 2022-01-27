using Gra_Projekt_ASP.NET.Models;
using Microsoft.EntityFrameworkCore;

namespace Gra_Projekt_ASP.NET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<GameModel> Game{ get; set; }
        public DbSet<SignUp> SignUp { get; set; }

    }
}
    
