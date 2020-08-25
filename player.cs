using System;
using static System.Console;

class Player {
  public string playerName;
  public string lastInput; 

  public void GetInput (Dictionary<string, string> inputTable) {
    // tu będziemy uzupełniać działanie funkcji
  }


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