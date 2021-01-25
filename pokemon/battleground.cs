using System;
using System.Collections.Generic;
using System.Text;

namespace bot
{
    class Battle_Arena
    {
        public void requestAChallenger(Hokemon requestor)
        {
            Console.WriteLine("{0}: says 'Requesting challenger!!!'", requestor.Name);
        }

        public void theBattle(Hokemon attacker, Hokemon defender)
        {

            int round = 0;
            int attackValue = 0;
            int defenceValue = 0;
            Hokemon tempHoke;

            Console.WriteLine("{0}: waiting...", attacker.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: waiting...", attacker.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: 'Challenge accepted!!", defender.Name);

            Console.WriteLine("*** Stats ***");
            attacker.get_details();
            defender.get_details();

            Console.WriteLine("*** BATTLE START ***\n");

            while (Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >= 0)
            {
                round += 1;
                attackValue = attacker.attackCalculator();
                defenceValue = defender.defenceCalculator();

                Console.WriteLine("*** ROUND {0} ***\n\n", round);

                for (int i = 0; i < 2; i++)
                {
                    System.Threading.Thread.Sleep(2000); 

                    Console.WriteLine("{0}: Prepares for an attack ...", attacker.Name);
                    Console.ReadLine();
                    Console.WriteLine("{0}: Attack value: {1}...\n\n", attacker.Name, attackValue);
                    Console.ReadLine();
                    Console.WriteLine("{0}: 'Swiftly moves and creates a Defence value of: {1}", defender.Name, defenceValue);
                    Console.ReadLine();
                    Console.WriteLine("{0}: Takes damage (HEALTH {1} + Defence {2}) = {3} - Attack {4}\n", defender.Name, defender.Health, defenceValue, (defender.Health + defenceValue), attackValue);
                    defender.Health = (defender.Health + defenceValue) - attackValue;
                    Console.WriteLine("{0}: New HEALTH value: {1} ", defender.Name, ((defender.Health + defenceValue) - attackValue));

                    Console.WriteLine("\n*********************\n");

                    Console.WriteLine("\n****\nSwitch turns: Defender becomes the Attacker...\n****\n");
                    tempHoke = attacker;
                    attacker = defender;
                    defender = tempHoke;
                }
            }

            if (attacker.Health > defender.Health)
            {
                Console.WriteLine("{0}: WINS", attacker.Name); 
            }
            else
            {
                Console.WriteLine("{0}: WINS", defender.Name);  
            }


        }

    }
}