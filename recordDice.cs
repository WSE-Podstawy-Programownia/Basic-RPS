using System;

class RecordDice : IRecord{

int roll_value_1;
int roll_value_2;
string result;

public RecordDice (int roll_value_1, int roll_value_2, string result) {
    this.roll_value_1 = roll_value_1;
    this.roll_value_2 = roll_value_2;
    this.result = result;
}

override public string ToString (){
    return string.Format("{0,20} : {1,-20}", roll_value_1 + " vs " + roll_value_2 , result);
}



}