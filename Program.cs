using System;

namespace IterativeStatementYuanluFang
{
    class Program
    {
        static void Main(string[] args)
        {
            //print instruction
            Console.WriteLine("Please enter a whole number between 2 and 10:");
            // declear integer
            int n;        
            string printedMessage;
            //try to sting user input into decleared integer
            int.TryParse(Console.ReadLine(), out n);
            
   
            //using given if statements to detect odd or even number
                if (n % 2 == 1)
                {
                //use For statement to print multiple lines (this for statement is specifically design for odd number)
                //this statement depends on i to print the multiple lines
                //declear a integer i to hold prefix count and asking it to start printing at 1
                // if i is smaller than user input 2-10 then continue the loop
                //Also everytime for loop runs, i will add 1 number
                for (int i = 1; i < n; i++) 
                {
                    printedMessage = i + ". You entered an odd number"; // use the string to hold i number and message
                    Console.WriteLine(printedMessage); //pring message on the screen
                    }                                      
                }
                else 
                {
                //use For statement to print multiple lines (this for statement is specifically design for even number) I also have quite a hard time to fix this for loop because I couldn't find the right i or n condition
                //this statement depends on n (a count-down method)to print the multiple lines
                //declear a integer i to hold prefix count and asking it to start printing at 1
                // if n is smaller and equal to 10 (First condition) AND if n is bigger and equal to 0 (Second condition)
                //Also everytime for loop runs, i will add 1 number
                //for loops stops at 11th because 11 > 10 (10 is the max input)
                for (int i = 1; n <= 10 && n >= 0; i++)
                    {
                        printedMessage = i + ". You entered an even number";
                        Console.WriteLine(printedMessage);
                        n--;// this is used to control n condition to makesure it is printing n (user input number) -1 lines
                        
                    }
                }
            
            
        }
    }
}
