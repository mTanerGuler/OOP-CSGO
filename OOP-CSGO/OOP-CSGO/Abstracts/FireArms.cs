using OOP_CSGO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSGO.Abstracts
{
    abstract class FireArms : Weapon
    {
        protected FireArms(string marka, string model, double weight, double kalibre, RangeTypes range) : base(marka, model, weight,range) //"Weapon"dan kalıtım aldığım için constructor oluşturup base ve this parametrelerini oluşturmak zorundayım. Ancak parametrelere değer atamayı burada yapmak zorunda değilim.
        {
            
            Kalibre = kalibre; //Dökümantasyonda bu bilgiler de verilmediği için constuctor'a ekleyip developer'ın atamasını istiyoruz.
        }

        public BulletType BulletType { get; set; } //Tipleri elle atamak yerine "enum" oluşturup özelliği veri tipi olarak çektik.
        public int BulletCapacity { get; set; }
        public double Kalibre { get; set; }
        
        protected string FireSound()
        {
            return "TakTakTak";
        }
        protected string ReloadSound()
        {
            return "TakTakTak";
        }
        internal virtual int Reload(int bullet,int capacity)
        {
            if (bullet==capacity)
            {
                Console.WriteLine("Şarjör zaten dolu.");
            }
            else
            {
                bullet = capacity;
                Console.WriteLine("Mermi dolduruldu.");
            }
            return bullet;
        }
    }
}
