using System;


class Player {
   
   public string playerName;
   
   public Player (string playerName) {this.playerName = playerName;}

   public void SetPlayerName () {
      Console.Write("Please enter player name: ");
      playerName = Console.ReadLine();
}

public Player () {
  SetPlayerName();
}








}
