using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class RecordLabirynt : IRecord {
int liczbakrokow = 0;
string ImieGracza;
public RecordLabirynt (string Imie, int kroki){
    liczbakrokow = kroki;
    ImieGracza = Imie;


}

override public string ToString (){
    return string.Format("{0}, wykonał {1} kroków",ImieGracza, liczbakrokow);
}


}