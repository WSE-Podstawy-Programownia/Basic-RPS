using System;

namespace Players
{
    interface IPlayer
    {
        int Choose();
        bool IsValid(int input);
    }

    class HumanPlayer : IPlayer
    {

        public void Greet()
        {
            Console.WriteLine("Hello there");
        }
        public int Choose()
        {
            Console.WriteLine("Choose 1 - rock  2 - paper  3 - scissors");
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }

        public bool IsValid(int userInput)
        {
            try
            {
                if (userInput > 0 && userInput <= 3)
                    return true;
                else
                {
                    Console.WriteLine("Number not in range [1, 3]");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }

    class ComputerPlayer : IPlayer
    {
        public int Choose()
        {
            Random rand = new Random();
            int enemyChoice = rand.Next(1, 4);
            return enemyChoice;
        }

        public bool IsValid(int input)
        {
            throw new NotImplementedException();
        }
    }
}
