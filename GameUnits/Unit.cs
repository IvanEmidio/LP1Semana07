using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit 
    //Changed to abstract because we don't know what unity it will be.
    {
        private int movement;
        public virtual int Health { get; set; } 
        //It's virtual to guarantee that the unit will always have a base health
        //that can modified in derived classes. 

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public abstract float Cost { get; } //Read-only abstract property
        
        //Shows how much the unity moved
        public void Move() => Console.WriteLine($"{movement}");

        //Method ToString gets the type of unit this unit is, as well as its
        //health and cost (with two decimal places).
        public override string ToString() => $"{GetType().Name}: HP={Health}" +
         $" COST={Cost.ToString("0.00")}";

    }   
}
