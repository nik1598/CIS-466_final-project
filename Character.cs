using System;

namespace HeroMonsterBattle_FinalProject
{
    public class Character 
    {
        // adding properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public Character(string name, int health, int damageMaximum, bool attackBonus)
        {
            Name = name;
            Health = health;
            DamageMaximum = damageMaximum;
            AttackBonus = attackBonus;

        }

        public int Attack()
        {
            var Rand = new Random(this.DamageMaximum); //randomly determine the amount of damange this Character object inflicted
            return Rand.Next();
        }

        public void Defend(int damage) //deducts the damage from this Character's health
        {
            this.Health -= damage;
        }
    }
}
