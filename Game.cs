using System.Collections.Generic;
abstract class Game
{
    private static string gameName;
    private static string gameRules;
    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }

    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GameRecord gameRecord;
    public abstract void Play();
}
