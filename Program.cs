using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string userInput = Console.ReadLine();
            if(userInput.Length > 0)
            {
                Console.WriteLine("the user entered a value");
            }
            else
            {
                Console.WriteLine("The user did enter a value");
            }
        }
    }
}

