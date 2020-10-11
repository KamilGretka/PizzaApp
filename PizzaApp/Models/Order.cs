namespace PizzaApp.Models
{
    public class Order
    {
        public Order(string name, decimal price, string extras)
        {
            Name = name;
            Price = price;
            Extras = extras;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Extras { get; set; }
    }
}