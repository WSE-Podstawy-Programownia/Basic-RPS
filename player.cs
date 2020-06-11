using System;
using static System.Console;

class Player
{
  public string playerName;
  
  private readonly int maxNameLength = 10;
  
  public void SetPlayerName ()
  {
    Write("Please enter player name: ");
    playerName = ReadLine();
  	if ( playerName.Length > maxNameLength || playerName.Length == 0 )
    {
      throw new Exception("Invalid player name");
    }
  }

  public Player ()
  {
    SetPlayerName();
  }
  
  public Player(string playerName)
  {
    playerName = playerName;
  }
  
}