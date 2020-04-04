using System;
using static System.Console;

class MainClass {
  enum Choice {
    Rock,
    Paper,
    Scissors,
    Error
  }
  public static void Main (string[] args) {
    int gamesRecordSize = 10;
    string[,] gamesRecord = new string[gamesRecordSize,3];
    int gamesRecordCurrentIndex = 0;
    do {
    Console.Clear ();
    Console.WriteLine ("Hello Player 1, make your choice.");
    Console.WriteLine ("Press (1) for Rock, (2) for Paper or (3) for Scissors.");
    Console.WriteLine ("Press Enter to confirm your choice.");
    string p1input = Console.ReadLine();
    Choice p1;
    if (p1input == "1"){
      p1 = Choice.Rock;
      gamesRecord[gamesRecordCurrentIndex, 0] = "Rock";
    }
    else if (p1input == "2"){
      p1 = Choice.Paper;
      gamesRecord[gamesRecordCurrentIndex, 0] = "Paper";
    }
    else if (p1input == "3"){
      p1 = Choice.Scissors;
      gamesRecord[gamesRecordCurrentIndex, 0] = "Scissors";
    }
    else{
      p1 = Choice.Error;
      gamesRecord[gamesRecordCurrentIndex, 0] = "Error";
    }
    Console.Clear ();
    Console.WriteLine ("Player 1 selected {0}. Press any key to continue.", p1);
    Console.ReadKey();
    Console.Clear ();
    Console.WriteLine ("Hello Player 2, make your choice.");
    Console.WriteLine ("Press (1) for Rock, (2) for Paper or (3) for Scissors.");
    Console.WriteLine ("Press Enter to confirm your choice.");
    string p2input = Console.ReadLine();
    Choice p2;
    if (p2input == "1"){
      p2 = Choice.Rock;
      gamesRecord[gamesRecordCurrentIndex, 1] = "Rock";
    }
    else if (p2input == "2"){
      p2 = Choice.Paper;
      gamesRecord[gamesRecordCurrentIndex, 1] = "Paper";
    }
     else if (p2input == "3"){
      p2 = Choice.Scissors;
      gamesRecord[gamesRecordCurrentIndex, 1] = "Scissors";
    }
    else{
      p2 = Choice.Error;
      gamesRecord[gamesRecordCurrentIndex, 1] = "Error";
    }
    Console.Clear ();
    Console.WriteLine ("Player 2 selected {0}. Press any key to continue.", p2);
    Console.ReadKey();
    Console.Clear ();
    if (p1 == Choice.Error && p2 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("You both lose. Try correct inputs next time ;)");
       gamesRecord[gamesRecordCurrentIndex, 2] = "Nobody won";
    }
    else if (p1 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 2 wins. Try correct inputs next time, Player 1 ;)");
       gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2 won";
    }
    else if (p2 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins. Try correct inputs next time, Player 2 ;)");
       gamesRecord[gamesRecordCurrentIndex, 2] = "Player 1 won";
    }
    else if (p1 == p2){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("It's a Tie!");
       gamesRecord[gamesRecordCurrentIndex, 2] = "It was a tie";
    }
    else if (p1 == Choice.Rock && p2 == Choice.Scissors
    || p1 == Choice.Scissors && p2 == Choice.Paper
    || p1 == Choice.Paper && p2 == Choice.Rock)
    {
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins! Congratulations!");
       gamesRecord[gamesRecordCurrentIndex, 2] = "Player 1 won";
    }
    else{
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins! Congratulations!");
       gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2 won";
    }
    gamesRecordCurrentIndex += 1;
      Console.WriteLine ("Press (y) to finish, press eny other key to continue");

} while (Console.ReadLine() != "y");
  }
}
