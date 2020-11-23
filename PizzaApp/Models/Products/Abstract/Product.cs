using System.Collections.Generic;

namespace PizzaApp.Models.Products.Abstract
{
    internal class Product : IProduct
    {
        internal Product(string name, decimal price, List<string> extas = null)
        {
            Name = name;
            Price = price;
            Extras = extas;
        }

        public List<string> Extras { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}