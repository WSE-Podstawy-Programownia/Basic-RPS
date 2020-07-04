using System.Collections.Generic;
public abstract class Game
{
    private static string gameName;
    private static string gameRules;
    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }

    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract string GetPlayerInput(Player player);
    public abstract void Play();

    public virtual void DuelMode()
    {
        System.Console.WriteLine("Duel mode not supported for this game.");
    }
}