using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            double ay = 16.5;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.IzlnmeOrani = 68;
            kurs1.Egitmen = "Engin Demirog";

            
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.IzlnmeOrani = 70;
            kurs2.Egitmen = "Kerem ulaş";


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.IzlnmeOrani = 92;
            kurs3.Egitmen = "Seco baba";

           //Console.WriteLine(kurs3.KursAdi + ":" + kurs3.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

           


        
        }
    }

  

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlnmeOrani { get; set; }


    }
}
