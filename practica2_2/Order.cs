using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    internal class Order {

        public static int Number = 1;
        public int OrderNumber { get; set; }
        public DateTime OrderTime { get; set; }
        public List<Product> Products { get; set; }

        public Order () 
            {
            OrderNumber = Number++;
            OrderTime = DateTime.Now;
            Products = new List<Product>();
        }
        public void AddProduct (Product product) {
            Products.Add(product);
        }
        public decimal TotalPrice () {
            decimal totalprice = 0;
            foreach (var product in Products) {
                totalprice += product.GetPrice();            
            }
            return totalprice;
        }
     
    }
}
