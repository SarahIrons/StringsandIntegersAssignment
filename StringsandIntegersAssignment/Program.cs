using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StringsandIntegersAssignment
{
    //   Create a list of integers.Ask the user for a number to divide each number in the list by.Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

    //Run the code, entering in non-zero numbers as the user.Look at the displayed results.


    //Run the code again, entering in zero as the number to divide by.Note any error messages you get.


    //Run the code once again, entering in a string as the number to divide by.Note any error messages you get.


    //Now put the loop in a try/catch block.Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution.In the catch block, display the error message to the screen.Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
    class Program
    {
        

        static void Main(string[] args)
        {
            try
            {
                //Create a list of integers.
                int[] numbersList = { 22, 36, 44, 68 };
                //Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Please provide a number:");
                //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                string userNumber = Console.ReadLine();
                int inputNumber = Convert.ToInt32(userNumber);

                foreach (int number in numbersList)
                {

                    int solution = number / inputNumber;
                    Console.WriteLine("value: " + number + "/" + inputNumber + "=" + solution);
                }

            }
            catch (FormatException)

            {
                Console.WriteLine("Enter a whole number.");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero; select a different number.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            finally
            { 
              Console.WriteLine("Program exiting. Have a great day!");
            }
        
        }
    }
}
