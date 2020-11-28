using Assignment_4_Server_Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_4_Server_Database.DataAccess
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\User\RiderProjects\Assigment_4\Assignment_4_Server_Database\Family.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(usr => new {usr.Password, usr.SecurityLevel, usr.UserName, usr.UserId});
        }
    }
}