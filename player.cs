using System;
using System.Collections.Generic;
using System.Linq;

class Player {
   
   public string playerName;
    public string lastInput; 

    public Player (string playerName) {this.playerName = playerName;}

   public void SetPlayerName () {
      Console.Write("Please enter player name: ");
      playerName = Console.ReadLine();
}

public Player () {
  SetPlayerName();
}

 public void GetInput (Dictionary<string, string> inputTable) {

      string rawInput;
  
      Console.WriteLine ("{0}, Choose:", playerName);
      
      foreach(KeyValuePair<string, string> entry in inputTable) {
          
          Console.WriteLine ("[{0}] {1}", entry.Key, entry.Value);
  }
  rawInput = Console.ReadLine();
  
  while (!inputTable.TryGetValue(rawInput, out lastInput)) {
    Console.WriteLine ("Wrong input. Please enter correct one.");
    rawInput = Console.ReadLine();
  }





  }






}
