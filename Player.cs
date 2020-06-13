using System;
using static System.Console;




class Player {
  public string GraczImie;
  public Player (string GraczImie) {
   this.GraczImie = GraczImie;
  }

 

public void SetGraczImie () {
  Write("Proszę wprowadź imię gracza: ");
  GraczImie = ReadLine();
}

public Player () {
  SetGraczImie();
}



}
