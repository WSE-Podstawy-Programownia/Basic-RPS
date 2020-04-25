using System;
using static System.Console;

class MainClass {
  static void DisplayWelcomeMessage (){
  WriteLine ("Witaj w grze Kamień,Papier,Nożyce!");
}
static string GetPlayerInput (){
  string rawInput;
  string properInput="";
  WriteLine ("Wybór P1:\nk =Kamień\np = Papier\nn = Nożyce");
  rawInput = ReadLine();
  while (rawInput != "k" && rawInput != "p" && rawInput != "n") {
  WriteLine ("Błędny wybór! Spróbuj jeszcze raz. Wybór P1:\nk =Kamień\np = Papier\nn = Nożyce");
  rawInput = ReadLine();
  }

  if (rawInput == "k") { properInput = "Kamień"; }
  else if (rawInput == "p") { properInput = "Papier"; }
  else { properInput = "Nożyce"; }


return properInput;
}

static string DetermineWinner (string inputPlayerOne, string inputPlayerTwo){
if (inputPlayerOne == inputPlayerTwo){
  WriteLine ("Remis");
  return "Remis";
}
else if ((inputPlayerOne == "Kamień" && inputPlayerTwo == "Nożyce") ||
         (inputPlayerOne == "Papier" && inputPlayerTwo == "Kamień") ||
         (inputPlayerOne == "Nożyce" && inputPlayerTwo == "Papier")){
  Console.WriteLine ("Zwycięstwo gracza pierwszego");
  return "Zwycięstwo gracza pierwszego";
}
else {
  Console.WriteLine ("Zwycięstwo gracza drugiego");
  return "Zwycięstwo gracza drugiego";
}
}

static void DisplayGamesHistory (string[,] tablicawynikow, int tablicawynikowrozmiar, int tablicawynikowrozmiarobecny = 10, int ostatniwynik = 0){
  int numerpartii;
if (tablicawynikowrozmiarobecny < tablicawynikowrozmiar){
  numerpartii = 0;
}
else {
  numerpartii = ostatniwynik;
}
WriteLine ("Wyniki");
for (int i = 0; i < tablicawynikowrozmiarobecny; i++){
  WriteLine ("Gra #{0}:\t{1}\t-\t{2},\t{3}", i+1, tablicawynikow[numerpartii,0], tablicawynikow[numerpartii,1], tablicawynikow[numerpartii,2]);
  numerpartii = (numerpartii + 1) % tablicawynikowrozmiarobecny;
}
}


  public static void Main (string[] args) {

    string[,] tablicawynikow = new string[10,3];
    int numerpartii = 0;

    while(true){
    DisplayWelcomeMessage();  
    
  string inputPlayerOne = GetPlayerInput();
  tablicawynikow[numerpartii, 0] = inputPlayerOne;
  WriteLine("Naciśnij dowolny klawisz, żeby przejść do P2");
  ReadKey();
  Clear();

  string inputPlayerTwo = GetPlayerInput();
  tablicawynikow[numerpartii, 1] = inputPlayerTwo;

  tablicawynikow[numerpartii, 2] = DetermineWinner(inputPlayerOne, inputPlayerTwo);

    WriteLine("Zakończyć grę? [t]");
    string isExit = ReadLine();
    Clear();
    
    if(isExit == "t"){
      Console.WriteLine ("Wyniki:");
        for (int p = 0; p < numerpartii+1; ++p){
          
        Console.WriteLine ("Partia #{0}: {1} - {2}. Wynik: {3}",
        p+1, tablicawynikow[p,0], tablicawynikow[p,1], tablicawynikow[p,2]);
         }  
        Console.ReadLine (); {break;}
      }
    
    
    else {
    numerpartii = numerpartii+1;
    } 

  }
  }
}