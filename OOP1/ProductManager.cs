using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //ürün türünde ürün istedik.int sayi;veya string ad gibi
        {
            Console.WriteLine(product.ProductName +"eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName +"güncellendi.");//geriye değer döndürmez.
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;//return ile geriye değer döndürür
            //işlem sonucu oluşan değeri değişkende tutarak başka yerdede kullanabiliriz.
        }

        public void Topla2(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1+sayi2);//voıd geriye değer döndürmez
        }
    }
}
