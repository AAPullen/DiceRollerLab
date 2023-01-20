using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public static class Casino
    {
        public static int DiceRoll(int diceSides)
        {
            Random roll = new Random();
            int result = roll.Next(1 , (diceSides + 1));
            return result;
        }

        public static string Reroll()
        {
            Console.Write("Would you like to roll again (y/n)? ");
            string answer = Console.ReadLine().ToLower().Trim();
            return answer;
        }
        
        public static string SixSidedComboCheck(int dieOne, int dieTwo)
        {
            int total = dieOne + dieTwo;

            if (dieOne == 1 && dieTwo == 1)
            {
                return "Snake Eyes.";
            }
            else if (dieOne == 6 && dieTwo == 6)
            {
                return "Box Cars.";
            }
            else if ((dieOne == 1 && dieTwo == 2) || (dieOne == 2 && dieTwo == 1))
            {
                return "Ace Deuce.";
            }
            else
            {
                return null;
            }
        }

        public static string CheckWinLose(int dieOne, int dieTwo)
        {
            int total = dieOne + dieTwo;
            if (total == 2 || total == 3 || total == 12)
            {
                return "Craps.\n";
            }
            else if (total == 7 || total == 11)
            {
                return "you Win!\n";
            }
            else
            {
                return null;
            }
        }
    }
}
