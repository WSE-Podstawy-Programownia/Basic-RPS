using System;
using Players;

public class Program
{
    public static void Main()
    {
        //preparing stuff
    		HumanPlayer player = new HumanPlayer();
        ComputerPlayer enemy = new ComputerPlayer();

        string drawMsg = "A draw ! I bet you did not expect this !";
        string winMsg = "You win ! Are you that skilled or just lucky ?";
        string loseMsg = "You lose ! But don't give up, you can beat this pesky machine !";

        bool complete = false;

        //main loop, runs till input after match result != y
        while (!complete)
        {
            player.Greet();
            int userInput = player.Choose();
            if (player.IsValid(userInput)) 
            {
                int userChoice = userInput;
                int enemyChoice = enemy.Choose();

                Console.WriteLine("Player has chosen: " + userChoice);
                Console.WriteLine("Computer has chosen: " + enemyChoice);

                // here goes the magic (there is a finite number of possible results of subtraction
                // therefore we can simplify the whole decision part)
                if (userChoice == enemyChoice)
                    Console.WriteLine(drawMsg);
                else if (userChoice - enemyChoice == -2 || userChoice - enemyChoice == 1)
                    Console.WriteLine(winMsg);
                else
                    Console.WriteLine(loseMsg);
            }

            string continueGame;
            Console.WriteLine("Continue ? {y} ");
            continueGame = Console.ReadLine();
            if (continueGame == "y")
                complete = false;
            else
                complete = true;
        }
    }
}
