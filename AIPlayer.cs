using System;
using System.Linq;

public class AIPlayer : Player
{
    Random random;

    public AIPlayer() : base(false)
    {
        this.playerName = "AI Player";
        random = new Random();
    }

    public override void GetInput(System.Collections.Generic.Dictionary<int, string> inputTable)
    {
        LastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
    }

}