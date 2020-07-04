using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class Player {
protected string playerName;
    private string lastInput;

    public string PlayerName {
  get {
  return playerName;
  }
  set {
  playerName = value;
}
}

    public string LastInput { get => lastInput; set => lastInput = value; }

    public Player (bool invokeNameInput = true) {
    if (invokeNameInput) {
    SetPlayerName();
    };
  }

public void SetPlayerName () {
  Clear();
  Write("Wpisz swoje imię: ");
  playerName = ReadLine();
  }
  public Player () {
  SetPlayerName();
  }
  virtual public void GetInput (Dictionary<string, string> inputTable) {
    string rawInput;
    WriteLine ("{0}, Wybierz:", playerName);
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


