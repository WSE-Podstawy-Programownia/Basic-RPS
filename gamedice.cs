using System;
using System.Collections.Generic;
using System.Linq;


class GameDice :Game {

int roll_value_1;
int roll_value_2;

 public GameDice (bool singleplayer = false) {
   
  GameName = "Dice";
    
  GameRules = "The rules are very simple - each player can roll a dice or pass by enterinag a choice number\n[1] Roll\n[2] Pass\nand confirm it by clicking Enter.\nAfter both player choose, the winner is determined. After each game the application will ask the players if they want to continue, and if the player respond with anything else than [y]es than the game finishes.\n\nHave fun!";

  inputTable = new Dictionary<string, string> () {
    {"1", "Roll"},
    {"2", "Pass"},  
  };

playerOne = new Player ();
  
    if (singleplayer) playerTwo = new AIPlayer ();
  
    else playerTwo = new Player ();
  
    gamesRecord = new GamesRecord ();


}

public int Roll(Player player)
{
    if(player.LastInput == "Pass") {
        int roll_value = 0;
        return roll_value;
            
        
    }
    else {
        Random rnd = new Random();            
        int roll_value = 1 + rnd.Next(6);
        return roll_value;
        
   }

}

public string DetermineRollWinner(Player playerOne, Player playerTwo)
{
    if(roll_value_1 == roll_value_2) {
        
        Console.WriteLine ("It's a tie");
        return "Tie";

    }

    else if (roll_value_1 > roll_value_2){

            Console.WriteLine ("{0} vs {1} {2} won!", roll_value_1, roll_value_2, playerOne.PlayerName);
            
            return String.Format("{0} won!", playerOne.PlayerName);;

    }
    
    else{

        Console.WriteLine ("{0} vs {1} {2} won!", roll_value_1, roll_value_2, playerTwo.PlayerName);
            
        return String.Format("{0} won!", playerTwo.PlayerName);;

    }

}

override public void Play () {

  Console.Clear ();
 
    playerOne.GetInput(inputTable);
    roll_value_1 = Roll(playerOne);


  Console.Clear ();

     playerTwo.GetInput(inputTable);
     roll_value_2 = Roll(playerTwo);


  Console.Clear ();

  
  string gameResult = DetermineRollWinner(playerOne, playerTwo);
  

  gamesRecord.AddRecord(new RecordDice(roll_value_1, roll_value_2, gameResult));

  
  

Console.WriteLine("Do you want to play another round? [y]");
if (Console.ReadKey(true).Key == ConsoleKey.Y){
  Play();
}
}



}

