using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Welcome! You're playing rock, paper, scissors game! Game rules: Scissors beat paper, paper beats rock, rock beats scissors. The game ends when you beat an opponent three times. Good luck! Ready! Steady! Go! Press any key to continue");
    Console.ReadKey();
    Console.Clear();

    string [,] gamesRecord = new string [10,3];
    int gamesRecordCurrentIndex = 0;
    
    string[] lookupTable = new string[] {"rock\t", "paper\t", "scissors"};

    do
    {
      int playerOneChoice;
      bool playerOneParseSuccess;
      do
      {
        Console.WriteLine("[Player 1] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
        playerOneParseSuccess = Int32.TryParse(Console.ReadLine(), out playerOneChoice);
      } while (!playerOneParseSuccess || playerOneChoice <= 0 || playerOneChoice >= 4);
      gamesRecord[gamesRecordCurrentIndex, 0] = lookupTable[playerOneChoice - 1];
      
      int playerTwoChoice;
      bool playerTwoParseSuccess;
      do
      {
        Console.WriteLine("[Player 2] Enter your choice:\n(1) rock\n(2) paper\n(3) scissors");
        playerTwoParseSuccess = Int32.TryParse(Console.ReadLine(), out playerTwoChoice);
      } while (!playerTwoParseSuccess || playerTwoChoice <=0 || playerTwoChoice >= 4);
      gamesRecord[gamesRecordCurrentIndex, 1] = lookupTable[playerTwoChoice - 1];

      int difference = playerOneChoice - playerTwoChoice;
      if (difference == 1 || difference == -2)
      {
        Console.WriteLine("Player 1 won!");
        gamesRecord[gamesRecordCurrentIndex,2]="Player 1 won";

      }
      else if (difference == 0)
      {
        Console.WriteLine("Draw!!!");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Draw";
      }
      else
      {
        Console.WriteLine("Player 2 won!");
        gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2 won";
      }

      gamesRecordCurrentIndex++;
      Console.WriteLine ("Do you want to quit? (y)");
    } while (gamesRecordCurrentIndex < 10 && Console.ReadLine() != "y");

    Console.WriteLine("|Game No\t|Player 1\t|Player 2\t|Winner");
    for (int i = 0; i < gamesRecordCurrentIndex; ++i)
    {
      Console.WriteLine($"|{i+1}\t\t|{gamesRecord[i, 0]}\t|{gamesRecord[i, 1]}\t|{gamesRecord[i, 2]}");
    }
  }

}