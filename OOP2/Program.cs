// See https://aka.ms/new-console-template for more information
using OOP2;
//MuratDoğan

GercekMusteri musteri1= new GercekMusteri();//müşteri1 değişkeni adında gerçek müşteri nesnesi oluşturduk.
musteri1.Id = 1;
musteri1.MusteriNo = "112233";
musteri1.Adi = "Murat";
musteri1.Soyadi = "Doğan";
musteri1.TCNo = "15464148688";
 


//tüzel müşteri

TuzelMusteri musteri2= new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "546545465";
musteri2.SirketAdi = "Fromfleks";
musteri2.VergiNo = "648644";


Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();
 //müşteri sınıfından baz alarak gerçek müşteri nesnesi oluşturabiliriz.
//Halbuki ikisi farklı sınıflar.Fakat Müsteri sınıfı,gerçekk ve tüzel
//müşterilere miras olarak aktardığımız için bu mümkün oldu.


MusteriManager musteriManager=new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);