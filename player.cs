using System;
using static System.Console;

class Player
{
    public string playerName;
    public Player(string playerName)
    {
        this.playerName = playerName;
    }
    public void SetPlayerName()
    {
        do
        {
            Clear();
            Write("Please enter player name: ");
            playerName = ReadLine();
        }
        while (playerName.Length == 0 || playerName.Length > 10);
    }
    public Player()
    {
        SetPlayerName();
    }

}
