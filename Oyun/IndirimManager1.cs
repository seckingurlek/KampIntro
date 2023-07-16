using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class IndirimManager : Urun
    {
        public void IndırımYap(Urun urun)
        {
            urun.UrunFiyati = urun.UrunFiyati * 90 / 100;
        }
        public void Indırım (Urun urun)
        {
            urun.UrunFiyati = urun.UrunFiyati * 75 / 100;

        }
        public void IndırımYaz(List<IndirimManager> oyunlar)
        {
            foreach (var oyun in oyunlar)
            {
                oyun.Indırım();
            }
        }
    }
}
