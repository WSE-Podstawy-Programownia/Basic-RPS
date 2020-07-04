using System;
using System.Collections.Generic;
using System.Text;

abstract class Game
{
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract string GetPlayerInput(Player player);
    public abstract void Play();
}