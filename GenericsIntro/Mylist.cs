using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Mylist<T>//herşeyi araya yazabiliriz.
    {
        //List gibi kendi List sınıfımızı oluşturacağız.
        T[] items;
        public Mylist()
        {
                items=new T[0]; 
        }
        public void Add(T item)
        {
            T[] tempArray = items; 
            items=new T[items.Length+1];
        }
    }
}
