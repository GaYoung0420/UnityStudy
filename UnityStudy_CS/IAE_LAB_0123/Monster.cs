using System;
using System.Collections.Generic;
using System.Text;

namespace IAE_LAB_0123
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Skeleton = 3
    }
    
    class Monster : Creature
    {
        protected MonsterType monster = MonsterType.None;
        protected Monster(MonsterType monster) : base(CreatureType.Monster)
        {
            this.monster = monster;
        }
    }

    class Slime : Monster
    {
        public Slime() : base(MonsterType.Slime)
        {
            base.SetInfo(100, 3);
        }
    }

    class Orc : Monster
    {
        public Orc() : base(MonsterType.Orc)
        {
            base.SetInfo(100, 9);
        }
    }

    class Skeleton : Monster
    {
        public Skeleton() : base(MonsterType.Skeleton)
        {
            base.SetInfo(100, 12);
        }
    }

}