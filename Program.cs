using System;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        {
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Bill");
            names.Add("Sue");

            names.ForEach(name => Console.Write(name));

            string aString ="a";
            List<string> stuff = new List<string> {aString, "b", "c", "d"};

            char singleCharacter = 'a';
            Console.WriteLine($"This is a single character: {singleCharacter}");

        int x = 5;
        int y = 7;
        int results = Adder(x,y);

        Console.WriteLine($"Results: {results}");

        }



        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}

