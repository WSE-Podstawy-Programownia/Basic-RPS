using System;



public class Program
{


  public static void Powitanie ()
  {
    Console.WriteLine("Cześć! Zagrajmy w RPS.");
  }
  public static int SprawdzenieZwyciestwa(string wyborGracza, string wyborPC)
  {
    return 0;
  }
  
  public static void Main(string[] args) 
  {
    string odp = "";
    int wynikuser = 0;
    int wynikPC = 0;

    Powitanie();

    while (odp != "NIE") //Główna pętla z grą
    {
      Console.WriteLine("Wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
      string[] choices = new string[3] { "Kamień", "Papier", "Nożyce" };
      Random rnd = new Random();
      int n = rnd.Next(0, 3); //Komputer losuje
      Console.WriteLine("Twój wybór:");
      string user = Console.ReadLine().ToUpper();
      Console.WriteLine("Komputer:" + choices[n]);
      int wynik = SprawdzenieZwyciestwa(user, choices[n]);
      if(wynik == 1)
      {
        Console.WriteLine("Wygrałeś!");
        wynikuser += 1;
      }
      else if(wynik == -1)
      {
        Console.WriteLine("Przegrałeś!");
        wynikPC += 1; //+1 do wyniku komputera
      }
      else if(wynik == 0)
      {
         Console.WriteLine("Remis!");
      }
      
      if (user == "1" && choices[n] == "Nożyce")
      {
      Console.WriteLine("Wygrałeś!");
      wynikuser += 1; //+1 do wyniku gracza
      }
      else if (user == "1" && choices[n] == "Papier")
      {
      Console.WriteLine("Przegrałeś!");
      wynikPC += 1; //+1 do wyniku komputera
      }
      else if (user == "2" && choices[n] == "Kamień")
      {
      Console.WriteLine("Wygrałeś!");
      wynikuser += 1;
      }
      else if (user == "2" && choices[n] == "Nożyce")
      {
      Console.WriteLine("Przegrałeś!");
      wynikPC += 1;
      }
      else if (user == "3" && choices[n] == "Kamień")
      {
      Console.WriteLine("Przegrałeś!");
      wynikPC += 1;
      }
      else if (user == "3" && choices[n] == "Papier")
      {
      Console.WriteLine("Wygrałeś!");
      wynikuser += 1;
      }
      else
      {

      }
      Console.WriteLine("Kontynuujesz? (TAK/NIE):");
      odp = Console.ReadLine().ToUpper();
      Console.WriteLine("---------------------------------------");
    }
    Console.WriteLine("Koniec gry!");
    Console.WriteLine("Gracz: " + wynikuser);
    Console.WriteLine("Komputer: " + wynikPC);
  }
}

