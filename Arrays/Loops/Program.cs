using System;

namespace Loops
{
    class Program
    {
        /// <summary>
        /// Ask user to input some number and check, if it is integer or not
        /// </summary>
        /// <returns>Received data in integer type</returns>
        public static int ReceiveInt()
        {
            int result;
            bool dataInput;
            do{
                dataInput = int.TryParse(Console.ReadLine(), out result);  //Receive input data from the user and try to convert it to integer
                if (!dataInput) { 
                    Console.WriteLine("This is not a number. Please, try again!"); //If received data is not a number, print message and try again
                }
            }
            while (!dataInput);
            return result;
        }
        /// <summary>
        /// Check if user input is between needed range
        /// </summary>
        /// <param name="receivedMin">range minimum</param>
        /// <param name="receivedMax">range maximum</param>
        /// <returns>Input data in integer type</returns>
        public static int ReceiveCheckedInt(int receivedMin, int receivedMax)
        {
            int receivedInt;
            while (true)
            {
                receivedInt = ReceiveInt();
                if (receivedInt < receivedMin || receivedInt > receivedMax)
                {
                    Console.WriteLine($"Your number must be between {receivedMin} and {receivedMax}. Please try again!");
                }
                else
                {
                    break;
                }
            }
            return receivedInt;
        }
        static void Main(string[] args)
        {
            //Simple game: program chose regular number between 12 and 120, users chose  1, 2, 3 or 4. 
            //This number substracts from gamenumber. User, who receive 0 — wins.

            Console.WriteLine("Choose number of players (1 — with computer): ");

            int playersNumber = ReceiveInt();  //Create variable for number of players

            Console.WriteLine("Start");
            Random randomize = new Random(); //add random method
            int gameNumber = randomize.Next(12, 120); //Create random integer within 12 to 120
            string[] playerNames = new string[playersNumber]; //Create array with player names

            for (int i = 0; i < playersNumber; i++) //for every player ask his name and add it into an array
            {
                Console.WriteLine($"Input name of {i+1} player");
                playerNames[i] = Console.ReadLine();
            }

            int userTry;
            Console.WriteLine($"Game starts! Begin with {gameNumber}");

            while (gameNumber > 0)
            {
                for (int i = 0; i < playersNumber; i++) //For all players in names array
                {
                    Console.WriteLine($"Player {playerNames[i]} turn: ");
                    userTry = ReceiveCheckedInt(1, 4); //Receive number from player
                    gameNumber -= userTry; //Substract it from gamenumber
                    Console.WriteLine(gameNumber);
                    if (gameNumber <= 0)
                    {
                        Console.WriteLine($"Player {playerNames[i]} wins!");
                        break;
                    }
                    if(playersNumber == 1)
                    {
                        if (gameNumber <= 4)
                        {
                            userTry = gameNumber;
                        }
                        else
                        {
                            userTry = randomize.Next(1, 4);
                        }
                        gameNumber -= userTry; //Substract it from gamenumber
                        Console.WriteLine(gameNumber);
                        if (gameNumber <= 0)
                        {
                            Console.WriteLine($"Computer wins!");
                            break;
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
