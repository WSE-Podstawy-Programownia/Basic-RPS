using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

abstract class Game 
{
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract void PlayGame();
}