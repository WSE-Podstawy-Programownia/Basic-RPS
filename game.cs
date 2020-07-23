using static System.Console;
using System.Collections.Generic;

abstract class Game
{
    private static string gameName;

    private static string gameRules;

    

    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;

    public static string GameName { get => gameName; set => gameName = value; }
    
    public static string GameRules { get => gameRules; set => gameRules = value; }

    public abstract void Play ();


}