using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int position;
        static int win = 0;
        static void Main(string[] args)
        {
            do 
            {
                Console.Clear();
                Console.WriteLine("Player1: X and Player2: O");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2: take your turn");
                }
                else
                {
                    Console.WriteLine("Player 1: take your turn");
                }
                Board();
                position = int.Parse(Console.ReadLine());
                if (arr[position] != 'X' && arr[position] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        (arr[position]) = 'O';
                        player++;
                    }
                    else
                    {
                        arr[position] = 'X';
                        player++;
                    }
                    }
                else
                {
                    Console.WriteLine("Row {0} is already marked with {1}", position, arr[position]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 3 seconds while I reload the board.......");
                    Thread.Sleep(3000); //this will load the board after 3000 milliseconds I hope
                }
                win = Winner();// calling check win function
            }
            while (win != 1 && win != -1);
             Console.Clear();// clearing the console
            Board();// getting filled board again
            if (win == 1)
            //if win == 1 then then there is a winner
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else// if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();

            }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");


        }
        private static int Winner()
        {
            //I couldn't decide how to determine a winner. 
            //But the best of could think of was going by the possible outcomes. 
            //I know it is longer than what I probably could do, but everything else 
            //I tried did not work. 

            //horizontal outcomes:
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            //vertical outcomes:
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            //diagonal outcomes:
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            //check for draw:
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            
            else
            {
                return 0;
            }
        }
        

    }
}

