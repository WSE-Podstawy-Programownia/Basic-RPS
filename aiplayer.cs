using System;
using System.Collections.Generic;
using System.Linq;

class AIPlayer : Player {
    // Random random;
    private static Random random = new Random ();

    // zdefiniowanie puli imion  randomowych - zadaie dodatkowe nr 2 - lab7 
    private static string[] AInames = new string [] {
      "Oin", "Gloin", "Fili", "Kili", "Thorin", "Bifur", "Bofur", "Bombur", "Dwalin", "Balin", "Ori", "Nori", "Dori"
      };
    public AIPlayer() : base(AInames[random.Next(0, AInames.Length)])
    {}

    // public AIPlayer () : base(false) {
    //   this.PlayerName += "[AI Player]";
    //   random = new Random();
    // }
    override public void GetInput (Dictionary<string, string> inputTable) {
        LastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
  }

}
