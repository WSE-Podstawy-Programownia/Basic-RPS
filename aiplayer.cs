using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class AIPlayer : Player 
{
 Random random;

 override public void GetInput (Dictionary<string, string> inputTable) {
    lastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
  }


  public AIPlayer () {
      this.playerName += " [AI Player]";
      random = new Random();
  }
   
}
