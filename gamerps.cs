using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class GameRPS : Game {



 public GameRPS (bool singleplayer = false) {
   GameName = "Kamień-Papier-Nożyce";
   GameRules = "\n\n Zasady gry są proste!\n Gracz Pierwszy wybiera: [1] Kamień lub [2] Papier lub [3] Nożyce\n Gracz Drugi wybiera: [1] Kamień lub [2] Papier lub [3] Nożyce\n\n *Pamiętajcie aby nie podglądać!\n\nWygrywa ten który wybrał silniejszy artefakt!\n\nDla przypomnienia:\n Nożycze niszczą Papier\n Papier neutralizuje Kamień\n Kamień tępi Nożyce\n\nPowodzenia!\n ";
   inputTable = new Dictionary<string, string> ()
{
{"1", "Kamień"},
{"2", "Papier"},
{"3", "Nożyce"}
};
  playerOne = new Player ();
  if (singleplayer) playerTwo = new AIPlayer ("");
  else playerTwo = new Player ();
  gamesRecord = new GamesRecord ();
}
  
   string DetermineWinner (){

    if (playerOne.LastInput == playerTwo.LastInput){ 
      WriteLine ("Remis!"); 
      return "Remis";
      } 
      else if ((playerOne.LastInput == "Kamień" && playerTwo.LastInput == "Nożyce") || 
      (playerOne.LastInput == "Papier" && playerTwo.LastInput == "Kamień") || 
      (playerOne.LastInput == "Nożyce" && playerTwo.LastInput == "Papier")){ 
      WriteLine ("Zwycięża " + playerOne.PlayerName);
      return String.Format ("Zwycięża " + playerOne.PlayerName);; 
      }
      else { 
      WriteLine ("Zwycięża " + playerTwo.PlayerName); 
      return String.Format ("Zywcięża " + playerTwo.PlayerName); }
      } 

  public override void Play () {
    Console.Clear();
    playerOne.GetInput(inputTable);
    Clear();
    WriteLine ("Wybrałeś: " + playerOne.LastInput + "\nWciśniej dowolny przycisk, aby kontynuować");
    Console.ReadKey();
    Clear();
    playerTwo.GetInput(inputTable);
    Clear();
    WriteLine ("Wybrałeś: " + playerTwo.LastInput + "\nWciśniej dowolny przycisk, aby kontynuować");
    Console.ReadKey();
    Clear();

    string gameResult = DetermineWinner();

    gamesRecord.AddRecord (playerOne.LastInput, playerTwo.LastInput, gameResult);

    WriteLine("Czy chcesz rozegrać kolejną rundę? Jeśli tak wciśnij [y] \n\nAby zakończyć rozgrywkę wciśnij dowolny przycisk"); 
    if (ReadKey(true).Key == ConsoleKey.Y){
    Play();
    }
  }




  

}