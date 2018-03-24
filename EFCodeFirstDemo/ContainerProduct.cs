using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    class ContainerProduct
    {
        static void Main(string[] args)
        {
          
                EFContext context = new EFContext();
                //Product p = new Product { ID = 2, ProductName = "Pencil", ProductPrice = 5.0 };
                //Container c = new Container { ID = 10, ContainerName = "Box"};
                //context.Products.Add(p);
                //context.Containers.Add(c);
                //context.SaveChanges();
                var result = context.Products;
                Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
