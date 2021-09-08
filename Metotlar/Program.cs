using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 8;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 40;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach ( Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-----------");


            }

            Console.WriteLine("---------Metodlar-------------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 8);
            sepetManager.Ekle2("Elma", "Amasya", 12, 25);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 9);
        }
    }
}

//Dont repeat yourself - DRY - Clean Code - Best practice
