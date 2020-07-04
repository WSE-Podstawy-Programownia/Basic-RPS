using System.Collections.Generic;
public abstract class Game
{
    private string gameName;
    private string gameRules;
    public string GameName { get => gameName; set => gameName = value; }
    public string GameRules { get => gameRules; set => gameRules = value; }

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