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

      Console.WriteLine("Wybierz jedno: \n1->Kamień\n2->Papier\n3->Nożyce");
      Gracz = Console.ReadLine();
       while (Gracz != "1" && Gracz != "2" && Gracz != "3")
        {
            Console.WriteLine("Nieprawidłowy wybór. Wybierz cyfrę od 1 do 3");
            Gracz = Console.ReadLine();
        }
          return Gracz;
  }

  public static int PCWybiera ()
  {
    Random rnd = new Random();
    int PCyfra = rnd.Next(0, 3);
    return PCyfra;
  }

  public static int SprawdzenieZwyciezcy(string Gracz, string PCyfra)
  {
   if (Gracz == PCyfra)
   {
     Console.WriteLine ("Remis!");
     return 0;
   }
   else if ((Gracz == "1" && PCyfra == "3") ||
         (Gracz == "2" && PCyfra == "1") ||
         (Gracz == "3" && PCyfra == "2"))
         {
            Console.WriteLine ("Wygrałeś!");
            return 1;
         }
   else
   {
     Console.WriteLine ("Przegrałeś!");
     return 2;
   }
  }

  public static void Zagraj ()
  {
    Console.Clear();
  string Gracz = GraczWybiera();
  int PCyfra = PCWybiera();
  int wygrywa = SprawdzenieZwyciezcy(Gracz, PCyfra);
  }






  public static void MenuGlowne ()
  {
  ConsoleKeyInfo inputKey;
  do 
  {
  Console.Clear();
  Console.WriteLine ("Kamień, Papier i Nożyce - Menu:\n\t[1] Zagraj\n\t[2] Zasady\n\t[ESC] Wyjście");
  inputKey = Console.ReadKey(true);
  
  if (inputKey.Key == ConsoleKey.D1){
  Console.WriteLine("Opcja pierwsza");
  }
  else if (inputKey.Key == ConsoleKey.D2){
  Powitanie();
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