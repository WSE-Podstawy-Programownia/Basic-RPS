using System;
using static System.Console;



class GamesRecord {
   int TabelawynikowSize;
 string[,] Tabelawynikow;
 int TabelawynikowCurrentIndex;
 int TabelawynikowCurrentSize;

public GamesRecord (int recordSize = 10) {
  try {
    TabelawynikowSize = recordSize;
    Tabelawynikow = new string[TabelawynikowSize,3];
  }
  catch (OverflowException e){
    WriteLine("OverflowException during GamesRecord initialization: \"{0}\"\nrecordSize given was [{1}]\nSetting recordSize to 10", e.Message, recordSize);
  }
    TabelawynikowCurrentIndex = 0;
    TabelawynikowCurrentSize = 0;
}



public void AddRecord (string wyborgracza1, string wyborgracza2, string result) {
  Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1;
  Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2;
  Tabelawynikow[TabelawynikowCurrentIndex, 2] = result;
  
  TabelawynikowCurrentIndex = (TabelawynikowCurrentIndex + 1) % TabelawynikowSize;
  if (TabelawynikowCurrentSize < TabelawynikowSize){
    TabelawynikowCurrentSize++;
  }



 
}
 public void DisplayGamesHistory () {
  int TabelawynikowIndex;
  if (TabelawynikowCurrentSize < TabelawynikowSize){
    TabelawynikowIndex = 0;
  }
  else {
    TabelawynikowIndex = TabelawynikowCurrentIndex;
  }
  WriteLine ("Historia ostatnich gier:");
  for (int i = 0; i < TabelawynikowCurrentSize; i++){
    WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, Tabelawynikow[TabelawynikowIndex,0], Tabelawynikow[TabelawynikowIndex,1], Tabelawynikow[TabelawynikowIndex,2]);
    TabelawynikowIndex = (TabelawynikowIndex + 1) % TabelawynikowCurrentSize;
  }

}


}
