using DiceRoller;


Console.WriteLine("Welcome to the Grand Circus Casino!\n" +
    "How many sides should the pair of dice have?");

bool playGame = false;
while (playGame == false)
{ 
    string userSides = Console.ReadLine();
    if (int.TryParse(userSides, out int diceSides))
    {
        playGame = true;
        string reroll;

        do
        {
            int dieOne = Casino.DiceRoll(diceSides);
            int dieTwo = Casino.DiceRoll(diceSides);
            Console.WriteLine($"Results = {dieOne} and {dieTwo}. Total = {dieOne + dieTwo}.");

            if (diceSides == 6)
            {
                string Combos = Casino.SixSidedComboCheck(dieOne, dieTwo);
                Console.WriteLine(Combos);

                string winLose = Casino.CheckWinLose(dieOne, dieTwo);
                Console.WriteLine(winLose);
            }

            reroll = Casino.Reroll();

        } while (reroll == "y");
    }
    else
    {
        Console.WriteLine("You have made an invalid entry for number of sides. Please enter an integer.");
    }
}