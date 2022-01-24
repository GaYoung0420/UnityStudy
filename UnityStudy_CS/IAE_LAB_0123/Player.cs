using System;
using System.Collections.Generic;
using System.Text;

namespace IAE_LAB_0123
{
    public enum PlayerType
    {
        None = 0,
        Knight = 1,
        Archer = 2,
        Mage = 3
    }

    class Player : Creature
    {
        protected PlayerType player = PlayerType.None;
        protected Player(PlayerType player) : base(CreatureType.Player)
        {
            this.player = player;
        }

    }

    class Knight : Player
    {
        public Knight() : base(PlayerType.Knight)
        {
            base.SetInfo(100, 10);
        }
    }

    class Archer : Player
    {
        public Archer() : base(PlayerType.Archer) 
        {
            base.SetInfo(100, 20);
        }
    }

    class Mage : Player
    {
        public Mage() : base(PlayerType.Mage) 
        {
            base.SetInfo(100, 30);
        }
    }

}