using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using JustASimpleGame.Characters;
//nie dzia³aj¹ statyczne metody w CharacterData
namespace JustASimpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Starting.StartTxt();
            GameInvocation.OptionsSelector();
        }
    }
}



//ICharacters characters = new Archer();
//Console.WriteLine(characters.HitPoints);
//characters.Health();
//Console.WriteLine(characters.HitPoints);
//ICharacters wizard = new Wizard();

//Timer.SetTime(characters, "ATTACK");
//Console.WriteLine(characters.TimeForActions[0]);
//Console.WriteLine(characters.TimeForActions[1]);
//Console.ReadKey();
//int ifPossible = 1;
//ChoicesOnFight.FightChoices(ref characters, ref wizard, ifPossible);
//Console.ReadKey();
//GameInvocation.OptionsSelector();
//ICharacters character = new Archer();

//List<CreatingItems> buildingitems = new List<CreatingItems>();
//buildingitems = ProductsInBuldings.GetWeaponsAvailable(character);
////foreach(object items in buildingitems)
////{
////    Console.WriteLine(items);
////}
//Random rand = new Random();
//Weapon FirstItem = new Weapon(character, rand);


//Console.WriteLine(FirstItem.Required);


//Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Strength"));
//CreatingItems one = buildingitems[0];
//Console.WriteLine(one.Price);
//Console.ReadLine();
//ThreeHeadedDragon drago = new ThreeHeadedDragon();
//drago.Picture();
//Console.ReadKey();
//CityMap.ShowMap(character);
