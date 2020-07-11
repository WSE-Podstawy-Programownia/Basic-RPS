using System;
using System.Collections.Generic;

class RecordRPS : IRecord {
    //eklaracja zmiennych i funkcji
    string playerOneChoice;
    string playerTwoChoice;
    string result;
    public RecordRPS (string playerOneChoice, string playerTwoChoice, string result) {
        this.playerOneChoice = playerOneChoice;
        this.playerTwoChoice = playerTwoChoice;
        this.result = result;
    }

     //dodajemy przesłonięcie funkcji ToString(), tak aby zwracała rekord w formie w jakiej chcielibyśmy go wypisać

    override public string ToString (){
    return string.Format("{0,20} : {1,-20}", playerOneChoice + " vs " + playerTwoChoice, result);
    }

}
