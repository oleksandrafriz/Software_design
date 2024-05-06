using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Food
    {
        public string Type { get; set; }
        public double Quantity { get; set; }

        public Food(string type, double quantity)
        {
            Type = type;
            Quantity = quantity;
        }
    }

}
