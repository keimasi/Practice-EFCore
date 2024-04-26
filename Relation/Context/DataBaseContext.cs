using Microsoft.EntityFrameworkCore;
using Relation.Many_to_Many;
using Relation.One_to_Many;
using Relation.One_to_Many.Mapping;
using Relation.One_to_One;

namespace Relation.Context
{
    public class DataBaseContext : DbContext
    {
        //One To Many
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //One To One
        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        //Many To Many
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=PracticeEF;Integrated Security=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
