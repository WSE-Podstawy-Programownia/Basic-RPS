using System.Collections.Generic;
public abstract class Game
{
    // private string gameName;
    // private string gameRules;
    public static string GameName {get; set;} //{ get => gameName; set => gameName = value; }
    public static string GameRules {get; set;}//{ get => gameRules; set => gameRules = value; }

    protected Player playerOne, playerTwo;
    protected Dictionary<int, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract int GetPlayerInput(Player player);
    public abstract void PlayGame();

    public virtual void DuelMode()
    {
        System.Console.WriteLine("Duel mode not supported for this game.");
    }
}