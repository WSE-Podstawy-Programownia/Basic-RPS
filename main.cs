using System;

class MainClass {
  

  static void DisplayWelcomeMessage() {
        
        Console.WriteLine ("Welcome in RPS - Rock, Paper, Scissors");
        Console.WriteLine ("Rules: Rock beats Scissors, Scissors beat Paper, Paper beats Rock");//zasady gry

  }

static string GetPlayerInput(){
       
       //deklaracja zmiennych funkcji
        string rawInput;
        string properInput = "";
        
        //instrukcja dla gracza
        Console.WriteLine ("Choose (1)Rock, (2)Paper or (3)Scissors");
        
        // czytanie klawisza
        rawInput = Console.ReadLine();
        
        //sprawdzanie poprawności inputu
        while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
            Console.WriteLine ("Wrong input. Please enter correct one.\nChoose:\n[1] Rock\n[2] Paper\n[3] Scissors");
            rawInput = Console.ReadLine();
        }
        if (rawInput == "1") { properInput = "Rock"; }
        else if (rawInput == "2") { properInput = "Paper"; }
        else { properInput = "Scissors"; }        
        
        return properInput;
}

static string DetermineWinner(string c_p1, string c_p2){
 
 if (c_p1 == c_p2) {//wszystkie remisy
              Console.WriteLine ("It's a tie");
              return "Tie";
              }
            
            else if (c_p1 == "Rock" && c_p2 == "Paper"){ // gracz 1 kamien, gracz 2 papier
              Console.WriteLine ("Paper beats Rock. Player 2 wins.");
              return "Player 2 won";
              }
                  
            else if  (c_p1 == "Rock" && c_p2 == "Scissors") {// gracz 1 kamien, gracz 2 nozyce
              Console.WriteLine ("Rock beats Scissors. Player 1 wins.");
             return "Player 1 won";
              }

            else if (c_p1=="Paper" && c_p2 == "Rock"){ // gracz 1 papier, gracz 2 kamien
              Console.WriteLine ("Paper beats Rock. Player 1 wins.");
              return "Player 1 won";
              }
            
            else if (c_p1=="Paper" && c_p2 == "Scissors"){ // gracz 1 papier, gracz 2 nożyce
              Console.WriteLine ("Scissors beat Paper. Player 2 wins.");
              return "Player 2 won";
             }
          
            else if (c_p1=="Scissors" && c_p2 == "Rock"){ // gracz 1 nozyce gracz 2 kamien
              Console.WriteLine ("Rock beats Scissors. Player 2 wins");
              return "Player 2 won";
              }
            
            else if (c_p1=="Scissors" && c_p2=="Paper") {//gracz 1 nozyce, gracz 2 papier
              Console.WriteLine ("Scissors beat Paper. Player 1 wins.");
              return "Player 1 won";
              }

              return "";
            
}

static void DisplayGamesHistory (string[,] gamesRecord, int gamesRecordSize, int gamesRecordCurrentSize = 10, int lastRecordIndex = 0){
int currentIndex;
if (gamesRecordCurrentSize < gamesRecordSize){
  currentIndex = 0;
}
else {
  currentIndex = lastRecordIndex;
  }

 Console.WriteLine ("The scores are:");
   for (int i = 0; i < gamesRecordCurrentSize; i++){
      Console.WriteLine ("Game #{0}:\t{1}\t-\t{2},\t{3}", i+1, gamesRecord[currentIndex,0], gamesRecord[currentIndex,1], gamesRecord[currentIndex,2]);
      currentIndex = (currentIndex + 1) % gamesRecordCurrentSize;
}

}

  
  
  public static void Main (string[] args) {
    
    string c_p1; //inicjalizacja zmiennej dla gracza 1
    string c_p2; //inicjalizacja zmiennej dla gracza 2
    int gamesRecordSize = 10;
    string[,] gamesRecord = new string[gamesRecordSize,3]; //inicjalizacja tablicy wyników
    int gamesRecordCurrentIndex = 0;
    int gamesRecordCurrentSize = 10;
    
    do {
    
          DisplayWelcomeMessage();
                 
          c_p1 = GetPlayerInput();//pierwszy gracz przypisuje wartość zmiennej
          gamesRecord[gamesRecordCurrentIndex, 0] = c_p1; //wpisanie wyboru pierwszego gracza do odpowiedniego miesjca w tablicy
          
        
          Console.Clear(); //czyszczenie ekranu
          
          c_p2=GetPlayerInput();//drugi gracz przypisuje wartość zmiennej
          gamesRecord[gamesRecordCurrentIndex, 1] = c_p2;//wpisanie do tablicy wyboru gracza 2 
          
          
              Console.Clear(); //czyszczenie ekranu
              gamesRecord[gamesRecordCurrentIndex,2]= DetermineWinner(c_p1, c_p2);
                     
              //gamesRecordCurrentIndex = (gamesRecordCurrentIndex + 1) % gamesRecordSize;
              Console.WriteLine ("Do you want to quit? (t)");

    } while (Console.ReadLine() != "t");

       DisplayGamesHistory (gamesRecord, gamesRecordSize, gamesRecordCurrentSize, gamesRecordCurrentIndex);


}

  
}