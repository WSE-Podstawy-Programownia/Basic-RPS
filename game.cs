using System.Collections.Generic;

abstract class Game {
    private static string gameName;
    private static string gameRules;
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }
    public GamesRecord gamesRecord;
    public abstract void Play ();
}
