using OOP_CSGO.Abstracts.Weapons;
using OOP_CSGO.Enums;
using System;

namespace OOP_CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabanca tabanca = new Tabanca("Eagle", "E-372", 1.32, 5.62, RangeTypes.UzakMenzilli);
            
            int select;
            Console.WriteLine("Silah Seçimi:\n1-Bıçak\n2-Tabanca");
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 2:
                    tabanca.GetInfos();
                    GamePlay(tabanca);
                    break;
            }
        }

        private static void GamePlay(Tabanca tabanca)
        {
            string selectProcess;
            do
            {
                Console.WriteLine("Fire:F - Reload:R - Stop:S");
                selectProcess = Convert.ToString(Console.ReadLine());
                if (selectProcess == "F")
                {
                    tabanca.Fire();
                }
                else if (selectProcess=="R")
                {
                    tabanca.Reloaded();
                }
            } while (selectProcess != "S");
        }
    }
}
