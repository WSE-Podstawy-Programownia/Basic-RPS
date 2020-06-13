using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args){

    Game game = new Game();
  }
}


class GamesRecord {
   int TabelawynikowSize;
 string[,] Tabelawynikow;
 int TabelawynikowCurrentIndex;
 int TabelawynikowCurrentSize;

public Tabelawynikow (int recordSize = 10) {
  TabelawynikowSize = recordSize;
  Tabelawynikow = new string[TabelawynikowSize,3];
  TabelawynikowCurrentIndex = 0;
  TabelawynikowCurrentSize = 0;
}

GamesRecord gamesRecord = new GamesRecord(15);

}
