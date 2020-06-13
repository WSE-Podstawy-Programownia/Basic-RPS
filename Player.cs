using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args){

    Game game = new Game();
  }
}


class Player {
  public string GraczImie;
  public Player (string GraczImie) {
   this.GraczImie = GraczImie;
  }

  public static void Main (string[] args) {
  // MainMenuLoop();
  Player Gracz1 = new Player();
 Player Gracz1 = new Player("Gracz 1");
  WriteLine(Gracz1.GraczImie);
Player Gracz2 = new Player();
WriteLine(Gracz2.GraczImie);

}

public void SetGraczImie () {
  Write("Proszę wprowadź imię gracza: ");
  GraczImie = ReadLine();
}

public Player () {
  SetGraczImie();
}



}
