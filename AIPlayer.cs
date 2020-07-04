using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class AIPlayer : Player {
Random random;
string[] imiona = new string[]{"Glados","Hal9000","SkyNet","Normandy","Conor","Alxa", "Siri"};


public AIPlayer (string playerName) : base(false) {

this.playerName = "AI Player: ";
random = new Random();

Random rnd = new Random();
int rand  = rnd.Next(0, 6);

this.playerName += imiona[rand];
random = new Random();
}



    override public void GetInput (Dictionary<string, string> inputTable) {
LastInput = inputTable.ElementAt(random.Next(inputTable.Count)).Value;
}



}