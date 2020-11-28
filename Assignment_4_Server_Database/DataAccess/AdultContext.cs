using Assignment_4_Server_Database.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_4_Server_Database.DataAccess
{
    public class AdultContext : DbContext
    {
        public DbSet<Adult> Adult { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\User\RiderProjects\Assigment_4\Assignment_4_Server_Database\Family.db");
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}