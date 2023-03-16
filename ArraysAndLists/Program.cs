using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] myArray01 = new int[10];
            {
                for (int i = 0; i < 10; i++)
                {
                    myArray01[i] = i + 1;
                }
















                /* Create two Lists of type int.
                 * Name one List "evens"
                 * 
                 * 
                 * Name the other List "odds"
                 * 
                 */
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();




                /* Using either a foreach or for loop,
                 * 
                 * 
                 * nest an if statement to check to see
                 *  if a number is even or odd.
                 * Then add those numbers to either the evens List
                 * or the odds List
                 */
                for (int i = 0; i < myArray01.Length; i++)
                {
                    if (myArray01[i] % 2 == 0)
                    {
                        evens.Add(myArray01[i]);
                    }
                    else
                    {
                        odds.Add(myArray01[i]);
                    }
                }


                /* Now using foreach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */
                foreach (var num1 in evens)
                {
                    Console.WriteLine(num1);
                }

                foreach (var num1 in odds)
                {
                    Console.WriteLine(num1);
                }
            }

        }
    }
}