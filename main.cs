using System;
using static System.Console;
public class MainClass{
  public static void Main(string[] args) {
    
    string kolejnaGra;
  
  do{
    string rozmiarGry;
    int wielkoscGry = 0;
        Console.WriteLine("Ile gier chcesz rozegrać?");
        do {
          rozmiarGry = Console.ReadLine();
          if (!(int.TryParse(rozmiarGry, out _)))
          {
              Console.WriteLine("WPISZ LICZBE");
          }
        }while (!(int.TryParse(rozmiarGry, out wielkoscGry)));

    string[,] tablicaWynikow = new string [wielkoscGry, 3];
    
    //input gracza
        for (int i = 0; i < wielkoscGry; i++){
          string inputPlayerOne;
          string inputPlayerTwo;
                  WriteLine("Witaj graczu pierwszy! Wybierz:\n(k) Kamień\n(p) Papier\n(n) Nożyczki");
                  do{
                    inputPlayerOne = ReadLine();
                      if(inputPlayerOne != "k" && inputPlayerOne != "p" && inputPlayerOne != "n"){
                        Console.WriteLine("wcisnij klawisz k, p lub n, gnojcu");
                      }
                  }while (inputPlayerOne != "k" && inputPlayerOne != "p" && inputPlayerOne != "n");
            WriteLine("Naciśnij cokolwiek");
            
            ReadKey();
            Clear();

                WriteLine("Witaj graczu drugi! Wybierz:\n(k) Kamień\n(p) Papier\n(n) Nożyczki");
                  do{
                    inputPlayerTwo = ReadLine();
                      if(inputPlayerTwo != "k" && inputPlayerTwo != "p" && inputPlayerTwo != "n"){
                        Console.WriteLine("wcisnij klawisz k, p lub n, pajacu");
                      }
                  }while (inputPlayerTwo != "k" && inputPlayerTwo != "p" && inputPlayerTwo != "n");
            WriteLine("Naciśnij cokolwiek");
            ReadKey();
            Clear();

        // porównywanie wynikow
        if(inputPlayerOne == inputPlayerTwo){
          WriteLine("remis :(");
          
          tablicaWynikow [i, 0] = inputPlayerOne;
          tablicaWynikow [i, 1] = inputPlayerTwo;
          tablicaWynikow [i, 2] = "remis";

        }

        else if((inputPlayerOne == "k" && inputPlayerTwo == "n")
            || (inputPlayerOne == "p" && inputPlayerTwo == "k")
             || (inputPlayerOne == "n" && inputPlayerTwo == "p")){
            WriteLine("Zwycięzcą jest gracz 1!\n");

          tablicaWynikow [i, 0] = inputPlayerOne;
          tablicaWynikow [i, 1] = inputPlayerTwo;
          tablicaWynikow [i, 2] = "gracz 1";
          }

          else if((inputPlayerTwo == "k" && inputPlayerOne == "n")
        || (inputPlayerTwo == "p" && inputPlayerOne == "k")
        || (inputPlayerTwo == "n" && inputPlayerOne == "p")){
            WriteLine("Gratulacje, graczu 2. Wygrałeś.\n");

          tablicaWynikow [i, 0] = inputPlayerOne;
          tablicaWynikow [i, 1] = inputPlayerTwo;
          tablicaWynikow [i, 2] = "gracz 2";
          }
    } // for i<10
  //wyswietlanie tablicy
  for (int i = 0; i < wielkoscGry; i++){
    for (int j = 0; j < 3; j++){
      System.Console.Write(tablicaWynikow[i,j] + "    ");
    }
  System.Console.WriteLine();
  }

   WriteLine("Czy chcesz powtórzyć? [y]");
   kolejnaGra = Console.ReadLine();
  }while(kolejnaGra == "y");


  } 
}
