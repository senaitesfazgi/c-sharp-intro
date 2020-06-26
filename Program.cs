using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {  
            //Guide the user
            Console.WriteLine("Please enter add/subtract/multiply/divide"); 

            //collect user input
            string userInput;
            while ((userInput = Console.ReadLine())!= "exit")//Loops.....
            {
                int firstNum;
                int secondNum;
                int result;
                //Console.WriteLine("Looping.......");

                //switch statements are similar to if/else 
                switch(userInput)   //Here we enter the value we want to enter.
                {//cases are us testing the above against specific values
                    case "add":
                        Console.WriteLine("Enter first number for addition:");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter first number for addition:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum + secondNum;
                        Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
                        break;
                    case "subtract":
                        Console.WriteLine("Enter first number for subtraction:");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter first number for subtraction:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum - secondNum;
                        Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, result);
                        break;
                    case "multiply":
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter first number for multiplication:");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum * secondNum;
                        Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, result);
                        break;
                    case "divide":
                        Console.WriteLine("enter the first number to divide");
                        firstNum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number to divide");
                        secondNum = Int32.Parse(Console.ReadLine());
                        result = firstNum / secondNum;
                        Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, result);
                        break;
                    default:
                        Console.WriteLine("Unrecognized operator entered");
                        break;
                }//end switch statement
            }
        }
    }
}

