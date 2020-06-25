using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
            int  myNum = 3;
            while (myNum > 0)// Iterates/loops while the condition is TRUE.
            {
                Console.WriteLine("Current number is: {0}", myNum);
                myNum--;
            }
            /*for loop has 3 semi-colon-separated componenets:
               1)Assignement 
               2)[Termination condition]
               3)Iteration or looping
            */

            for (int i = 0; i < 5; i+=2)
            {
                Console.WriteLine("Current (for) number is: {0}", i);
            }
            //If we need to iterate through a list, use foreach!
            //@link https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
            string[] myList = {"cat", "turtle", "lizard", "frog", "dog"};
            foreach (string listItem in myList)
            {
                Console.WriteLine("Current item is {0}", listItem);
            }
        }
    }
}

