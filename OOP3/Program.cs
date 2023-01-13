// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//INTERFACES
using OOP3;

IhtiyacKrediManager ihtiyacKrediManager =new IhtiyacKrediManager();
TasitKrediManager tasitKrediManager = new TasitKrediManager();
KonutKrediManager konutKrediManager = new KonutKrediManager();

IloggerService dataBaseLoggerService = new DatabaseLoggerService();
IloggerService fileLoggerService= new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager,new List<IloggerService> { new DatabaseLoggerService(),new FileLoggerService()});// virgülden sonra bu da yazılabilir sana kalmış,dataBaseLoggerService
//içeriye yani ekranda ne seçersek o kredinin hesapla fonksiyonu çalışır.

List<IKrediManager> krediler = new List<IKrediManager>(){ ihtiyacKrediManager,tasitKrediManager };
//ekrandan ihtiyaç kredisini seçerse
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);




/*IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla();

//IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

//IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

//interfacelerde aynı işi yapar.yukarıdakilerle aynı işi yapar.İnterface onu implente eden clasın referans bilgisini tutar. */