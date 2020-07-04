using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

abstract class Game {

   protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    
    public abstract void Play (); 

    private static string gameName;
    private static string gameRules;

    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }
}