using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double ve float değişkenler ondalıklı sayısal değerleri tutarlar.
            //Double ve float değişkenler tanımlanırken ondalıklı kısım nokta ile yazılsa da console ekranında virgülle yazdırılır.

            //double ornekSayi = 3.45;

            //Console.Write("Double değerimiz: " +ornekSayi);


            //Bool değişkenler true veya false değerlerini tutar.

            bool dogruMu = true;

            Console.WriteLine("Su 100 derecede kaynar : " + dogruMu);

            dogruMu = 5 > 5;

            Console.WriteLine("Atama doğru mu: " + dogruMu);

            //Bool değerlerde karşılaştırma yapılarak değer atama da yapılabilir.


            //Char değişkenler sadece bir karakter tutulur.
            //Char değişkenlerde ' ' arasında karakter ataması yapılır.
            char ornekKarakter = 'a';

            Console.WriteLine("Kaydedilen karakter: " + ornekKarakter);

            //Console ekranında çift tırnak (") yazdırabilmek için, char içinde çift tırnak (") tutmak ve yazdırmak gerekir.

            /* Sayısal değerleri artırma yolları
            
            x++;
            ++x;
            x = x+1;
            x+=1;

             */

            Console.WriteLine("|----- Temel İşlemler -----|");

            int x = 10;
            int y = 7;

            int mod = x % y;

            Console.WriteLine("X mod Y = " + mod);

            x += y;

            Console.WriteLine("X'in Y ile toplamı = "+ x);
            Console.WriteLine("------------------");

            x = 10;
            y = 5;

            Console.WriteLine("X değeri = " + x);
            Console.WriteLine("Y değeri = " + y);

            x = y++; //Önce X'e eşitle, sonra değerini artır.

            Console.WriteLine("Yeni X değeri = " + x);
            Console.WriteLine("Yeni Y değeri = " + y);

            Console.WriteLine("------------------");

            x = 10;
            y = 5;
            x = ++y; //Önce Y'yi artır, sonra X'e eşitle.
            Console.WriteLine("Daha Yeni X değeri = " + x);
            Console.WriteLine("Daha Yeni Y değeri = " + y);

            //Metin, kelime, harf, gibi içerikler string değişkeni ile tutulabilir.
            //Kullanıcıdan string girişi alınacağında Console.Readline(); kullanılır.

            Console.WriteLine("------------------");
            string isim;
            Console.Write("Lütfen isminizi giriniz: ");
            isim = Console.ReadLine();
            string dersAdi;
            Console.Write("Lütfen almakta olduğunuz ders ismini giriniz: ");
            dersAdi = Console.ReadLine();
            Console.WriteLine("Girilen isim: " + isim + " Alınmakta olunan ders: " + dersAdi);

            //Kullanıcıdan string harici veri girişi alınacağında Convert.ToInt16(Console.Readline()); gibi bir Convert.To  kullanılır. kullanılır.

            Console.ReadKey();
        }
    }
}
