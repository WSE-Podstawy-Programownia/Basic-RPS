 using System;
  using static System.Console;
class Player {
public string playerName;
public Player (string playerName) {
  this.playerName = playerName;
  }

public void SetPlayerName () {
  Write("Wpisz swoje imię: ");
  playerName = ReadLine();
  }
  public Player () {
  SetPlayerName();
  }



  





}


