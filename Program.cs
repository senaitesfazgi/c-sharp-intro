using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Please type: (add/subtract/exit)");
            string command;//declare a variable
            //accept commands
            while((command = Console.ReadLine()) != "exit") 
            {
                Console.WriteLine("Please type: (add/subtract/exit)");
                if (command == "add")
                {
                    Console.WriteLine("Enter the first number to add");
                    int firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number to add");
                    int secondNum = int.Parse(Console.ReadLine());
                    int result = Addition(firstNum,secondNum);
                    Console.WriteLine("{0} + {1} = {2}",firstNum,secondNum, result);
                }

                else if(command == "subtract")
                {
                    Console.WriteLine("Enter the first number to subtact");
                    int firstNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number to subtract");
                    int secondNum = int.Parse(Console.ReadLine());
                    int result = Subtraction(firstNum,secondNum);
                    Console.WriteLine("{0} + {1} = {2}",firstNum,secondNum, result);
                }
                else
                {
                    Console.WriteLine("Invalid input: Enter add/subtract to continue");
                }
            }  
            //this method takes two arguments and returns an integer
        static int Addition(int num1, int num2)
        //static used for independent methods
        {
            return num1 + num2;
        }  
        //this method takes two arguments and returns an integer
        static int Subtraction(int num1, int num2)
        //static used for independent methods
        {
            return num1 - num2;
        }             
        }
    }
}

