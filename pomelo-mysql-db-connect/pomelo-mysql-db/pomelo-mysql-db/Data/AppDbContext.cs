using Microsoft.EntityFrameworkCore;
using pomelo_mysql_db.Model;

namespace pomelo_mysql_db.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = "server=localhost;port=3306;database=testdb;user=janidu;password=Janidu@Q_Excess";

            var serverVersion = new MySqlServerVersion(new Version(5, 7, 42));
            optionsBuilder.UseMySql(connectionstring, serverVersion);
        }

    }
}
