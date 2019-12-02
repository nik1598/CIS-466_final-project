using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Setting properties for our hero
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 100;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;
 
            //Setting properties for our hero
            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 100;
            monster.DamageMaximum = 18;
            monster.AttackBonus = false;
        }
    }
}
