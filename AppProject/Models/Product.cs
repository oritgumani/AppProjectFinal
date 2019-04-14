using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public int AmountInStock { get; set; }
        public int AmountOfOrders { get; set; }
        public double DeliveryPrice { get; set; }
        public int CategoryId { get; set; }
        //sub category id
    }
}
