using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun() { GameName = "Fifa", UrunFiyati = 125  };

            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = "Seçkin";
            oyuncu1.KullanıcıAdi = "SeckinBey";
            oyuncu1.Sifre = "Seckinben1";
            SaleManager saleManager = new SaleManager();
            saleManager.Sat(urun1);

        }
    }
}
