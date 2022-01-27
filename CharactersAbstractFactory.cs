using System.Collections.Generic;

namespace VoLamTruyenKy
{
    public abstract class CharactersAbstractFactory
    {
        public abstract Hero CreateHero(string name, Sect sect);
        public abstract Monster CreateMonster(MonsterType type, int level);
    }
}