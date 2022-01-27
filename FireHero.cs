using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public class FireHero : Hero
    {

        public FireHero(string name, Sect sect) : base(name, sect)
        {
        }

        public override string Info()
        {
            return "Fire";
        }

        public override int Dame(Hero hero)
        {
            if(hero.Info() == "Water")
            {
                return (int)(this.Dame() * 0.8);
            }
            return this.Dame();
        }

        public override int Dame(Monster monster)
        {
            if (monster.Info() == "Water")
            {
                return (int)(this.Dame() * 0.8);
            }

            return this.Dame();
        }
    }
}
