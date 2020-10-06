using System.Data.Entity;

namespace PizzaApp.Models.Database
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=DefaultConnection")
        {

        }

        public virtual DbSet<OrderHistory> OrderHistory { get; set; } 
    }
}