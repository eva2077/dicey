using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicey
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare roll as variable
            int rolls = 0;
            //write dialogue for game
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? : ");
            //Input number of rolls
            rolls = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("DICE ROLLING SIMULATION RESULTS \n");
            Console.Write("Each '*' represents 1% of the total number of rolls.\n");

            // display total amount of rolls
            Console.Write("Total number of rolls = " + rolls + "\n");
            //Generate random number
            Random r = new Random();
            Console.WriteLine();
            //empty array to store 12 numbers 
            int[] rollresults = new int[13];
            //declare var to store random number
            int num1, num2,totalnum;
            for (int i = 1; i <= rolls; i++)

            {
                //make two random number between 1-6
                num1 = r.Next(1, 7);
                num2 = r.Next(1, 7);
                // add two random numbers 
                totalnum = num1 + num2;
                // add to the occurence of each number
                rollresults[totalnum]++;
        
            }

            //for loop to display data for histogram
            for (int index = 0; index < 12; index++)
            {
                //if statement to only display if the number occures
                if (rollresults[index] > 0)
                {
                    //calculations for the percentages
                    double per = (((double)rollresults[index] / (double)rolls) * 100);
                    per = Math.Round(per, 0);
                    //Console.WriteLine((i + 1) + " : " + rollresults[i]);
                    //display the numbers that were rolled
                    Console.Write((index + 1) + " : ");
                    int astrick = 0;

                    //Console.Write(per);
                    //display the correct amount of astricks
                    while (astrick < per)
                    {
                        Console.Write("*");

                        astrick++;
                    }
                    Console.WriteLine();
                }

             

            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");



        }
    }
}
