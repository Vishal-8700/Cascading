using Cascading.Models;
using Microsoft.EntityFrameworkCore;

namespace Cascading.Data
{
    public class AddDb:DbContext
    {
        public AddDb(DbContextOptions<AddDb> options) : base(options)
        {
            
        }
        public DbSet<Country> countries  { get; set; }
        public DbSet<State> states  { get; set; }
        public DbSet<City> cities  { get; set; }
    }
}
