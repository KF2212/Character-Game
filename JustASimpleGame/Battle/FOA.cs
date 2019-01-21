using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustASimpleGame.Battle
{
    class FOA
    {
     
            public static ICharacters Attack(ref ICharacters character, ref ICharacters opponent)
            {
                int AttackDealt;
                int HitPointsDefender;
                Random rand = new Random();
                AttackDealt = OFA.StrengthAction(opponent);
                HitPointsDefender =character.HitPoints;
                if (DFA.ArmorAction(character) > AttackDealt)
                {
                   character.HitPoints = HitPointsDefender - 5;
                }
                else
                {
                    character.HitPoints = HitPointsDefender - ((AttackDealt) - DFA.ArmorAction(character)) * DFA.LuckAction(character);
                }
                return character;
            }
            public static void AttackMechanics(ref ICharacters opponent, ref ICharacters character, int ifPossible)
            {
                FOA.Attack(ref character, ref opponent);
                TIM.SetTime(opponent, "ATTACK");
                ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
            }
            public static void SpellMechanics(ref ICharacters opponent, ref ICharacters character, int ifPossible)
              {
                 FOA.Spell(ref character, ref opponent);
                 TIM.SetTime(opponent, "SPELL");
                 ChoicesOnFightOpponent.FightChoices(ref opponent, ref character, ifPossible);
                 
              }
            public static ICharacters Spell(ref ICharacters character, ref ICharacters opponent)
            {
                int AttackDealt;
                int HitPointsDefender;
                Random rand = new Random();
                AttackDealt = OFA.StrengthAction(opponent);
                HitPointsDefender = character.HitPoints;
                if (DFA.ArmorAction(character) > AttackDealt)
                {
                    character.HitPoints = HitPointsDefender - 10;
                }
                else
                {
                    character.HitPoints = HitPointsDefender - ((AttackDealt) - DFA.ArmorAction(character)) * DFA.LuckAction(character);
                }
                return character;
            }


        }
}
