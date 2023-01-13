using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection yaptık
        public void BasvuruYap(IKrediManager krediManager,List<IloggerService> loggerServices)
            /*değer olarak interfacei veririz çünkü diğerlerini de bu tutuyor.O zaman diğer kredi türlerine rahatça ulaşırız*/
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

            /*basvuran bilgilerini değerlendirmek için kodlar burada yazılır.

            //KonutKrediManager konutKrediManager1= new KonutKrediManager();
            // konutKrediManager1.Hesapla();
            // eğer yukarıdaki gibi bir kod yazarsak başvuruyap metodu sadece konut kredisine bağlı kodlara bapımlı olacaktır.Biz tasit ihtiyaç vs diğer kredileride değerlendirebilen bir fonkssiyon yazacağız*/
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//bana bir liste ver ve bu listenin türü Ikredimanager olsun.
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
 



    }
}
