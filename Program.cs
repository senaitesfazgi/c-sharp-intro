using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {  
            //2 dimensional array!
            //string[,] list of lists
            //string[] one list
            //string one string
            string[,] topics = {{"cat","dog","frog","hedgehog"},
                                {"zebra", "giraffe", "lion", "ellephant"},
                                {"dolphin", "octopus", "sharp","whale"},
                                {"ant","bee","mosquito","fly"}};
            //we can use a foreach to iterate through the list of lists,
            //at a time
            //Loop though the rows ....
            for(int row = 0; row < topics.GetLength(0); row++)
            {
                //Output current row....
                Console.WriteLine("Starting row #{0}", row);
                //Loop through current columns
                for(int column = 0; column < topics.GetLength(1); column++)
                {
                    //Output the current animal!
                    Console.WriteLine("This animal is {0}",topics[row, column]);
                }
            }
                                 
        }
    }
}

