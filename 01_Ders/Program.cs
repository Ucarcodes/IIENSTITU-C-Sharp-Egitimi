using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tek satırlık notlar için // kullanılır.

            /* 
             Çok satırlı notlar için, 
            iki slash arasında yıldızlar kullanılır.
             */

            //Console.Write(); komutunda, imleç ilk satırın son harfinde olur.
            //Console.WriteLine(); komutunda, imleç bir alt satıra kayar.
            //Console.Write("Metin \n deneme"); komutunda da \n 'den sonraki kısım alt satıra yazdırılır.

            //Console.Write(); veya Console.WriteLine(); içinde "" içinde yazılanlar metin olarak algılanır.

            //Console.WriteLine("|----- IIENSTITU C# EĞİTİMİ -----|");
            //Console.Write("2+5=" + (2+5)); //(2+5) şeklinde yazmasak, 7 yerine 2 ve 5'i yan yana ekleyerek 25 değerini yazdıracaktı.


            /* 
            Değişken adlandırılırken, ilk karakter sayı olamaz.
            Değişken adlandırılırken, Türkçe karakter kullanılmaz.
            Değişken adlandırılırken, iki kelime arasına _ koyulabilir.
            Değişken adlandırılırken ilk kelimenin ilk harfi küçük olup, sonra gelen tüm kelimelerin ilk hafleri büyük olur.
            */

            
            /*
            Short, 16 bit ; Int, 32 bit, Long, 64 bit'lik sayı tutabilir.
            */

            string ogrenciIsmi = "Mevlüt";
            string ogrenciSoyadi = "Uçar";

            Console.WriteLine("Öğrenci ismi: " + ogrenciIsmi + " Öğrenci Soyadı: " + ogrenciSoyadi);


            Console.ReadKey();
        }
    }
}
