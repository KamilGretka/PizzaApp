using System;
using System.Data.Entity;
using System.IO;

namespace PizzaApp.Models.Database
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base(string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0}\PizzaApp\Database\PizzaAppDB.mdf;Integrated Security=True",
                                                Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName))
        {

        }

        public virtual DbSet<OrderHistory> OrderHistory { get; set; } 
    }
}