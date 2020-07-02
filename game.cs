using System;
using System.Collections.Generic;
using System.Linq;

class Game {
Player playerOne, playerTwo;
 public GamesRecord gamesRecord;

  Dictionary <string, string> inputTable = new Dictionary<string, string> () 
    {
      {"1", "Rock"},
      {"2", "Paper"},
      {"3", "Scissors"}
    };


public Game () {
  playerOne = new Player ();
  playerTwo = new Player ();
  gamesRecord = new GamesRecord ();
  //MainMenuLoop ();
}
public void DisplayRules (bool withWelcomeMessage = true) {
  if (withWelcomeMessage) {
    Console.WriteLine ("Welcome to a simple Rock-Paper-Scissors game!");
  }
  Console.WriteLine ("The rules are very simple - each player chooses Rock, Paper or Scissors choice by entering the choice's number\n[1] Rock\n[2] Paper\n[3] Scissors\n and confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player repond with anything else than [y]es than the game finishes and presents the record of the last up to 10 games.\n\nHave fun!");
}

/*
stara funkcja pobierająca input gracza
public string GetPlayerInput(Player player){
       //funkcja pobierajaca input gracza

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
*/
public string DetermineWinner(Player playerOne, Player playerTwo){
        //funkcja określajaca kto wygral rozgrywke

 if (playerOne.lastInput == playerTwo.lastInput) {//wszystkie remisy
              Console.WriteLine ("It's a tie");
              return "Tie";
              }
            
            else if (playerOne.lastInput == "Rock" && playerTwo.lastInput == "Paper"){ // gracz 1 kamien, gracz 2 papier
              Console.WriteLine ("Paper beats Rock. {0} won!", playerTwo.playerName);
              return String.Format("{0} won!", playerTwo.playerName);
              }
                  
            else if  (playerOne.lastInput == "Rock" && playerTwo.lastInput == "Scissors") {// gracz 1 kamien, gracz 2 nozyce
              Console.WriteLine ("Rock beats Scissors. {0} won!", playerOne.playerName);
              return String.Format("{0} won!", playerOne.playerName);
              }

            else if (playerOne.lastInput =="Paper" && playerTwo.lastInput == "Rock"){ // gracz 1 papier, gracz 2 kamien
              Console.WriteLine ("Paper beats Rock. {0} won!", playerOne.playerName);
              return String.Format("{0} won!", playerOne.playerName);
              }
            
            else if (playerOne.lastInput =="Paper" && playerTwo.lastInput  == "Scissors"){ // gracz 1 papier, gracz 2 nożyce
              Console.WriteLine ("Scissors beat Paper. {0} won!", playerTwo.playerName);
              return String.Format("{0} won!", playerTwo.playerName);
             }
          
            else if (playerOne.lastInput =="Scissors" && playerTwo.lastInput  == "Rock"){ // gracz 1 nozyce gracz 2 kamien
              Console.WriteLine ("Rock beats Scissors. {0} won!", playerTwo.playerName);
              return String.Format("{0} won!", playerTwo.playerName);
              }
            
            else if (playerOne.lastInput == "Scissors" && playerTwo.lastInput =="Paper") {//gracz 1 nozyce, gracz 2 papier
              Console.WriteLine ("Scissors beat Paper. {0} won!", playerOne.playerName);
              return String.Format("{0} won!", playerOne.playerName);
              }

              return "";
            
}


public void Play () {

  Console.Clear ();
  //string c_p1 = GetPlayerInput(playerOne);
    playerOne.GetInput(inputTable);

  Console.Clear ();
  //string c_p2 = GetPlayerInput(playerTwo);
     playerTwo.GetInput(inputTable);


  Console.Clear ();

  //string gameResult = DetermineWinner(c_p1, c_p2);
  //gamesRecord.AddRecord(c_p1, c_p2, gameResult);
  string gameResult = DetermineWinner(playerOne, playerTwo);
  gamesRecord.AddRecord(playerOne.lastInput, playerTwo.lastInput, gameResult);

  
  
  

Console.WriteLine("Do you want to play another round? [y]");
if (Console.ReadKey(true).Key == ConsoleKey.Y){
  Play();
}
}

public void MainMenuLoop (){

      // funkcja odpowiedzialna za pętle glownego menu

  ConsoleKeyInfo inputKey;
   

  do {
     Console.Clear();
    
     Console.WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
       
      inputKey = Console.ReadKey(true);

      if (inputKey.Key == ConsoleKey.D1){
            Play();
        }

      else if (inputKey.Key == ConsoleKey.D2){
            DisplayRules(false);
        }
      else if (inputKey.Key == ConsoleKey.D3){
            gamesRecord.DisplayGamesHistory();

      }
      else { continue; }
          Console.WriteLine ("(Press any key to continue)");
            Console.ReadKey(true);

    
    } 
  while (inputKey.Key != ConsoleKey.Escape);


}
}



