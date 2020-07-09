using System;
using System.Collections.Generic;
using System.Linq;

class AIPlayer : Player {
    Random random;

<<<<<<< HEAD
    public AIPlayer () : base(false) {
        this.playerName = "AI Player";
=======
    public AIPlayer () {
        this.playerName += " [AI Player]";
>>>>>>> 20c5dc4f8c51622fed076cf85cf304c3af48eca9
        random = new Random();
    }

    override public void GetInput (Dictionary<string, string> inputTable) {
<<<<<<< HEAD
        LastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
=======
        lastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
>>>>>>> 20c5dc4f8c51622fed076cf85cf304c3af48eca9
    }
}