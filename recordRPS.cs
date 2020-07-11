using System;

class RecordRPS : IRecord{

string c_p1;
string c_p2;
string result;

public RecordRPS (string c_p1, string c_p2, string result) {
    this.c_p1 = c_p1;
    this.c_p2 = c_p2;
    this.result = result;
}

override public string ToString (){
    return string.Format("{0,20} : {1,-20}", c_p1 + " vs " + c_p2, result);
}



}