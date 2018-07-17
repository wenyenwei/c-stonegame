using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stone Game!");
            Game game = new Game();
            User user1 = new User();
            User user2 = new User();
            user1.username = game.enterPlayer(1);
            user2.username = game.ifComputerPlayer() ? "computer" : game.enterPlayer(2);
        }
    }


    class Game
    {
        // set player username
        public String enterPlayer(int index)
        {
            Console.Write("Please enter player{0} name:", index);
            String username = Console.ReadLine();
            Console.WriteLine("Welcome, {0}!", username);
            return username;
        }

        // set if with computer player
        public Boolean ifComputerPlayer()
        {
            Console.WriteLine("Do you want to battle with computer player(y/n)?");
            Console.Write(">");
            String withComputer = Console.ReadLine();
            if (ynValidator(withComputer))
                return withComputer.Equals("y") ? true : false;
            else
                return ifComputerPlayer();
              
        }

        // y/n validator
        private Boolean ynValidator(String reply){
            if (reply != null)
                if (reply.Equals("y"))
                    return true;
                else if (reply.Equals("n"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Cannot identify your input, please enter y/n");
                    return false;
                }
            else
                Console.WriteLine("Cannot identify your input, please enter y/n");
                return false;
        }
    }

    class User
    {
        public String username;
            
    }
}
