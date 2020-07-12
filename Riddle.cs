/*
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
 class Riddle
{
    string  riddle;
    string [] answers;
    int correctAnswerIndex;

    public Riddle (string riddle, string[] answers, int correctAnswerIndex){
        this.Zagadka = riddle;
        this.answers = new string [answers.Length];
        answers.CopyTo(this.answers, 0);
        this.correctAnswerIndex = correctAnswerIndex;
    }




    public string Zagadka { get => riddle; set => riddle = value; }

public void Pytania () {

for (int i = 0; i < answers; i++){
    WriteLine ("Game #{0}:\t{1}", i+1, gamesRecord[displayRecordIndex].ToString());
    displayRecordIndex = (displayRecordIndex + 1) % gamesRecordCurrentSize;
  }

}


}
*/