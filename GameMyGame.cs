using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
class GameMyGame : Game
{
    
    public GameMyGame (){
        inputTable = new Dictionary<string, string> () 
  {
    {"1", "a"},
    {"2", "b"},
    {"3", "c"}
  };
  playerOne = new Player ();
  gamesRecord = new GamesRecord ();
    }

    public override void Play()
    { 

        
        //losuje się nowa zagadka
        //gracz wybiera odpowiedź 
        Random rand = new Random();
        Riddle obecnaZagadka = RiddlesTable.ElementAt(rand.Next(RiddlesTable.Count)).Value;
        WriteLine ("Obecnie wyświetlana zagadka [{0}]",obecnaZagadka.Zagadka);
        
/*
 ConsoleKeyInfo inputKey;
  do {
    Clear();
    
  inputKey = ReadKey(true);
    if (inputKey.Key == ConsoleKey.D1)
    {
     if (gameType[currentGameTypeIndex] == "BasicRPS")
      game = new GameRPS();
    else if (gameType[currentGameTypeIndex] == "MyNewGame")
      game = new GameMyGame();
    else
      throw new ArgumentException("Błędna Odpowiedź");
    game.Play();
    gamesRecord += game.gamesRecord;
  }

    else if (inputKey.Key == ConsoleKey.D2)
    {
    game = new GameRPS(true);
    game.Play();
    gamesRecord += game.gamesRecord;
  }
  else if (inputKey.Key == ConsoleKey.D3)
  {
    DisplayRules(game, false);
  }
*/
    }
    Dictionary<string, Riddle> RiddlesTable = new Dictionary<string, Riddle>()
{
    {"1", new Riddle ("Co oznacza skrót nazwy naszej uczelni",new string[] {"Wyższa Szkoła Europejska","Wyższa Szkoła Ekonomiczna","abc"},0)},
    {"2", new Riddle ("Na jakiej ulicy znajduje się uczelnia",new string[] {"Wyższa Szkoła Europejska","Wyższa Szkoła Ekonomiczna"},0)},
    {"3", new Riddle ("W którym roku została założona uczelnia",new string[] {"Wyższa Szkoła Europejska","Wyższa Szkoła Ekonomiczna"},0)},
};

    Dictionary<string, string> RiddlesTable2 = new Dictionary<string, string>()
    {
    {"1", "a"},
    {"2", "b"},
    {"3", "c"}
};

}



 
