using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please us if you want to add or subtract: add/subtract");
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
        }
    }
}

