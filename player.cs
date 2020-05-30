using System;
using static System.Console;
class Player {
  public string playerName;

public void SetPlayerName (){
  Write("Please enter player name: ");
  playerName = ReadLine();
}
public Player () {
  SetPlayerName();
}
}
