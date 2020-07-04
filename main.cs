using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    GameController gameController = new GameController();
    gameController.MainMenuLoop();
    }
}