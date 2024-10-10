using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Try catch komutu, programın hata vereceği kısımlar ve hata durumunda ne yapılacağı yazılır.
            // Try catch, kullanıcının yapabileceği hatalı girişleri engellemek için kullanılır.

            //try
            //{
            //    Console.Write("Lütfen bir tam sayı giriniz: ");
            //    int sayi = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine(hata.Message); //Hatanın ne olduğunu ekrana yazdırır.
            //    Console.WriteLine("Lütfen tam sayı giriniz!");
            //}

            // Console.Clear(); komutu, console ekranını temizler.

            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("Ekranı temizlemek için, herhangi bir tuşa basınız.");
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("Ekran temizlendi!");


            // System.Threading.Thread.Sleep(1000); 1 saniye beklemeyi sağlar.

            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("deneme deneme deneme deneme");
            //Console.WriteLine("Ekranı temizlemek için, kalan süre 3 saniye.");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Ekranı temizlemek için, kalan süre 2 saniye.");
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Ekranı temizlemek için, kalan süre 1 saniye.");
            //System.Threading.Thread.Sleep(1000);
            //Console.Clear();
            //Console.WriteLine("Ekran temizlendi!");


            // goto komutu, kodun istediğimiz satırına gitmeyi ve o satırdan itibaren tekrardan çalışmasını sağlar.
            // goto kullanımında, gidilmek istenen satırda bir etiket tanımlarız.
            // etiket tanımı örneğin, kod325: gibi olur.
            // goto kod325; dediğimizde, kod325: etiketimizin olduğu satıra gider ve o satırdan sonra tekrardan programı çalıştırır.

            //satir1Baslangici:
            //    int tekrarSayisi = 1;
            //    Console.WriteLine("Satır 1 başlangıcı, tekrar sayısı: " + tekrarSayisi);
            //    tekrarSayisi++;
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");
            //    Console.WriteLine("Satır Lorem ipsum dolor sit amet. ");

            //    Console.WriteLine();

            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");
            //    Console.WriteLine("Satır2 Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            //    Console.WriteLine();

            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");
            //    Console.WriteLine("Satır3 Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis convallis. ");

            //    Console.WriteLine();
            //    Console.WriteLine("Satır1'in başlangıcına gitmek için herhangi bir tuşa basınız.");
            //    Console.ReadKey();
            //    Console.Clear();
            //    goto satir1Baslangici;


            //sayiGirisEkrani:
            //    try
            //    {

            //        Console.Write("Lütfen bir tam sayı giriniz: ");
            //        int sayi = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);

            //        Console.WriteLine("Yeniden giriş yapmak ister misiniz? (E-H)");

            //        char girilenKarakter = char.Parse(Console.ReadLine());
            //        if (girilenKarakter == 'e' || girilenKarakter == 'E')
            //        {
            //            Console.Clear();
            //            goto sayiGirisEkrani;
            //        }
            //    }
            //    catch (Exception hata)
            //    {
            //        Console.WriteLine(hata.Message); //Hatanın ne olduğunu ekrana yazdırır.
            //        Console.WriteLine("Yeniden giriş yapmak ister misiniz? (E-H)");

            //        char girilenKarakter = char.Parse(Console.ReadLine());
            //        if (girilenKarakter == 'e' || girilenKarakter == 'E')
            //        {
            //            goto sayiGirisEkrani;
            //        }
            //        else if (girilenKarakter == 'h' || girilenKarakter == 'H')
            //        {
            //            Console.Clear();
            //            Console.WriteLine("İşlem iptal edildi.");
            //            Console.WriteLine("Program kapanıyor. 3...");
            //            System.Threading.Thread.Sleep(1000);
            //            Console.WriteLine("Program kapanıyor. 2...");
            //            System.Threading.Thread.Sleep(1000);
            //            Console.WriteLine("Program kapanıyor. 1...");
            //            System.Threading.Thread.Sleep(1000);
            //            Environment.Exit(0); //Programı kapatır.
            //        }
            //    }



            // Döngüler, tekrar eden işlemlerden bizi kurtaran kod satırlarıdır.
            // While -> Koşul sağlandığı sürece dön. If yapısına benzer.
            // "Sürece" kelimesi, while döngüsüne aittir.

            //int tekrarSayisi = 0;
            //while (true)
            //{
            //    tekrarSayisi++;
            //    Console.WriteLine("Tekrar sayısı: " + tekrarSayisi);
            //}

            //int gecenSaniye = 0;
            //while (true)
            //{
            //    gecenSaniye++;
            //    System.Threading.Thread.Sleep(1000);
            //    Console.WriteLine(gecenSaniye + " saniye geçti.");

            //}

            //int gecenSaniye = 0;
            //while (gecenSaniye <10)
            //{
            //    gecenSaniye++;
            //    System.Threading.Thread.Sleep(1000);
            //    Console.WriteLine(gecenSaniye + " saniye geçti.");

            //}
            //Console.WriteLine("Döngü tamamlandı ve durdu.");

            //int gecenSaniye = 0;
            //while (true)
            //{
            //    gecenSaniye++;
            //    System.Threading.Thread.Sleep(1000);
            //    Console.WriteLine(gecenSaniye + " saniye geçti.");

            //    if (gecenSaniye == 10)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Döngü tamamlandı ve durdu.");

            Console.Write("Kelime giriniz: ");

            string girilenKelime = Console.ReadLine();

            while (girilenKelime != "iptal")
            {
                Console.WriteLine("Döngüyü durdurmak için iptal yazınız.");
                Console.Write("Kelime giriniz: ");
                girilenKelime = Console.ReadLine();
            }
            Console.WriteLine("iptal kelimesi girildiği için döngü durdu.");
            Console.ReadKey();
        }
    }
}
