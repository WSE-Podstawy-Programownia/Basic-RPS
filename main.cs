zusing System;



public class Program
{


  public static void Powitanie ()
  {
    Console.WriteLine("Cześć! Zagrajmy w RPS.");
  }
  
  public static string GraczWybiera ()
  {
     string Gracz;
     string GraczSlowo;

      Console.WriteLine("Wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
      Gracz = Console.ReadLine();
       while (Gracz != "1" && Gracz != "2" && Gracz != "3")
        {
            Console.WriteLine("Nieprawidłowy wybór. Wybierz cyfrę od 1 do 3");
            Gracz = Console.ReadLine();
        }
         if (Gracz == "1") { GraczSlowo = "Kamien"; }
        else if (Gracz == "2") { GraczSlowo = "Papier"; }
        else { GraczSlowo = "Nozyce"; }
        return Gracz;
        return GraczSlowo;
  }

  public static int PCWybiera ()
  {
    Random rnd = new Random();
    int PCyfra = rnd.Next(0, 3);
    return PCyfra;
  }

  public static int SprawdzenieZwyciezcy(string Gracz, string PCyfra)
  {
    return 0;
  }
  
  public static void Main(string[] args) 
  {
    string odp = "";
    int wynikGracz = 0;
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
        wynikGracz += 1;
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
      wynikGracz += 1; //+1 do wyniku gracza
      }
      else if (user == "1" && choices[n] == "Papier")
      {
      Console.WriteLine("Przegrałeś!");
      wynikPC += 1; //+1 do wyniku komputera
      }
      else if (user == "2" && choices[n] == "Kamień")
      {
      Console.WriteLine("Wygrałeś!");
      wynikGracz += 1;
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
      wynikGracz += 1;
      }
      else
      {

      }
      Console.WriteLine("Kontynuujesz? (TAK/NIE):");
      odp = Console.ReadLine().ToUpper();
      Console.WriteLine("---------------------------------------");
    }
    Console.WriteLine("Koniec gry!");
    Console.WriteLine("Gracz: " + wynikGracz);
    Console.WriteLine("Komputer: " + wynikPC);
  }
}

