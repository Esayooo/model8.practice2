using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model8.practice2
{

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }  
        public int Discount { get; set; }   
        public int category { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermarket  supermarket = new Supermarket();
            Console.WriteLine("Сумма всех продуктов :[0]", supermarket[1]);
            Console.ReadKey();
        }
    }
}
