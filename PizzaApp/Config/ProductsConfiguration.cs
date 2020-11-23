using PizzaApp.Models.Products.Abstract;
using System.Collections.Generic;

namespace PizzaApp.Config
{
    static internal class ProductsConfiguration
    {
        static internal Dictionary<string, Product> ExtrasProduct = new Dictionary<string, Product>()
        {
            { ProductsNames.Margheritta, new Product(ProductsNames.Margheritta, 20m, new List<string>()) },
            { ProductsNames.Vegetariana, new Product(ProductsNames.Vegetariana, 22m, new List<string>()) },
            { ProductsNames.Tosca, new Product(ProductsNames.Tosca, 25m, new List<string>()) },
            { ProductsNames.Venecia, new Product(ProductsNames.Venecia, 25m, new List<string>()) }
        };

        static internal Dictionary<string, Product> Product = new Dictionary<string, Product>()
        {
            { ProductsNames.PorkHop, new Product(ProductsNames.PorkHop, 30m) },
            { ProductsNames.FishFries, new Product(ProductsNames.FishFries, 28m) },
            { ProductsNames.HungarianCake, new Product(ProductsNames.HungarianCake, 27m) },
            { ProductsNames.TomatoSoup, new Product(ProductsNames.TomatoSoup, 12m) },
            { ProductsNames.ChickenSoup, new Product(ProductsNames.ChickenSoup, 10m) },
            { ProductsNames.Cola, new Product(ProductsNames.Cola, 5m) },
            { ProductsNames.Coffie, new Product(ProductsNames.Coffie, 5m) },
            { ProductsNames.Tea, new Product(ProductsNames.Tea, 5m) },
        };
    }
}