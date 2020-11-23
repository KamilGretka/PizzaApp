using System.Collections.Generic;

namespace PizzaApp.Models.Products.Abstract
{
    public interface IProduct
    {
        public decimal Price { get; set; }

        public string Name { get; set; }

        public List<string> Extras { get; set; }
    }
}