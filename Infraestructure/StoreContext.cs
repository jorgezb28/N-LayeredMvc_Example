using System.Data.Entity;
using Domain.Entities;

namespace Infraestructure
{
    public class StoreContext:DbContext
    {
        public StoreContext():base("name=StoreContext")
        {
        }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
