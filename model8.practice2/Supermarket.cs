using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model8.practice2
{
    class Supermarket
    {
        List<Product> products = null;
        public Supermarket() 
        { 
            products = new List<Product>();
            products.Add(new Product { Price = 1000,category= 1 });
            products.Add(new Product { Price=2000, category = 1 });

        }

        public double this[int category]
        {
            get
            {
                TimeSpan startTime = new TimeSpan(8,0,0);
                TimeSpan endDay = new TimeSpan(12,0,0);
                var t=DateTime.Now.TimeOfDay;
                double sum = 0;
                foreach (Product item in products)
                {
                    //sum =  sum + item.Price;
                    sum += item.Price;
                }
                if (t>startTime && t < endDay)
                { 
                    return sum * 0.95;
                }
                else
                {
                    return sum;
                }
            }
        }
    }
}
