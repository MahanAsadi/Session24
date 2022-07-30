using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person
        {
            get;
            set;
        }
        public DbSet<Address> Address
        {
            get;
            set;
        }
        public DbSet<Email> Email
        {
            get;
            set;
        }
    }
}
