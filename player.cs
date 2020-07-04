using System;
using System.Collections.Generic;
using static System.Console;
class Player {
  protected string playerName;
    private string lastInput; // pole zrobimy publiczne, żeby mieć do niego dostęp z obiektu Game
    public string PlayerName {
    get {
      return playerName;
    }
    set {
      playerName = value;
    }
  }

    public string LastInput { get => lastInput; set => lastInput = value; }

    public Player (){
    SetPlayerName ();
  }
  public Player (string playerName) {
    this.playerName = playerName;
  }
  public void SetPlayerName () {
    Write("Please enter player name: ");
    playerName = ReadLine();
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
}