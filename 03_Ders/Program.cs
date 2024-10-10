using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if, koşul sağlandığında, else; koşul sağlanmadığında çalışır.
            // Parse ile de convert işlemleri yapılabilir.


            //Console.WriteLine("|----- Ehliyet Yaş Kontrolü -----|");
            //Console.Write("Lütfen yaşınızı giriniz: ");
            //int yas = int.Parse(Console.ReadLine());
            //if (yas >= 18)
            //{
            //    Console.WriteLine("Ehliyet alabilirsiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Ehliyet alamazsınız!");
            //}

            //Console.WriteLine("|----- Sayının Pozitif - Negatif veya Sıfır Olması Durumu -----|");
            //Console.Write("Lütfen bir sayı değeri giriniz: ");
            //int girilenSayi= int.Parse(Console.ReadLine());

            //if (girilenSayi > 0)
            //{
            //    Console.WriteLine("Girilen sayı: " + girilenSayi + " Pozitiftir.");
            //}

            //else if (girilenSayi < 0)
            //{
            //    Console.WriteLine("Girilen sayı: " + girilenSayi + " Negatiftir.");
            //}

            //else
            //{
            //    Console.WriteLine("Girilen sayı: " + girilenSayi + " Sıfırdır.");
            //}

            //Else if kullanımında, herhangi bir if bloğu veya else if bloğunun koşuluğu sağlanırsa, alttaki hiçbir koşula bakmadan direkt işlemi bitirir.
            //If kullanımında ise, if bloklarının herhangi birinin koşulu sağlansa bile tüm ifler kontrol edilir ve tüm iflerin sonuçları da işlenir.


            //Console.WriteLine("|----- Sayının 15'e Bölümünden Kalan Kontrolü -----|");

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int girilenSayi = int.Parse(Console.ReadLine());
            //int kalanSayi = girilenSayi % 15;

            //if (girilenSayi % 3 == 0 & girilenSayi % 5 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı 15'e tam bölünür. Kalan: " + kalanSayi);
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı 15'e tam bölünmez. Kalan: " + kalanSayi);
            //}

            Console.WriteLine("|----- Kullanıcı Giriş Ekranı -----|");
            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "admin")
            {
                Console.WriteLine("Giriş başarılı!");

            }
            else if (kullaniciAdi == "admin" && sifre != "admin")
            {
                Console.WriteLine("Şifre hatalı!");

            }
            else if (kullaniciAdi != "admin" && sifre == "admin")
            {

                Console.WriteLine("Kullanıcı adı hatalı!");

            }

            else
            {
                Console.WriteLine("Kullanıcı adı ve şifre hatalı!");
            }
            Console.ReadKey();
        }
    }
}
