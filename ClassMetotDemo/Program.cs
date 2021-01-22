using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali Vehbi";
            musteri1.Soyad = "Mersin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Emine";
            musteri2.Soyad = "Mersin";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);

            Console.WriteLine("----------");

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);

            Console.WriteLine("----------");

            string[] musteriler = new string[] { musteri1.Ad, musteri2.Ad};

            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i]);
            }
        }
    }
}
