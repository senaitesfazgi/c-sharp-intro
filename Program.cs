using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please us if you want to add, subtract, or multiply: add/subtract");
            string userOperator = Console.ReadLine();
            //Check if the user typed add
            if (userOperator == "add")
            {
                Console.WriteLine("Please the first number:");
                int firstNum = Int32.Parse(Console.ReadLine()); //Convert string to integer
                //@Link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please Enter the second number to add:");
                int secondNum = Int32.Parse(Console.ReadLine());
                //Calculate the result.
                int result = firstNum + secondNum;
                Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
            }
            else if (userOperator == "subtract")
            {
                Console.WriteLine("Please the first number:");
                int firstNum = Int32.Parse(Console.ReadLine()); //Convert string to integer
                //@Link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please Enter the second number to subtract:");
                int secondNum = Int32.Parse(Console.ReadLine());
                //Calculate the result.
                int result = firstNum - secondNum;
                Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, result);

            }
            else if (userOperator == "multiply")
            {
                Console.WriteLine("Please the first number:");
                int firstNum = Int32.Parse(Console.ReadLine()); //Convert string to integer
                //@Link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                Console.WriteLine("Please Enter the second number to :multiply");
                int secondNum = Int32.Parse(Console.ReadLine());
                //Calculate the result.
                int result = firstNum * secondNum;
                Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, result);
            }
            else
            {
                Console.WriteLine("Invalid operator entered");

            }
        }
    }
}

