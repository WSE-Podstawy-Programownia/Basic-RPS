using System;
using System.Collections.Generic;
using System.Linq;
class AIPlayer : Player {
  Random random;

  public AIPlayer () : base(false) {
      this.playerName = "AI Player";
      random = new Random();
  }

 
}
