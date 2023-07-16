using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class SaleManager: Urun
    {
        public void Sat (Urun urun)
        {
            Console.WriteLine("Satış yapıldı.");
        }
        public void IndırımYaz (List<IndirimManager> oyunlar)
        {
            foreach (var oyun in oyunlar)
            {
                oyun.Indırım();
            }
        }
    }
}
