using System;
using static System.Console;
using System.Collections.Generic;

public class Player {
  protected string playerName;
  protected string lastInput;

 public string PlayerName {
    get {
      return playerName;
    }
    set {
      playerName = value;
    }
 }

 public string LastInput {
   get {
        return lastInput;
      }
 set {
      lastInput = value;
    }
 }

 public Player (string playerName) {
   this.playerName = playerName;
  }

public Player (bool invokeNameInput = true) {
  if (invokeNameInput) {
    SetPlayerName();
  }
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
