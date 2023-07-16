using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilimgelistirmekampi";
            string kurs2 = "programlama temel kurs";
            string kurs3 = "java";
            Console.WriteLine(kurs1);

            //array dizi
            string[] kurslar = new string[] { "yazilimgelistirmekampi", "programlama temel kurs", "java","python" };

            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

           }
            Console.WriteLine("for bitti");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
