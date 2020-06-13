using System;
using static System.Console;

class MainClass {
  static void Main(){
    MainMenuLoop();
  }
  static void DisplayWelcomeMessage (){
  WriteLine ("Witaj w grze papier, kamień, nożyce ;)");}

static void PlayGame (){
 Clear();


string wyborgracza1String = wyborgraczaInput("Gracz 1");
Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1String;
Clear ();
string wyborgracza2String = wyborgraczaInput("Gracz 2");
Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2String;
Clear ();
Tabelawynikow[TabelawynikowCurrentIndex, 2] = DetermineWinner(wyborgracza1String, wyborgracza2String);
TabelawynikowCurrentIndex = (TabelawynikowCurrentIndex + 1) % TabelawynikowSize;
if (TabelawynikowCurrentSize < TabelawynikowSize){
  TabelawynikowCurrentSize++;
WriteLine("Czy chcesz zagrać kolejną rundę [t]");
if (ReadKey(true).Key == ConsoleKey.T){
  PlayGame();
}


}

}





static int TabelawynikowSize = 10;
static string[,] Tabelawynikow = new string[TabelawynikowSize,3];
static int TabelawynikowCurrentIndex = 0;
static int TabelawynikowCurrentSize = 0;

static void MainMenuLoop (){

ConsoleKeyInfo inputKey;

  do {
    Clear();
    WriteLine ("Papier, kamień, nożyce Menu:\n\t[1] Zagraj\n\t[2] Pokaż zasady\n\t[3] Wyświetl historię ostatnich gier\n\t[ESC] Wyjdź");
    inputKey = ReadKey(true);
    if (inputKey.Key == ConsoleKey.D1){
    PlayGame();
  }
  else if (inputKey.Key == ConsoleKey.D2){
    DisplayWelcomeMessage();
  }
  else if (inputKey.Key == ConsoleKey.D3){
    DisplayGamesHistory (Tabelawynikow, TabelawynikowSize, TabelawynikowCurrentSize, TabelawynikowCurrentIndex);
  }

  else { continue; }
  WriteLine ("(Kliknij jakikolwiek przycisk, aby kontynuować)");
  ReadKey(true);

  } while (inputKey.Key != ConsoleKey.Escape);
}



  static void DisplayGamesHistory (string[,] Tabelawynikow, int TabelawynikowSize, int TabelawynikowCurrentSize = 10, int OstatniwynikIndex = 0){
  int currentIndex;
if (TabelawynikowCurrentSize < TabelawynikowSize){
  currentIndex = 0;
}
else {
  currentIndex = OstatniwynikIndex;
}

WriteLine ("Ostatnie wyniki:");
for (int i = 0; i < TabelawynikowCurrentSize; i++){
  WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, Tabelawynikow[currentIndex,0], Tabelawynikow[currentIndex,1], Tabelawynikow[currentIndex,2]);
  currentIndex = (currentIndex + 1) % TabelawynikowCurrentSize;
}


}


  static string wyborgraczaInput (string player){

  string rawInput;
  string properInput="";
   WriteLine ("{0} proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)", player);

    rawInput = ReadLine();


while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
  WriteLine ("Źle wprowadzona liczba. Proszę wybrać ponownie papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
  rawInput = ReadLine();
}

  if (rawInput == "1") { properInput = "Papier"; }
else if (rawInput == "2") { properInput = "Kamień"; }
else { properInput = "Nożyce"; }

return properInput;
}

static string DetermineWinner (string wyborgracza1String, string wyborgracza2String){


    if (wyborgracza1String == wyborgracza2String){
  WriteLine ("Remis");
  return "Remis";
}

else if ((wyborgracza1String == "2" && wyborgracza2String == "3") ||
         (wyborgracza1String == "1" && wyborgracza2String == "2") ||
         (wyborgracza1String == "3" && wyborgracza2String == "1")){
  Console.WriteLine ("Wygrał gracz nr 1!");
  return "Wygrał gracz nr 1";
}

else {
  Console.WriteLine ("Wygrał gracz nr 2!");
  return "Wygrał gracz nr 2";
}


}




}