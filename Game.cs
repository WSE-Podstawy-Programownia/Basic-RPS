using System;
using static System.Console;



class Game {
  Player gracz1, gracz2;
 GamesRecord Tabelawynikow;

 public Game () {
  gracz1 = new Player ();
  gracz2 = new Player ();
  Tabelawynikow = new GamesRecord ();
}

public void DisplayRules (bool withWelcomeMessage = true) {
  if (withWelcomeMessage) {
    WriteLine ("Witaj w grze papier, kamień, nożyce!");
  }
  WriteLine ("Zasady są bardzo proste - każdy z graczy wybiera papier, kamień, nożyce poprzez kliknęcie odpowiednigo klawisza (Papier [1], Kamień [2], Nożyce [3]) i potwierdza wybór za pomocą przycisku Enter. Po tym jak obaj gracze dokonają wyboru gra wyłania zwycięzcę. Po każdej grze program zapyta graczy czy chcą kontynuować, a jeśli odpowiedzą jakimkolwiek innym przyciskiem niż [t]ak gra się zakończy i pokaże wynik ostatnich 10 gier. Powodzenia!");
}

public string GetPlayerInput (Player player){
  string rawInput;
  string properInput;
  WriteLine ("{0}, Wybierz papier {1}, kamień {2}, nożyce{3}", player.GraczImie);
  rawInput = ReadLine();
  while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
      WriteLine ("Źle wprowadzona liczba. Proszę wybrać ponownie papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
      rawInput = ReadLine();
  }
  if (rawInput == "1") { properInput = "Papier"; }
  else if (rawInput == "2") { properInput = "Kamień"; }
  else { properInput = "Nożyce"; }
  return properInput;
}

public string DetermineWinner (string wyborgracza1, string wyborgracza2){
  if (wyborgracza1 == wyborgracza2){
      WriteLine ("Remis!");
      return "Remis";
  }
  else if ((wyborgracza1 == "Papier" && wyborgracza2 == "Kamień") ||
          (wyborgracza1 == "Kamień" && wyborgracza2 == "Nożyce") ||
          (wyborgracza1 == "Nożyce" && wyborgracza2 == "Papier")){
    Console.WriteLine ("Wygrał gracz numer 1!");
    return "Wygrał gracz numer 1";
  }
  else{
    Console.WriteLine ("Wygrał gracz numer 2!");
    return "Wygrał gracz numer 2";
  }
}


}

