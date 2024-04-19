using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit // Herança!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public override int Health //Overwrites original Health given by Unit
        {
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
        }

        public override float Cost //Overwrites original Cost property
        {    
            get
            {
                return AttackPower + XP;
            }
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        //Method ToString gets the type of unit this unit is, as well as its
        //health, cost (with two decimal places), attack power and experience.  
        public override string ToString() => $"{GetType().Name}:" +
                $" HP={Health} COST={Cost.ToString("0.00")} AP={AttackPower} XP={XP}";
    }   
}
