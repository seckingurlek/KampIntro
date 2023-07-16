using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List < ILoggerService> loggerServices)
        {
            //başvuran bilgilerinideğerlendirme
            //...
            krediManager.Hesapla();
            foreach (var loggers in loggerServices)
            {
                loggers.Log();
            }


        }
        public void KrediOnbilgilendirmesiYap(List <IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
