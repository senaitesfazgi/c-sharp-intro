using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two slashes are the beginning of a single line comment
            //We are assigning a string value to a variable
            string myName = "Senai Tesfazgi";
            /* We begin multiline comment with forward slash and asterisk

            Symbols between values and evaluations are considered "operators."
            below we areusing the addition symbol to concatenate two strings
            (Concatenation means, gluing two strings, or texts together.)

            .....and we end multi-line comments with an asterisk with a 
            followed by a forward
            */
            Console.WriteLine("Hello," + myName);

            Console.WriteLine("Please enter your name");
            //Assign a variable 'userName' to value entered by the user
            string userName = Console.ReadLine();
            Console.WriteLine("You have entered " + userName);
            //Instead of traditional concatenation usign the addition operator 
            //We can use string interpolSenaiation (place holders) to embed values in
            //a string
            //@lnk https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            Console.WriteLine("Hey {0} you are looking great today! ", userName);

            //Let's play with strings
            Console.WriteLine("Makemeuppercase".ToUpper());
            Console.WriteLine("MAKEMELOWERCASE".ToLower());
            //Takes two arguments: 1) Starting character position 2)Number of character to collect.
            Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(3, 3));
            Console.WriteLine("XYZ".Length);

        }
    }
}

