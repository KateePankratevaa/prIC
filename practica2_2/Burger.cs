using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2_2 {
    internal class Burger:Product
        {
       
        public List<Option> Option { get; set; }

        public override decimal GetPrice () {
            decimal priceOption = 0;
            foreach (var option in Option)
                {
                priceOption += Convert.ToDecimal(option.Price);
            }
            return BasePrice + priceOption;
        }

    }
}
