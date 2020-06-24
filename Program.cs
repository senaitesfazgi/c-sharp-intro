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
        }
    }
}
