﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1Exercises
{
    public class Weapon : IComparable<Weapon>
    {
        public float AttackPower { get; }
        public float Durability { get; }

        public int CompareTo(Weapon other)
        {
            if (other == null) return 1;
            return other.AttackPower.CompareTo(AttackPower);
        }

        public Weapon(float attackPower, float durability)
        {
            AttackPower = attackPower;
            Durability = durability;
        }
    }
}
