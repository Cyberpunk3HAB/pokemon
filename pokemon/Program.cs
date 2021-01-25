using System;

namespace bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Hokemon[] ChallengerArray = new Hokemon[3];
            Battle_Arena newBattleObject = new Battle_Arena();

            Random rnd = new Random();

            Boolean repeatGame = true;
            string result;

            Console.WriteLine("Welcome to bot battle arena");

            
            Hokemon hoke03 = new Hokemon();

            iron hoke04 = new iron(); 
            Console.WriteLine("I'm part of {0} team.", hoke04.team);
            

            iron playerHoke = new iron();

            while (repeatGame == true)
            {
                newBattleObject.requestAChallenger(playerHoke);

                for (int i = 0; i < 3; i++)
                {
                    ChallengerArray[i] = new Hokemon();
                }
            }

            newBattleObject.theBattle(playerHoke, ChallengerArray[rnd.Next(0, ChallengerArray.Length)]);

            playerHoke.get_details();

            Console.WriteLine("Do you want another battle? (y/n)");
            result = Console.ReadLine();
            if ((result.ToLower())[0] == 'n')
            {
                repeatGame = false;
            }

            
            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.requestAChallenger(hoke03); 

            newBattleObject.theBattle(hoke03, hoke04);
            
        }
    }
}