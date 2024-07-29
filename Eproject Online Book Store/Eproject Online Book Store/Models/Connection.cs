using Microsoft.EntityFrameworkCore;

namespace Eproject_Online_Book_Store.Models
{
    public class Connection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=BookStore;User Id=sa;Password=aptech;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}
