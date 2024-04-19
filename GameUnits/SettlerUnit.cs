using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit() : base(1, 3) //movement = 1, health = 3
        {} 


        public override float Cost { get; } = 5f;
        //Overwrites original Cost and returns 5.
    }
}