using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For döngüsü, başlangıç, bitiş ve artış miktarı belirtilen bir döngüdür.

            //int sayac = 0;
            //for (int i = 250; i <= 1000; i += 5)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac + " . sayı= " + i);
            //}


            //int sayac = 0;
            //int toplam = 0;
            //for (int i = 2500; i >= 500; i -= 50)
            //{
            //    sayac++;
            //    toplam += i;
            //    Console.WriteLine(sayac + " . sayı= " + i);
            //}
            //Console.WriteLine("Bu aralıktaki sayıların toplamı= " + toplam);


            //Console.WriteLine("|----- Kullanıcıdan Alınan 2 Sayı Arasındaki Tüm Sayıları Ekrana Yazdıran Uygulama -----|");
            //Console.Write("Başlangıç değerini giriniz: ");
            //int baslangicDegeri = int.Parse(Console.ReadLine());
            //Console.Write("Bitiş değerini giriniz: ");
            //int bitisDegeri = int.Parse(Console.ReadLine());
            //int sayac = 0;

            //for (int i = baslangicDegeri; i <= bitisDegeri; i++)
            //{
            //    sayac++;
            //    Console.WriteLine(sayac + ". sayı= " + i);
            //}

            //Console.WriteLine("|----- Girilen sayının faktöriyelini bulma -----|");
            //Console.Write("Faktöriyelini bulmak istediğiniz sayıyı giriniz: ");
            //int girilenSayi = int.Parse(Console.ReadLine());
            //long carpimToplami = 1;
            //for (long i = 1; i <= girilenSayi; i++)
            //{
            //    carpimToplami *= i;

            //}
            //Console.WriteLine("Girdiğiniz sayının faktöriyeli= " + carpimToplami);



            /* For döngüsünde, sonsuz döngü yapmak için,
             for (; ; )
            {

            } kullanabilirsin.  */

            // Diziler, degiskenTipi [] diziIsmi = new degiskenTipi[diziBuyukluğu]; şeklinde oluşturulabilir.
            // Diziler degiskenTipi [] diziIsmi = new degiskenTipi["ornek1", "ornek2", "ornek3", 10, 50, 'c']; şeklinde de oluşturulabilir
            // Diziler, 0. indexten başlar.
            // Dizilerin indexleri doldurulurken, sırayla doldurma zorunluluğu yoktur.

            //string[] haftaninGunleri = new string[7];

            //haftaninGunleri[0] = "Pazartesi";
            //haftaninGunleri[1] = "Salı";
            //haftaninGunleri[2] = "Çarşamba";
            //haftaninGunleri[3] = "Perşembe";
            //haftaninGunleri[4] = "Cuma";
            //haftaninGunleri[5] = "Cumartesi";
            //haftaninGunleri[6] = "Pazar";

            //for (int i = 0; i < haftaninGunleri.Length; i++)
            //{
            //    Console.WriteLine("Haftanın " + (i+1) + ". günü: " + haftaninGunleri[i]);
            //}

            // Foreach döngüsü, tüm ihtimaller üstünde işlem yapılacağında kullanılabilecek bir döngü çeşididir.

            Console.ReadKey();
        }
    }
}
