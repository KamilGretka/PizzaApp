using PizzaApp.Config;
using System.Data.Entity;

namespace PizzaApp.Models.Database
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base(DatabaseConfiguration.ConnectionString)
        {

        }

        public virtual DbSet<OrderHistory> OrderHistory { get; set; } 
    }
}