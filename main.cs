using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args)
  {
    int gamesRecordSize = 10;
    string [,] gamesRecord = new string[gamesRecordSize,3];
    int gamesRecordCurrentIndex = 0; 
    int gamesRecordCurrentSize = 0;
    do 
    {
      string wiadomoscPowitalna = "GRACZU pierwszy, wybierz jedną z możliwości: \n1 - Kamień\n2 - Papier\n3 - Nożyce";
      WriteLine(wiadomoscPowitalna);
      string inputPlayerOne;
      inputPlayerOne = ReadLine();
      if(inputPlayerOne == "1")
      {
        WriteLine("Gracz pierwszy wybrał kamień");
      }
      else if(inputPlayerOne == "2")
      {
        WriteLine("Gracz pierwszy wybrał papier");
      }
      else if(inputPlayerOne == "3")
      {
        WriteLine("Gracz pierwszy wybrał nożyce");
      }
      else
      {
        WriteLine("Gracz wpisał coś niepoprawnego");
      }

      WriteLine("GRACZU drugi, wybierz jedną z możliwości:\n1 - Kamień\n2 - Papier\n3 - Nożyce");
      string inputPlayerTwo;
      inputPlayerTwo = ReadLine();
      
      if(inputPlayerTwo == "1")
      {
        WriteLine("Gracz drugi wybrał kamień");
      }
      else if(inputPlayerTwo == "2")
      {
        WriteLine("Gracz drugi wybrał papier");
      }
      else if(inputPlayerTwo == "3")
      {
        WriteLine("Gracz drugi wybrał nożyce");
      }
      else
      {
        WriteLine("Gracz wpisał coś niepoprawnego");
      }
      
      if(inputPlayerOne == inputPlayerTwo){
        WriteLine("Remis");
      }
      else if((inputPlayerOne == "1" && inputPlayerTwo == "3") 
      || (inputPlayerOne == "2" && inputPlayerTwo == "1")
      || (inputPlayerOne == "3" && inputPlayerTwo == "2"))
      {
        WriteLine("Zwyciestwo gracza pierwszego");
      }
      else if((inputPlayerOne == "3" && inputPlayerTwo == "1") 
      || (inputPlayerOne == "1" && inputPlayerTwo == "2")
      || (inputPlayerOne == "2" && inputPlayerTwo == "3"))
      {
        WriteLine("Zwyciestwo gracza drugi");
      }
      else
      {
        WriteLine("Wpisano niepoprawne znaki");
      }
      gamesRecord[gamesRecordCurrentIndex, 0] = inputPlayerOne;
      gamesRecord[gamesRecordCurrentIndex, 1] = inputPlayerTwo;
      gamesRecord[gamesRecordCurrentIndex, 2] = "Pierwszy";
      gamesRecord[gamesRecordCurrentIndex, 2] = "Drugi";
      gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
    
      WriteLine("Czy chcesz zakończyć grę? (t)");
    } while(Console.ReadLine() != "t");
    
    gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
    if (gamesRecordCurrentSize < gamesRecordSize)
    {
      gamesRecordCurrentSize++;
    }
    
    Clear();
    WriteLine("Tablica wyników: ");
    for (int i = 0; i < gamesRecordCurrentIndex; i++)
    {
      int currentIndex;
      if (gamesRecordCurrentSize < gamesRecordSize)
      {
        currentIndex = 0;
      }
      else
      {
        currentIndex = gamesRecordCurrentIndex;
      }

      WriteLine("Gra #{0}: {1} - {2}, wygrał gracz {3}", i+1, gamesRecord[i,0], gamesRecord[i,1], gamesRecord[i,2]);
    }
  }
}