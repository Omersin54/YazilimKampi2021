using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1="Ygyk";
            //string kurs2="pbitk";
            //string kurs3="java";

            //array - dizi

            string[] kurslar = new string[] { "ygyk", "pbitk", "java", "pyhton", "C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            /* string ad;
                       Console.Write("Adınızı Giriniz: ");
                       ad = Console.ReadLine();

                       Console.Write("Merhaba: " + ad);
                       Console.ReadKey(); */

            Console.WriteLine("Sayfa sonu");
        }
    }
}
