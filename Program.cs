// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*
Goal: Make a program that can play tic tac toe
*/


/*
Ai move needs to:
- Output current grid
- check existing rules for known moves
- iterate through all possible moves and decide the best priotity moves
- choose a move
- start the next turn
*/
using System;


namespace TicTakToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] grid = {' ',' ',' ',' ',' ',' ',' ',' ',' '};
            // bool isPlayerFirst;
            Console.WriteLine("Would you like to go first? (yes/no)");
            string firstMoveChoice = Console.ReadLine();
            if(firstMoveChoice == "yes")
            {
                OutputGrid(grid);
                NextMovePlayer(grid, 0, true);
            }
            if(firstMoveChoice == "no")
            {
                OutputGrid(grid);
                NextMoveAI(grid,0,true);
            }
        }

        public static void NextMoveAI(char[] array, int movePriority = 0, bool isPlayerFirst = true)
            {

                return;
            }

        public static int BestMove(char[] array, int movePriority ,bool isPlayerFirst)
        {
            
            return 0;
            // returns index of best spot to move
        }
        public static void NextMovePlayer(char[] array, int movePriority = 0, bool isPlayerFirst = true)
        {

            bool invalidChoice;
            do
            {
            invalidChoice = false;
            Console.WriteLine("Please choose you next move.\nReminder the grid positions are\n 1 2 3\n 4 5 6\n 7 8 9");
            int choice = int.Parse(Console.ReadLine());
            choice--;
                if(choice < 9 && choice >= 0 && array[choice] == ' ')
                {
                    if(isPlayerFirst)
                    {
                        array[choice] = 'X';
                    }
                    else
                    {
                        array[choice] = 'O';
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid move.");
                    invalidChoice = true;
                }
            }while(invalidChoice);
            if(isWin(array, isPlayerFirst))
            {
                OutputGrid(array);
            }
            else if(!array.Contains(' '))
            {
                OutputGrid(array);
                Console.WriteLine("It's a Tie!!!!");
            }
            else
            {
                OutputGrid(array);
                // NextMoveAI(array, 0, !isPlayerFirst);     
                NextMovePlayer(array,0,!isPlayerFirst);
            }
       
        }
        public static void OutputGrid(char[] array)
        {
            Console.WriteLine($"Current Board State:");
            Console.WriteLine($"{array[0]} {array[1]} {array[2]}");
            Console.WriteLine($"{array[3]} {array[4]} {array[5]}");
            Console.WriteLine($"{array[6]} {array[7]} {array[8]}");    
        }
        public static bool isWin(char[] array, bool isPlayerFirst)
        {
            char marker = ' ';
            if(isPlayerFirst)
            {
                marker = 'X';
            }
            else
            {
                marker = 'O';
            }
            //if a win
            if(array[0] == marker && array[1]==marker && array[2]==marker)
            {return true;}
            else if(array[3] == marker && array[4]==marker && array[5]==marker)
            {return true;}
            else if(array[6] == marker && array[7]==marker && array[8]==marker)
            {return true;}
            else if(array[0] == marker && array[3]==marker && array[6]==marker)
            {return true;}
            else if(array[1] == marker && array[4]==marker && array[7]==marker)
            {return true;}
            else if(array[2] == marker && array[5]==marker && array[8]==marker)
            {return true;}
            else if(array[0] == marker && array[4]==marker && array[8]==marker)
            {return true;}
            else if(array[2] == marker && array[4]==marker && array[6]==marker)
            {return true;}
            //if a loss
            else
            {return false;}
        }
    }
}