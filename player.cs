using System;
using static System.Console;
using System.Collections.Generic;

class Player {
  protected string playerName;
  public string lastInput; 

  public string PlayerName {
    get {
      return playerName;
    }
    set {
      playerName = value;
    }
  }


  virtual public void GetInput (Dictionary<string, string> inputTable) {
  string rawInput;
  WriteLine ("{0}, Choose:", playerName);
  foreach(KeyValuePair<string, string> entry in inputTable) {
    WriteLine ("[{0}] {1}", entry.Key, entry.Value);
  }
  rawInput = ReadLine();
  while (!inputTable.TryGetValue(rawInput, out lastInput)) {
    WriteLine ("Wrong input. Please enter correct one.");
    rawInput = ReadLine();
  }
}


  public Player (bool invokeNameInput = true) {
  if (invokeNameInput) {
    SetPlayerName();
  }
}


  public Player (string playerName) {
    this.playerName = playerName;
  }

  public void SetPlayerName () {
    Write("Please enter player name: ");
    playerName = ReadLine();
  }

}