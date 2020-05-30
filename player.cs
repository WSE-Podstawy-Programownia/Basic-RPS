class Player {
  public string playerName;
   public Player (string playerName) {
   this.playerName = playerName;
  }
  public void SetPlayerName () {
    Write("Please enter player name: ");
    playerName = ReadLine();
  }
  public Player () {
    SetPlayerName();
  }
}
