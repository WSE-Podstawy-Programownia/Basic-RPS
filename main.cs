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
    Console.Clear ();
    Console.WriteLine ("Hello Player 1, make your choice.");
    Console.WriteLine ("Press 1 for Rock, 2 for Paper or 3 for Scissors.");
    Console.WriteLine ("Press Enter to confirm your choice.");
    string p1input = Console.ReadLine();
    Choice p1;
    if (p1input == "1"){
      p1 = Choice.Rock;
    }
    else if (p1input == "2"){
      p1 = Choice.Paper;
    }
    else if (p1input == "3"){
      p1 = Choice.Scissors;
    }
    else{
      p1 = Choice.Error;
    }
    Console.Clear ();
    Console.WriteLine ("Player 1 selected {0}. Press any key to continue.", p1);
    Console.ReadKey();
    Console.Clear ();
    Console.WriteLine ("Hello Player 2, make your choice.");
    Console.WriteLine ("Press 1 for Rock, 2 for Paper or 3 for Scissors.");
    Console.WriteLine ("Press Enter to confirm your choice.");
    string p2input = Console.ReadLine();
    Choice p2;
    if (p2input == "1"){
      p2 = Choice.Rock;
    }
    else if (p2input == "2"){
      p2 = Choice.Paper;
    }
     else if (p2input == "3"){
      p2 = Choice.Scissors;
    }
    else{
      p2 = Choice.Error;
    }
    Console.Clear ();
    Console.WriteLine ("Player 2 selected {0}. Press any key to continue.", p2);
    Console.ReadKey();
    Console.Clear ();
    if (p1 == Choice.Error && p2 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("You both lose. Try correct inputs next time ;)");
    }
    else if (p1 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 2 wins. Try correct inputs next time, Player 1 ;)");
    }
    else if (p2 == Choice.Error){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins. Try correct inputs next time, Player 2 ;)");
    }
    else if (p1 == p2){
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("It's a Tie!");
    }
    else if (p1 == Choice.Rock && p2 == Choice.Scissors
    || p1 == Choice.Scissors && p2 == Choice.Paper
    || p1 == Choice.Paper && p2 == Choice.Rock)
    {
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins! Congratulations!");
    }
    else{
       Console.WriteLine ("Player 1 selected {0}", p1);
       Console.WriteLine ("Player 2 selected {0}", p2);
       Console.WriteLine ("Player 1 wins! Congratulations!");
    }
  }
}