using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public class WaterFactory : CharactersAbstractFactory
    {
        public override Hero CreateHero(string name, Sect sect)
        {
            return new WaterHero(name, sect);
        }

        public override Monster CreateMonster(MonsterType type, int level)
        {
            return new WaterMonster(type, level);
        }
    }
}
