// See https://aka.ms/new-console-template for more information
using Methods;
using System.Security.Claims;
using System.Text;


//Methotlar ile tekrar tekrar aynı kod yazmanın önüne geçer.Kontrol bizde olur.
//Dont repeat yourself
//class bu özellikleri kullanarak bir ürünü tanımlar.Nesne haline getirir.

Urun urun1 = new Urun(); //Nesne oluşturduk.Ürün elma
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun(); //NEsne oluşturduk.Ürün karpuz
urun2.Adi = "Karpuz";
urun2.Fiyati = 18;
urun2.Aciklama = "Diyarbakır Karpuzu";


Urun[] urunler = new Urun[] {urun1,urun2 };//ürün dizisi oluşturduk
foreach (Urun urun in urunler)//foreach ile ürün dizisinde geziyoruz
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------");
}

//instance-örnek
Console.WriteLine("------------Methotlar--------------");
SepetManager sepetManager= new SepetManager(); //Nesne oluşturduk.Classı çağırdık.Class örneği oluşturduk.
sepetManager.Ekle(urun1);//metotu çağırdık.//encapsulatıon aşağıdaki gibi ayrı ayrı yazacağımıza tek bir yerde kapsülledik
sepetManager.Ekle(urun2);
/*sepetManager.Ekle();
sepetManager.Ekle();
sepetManager.Ekle();
sepetManager.Ekle();*/


sepetManager.Ekle2("armut", "yeşil armut", 12,10);//yukarıdaki daha mantıklı.Heryerde değiştirmek zorunda kalırsın.
