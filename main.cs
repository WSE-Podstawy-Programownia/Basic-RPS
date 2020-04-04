using System;

class MainClass {
  public static void Main (string[] args) {
    
    string c_p1; //inicjalizacja zmiennej dla gracza 1
    string c_p2; //inicjalizacja zmiennej dla gracza 2
    string[,] gamesRecord = new string[10,3]; //inicjalizacja tablicy wyników
    int gamesRecordCurrentIndex = 0;
    
    do {
    
          Console.WriteLine ("Welcome in RPS - Rock, Paper, Scissors"); //wiadomość powitalna
          Console.WriteLine ("Rules: Rock beats Scissors, Scissors beat Paper, Paper beats Rock");//zasady gry
          Console.WriteLine ("Player 1: choose (1)Rock, (2)Paper or (3)Scissors");//instrukcja dla pierwszego gracza
          c_p1=Console.ReadLine();//pierwszy gracz przypisuje wartość zmiennej
          gamesRecord[gamesRecordCurrentIndex, 0] = c_p1; //wpisanie wyboru pierwszego gracza do odpowiedniego miesjca w tablicy
          Console.WriteLine ("Press any key to continue");//komunikat o końcu tury
              Console.ReadKey(); //czekanie na klawisz
          Console.Clear(); //czyszczenie ekranu
          Console.WriteLine ("Player 2: choose (1)Rock, (2)Paper or (3)Scissors");//instrukcja dla drugiego gracza
          c_p2=Console.ReadLine();//drugi gracz przypisuje wartość zmiennej
          gamesRecord[gamesRecordCurrentIndex, 1] = c_p2;//wpisanie do tablicy wyboru gracza 2 
          Console.WriteLine ("Press any key to continue");//komunikat o końcu tury
          Console.ReadKey(); //czekanie na klawisz
              Console.Clear(); //czyszczenie ekranu
            
            if (c_p1 == c_p2) {//wszystkie remisy
              Console.WriteLine ("Remis");
              gamesRecord[gamesRecordCurrentIndex, 2] = "Remis";
              }
            
            else if (c_p1 == "1" && c_p2 == "2"){ // gracz 1 kamien, gracz 2 papier
              Console.WriteLine ("Paper beats Rock. Player 2 wins.",c_p1,c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2";
              }
                  
            else if  (c_p1 == "1" && c_p2 == "3") {// gracz 1 kamien, gracz 2 nozyce
              Console.WriteLine ("Rock beats Scissors. Player 1 wins.",c_p1,c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 1";
              }

            else if (c_p1=="2" && c_p2 == "1"){ // gracz 1 papier, gracz 2 kamien
              Console.WriteLine ("Paper beats Rock. Player 1 wins.",c_p1, c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 1";
              }
            
            else if (c_p1=="2" && c_p2 == "3"){ // gracz 1 papier, gracz 2 nożyce
              Console.WriteLine ("Scissors beat Paper. Player 2 wins.",c_p1,c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2";
             }
          
            else if (c_p1=="3" && c_p2 == "1"){ // gracz 1 nozyce gracz 2 kamien
              Console.WriteLine ("Rock beats Scissors. Player 2 wins.",c_p1,c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 2";
              }
            
            else if (c_p1=="3" && c_p2=="2") {//gracz 1 nozyce, gracz 2 papier
              Console.WriteLine ("Scissors beat Paper. Player 1 wins.", c_p1,c_p2);
              gamesRecord[gamesRecordCurrentIndex, 2] = "Player 1";
              }
              gamesRecordCurrentIndex += 1;
              Console.WriteLine ("Do you want to quit? (t)");


    } while (Console.ReadLine() != "t");




  }
}