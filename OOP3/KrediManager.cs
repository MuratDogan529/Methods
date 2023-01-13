using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager  //operasyon metot tanımlamayı burada yapıcaz.İnterfaceleri anlanak için başına I koyarız
    {
        void Hesapla();
        void BiseyYap();
    }
}


/*Not=İnterfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.*/

/*Loglama yapmak=kimin ne zaman hangi değişikliği yaptığı kayıtı tutar*/