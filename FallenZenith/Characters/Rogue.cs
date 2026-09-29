using FallenZenith.Skills;
using System;
using System.Collections.Generic;
using System.Text;

namespace FallenZenith.Characters
{
    internal class Rogue : Character
    {
        public Rogue(string name) : base(name)
        {
            MaxHP = 90;
            HP = MaxHP;
            MaxMP = 50;
            MP = MaxMP;
            ATT = 16;
            DEF = 9;
            SPD = 20;

            Skills.Add(new Backstab());
        }

        public override CharacterClass Job
        {
            get
            {
                return CharacterClass.Rogue;
            }
        }
    }
}
