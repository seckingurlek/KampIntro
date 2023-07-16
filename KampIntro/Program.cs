using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself
            string kategorietiketi = "kategori";
            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisyapmismi = false; 
            

            double dolarDun = 7.55;
                double dolarBugun = 7.55;
                if (dolarDun> dolarBugun)
            {
                Console.WriteLine("azalış butonu");

            }
                else if (dolarBugun> dolarDun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if (sistemeGirisyapmismi == true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            Console.WriteLine(kategorietiketi);

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "java";
            kurs1.eğitmen = "seçkin";
            kurs1.izlenmeOrani = 55;
            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "csharp";
            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "phyton";

            Kurs[] kurslar = new Kurs[] {kurs3,kurs2,kurs1};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }


                }
    }
   
}
