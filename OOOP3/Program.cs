using System;
using System.Collections.Generic;

namespace OOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            TasitKrediManager tasitKrediManager = new TasitKrediManager();            
            IKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService() };
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
           basvuruManager.BasvuruYap(tasitKrediManager,loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager};
          //  basvuruManager.KrediOnbilgilendirmesiYap(krediler);

        }
    }
}