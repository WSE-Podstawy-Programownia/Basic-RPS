using System;
using static System.Console;

class MainClass 
{
  public static void Main (string[] args) 
  {
    while(true){
      string startingScreen = "pls enter your selection: \n1 - Rock \n2 - Paper \n3 - Scissors";
      WriteLine("Player one, " + startingScreen);
      string playerOneInput;
      playerOneInput = ReadLine();

      if(playerOneInput == "1")
      {
        WriteLine("Player One selection: Rock");
      }
      else if(playerOneInput == "2")
      {
        WriteLine("Player One selection: Paper");
      }
      else if(playerOneInput == "3")
      {
        WriteLine("Player One selection: Scissors");
      }
      else 
      {
        WriteLine("Invalid Input. Try again.");
      }
      System.Console.Clear();


      WriteLine("\n");
      WriteLine("Player two, " + startingScreen)
      string playerTwoInput;
      playerTwoInput = ReadLine();

      if(playerTwoInput == "1")
      {
        WriteLine("player two choice: Rock");
      }
      else if(playerTwoInput == "2")
      {
        WriteLine("player two choice: Paper");
      }
      else if(playerTwoInput == "3")
      {
        WriteLine("player two choice: Scissors");
      }
      else 
      {
        WriteLine("Invalid Input. Try again.");
      }
      System.Console.Clear();


      if(playerOneInput == playerTwoInput)
      {
        WriteLine("Remis");
      }
      else if(playerOneInput == "1" && playerTwoInput == "2" || playerOneInput == "2" && playerTwoInput == "3" || playerOneInput == "3" && playerTwoInput == "1")
      {
        WriteLine("Player two wins!");
      }
      else if(playerOneInput == "1" && playerTwoInput == "3" || playerOneInput == "2" && playerTwoInput == "1" || playerOneInput == "3" && playerTwoInput == "2")
      {
        WriteLine("Player one wins!");
      }
      else 
      {
        WriteLine("Invalid Input. Try again.");
      }
      System.Console.Clear();
      WriteLine("Do you want to exit? [y]");
      string isExit = ReadLine();
      if(isExit == "y"){
        break;
      }
      Clear();
    }
  }
}