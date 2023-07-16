using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            int fiyati = 15;
            string aciklama = "Amasya elma";

            //string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakir karpuz";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler) 

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("----------");
            }

            Console.WriteLine("--------Metotlar---------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 9);

              
            
        }
    }
}


//do not repaet yourself