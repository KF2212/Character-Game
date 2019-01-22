using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JustASimpleGame
{
    class FightOptionAttack
    {
        private static ICharacters Attack(ref ICharacters attacker,ref ICharacters defender)
        {
            int AttackDealt;
            int HitPointsDefender;
            Random rand = new Random();
            AttackDealt = OffensiveActions.StrengthAction(attacker);
            HitPointsDefender = defender.HitPoints;
            if(defender.HeldArmor> AttackDealt)
            {
                defender.HitPoints = HitPointsDefender - 5;
            }
            else
            {
                defender.HitPoints = HitPointsDefender - ((AttackDealt) - defender.HeldArmor * DefenseActions.LuckAction(defender));
            }
            return defender;
        }
        public static void AttackMechanics(ref ICharacters character, ref ICharacters opponent,int ifPossible)
        {
            FightOptionAttack.Attack(ref character, ref opponent);
            Timer.SetTime(character, "ATTACK");
            ChoicesOnFight.FightChoices(ref character, ref opponent,ifPossible);
        }
    }
}

