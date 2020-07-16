using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

abstract class Game {
    private static string gameName;
  private static string gameRules;
public string GameName { get => gameName; set => gameName = value; }
  public string GameRules { get => gameRules; set => gameRules = value; }

    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    
    public abstract void Play ();

   
}

