using KargoTakip_Egitim_1.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace KargoTakip_Egitim_1.Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KargoTakipDb;Trusted_Connection=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
    }
}
