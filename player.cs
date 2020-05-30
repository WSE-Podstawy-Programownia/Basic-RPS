using System;
using static System.Console;

class Player {
  public string playerName;
  
  public Player () {
    SetPlayerName();
  }

  public Player (string playerName) {
    this.playerName = playerName;
  }

  public void SetPlayerName () {
    Write("Please enter player name: ");
    playerName = ReadLine();
  }

}