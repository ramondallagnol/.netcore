using Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) :
            base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;Port=5432;user id=postgres; password=39185cbd8b9b451bb1a0f5f7ee1ef81b;database=nca-teste");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(user => user.Id);
            base.OnModelCreating(builder);
        }        

    }
    

}