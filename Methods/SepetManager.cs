using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
         //metot yazıyoruz
         public void Ekle(Urun urun)//ekle metotu //Metot Urun tipinde bir parametre aldı.
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : "+urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat,int StokAdedi)//hatalı
        {

        }
    }
}
