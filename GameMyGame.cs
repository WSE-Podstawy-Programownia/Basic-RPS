using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class GameMyGame : Game
{

   
  string symbolGracza = "@";
  string ostatniePole = " ";
  int graczX = 1;
  int graczY = 10;

  bool czyMeta = true;
  
  string[] polaZakazane = { "X" };
  int kroki = 0;
  string[,] mapa = {

    {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", },
    {"X", "X", " ", " ", " ", " ", "X", "X", " ", " ", " ", "M", },
    {"X", " ", " ", "X", "X", " ", "X", " ", " ", "X", "X", "X", },
    {"X", "X", " ", " ", "X", " ", "X", "X", " ", " ", "X", "X", },
    {"X", "X", "X", " ", "X", " ", " ", "X", "X", " ", "X", "X", },
    {"X", "X", " ", " ", " ", "X", " ", " ", "X", " ", " ", "X", },
    {"X", "X", " ", "X", " ", "X", "X", " ", "X", "X", " ", "X", },
    {"X", " ", " ", "X", " ", " ", "X", " ", "x", "X", " ", "X", },
    {"X", " ", "X", "X", "X", " ", "X", " ", " ", " ", " ", "X", },
    {"X", " ", " ", " ", "X", " ", "X", " ", "X", "X", "X", "X", },
    {"X", " ", "X", " ", "X", " ", "X", " ", " ", " ", " ", "X", },
    {"X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", }
    
  };

  public GameMyGame(){
     GameName = "Labirynt";
     GameRules = "Dojdź do W";
     playerOne = new Player ();
     gamesRecord = new GamesRecord ();
  }

  public override void Play(){
        
    do{
    rysujGracza(graczX, graczY);
    rysujPlansze(mapa);
    ruchGracza();
    kroki = kroki +1;
    if(czyMeta == true)Clear();
    }while(czyMeta);
   // Clear();
   ForegroundColor = ConsoleColor.Magenta;
    WriteLine("\nGratulacje, Wygrałeś/aś/uś/oś");

    gamesRecord.AddRecord (new RecordLabirynt(playerOne.PlayerName, kroki));
    
   

  }

  public void rysujPlansze(string[,] plansza){
    for (int i = 0; i < 12; i++){
      for (int k = 0; k < 12; k++){
        Write(plansza[i, k ] + " ");
        }
        WriteLine();
    }
  }

   public void rysujGracza(int x, int y){
     
     mapa[y, x] = symbolGracza;

   }
  
    public void ruchGracza(){

      var przycisk = ReadKey(true).Key;

      if (przycisk == ConsoleKey.W){
        if(kolizja(graczY - 1,graczX)) {
        mapa[graczY, graczX] = ostatniePole;
        ostatniePole = mapa[graczY, graczX];
        graczY--; 
        }
      }
      else if (przycisk == ConsoleKey.S){
        if(kolizja(graczY + 1,graczX)) {
        mapa[graczY, graczX] = ostatniePole;
        ostatniePole = mapa[graczY, graczX];
        graczY++;
        }
      }
      else if (przycisk == ConsoleKey.A){
        if(kolizja(graczY, graczX - 1)) {
        mapa[graczY,graczX] = ostatniePole;
        ostatniePole = mapa[graczY, graczX];
        graczX--;
        }
      }
      else if (przycisk == ConsoleKey.D){
        if(kolizja(graczY, graczX + 1)) {
        mapa[graczY,graczX] = ostatniePole;
        ostatniePole = mapa[graczY, graczX];
        graczX++;
        }
      }
    }

    public bool kolizja(int y, int x){
     
      if(mapa[y,x] == "M") czyMeta = false;

      for (int i = 0; i < polaZakazane.Length; i++){
        if (mapa[y, x] == polaZakazane[i]) return false;
      }
      return true;

    }
}
