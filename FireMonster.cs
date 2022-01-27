using log4net.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public class FireMonster : Monster
    {

        public FireMonster(MonsterType type, int level_monster) : base(type,level_monster)
        {
        }

        public override string Info()
        {
            return "Fire";
        }

        public override int Dame(Hero heroMonster)
        {
            if(heroMonster.Info() == "Water")
            {
                return (int)(this.Dame() * 0.8);
            }
            return this.Dame();
        }
    }
}
