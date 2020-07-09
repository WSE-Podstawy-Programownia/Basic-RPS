using System.Collections.Generic;
using static System.Console;

class Player {
<<<<<<< HEAD
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
    }
=======
  public string playerName;
  public string lastInput;
  
  public Player () {
    SetPlayerName();
>>>>>>> 20c5dc4f8c51622fed076cf85cf304c3af48eca9
  }

  public Player (string playerName) {
    this.playerName = playerName;
  }

  public void SetPlayerName () {
    Write("Please enter player name: ");
    playerName = ReadLine();
  }

  virtual public void GetInput (Dictionary<string, string> inputTable) {
    // Variable declaration
    string rawInput;

    // Prompt for input
    WriteLine ("{0}, Choose:", playerName);
    foreach(KeyValuePair<string, string> entry in inputTable) {
      WriteLine ("[{0}] {1}", entry.Key, entry.Value);
    }
    
    // Get player input
    rawInput = ReadLine();

    // Verify input and reprompt if wrong
    while (!inputTable.TryGetValue(rawInput, out lastInput)) {
      WriteLine ("Wrong input. Please enter correct one.");
      rawInput = ReadLine();
    }
  }

}