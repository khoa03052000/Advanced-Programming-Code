using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public abstract class Hero
    {
        public int level = 1;
        protected int basicAttack ;
        public string Name;
        public Sect sectHero;
        protected Hero(string name, Sect sect)
        {
            Name = name;
            sectHero = sect;
            switch (sectHero)
            {

                case Sect.Shaolin:
                    basicAttack = 50;
                    break;
                case Sect.HeavenlyKings:
                    basicAttack = 55;
                    break;
                case Sect.Emei:
                    basicAttack = 40;
                    break;
                case Sect.TheyYen:
                    basicAttack = 45;
                    break;
                default:
                    Console.WriteLine("No Sect for choose");
                    break;
            }
        }
        public abstract string Info();

        public int Dame()
        {
            int dame = basicAttack * level;
            return dame;
        }
        public abstract int Dame(Hero hero);
        public abstract int Dame(Monster monster);
    }
    public enum Sect
    {
        // Fire
        Shaolin,
        HeavenlyKings,
        // Water
        Emei,
        TheyYen
    }
}
