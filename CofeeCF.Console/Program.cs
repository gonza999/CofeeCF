using CofeeCF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeCF.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CofeeDbContext())
            {
                var list = context.ProductTypes.ToList();
                foreach (var productType in list)
                {
                    System.Console.WriteLine(productType.Description + " " + productType.Details);
                }
            }
            System.Console.ReadKey();

        }
    }
}

