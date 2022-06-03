using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user);
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja;
            //*täringuid visatakase kolm korda;
            //programm kuulutab võitja.

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1} katse. Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");


                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja võitis katse.");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti võitis katse.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }
            if(cpuScore < userScore)
            {
                Console.WriteLine($"Kasutaja sai {userScore} punkti ja võitis mängu.");
            }
            else if(cpuScore > userScore)
            {
                Console.WriteLine($"Arvuti sai {cpuScore} punkti ja võitis mängu.");
            }
            else
            {
                Console.WriteLine($"Arvuti sai {cpuScore} punkti ja kasutaja sai {userScore} punkti. Mäng jäi viiki.");
            }

                 
            Console.WriteLine("Kena päeva!");

        }
    }
}
