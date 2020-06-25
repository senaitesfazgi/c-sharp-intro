using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
            int userInt = Int32.Parse(Console.ReadLine());
            if (userInt > 10)
            {
                Console.WriteLine("Greater than 5");
            }
            else if (userInt < 0)
            {
                Console.WriteLine("Negative number");
      
            }
            else if (userInt > 5)
            {
                Console.WriteLine("Greater than 10");
      
            }
            else if (userInt > 0)
            {
                Console.WriteLine("Positive number");
      
            }
            else
            {
                Console.WriteLine("Number is betweeen 1 and 4");
            }

        }
    }
}

