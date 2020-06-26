using System;

namespace c_sharp_intro
{
    class Program
    {
        public static object Cosnsole { get; private set; }

        static void Main(string[] args)
        {  
            //2 dimensional array!
            //string[,] list of lists
            //string[] one list
            //string one string
            string[,] topics = {{"cat","dog","frog","hedgehog"},
                                {"zebra", "giraffe", "lion", "ellephant"},
                                {"dolphin", "octopus", "sharp","whale"}};
            //we can use a foreach to iterate through the list of lists,
            //at a time
            foreach( string topic in topics)
            {
                //Loop through this specific 
                    Console.WriteLine("This animal is {0}", topic);
            }
                                 
        }
    }
}

