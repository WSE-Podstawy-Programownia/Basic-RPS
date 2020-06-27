using System;
using System.Collections.Generic;
using System.Linq;

class AIPlayer : Player
{
    private static Random random = new Random();

    private static string[] names = new string[]
    {
        "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Pikachu"
    };

    public AIPlayer() 
        : base(names[random.Next(0, names.Length)])
    {                
    }    

    override public void GetInput(Dictionary<string, string> inputTable)
    {
        lastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
    }
}