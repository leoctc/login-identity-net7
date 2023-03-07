using LoginIdentity.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoginIdentity.Data.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataSource=login.db;Cache=Shared");


        public DbSet<Usuario> Usuarios { get; set; }
    }
}
