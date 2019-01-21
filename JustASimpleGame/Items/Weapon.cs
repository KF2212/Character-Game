using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class Weapon : CreatingItems
    {
        public Weapon(ICharacters character, Random rand) : base(character,rand)
        {

        }
        
        //public Weapon(int requiredLevel,Random rand) : base(requiredLevel)
        //{
        //    this.Required = requiredLevel * rand.Next(1, 4);
        //    this.RequiredLevel = requiredLevel;
        //    this.Price = requiredLevel * 100 * rand.Next(80, 101) / 100;//Przykładowo randomowo to przecena 
        //    this.Min = this.Required * rand.Next(1, 4);
        //    this.Max = this.Required * rand.Next(4, 6);
        //}
    }
}
