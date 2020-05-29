using System;
 
class MainClass {



  
  // enum jako typ tylko do odczytu musi być zdefiniowany przed metodą Main
  enum Choices {
    Kamień,
    Papier,
    Nożyce
  }
 


//zdefiniowanie funkcji 
static void DisplayWelcomeMessage (){
  Console.WriteLine("Tekst który wyświetlamy na powitanie");
}



//Zadanie 1.B
static string GetPlayerInput (){
  // wnętrze funkcji
  // Variable declaration
string rawInput;
string properInput;
Console.WriteLine ("Choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
rawInput = Console.ReadLine();
//pętla
while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
  Console.WriteLine ("Wrong input. Please enter correct one.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
  rawInput = Console.ReadLine();
}
//postać opisowa
if (rawInput == "1") { properInput = "Rock"; }
else if (rawInput == "2") { properInput = "Paper"; }
else { properInput = "Scissors"; }
return properInput;
}




//Zadanie 1.C

static string DetermineWinner (string playerOne, string playerTwo){
  // wnętrze funkcji
  if (playerOne == playerTwo){
  Console.WriteLine ("It's a draw!");
  return "Draw";
}
else if ((playerOne == "Rock" && playerTwo == "Scissors") ||
         (playerOne == "Paper" && playerTwo == "Rock") ||
         (playerOne == "Scissors" && playerTwo == "Paper")){
  Console.WriteLine ("Player One won!");
  return "Player One won";
}
else {
  Console.WriteLine ("Player Two won!");
  return "Player Two won";
}

}

//Koniec Funkcji Zadania 1C



//Zadanie 1D

static void DisplayGamesHistory (string[,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0){
  // wnętrze funkcji
int currentIndex;
if (gamesRecordCurrentSize < gamesRecordSize){
  currentIndex = 0;
}
else {
  currentIndex = lastRecordIndex;
}
Console.WriteLine ("Last games history:");
for (int i = 0; i < gamesRecordCurrentSize; i++){
  Console.WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
  currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
}

}

//Koniec Zadania 1D


  public static void Main (string[] args) {
 
    //Komendy do utworzenia tablicy //zadanie 2 - zmiana na static
  static int gameRecordSize = 10;
  static string[,] gamesRecord = new string[gameRecordSize,3];
  static int gamesRecordCurrentIndex = 0;
  static int gamesRecordCurrentSize = 0;
 





//Zadanie 2b




static void MainMenuLoop (){
  // wnętrze funkcji
  ConsoleKeyInfo inputKey;
  
  do {
  Clear();
  WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
  inputKey = ReadKey(true);

if (inputKey.Key == ConsoleKey.D1){
  WriteLine("Mockup for option 1");
}
else if (inputKey.Key == ConsoleKey.D2){
 DisplayWelcomeMessage();

}
else if (inputKey.Key == ConsoleKey.D3){
  DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);

}

else { continue; }
WriteLine ("(click any key to continue)");
ReadKey(true);


} while (inputKey.Key != ConsoleKey.Escape);

}
//Zadanie 2



  
  do {
 
 

   DisplayWelcomeMessage();

   
    // Poniżej używam funkcji do wczytania klawisza z klawiatury, nie ciągu znaków
    Console.ReadKey();
string firstPlayerChoice = GetPlayerInput();
gamesRecord[gamesRecordCurrentIndex, 0] = firstPlayerChoice;
    Console.WriteLine ("Naciśnij dowolny klawisz aby kontynuować..");
    Console.ReadKey();
 
    // następnie czyścimy konsolę, żeby drugi gracz nie zobaczył wyboru pierwszego
    Console.Clear ();
   
    // drugi gracz ponawia proces pierwszego gracza
   string secondPlayerChoice = GetPlayerInput();
gamesRecord[gamesRecordCurrentIndex, 1] = secondPlayerChoice;
    // tutaj zastosujemy jedną z cech enuma, czyli jego literlną możliwość wypisania własnej nazwy
 
    Console.WriteLine ("Wybrałeś: {0}", secondPlayerChoice);
    Console.WriteLine ("Naciśnij dowolny klawisz aby kontynuować..");
    Console.ReadKey();
 
    // ponownie czyścimy konsolę przed pokazaniem wyniku
    Console.Clear ();
 
    // sprawdzamy wynik i wypisujemy na ekranie
   gamesRecord[gamesRecordCurrentIndex, 2] = DetermineWinner(firstPlayerChoice, secondPlayerChoice);

gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gameRecordSize;
if (gamesRecordCurrentSize < gameRecordSize){
  gamesRecordCurrentSize++;
}
 
 
   Console.WriteLine ("Czy chcesz zakończyć rozgrywkę? (t)");
}
while (Console.ReadLine() != "t");

    DisplayGamesHistory (gamesRecord, gameRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);
 
 
  }
  
}