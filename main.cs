using System;



public class Program
{


  public static void Powitanie ()
  {
    Console.WriteLine("Cześć! Zagrajmy w RPS.");
    Console.WriteLine("Zasady są proste - Kamień bije Nożyce, Nożyce biją Papier, Papier bije Kamień. Wybierz figurę, która pokona figurę wybraną przez Twojego przeciwnika, żeby zyskać punkt.");
  }
  
  public static string GraczWybiera ()
  {
     string Gracz;

      Console.WriteLine("Graczu pierwszy - wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
      Gracz = Console.ReadLine();
       while (Gracz != "1" && Gracz != "2" && Gracz != "3")
        {
            Console.WriteLine("Nieprawidłowy wybór. Wybierz cyfrę od 1 do 3");
            Gracz = Console.ReadLine();
        }
          return Gracz;
  }

  public static string GraczDrugiWybiera ()
    {
      string GraczDrugi;

        Console.WriteLine("Graczu drugi - wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
        GraczDrugi = Console.ReadLine();
        while (GraczDrugi != "1" && GraczDrugi != "2" && GraczDrugi != "3")
          {
              Console.WriteLine("Nieprawidłowy wybór. Wybierz cyfrę od 1 do 3");
              GraczDrugi = Console.ReadLine();
          }
            return GraczDrugi;
    }
  public static int SprawdzenieZwyciezcy(string Gracz, string GraczDrugi)
  {
   if (Gracz == GraczDrugi)
   {
     Console.WriteLine ("Remis!");
     return 0;
   }
   else if ((Gracz == "1" && GraczDrugi == "3") ||
         (Gracz == "2" && GraczDrugi == "1") ||
         (Gracz == "3" && GraczDrugi == "2"))
         {
            Console.WriteLine ("Wygrał gracz pierwszy!");
            return 1;
         }
   else
   {
     Console.WriteLine ("Wygrał gracz drugi!");
     return 2;
   }
  }

  public static void Zagraj ()
  {
    Console.Clear();
  string Gracz = GraczWybiera();
  string GraczDrugi = GraczDrugiWybiera();
  int wygrywa = SprawdzenieZwyciezcy(Gracz, GraczDrugi);
  }

  static void WyswietlHistorieGier (string[,] wynikiGier, int WielkoscHistoriiGier, int ObecnaWielkoscHistoriiGier = 10, int OstatniWynik = 0)
  {
    int indeks;
    if (ObecnaWielkoscHistoriiGier < WielkoscHistoriiGier){
      indeks = 0;
    }
    else {
      indeks = OstatniWynik;
    }
    Console.WriteLine ("Historia gier:");
  for (int i = 0; i < ObecnaWielkoscHistoriiGier; i++)
  {
    Console.WriteLine ("Rozgrywka #{0}:\t{1}\t-\t{2},\t{3}", i+1, wynikiGier[indeks,0], wynikiGier[indeks,1], wynikiGier[indeks,2]);
    indeks = (indeks + 1) % ObecnaWielkoscHistoriiGier;
  }

  }


  public static void MenuGlowne ()
  {
  ConsoleKeyInfo inputKey;
  do 
  {
  Console.Clear();
  Console.WriteLine ("Kamień, Papier i Nożyce - Menu:\n\t[1] Zagraj\n\t[2] Zasady\n\t[3] Historia gier\n\t[ESC] Wyjście");
  inputKey = Console.ReadKey(true);
  
  if (inputKey.Key == ConsoleKey.D1)
  {
    Zagraj();
  }
  else if (inputKey.Key == ConsoleKey.D2)
  {
   Powitanie();
  }
  else if (inputKey.Key == ConsoleKey.D3)
  {
   WyswietlHistorieGier();
  }
  else { continue; }
  Console.WriteLine ("(Wybierz jedną z opcji)");
  Console.ReadKey(true);
  } while (inputKey.Key != ConsoleKey.Escape);
  }

  
  public static void Main(string[] args) 
  {
    MenuGlowne();
  } 
  }