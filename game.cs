using System.Collections.Generic;

abstract class Game {
    private static string gameName;
    private static string gameRules;
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;

    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }

    public abstract void Play ();
}