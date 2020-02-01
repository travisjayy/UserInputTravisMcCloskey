using System;

namespace UserInputTravisMcCloskey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, this is Travis McCloskey :D, type something!");
            string wordsPersonTyped;
            wordsPersonTyped = Console.ReadLine();
            Console.WriteLine("Are you sure you wanted to type: " + wordsPersonTyped + "?");
        }
    }
}