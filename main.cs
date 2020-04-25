using System;
using static System.Console;

class MainClass 
{

  int gamesRecordSize = 10;
  string [,] gamesRecord = new string[gamesRecordSize,3];
  int gamesRecordCurrentIndex = 0; 
  int gamesRecordCurrentSize = 0;

  static void WelcomeScreen ()
  {
    WriteLine("Witaj w: kamień, papier, nożyce!");
  }
  static string GetPlayerOneInput()
  {
    string rawInput;
    string properInput;
    WriteLine ("GRACZU pierwszy, wybierz jedną z możliwości: \n1 - Kamień\n2 - Papier\n3 - Nożyce");
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3")
    {
      WriteLine ("Wpisałeś coś niepoprawnego");
    }
    if (rawInput == "1")
    {
      properInput = "Kamień";
      WriteLine("Gracz pierwszy wybrał Kamień");
    }
    else if (rawInput == "2")
    {
      properInput = "Papier";
      WriteLine("Gracz pierwszy wybrał Papier");
    }
    else if (rawInput == "3")
    {
      properInput = "Nożyce";
      WriteLine("Gracz pierwszy wybrał Nożyce");
    }
    return properInput; 
  }

  static string GetPlayerTwoInput()
  {
    string rawInput;
    string properInput;
    WriteLine ("GRACZU drugi, wybierz jedną z możliwości: \n1 - Kamień\n2 - Papier\n3 - Nożyce");
    rawInput = ReadLine();
    while (rawInput != "1" && rawInput != "2" && rawInput != "3")
    {
      WriteLine ("Wpisałeś coś niepoprawnego");
    }
    if (rawInput == "1")
    {
      properInput = "Kamień";
      WriteLine("Gracz drugi wybrał Kamień");
    }
    else if (rawInput == "2")
    {
      properInput = "Papier";
      WriteLine("Gracz drugi wybrał Papier");
    }
    else if (rawInput == "3")
    {
      properInput = "Nożyce";
      WriteLine("Gracz drugi wybrał Nożyce");
    }
    return properInput; 
  }

  static string WhoWon (string playerOne, string playerTwo)
  {
    if(playerOne == playerTwo)
      {
        WriteLine("Remis");
        return "Remis";
      }
      else if((playerOne == "Kamień" && inputPlayerTwo == "Nożyce") 
      || (inputPlayerOne == "Papier" && inputPlayerTwo == "Kamień")
      || (inputPlayerOne == "Nożyce" && inputPlayerTwo == "Papier"))
      {
        WriteLine("Zwyciestwo gracza pierwszego");
        return "Pierwszy";
      }
      else
      {
        WriteLine("Zwyciestwo gracza drugiego");
        return "Drugi";
      }
  }

  static void ScoreHistory (string [,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0)
  {
    int currentIndex; 
    if (gamesRecordCurrentSize < gamesRecordSize)
    {
      currentIndex = 0; 
    }
    else 
    {
      currentIndex = lastRecordIndex;
    }
    WriteLine("Tablica wyników: ");
    for (int i = 0; i < gamesRecordCurrentIndex; i++)
    {
      WriteLine("Game #{0}: \t{1}\t-\t{2}, \t{3}", i+1, gamesRecord[currentIndex, 0], gamesRecord[currentIndex, 1], gamesRecord[currentIndex, 2]);
      currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
    }
  }

  public static void Main (string[] args)
  {
    do 
    {
      WelcomeScreen();

      string inputPlayerOne = GetPlayerOneInput();
      gamesRecord[gamesRecordCurrentIndex, 0] = inputPlayerOne;

      string inputPlayerTwo = GetPlayerTwoInput;
      gamesRecord[gamesRecordCurrentIndex, 1] = inputPlayerTwo;

      WhoWon();
      gamesRecord[gamesRecordCurrentIndex, 2] = WhoWon(inputPlayerOne, inputPlayerTwo);
    
      WriteLine("Czy chcesz zakończyć grę? (t)");
    } while(Console.ReadLine() != "t");
    
    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    if (gamesRecordCurrentSize < gamesRecordSize)
    {
      gamesRecordCurrentSize++;
    }
    Clear();

    ScoreHistory (gamesRecord, gamesRecordCurrentSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);

      WriteLine("Gra #{0}: {1} - {2}, wygrał gracz {3}", i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
    }
  }
}