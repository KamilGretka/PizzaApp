using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Models.Database
{
    public class OrderHistory
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime OrderTime { get; set; }

        public string Adress { get; set; }

        public string OrderMessage { get; set; }

        public string CustomerName { get; set; }
    }
}