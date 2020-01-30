/*
 * Author: Christian Nielsen
 * Date: 1/30/19
 * Description: Demonstration of a For Loop
 */


using System;

namespace Deliverable_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask The user of an input
            Console.WriteLine("Please enter an integer value between 1-100");

            //Use a try catch statement to catch any user errors and display an error message
            try
            {
                //This variable will hold the user input
                string input = Console.ReadLine();

                //This variable will parse the string into an integer value to be used in the for loop
                int Value_of_input = int.Parse(input);

                //Use an if else statement to test the values of the user input so that the program
                //may execute different iterative statements.
                if(Value_of_input >=1 && Value_of_input <= 100)
                {
                    Console.WriteLine("Execute For Loop");
                    
                    //For Loop//CANT FIGURE OUT HOW TO START LOOP AT 1
                    for( int i = 0; i < Value_of_input; i++) 
                    {
                        Console.WriteLine("You have entered" + " " + Value_of_input +"." + " " + 
                        "This is the current integer value in the loop: " + i.ToString());
                        
                    }

                    //Close program
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                //Else if a user does not enter a value between 1-100 display an error message
                else
                {
                    Console.WriteLine("Please enter an integer value between 1-100 and try again.");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

            }
            //Use a catch statement to display an error message if the user does not enter
            //an integer value
            catch
            {
                Console.WriteLine("Please enter an integer data type value and try again.");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
