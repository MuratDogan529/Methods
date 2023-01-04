// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;//int değişkeni değer tiplidir. Referanslı olmadığı için atamada bağlantıyı koparır.
sayi2 = 65;
//sayi1=? 30 olur

int[] sayilar1 = new int[] { 10,20,30 };//array raefrans tipli
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1= sayilar2;
sayilar2[0] = 999;
//sayilar1[0]=? 999 olur.Referans tipli olduğu için referans alarak üzerine yazar.


