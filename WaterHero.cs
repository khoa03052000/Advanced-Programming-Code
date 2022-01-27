using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public class WaterHero : Hero
    {
        public WaterHero(string name, Sect sect) : base(name, sect)
        {
        }

        public override string Info()
        {
            return "Water";
        }

        public override int Dame(Hero hero)
        {
            if(hero.Info() == "Fire")
            {
                return (int)(this.Dame() * 1.2);
            }
            return this.Dame();
        }

        public override int Dame(Monster monster)
        {
            if (monster.Info() == "Fire")
            {
                return (int)(this.Dame() * 1.2);
            }
            return this.Dame();
        }
    }
}
