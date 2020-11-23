using PizzaApp.Models.Products.Abstract;

namespace PizzaApp.Models
{
    public class Order
    {
        public Order(IProduct product)
        {
            Product = product;
        }

        public IProduct Product { get; private set; }
    }
}