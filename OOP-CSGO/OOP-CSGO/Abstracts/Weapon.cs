using OOP_CSGO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSGO.Abstracts
{
    abstract class Weapon
    {
        public Weapon(string marka, string model, double weight, RangeTypes range) //İlerde sınıflardan silah oluşturmak için bu parametrelerin doldurulmasını zorunlu kılmak için constructor'da tanımladım.
        {
            Marka = marka;
            Model = model;
            Weight = weight;
            RangeType = range;
        }
        protected string Marka { get; private set; }
        protected string Model { get; private set; }
        protected double Weight { get; private set; }
        protected RangeTypes RangeType { get; private set; }
        protected 

        Random rnd = new Random();
        int killChance;
         public virtual int Kill(ref int bullet)
        {
            if (bullet>0)
            {
                bullet--;
                Console.WriteLine($"Kalan Mermi Adet:{bullet}");
                killChance = rnd.Next(1, 7);
                if (killChance == 6)
                {
                    Console.WriteLine("Hedef Öldürüldü");
                    return bullet;
                }
                else
                {
                    Console.WriteLine("Hedef yaralandı");
                    return bullet;
                }
            }
            else
            {
                Console.WriteLine("Merminiz kalmadı.");
                return bullet;
            }
        }
    }
}
