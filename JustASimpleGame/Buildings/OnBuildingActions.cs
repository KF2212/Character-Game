using JustASimpleGame.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame
{
    class OnBuildingActions
    {
        public static void InDoors(ICharacters character)
        {
            if (CityMap.PositionX == 20 && CityMap.PositionY == 19)
            {
                BuildingMessages.BuldingMessage("Arena");
                Arena.FightInArena(character,OnInputWork.ChoiceHandler());
                //Wykonuj sie arena
                }
            else if (CityMap.PositionX == 26 && CityMap.PositionY == 11)
            {
                BuildingMessages.BuldingMessage("WeaponSmith");
                //Wizard wizard = new Wizard();
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetWeaponsAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Strength"));
                BuildingPurchase.Buying(OnInputWork.MovingOnMapHandler(),character);
                //Wykonuj sie WeaponSmith
            }
            else if (CityMap.PositionX == 30 && CityMap.PositionY == 7)
            {
                BuildingMessages.BuldingMessage("ArmorSmith");
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetArmorAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Durability"));
                OnInputWork.ChoiceHandler();
                //Wykonuj sie ArmorSmith
            }
            else if (CityMap.PositionX == 16 && CityMap.PositionY == 4)
            {
                BuildingMessages.BuldingMessage("Shop");
                Console.WriteLine("You have: " + character.Money + " money, " + character.Intelligence + "Intelligence!");
                List<CreatingItems> buildingitems = new List<CreatingItems>();
                buildingitems = ProductsInBuldings.GetShopAvailable(character);
                Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Strength"));
                ItemShop.Item(character, buildingitems, OnInputWork.ChoiceHandler());
            }
            //BuildingMessages.BuldingMessage("Shop");
            //Wizard wizard = new Wizard();
            //List<BuildingItems> buildingitems = new List<BuildingItems>();
            //buildingitems = ProductsInBuldings.GetShopAvailable(wizard);
            //Console.WriteLine(ProductsInBuldings.ShowProductsAvailable(buildingitems, "Intelligence"));
        }
    }
}
