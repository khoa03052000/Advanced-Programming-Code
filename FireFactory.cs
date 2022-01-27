using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    class FireFactory: CharactersAbstractFactory
    {
        public override Hero CreateHero(string name, Sect sect )
        {
            return new FireHero(name, sect);
        }

        public override Monster CreateMonster(MonsterType type, int level)
        {
            return new FireMonster(type, level);
        }
    }
}
