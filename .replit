using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraKPN
{
    class Program
    {
        static void Main(string[] args)
        {
            string gracz, komputer = null;
            int randomInt;

            bool zagpon = true;

            while (zagpon)
            {
                {


                    Console.Write("Wybierz - kamień, papier, nożyce:    ");
                    gracz = Console.ReadLine();
                    gracz = gracz.ToUpper();
                    /*wybór gracza (małe litery+polskie znaki)*/

                    Random r = new Random();

                    randomInt = r.Next(1, 4); 
                    //komputer "losuje"

                    switch (randomInt)
                    {
                        case 1: //komputer wybrał kamień
                            komputer = "kamień";
                            Console.WriteLine("Komputer wybrał kamień.");
                            if (gracz == "kamień")
                            {
                                Console.WriteLine("REMIS!");
                            }
                            else if (gracz == "papier")
                            {
                                Console.WriteLine("Wygrałeś!");
                            }
                            else if (gracz == "nożyce")
                            {
                                Console.WriteLine("Przegrałeś!");
                            }
                            break;
                        case 2: //komputer wybrał papier
                            komputer = "papier";
                            Console.WriteLine("Komputer wybrał papier.");
                            if (gracz == "papier")
                            {
                                Console.WriteLine("REMIS");
                            }
                            else if (gracz == "kamień")
                            {
                                Console.WriteLine("Przegrałeś!");
                            }
                            else if (gracz == "nożyce")
                            {
                                Console.WriteLine("Wygrałeś!");
                            }
                            break;
                        case 3: //komputer wybrał nożyce
                            komputer = "nożyce";
                            Console.WriteLine("Komputer wybrał nożyce.");
                            if (gracz == "nożyce")
                            {
                                Console.WriteLine("REMIS");
                            }
                            else if (gracz == "kamień")
                            {
                                Console.WriteLine("Wygrałeś!");
                            }
                            else if (gracz == "PAPER")
                            {
                                Console.WriteLine("Przegrałeś!");
                            }
                            break;
                        default:  /*gracz wpisał coś innego niż "kamień", "papier", "nożyce"*/
                            Console.WriteLine("Wybierz jedno: papier, kamień, nożyce.");
                            break;
                    }

                }
                Console.WriteLine("Chcesz zagrać ponownie? tak/nie");
                string loop = Console.ReadLine();
                if (loop == "tak")
                {
                    zagpon = true;
                    Console.Clear();
                }
                else if (loop == "nie")
                {
                    zagpon = false;
                }
                else
                {

                }

            }
        }
    }
}