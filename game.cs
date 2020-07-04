using System.Collections.Generic;

abstract class Game {
    protected Player playerOne, playerTwo;
    protected Dictionary<string, string> inputTable;
    public GamesRecord gamesRecord;
    public abstract string GetPlayerInput (Player player);
    public abstract void Play ();
      private static string gameName;
  private static string gameRules;
  public string GameName { get => gameName; set => gameName = value; }
  public string GameRules { get => gameRules; set => gameRules = value; }

}
