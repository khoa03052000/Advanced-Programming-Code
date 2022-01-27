using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoLamTruyenKy
{
    public abstract class Monster
    {
        public int level;
        protected int basicAttack;
        public MonsterType Type;
        protected Monster(MonsterType type, int level_monster)
        {
            level = level_monster;
            Type = type;
            switch (Type)
            {
                case MonsterType.Dominate:
                    basicAttack = 50;
                    break;
                case MonsterType.Ordinary:
                    basicAttack = 30;
                    break;
                default:
                    Console.WriteLine("No type monster for choose");
                    break;
            }
        }
        public abstract string Info();

        public int Dame()
        {
            int dame = basicAttack * level;
            return dame;
        }
        public abstract int Dame(Hero heroMonster);
    }
    public enum MonsterType
    {
        Dominate,
        Ordinary
    }
}
