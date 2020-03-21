using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Rock paper scissors.");

    int player1Points = 0;
    int player2Points = 0;
    bool gameRunning = true;
  
    while (gameRunning)
    {
      Console.WriteLine("Choose weapon to beat your enemy.");
      Console.WriteLine("Player 1: ");
      string Player1 = Console.ReadLine();
      Player1 = Player1.ToLower();
      Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
      Console.WriteLine("Player 2: ");
      string Player2 = Console.ReadLine();
      Player2 = Player2.ToLower();
      
      if (Player1 == Player2)
      {
      Console.WriteLine("DRAW");
      }
      else if (Player1 == "rock" && Player2 == "scissors" || Player1 == "scissors" && Player2 == "paper" || Player1 == "paper" && Player2 == "rock")
      {
      Console.WriteLine("PLAYER 1 WINS");
      player1Points++;
      Console.WriteLine("PLAYER 1 SCORE:" + player1Points);
      Console.WriteLine("PLAYER 2 SCORE:" + player2Points);
      }
      else if (Player2 == "rock" && Player1 == "scissors" || Player2 == "scissors" && Player1 == "paper" || Player2 == "paper" && Player1 == "rock")
      {
      Console.WriteLine("PLAYER 2 WINS");
      player2Points++;
      Console.WriteLine("PLAYER 1 SCORE:" + player1Points);
      Console.WriteLine("PLAYER 2 SCORE:" + player2Points);
      }
      else
      {
      Console.WriteLine("Wrong choice. Try again");
      }


      if (player1Points == 3)
      {
      Console.Clear ();
      Console.WriteLine("PLAYER 1 SCORE:" + player1Points);
      Console.WriteLine("PLAYER 2 SCORE:" + player2Points);
      Console.WriteLine("The winner is Player 1!");
      gameRunning = false;
      }
      else if (player2Points == 3)
      {
      Console.WriteLine("PLAYER 1 SCORE:" + player1Points);
      Console.WriteLine("PLAYER 2 SCORE:" + player2Points);
      Console.WriteLine("The winner is Player 2!");
      gameRunning = false;
      }

    }





  }
}