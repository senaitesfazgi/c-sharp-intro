using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {
        //Logical operators.
        //OR will evaluate true if either side is TRUE
        Console.WriteLine(true || true); // True  // || is OR
        Console.WriteLine(false || true);//True
        Console.WriteLine(false || false);//False

        //And will evaluate true if bothe sides are TRUE
        Console.WriteLine(true && true); //TRUE  // && is AND
        Console.WriteLine(false && true);//False
        Console.WriteLine(false && false);//False

        // How does this behave with different datatypes?
        //Console.WriteLine(true && 1); // It DOESN't go!

        //Comparative Operators...
        //"Equal to" check
        //"==" is for Checking if they are equal
        Console.WriteLine(false == false); //True.
        Console.WriteLine(true == false); //false.
        Console.WriteLine(2.25 == 2.25); //True.
        Console.WriteLine(2.25 == 3.14); //True.
       // Console.WriteLine(2.25 == "3.14");  // Cannot check two diff. types!

       //"Greater than" check.
       Console.WriteLine(6 > 7); // False
       Console.WriteLine(10 > 5); //True

       //"Less than" check.
       Console.WriteLine(6 < 7); //True
       Console.WriteLine(10 < 5); //False

       //'Greater-than-or-equal-to" check
       Console.WriteLine(5 >= 5);//True
       Console.WriteLine(10 >= 5);//True
       Console.WriteLine(4 >= 5);//False

       //"Less-than-or-equal-to" check
       Console.WriteLine(5 <= 5);//True
       Console.WriteLine(10 <= 5);//False
       Console.WriteLine(4 <= 5);//True

       //"NOT equal to " check
       Console.WriteLine(false != false); //False
       Console.WriteLine(true != false); //True
       Console.WriteLine(5 != 5); //False
       Console.WriteLine(5 != 10); //True





        }
    }
}

