using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            /*
             * int double bool değer tip 
             * diziler class abstract class interface referans tip 
             */

            productManager.SayiTopla2(4, 5);
            int toplamaSonucu = productManager.SayiTopla(5, 4);
            Console.WriteLine(toplamaSonucu*10);
            






















            Console.ReadLine();

        }
    }
}
