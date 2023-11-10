using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    internal class Drink:Product {

        public Drink (string name, decimal basePrice, string imagePath, int volume, bool isBottled) : base(name, basePrice, imagePath) {
            Volume = volume;
            IsBottled = isBottled;
        }

        public int Volume { get; set; }
        public bool IsBottled { get; set; }

        public override decimal GetPrice () {
            if (IsBottled==true)
                return BasePrice + 25;
            else
                return BasePrice;
        }




    }

}
