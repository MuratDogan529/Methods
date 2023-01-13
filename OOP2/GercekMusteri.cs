using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class GercekMusteri :Musteri //Gerçek müşteri bir müşteridir.(Miras-inheritance)
        //entity classtır bu sınııfın olduğu yerde metot veya  operasyon tanımlanmaz!!!!!! 
    {
        
        public string TCNo { get; set; } 
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
