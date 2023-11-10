using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    public abstract class Product {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string ImagePath { get; set; }

        protected Product (string name, decimal basePrice, string imagePath) {
            Name = name;
            BasePrice = basePrice;
            ImagePath = imagePath;
        }

        public abstract decimal GetPrice ();

        //public abstract void SetPrice (double value);
    }
}
