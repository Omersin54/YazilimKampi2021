using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ömer";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ömer Mersin";
            kurs1.IzlenmeOranı = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "anıl";
            kurs2.IzlenmeOranı = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "pyhton";
            kurs3.Egitmen = "ahmet";
            kurs3.IzlenmeOranı = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Salih";
            kurs4.IzlenmeOranı = 95;


            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }
    //prop tab tab

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
