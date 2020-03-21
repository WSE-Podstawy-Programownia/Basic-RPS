using System;
using static System.Console;
class MainClass {
  public static void Main (string[] args) {
    WriteLine("Dear player One, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
    string inputPlayerOne;
    inputPlayerOne = ReadLine ();

     if(inputPlayerOne == "1"){
      WriteLine ("PlayerOne pick Rock.");
    }
    else if(inputPlayerOne == "2"){
      WriteLine ("PlayerOne select Paper.");
    }
    else if(inputPlayerOne == "3"){
      WriteLine ("PlayerOne take Scissors.");
    }
    else {
      WriteLine ("PlayerOne Choose to die hard");
    }
    WriteLine("Select any key to continue");
    Read();
     Clear();

    WriteLine("Dear player Two, choose wisely:\n1 - Rock\n2 - Paper\n3- Scissors" );
    string inputPlayerTwo;
    inputPlayerTwo = ReadLine ();


   if(inputPlayerTwo == "1"){
      WriteLine ("PlayerOne pick Rock.");
    }
    else if(inputPlayerTwo == "2"){
      WriteLine ("PlayerOne select Paper.");
    }
    else if(inputPlayerTwo == "3"){
      WriteLine ("PlayerOne take Scissors.");
    }
    else {
      WriteLine ("PlayerTwo Choose to die hard.");
    }
    WriteLine("Select any key to know the result.");
    Read();
    Clear();

    if(inputPlayerOne == inputPlayerTwo){
  WriteLine("Draw, another time guys.");
  }

  else if((inputPlayerOne == "1" && inputPlayerTwo == "2")
  || (inputPlayerOne == "2" && inputPlayerTwo == "1")
  || (inputPlayerOne == "3" && inputPlayerTwo == "2")){ WriteLine("Dear PlayerOne you are the winner!");
  }

  else if((inputPlayerOne == "1" && inputPlayerTwo == "3")
  || (inputPlayerOne == "2" && inputPlayerTwo == "3")
  || (inputPlayerOne == "3" && inputPlayerTwo == "1")){ WriteLine("Dear PlayerTwo you are the winner!");
  };
  }
}