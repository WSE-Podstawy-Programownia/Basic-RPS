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

Tabelawynikow Tabelawynikow = new Tabelawynikow(15);

public void AddRecord (string wyborgracza1, string wyborgracza2, string result) {
  Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1;
  Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2;
  Tabelawynikow[TabelawynikowCurrentIndex, 2] = result;
  
  TabelawynikowCurrentIndex = (TabelawynikowCurrentIndex + 1) % TabelawynikowSize;
  if (TabelawynikowCurrentSize < TabelawynikowSize){
    TabelawynikowCurrentSize++;
  }



  public void DisplayGamesHistory () {
  int TabelawynikowIndex;
  if (TabelawynikowCurrentSize < TabelawynikowSize){
    displayRecordIndex = 0;
  }
  else {
    displayRecordIndex = TabelawynikowCurrentIndex;
  }
  WriteLine ("Historia ostatnich gier:");
  for (int i = 0; i < TabelawynikowCurrentSize; i++){
    WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, Tabelawynikow[displayRecordIndex,0], Tabelawynikow[displayRecordIndex,1], Tabelawynikow[displayRecordIndex,2]);
    displayRecordIndex = (displayRecordIndex + 1) % TabelawynikowCurrentSize;
  }
}

}


}
