using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            string katagoriEtiketi = "Katagoriler";
            int ogreciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarınDunkiDegeri = 7.45;
            double dolarınBugunkiDegeri = 7.45;

            if (dolarınDunkiDegeri>dolarınBugunkiDegeri)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarınDunkiDegeri<dolarınBugunkiDegeri)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Değişmedi Oku");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(katagoriEtiketi);





        }
    }
}
