using System;
using System.Linq;

public class AIPlayer : Player
{
    Random random;

    public AIPlayer()
    {
        this.playerName += " [AI Player]";
        random = new Random();
    }

    public override void GetInput(System.Collections.Generic.Dictionary<string, string> inputTable)
    {
        lastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
    }

}