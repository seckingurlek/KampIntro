using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKrediManager };
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);





         }
       }
     }

































        
    

