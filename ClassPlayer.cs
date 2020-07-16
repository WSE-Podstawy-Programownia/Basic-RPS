using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class Player {
  protected string playerName;
    private string lastInput;

    public string PlayerName {
    get {
      return PlayerName;
    }
    set {
      PlayerName = value;
    }
  }

    public string LastInput { get => lastInput; set => lastInput = value; }

    public Player (string playerName) {
   this.PlayerName = playerName;
  }
  public void SetPlayerName () {
  Write("Please enter player name: ");
  PlayerName = ReadLine();
}
public Player (bool invokeNameInput = true) {
  if (invokeNameInput) {
    SetPlayerName();
  }
}
//Błąd StackOverflow


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
