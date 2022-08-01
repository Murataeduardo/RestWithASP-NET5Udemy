using Microsoft.EntityFrameworkCore;

namespace RestWithASP_NETUdemy.Model.Context
{
    public class MysqlContext : DbContext 
    {
        public MysqlContext() 
        {
        }
        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options){}

        public DbSet<Person> Persons { get; set; }
    }
}
