using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonsterBattle_FinalProject
{
    class Dice
    {
        public int Sides { get; set; }

        Random random = new Random();

        public int Roll()
        {
            return random.Next(1, this.Sides);     // Resturns random damage based on Sides propertiy, which is based on MaximumDamage
        }
    }
}
