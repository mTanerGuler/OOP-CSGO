using OOP_CSGO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSGO.Abstracts.Weapons
{
    class Tabanca : FireArms
    {
        public int bullet;
        public Tabanca(string marka, string model, double weight, double kalibre,RangeTypes range) : base(marka, model, weight, kalibre, range)
        {
            BulletType = BulletType.Çekirdekli;
            BulletCapacity = 15;
            bullet = BulletCapacity;
        }
        public void Fire()
        {
           Kill(ref bullet);
        }
        
        //static void Get()
        //{
        //    Tabanca tabanca = new Tabanca(); //static olmayan metota ulaşmak için metotun sınıfının instance'ını aldık
        //    tabanca.Get2();
        //}
        //void Get2()
        //{
        //    Get();
        //}
         public void Reloaded()
        {
            bullet = Reload(bullet,BulletCapacity);
        }
        public void GetInfos()
        {
            Console.WriteLine($"Silah Bilgileri:\nMarka:{Marka}\nModel:{Model}\nAğırlık:{Weight}\nKalibre:{Kalibre}\nMenzil Tipi:{RangeType}\nMermi Tipi:{BulletType}\nMermi Kapasitesi:{BulletCapacity}\n");
        }
        
    }
}
