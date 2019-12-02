using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Character
    {
        // adding properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public Character() //Default constructer
        {
        } 

        public Character(string name, int health, int damageMaximum, bool attackBonus)
        {
            Name = name;
            Health = health;
            DamageMaximum = damageMaximum;
            AttackBonus = attackBonus;

        }

       

        public int Attack(Dice dice) // Sets Sides property equal to maximun damage, returns a random int between 0 and DamageMaximum
        {
            dice.Sides = DamageMaximum;     
            int damageAmount = dice.Roll(); 
            return damageAmount;
        }

        public void Defend(int damage) //deducts the damage from this Character's health
        {
            this.Health -= damage;
        }
    }
}
