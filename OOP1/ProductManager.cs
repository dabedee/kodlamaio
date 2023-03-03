using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi ");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi " );
        }
        public int SayiTopla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public void SayiTopla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        
    }
}
