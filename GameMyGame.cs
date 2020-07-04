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
            WriteLine(RiddlesTable.ElementAt(rand.Next(RiddlesTable.Count)));
        throw new NotImplementedException();
    }
    Dictionary<string, Riddle> RiddlesTable = new Dictionary<string, string>()
{
    {"1", new Riddle ("What is your favourite colour?")},
    {"2", "pytanie2"},
    {"3", "pytanie3"}
};

    Dictionary<string, string> RiddlesTable2 = new Dictionary<string, string>()
    {
    {"1", "a"},
    {"2", "b"},
    {"3", "c"}
};
}

