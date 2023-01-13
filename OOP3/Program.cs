// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//INTERFACES
using OOP3;

IhtiyacKrediManager ıhtiyacKrediManager=new IhtiyacKrediManager();
ıhtiyacKrediManager.Hesapla(); 

TasitKrediManager tasitKrediManager= new TasitKrediManager();
tasitKrediManager.Hesapla();

KonutKrediManager konutKrediManager= new KonutKrediManager();
konutKrediManager.Hesapla();


//IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
//ıhtiyacKrediManager.Hesapla();

//IKrediManager tasitKrediManager = new TasitKrediManager();
//tasitKrediManager.Hesapla();

//IKrediManager konutKrediManager = new KonutKrediManager();
//konutKrediManager.Hesapla();

//interfacelerde aynı işi yapar.yukarıdakilerle aynı işi yapar.İnterface onu implente eden clasın  referans bilgisini tutar. 