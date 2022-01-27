using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public class WaterMonster: Monster
    {
        public WaterMonster(MonsterType type, int level_monster) : base(type, level_monster)
        {
        }

        public override string Info()
        {
            return "Water";
        }

        public override int Dame(Hero heroMonster)
        {
            if (heroMonster.Info() == "Fire")
            {
                return (int)(this.Dame() * 1.2);
            }
            return this.Dame();
        }
    }
}
    