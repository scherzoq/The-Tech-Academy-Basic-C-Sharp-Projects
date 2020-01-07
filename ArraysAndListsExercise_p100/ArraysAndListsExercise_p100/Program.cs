using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // array of strings
        string[] firstLines = new string[] { "Call me Ishmael.", "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.", "Happy families are all alike; every unhappy family is unhappy in its own way.", "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair.", "Whether I shall turn out to be the hero of my own life, or whether that station will be held by anybody else, these pages must show." };
        Console.WriteLine("Literary first lines! Enter an integer between 0 and 4 inclusive.");
        int userChoice1 = Convert.ToInt32(Console.ReadLine());
        while (userChoice1 >= firstLines.Length || userChoice1 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice1 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(firstLines[userChoice1]);
        Console.WriteLine("(Press enter to continue.)");
        Console.ReadLine();

        // array of integers
        int[] intArray = new int[] { 12, 20, 33, 42, 48 };
        Console.WriteLine("Lucky numbers! Enter an integer between 0 and 4 inclusive.");
        int userChoice2 = Convert.ToInt32(Console.ReadLine());
        while (userChoice2 >= intArray.Length || userChoice2 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(intArray[userChoice2]);
        Console.WriteLine("(Press enter to continue.)");
        Console.ReadLine();

        // list of strings
        List<string> lastLines = new List<string>();
        lastLines.Add("So we beat on, boats against the current, borne back ceaselessly into the past.");
        lastLines.Add("Who knows but that, on the lower frequencies, I speak for you?");
        lastLines.Add("He never sleeps, the judge. He is dancing, dancing. He says that he will never die.");
        lastLines.Add("\"Yes,\" I said. \"Isn’t it pretty to think so?\"");
        lastLines.Add("The rest is silence.");
        Console.WriteLine("Literary last lines! Enter an integer between 0 and 4 inclusive.");
        int userChoice3 = Convert.ToInt32(Console.ReadLine());
        while (userChoice3 >= lastLines.Count || userChoice3 < 0)
        {
            Console.WriteLine("Index does not exist! Enter an integer between 0 and 4 inclusive.");
            userChoice3 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(lastLines[userChoice3]);
        Console.Read();

    }
}
