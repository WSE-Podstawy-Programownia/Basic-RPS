using System.Collections.Generic;
public abstract class Game
{
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract string GetPlayerInput (Player player);
    public abstract void Play ();
}