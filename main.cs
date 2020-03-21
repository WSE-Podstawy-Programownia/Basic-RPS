using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Welcome! You're playing rock, paper, scissors game! Game rules: Scissors beat paper, paper beats rock, rock beats scissors. The game ends when you beat an opponent three times. Good luck! Ready! Steady! Go! Press any key to continue");
    Console.ReadKey();
    Console.Clear();

    int playerOneScore = 0;
    int playerTwoScore = 0;
    
    while (playerOneScore < 3 && playerTwoScore < 3)
    {
      int playerOneChoice;
      bool playerOneParseSuccess;
      do
      {
        Console.WriteLine("[Player 1] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
        playerOneParseSuccess = Int32.TryParse(Console.ReadLine(), out playerOneChoice);
      } while (!playerOneParseSuccess || playerOneChoice <= 0 || playerOneChoice >= 4);
      int playerTwoChoice;
      bool playerTwoParseSuccess;
      do
      {
        Console.WriteLine("[Player 2] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
        playerTwoParseSuccess = Int32.TryParse(Console.ReadLine(), out playerTwoChoice);
      } while (!playerTwoParseSuccess || playerTwoChoice <=0 || playerTwoChoice >= 4);
      
      int difference = playerOneChoice - playerTwoChoice;
      if (difference == 1 || difference == -2)
      {
        playerOneScore = playerOneScore + 1;
        Console.WriteLine("Player 1 won! Score : {0} - {1}", playerOneScore, playerTwoScore);
      }
      else if (difference == 0)
      {
        Console.WriteLine("Draw!!! Score: {0} - {1}", playerOneScore, playerTwoScore);
      }
      else
      {
        playerTwoScore = playerTwoScore + 1;
        Console.WriteLine("Player 2 won! Score : {0} - {1}", playerOneScore, playerTwoScore);
      }

    }

    if (playerOneScore == 3)
    {
      Console.WriteLine("Player 1 WON!!!");
    }
    else
    {
      Console.WriteLine("Player 2 WON!!!");
    }
    
   
  }

}