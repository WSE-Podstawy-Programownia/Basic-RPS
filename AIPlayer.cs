using System;
using System.Linq;

public class AIPlayer : Player
{
    Random random;

    public AIPlayer() : base(false)
    {
        this.PlayerName = "AI Player";
        random = new Random();
    }

    public override void GetInput(System.Collections.Generic.Dictionary<string, string> inputTable)
    {
        LastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
    }

}