using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //değer tutucu
            //Do not repeat yourself
            // Console.WriteLine(); cw tab tab
            //if (true)
            //{
            //if tab tab
            //}

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(faizOrani);

            Console.WriteLine(ogrenciSayisi);

            Console.WriteLine(kategoriEtiketi);

        }
    }
}





