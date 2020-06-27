using System;
using System.Collections.Generic;

class AIPlayer : Player
{
    Random random;

    public AIPlayer()
    {
        this.playerName += " [AI Player]";
        random = new Random();
    }
}