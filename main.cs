using System;
using System;

class MainClass {
  public static void Main (string[] args) {
    
    string c_p1; //inicjalizacja zmiennej dla gracza 1
    string c_p2; //inicjalizacja zmiennej dla gracza 2
    Console.WriteLine ("Welcome in RPS - Rock, Paper, Scissors"); //wiadomość powitalna
    Console.WriteLine ("Rules: Rock beats Scissors, Scissors beat Paper, Paper beats Rock");//zasady gry
    Console.WriteLine ("Player 1: choose (1)Rock, (2)Paper or (3)Scissors");//instrukcja dla pierwszego gracza
    c_p1=Console.ReadLine();//pierwszy gracz przypisuje wartość zmiennej
    Console.WriteLine ("Press any key to continue");//komunikat o końcu tury
        Console.ReadKey(); //czekanie na klawisz
    Console.Clear(); //czyszczenie ekranu
    Console.WriteLine ("Player 2: choose (1)Rock, (2)Paper or (3)Scissors");//instrukcja dla drugiego gracza
    c_p2=Console.ReadLine();//drugi gracz przypisuje wartość zmiennej
    Console.WriteLine ("Press any key to continue");//komunikat o końcu tury
    Console.ReadKey(); //czekanie na klawisz
    Console.Clear(); //czyszczenie ekranu
      if (c_p1 == c_p2) {//wszystkie remisy
        Console.WriteLine ("Remis");} 
      else if (c_p1 == "1" && c_p2 == "2"){ // gracz 1 kamien, gracz 2 papier
        Console.WriteLine ("Paper beats Rock. Player 2 wins.",c_p1,c_p2);}
      else if  (c_p1 == "1" && c_p2 == "3") {// gracz 1 kamien, gracz 2 nozyce
      Console.WriteLine ("Rock beats Scissors. Player 1 wins.",c_p1,c_p2);}
      else if (c_p1=="2" && c_p2 == "1"){ // gracz 1 papier, gracz 2 kamien
      Console.WriteLine ("Paper beats Rock. Player 1 wins.",c_p1, c_p2);}
      else if (c_p1=="2" && c_p2 == "3"){ // gracz 1 papier, gracz 2 nożyce
      Console.WriteLine ("Scissors beat Paper. Player 2 wins.",c_p1,c_p2);}
      else if (c_p1=="3" && c_p2 == "1"){ // gracz 1 nozyce gracz 2 kamien
      Console.WriteLine ("Rock beats Scissors. Player 2 wins.",c_p1,c_p2);}
      else if (c_p1=="3" && c_p2=="2") {//gracz 1 nozyce, gracz 2 papier
      Console.WriteLine ("Scissors beat Paper. Player 1 wins.", c_p1,c_p2);}



    




  }
}