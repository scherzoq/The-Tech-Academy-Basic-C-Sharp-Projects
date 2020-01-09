using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        // 1
        string[] nouns = { " shoes", " flower", " bus", " sky", " table", " phone", " hair", " fruit", " carpet", " ink" };
        
        Console.WriteLine("Enter your favorite color:");
        string color = Console.ReadLine();
        
        for (int i = 0; i < nouns.Length; i++)
        {
            nouns[i] = color + nouns[i];
        }
        
        for (int j = 0; j < nouns.Length; j++)
        {
            Console.WriteLine(nouns[j]);
        }
        Console.ReadLine();

        // 2-3
        //for (int i = 0; i > -10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.ReadLine();
        for (int i = 0; i > -10; i--)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();

        // 4
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i * i);
        }
        Console.ReadLine();

        // 5
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i * i);
        }
        Console.ReadLine();

        // 6-8
        List<string> animals = new List<string> { "lion", "elephant", "buffalo", "wildebeest", "cheetah", "rhinoceros", "leopard", "zebra", "giraffe", "gorilla", "hyena", "crocodile", "hippopotamus", "monkey" };
        bool validAnimal = false;
        Console.WriteLine("Welcome to the \"See Sharp\" Safari Tour. Please enter an animal to check if it is on our \"commonly seen animals\" list:");

        while (!validAnimal)
        {
            string userAnimal = Console.ReadLine();
                foreach (string animal in animals)
                {
                    if (userAnimal == animal)
                    {
                        Console.WriteLine("The animal you selected is on our list! List index: " + animals.IndexOf(animal));
                        validAnimal = true;
                        break;
                    }
                }
                if (!validAnimal)
                {
                    Console.WriteLine("Sorry, your animal was not found on our list. Please enter another animal.");
                }
        }
        Console.ReadLine();

        // 9-10
        List<string> pets = new List<string> { "dog", "cat", "fish", "dog", "fish", "hamster", "bird", "fish", "turtle", "fish", "fish", "bird", "snake", "guinea pig", "cat", "dog"};
        bool validPet = false;
        Console.WriteLine("Welcome to Mr. and Mrs. Petlover's store! Enter a species to see how many times it appears in the Petlovers' inventory of pets:");

        while (!validPet)
        {
            string userPet = Console.ReadLine();
                for (int i = 0; i < pets.Count; i++)
                {
                    if (pets[i] == userPet)
                        {
                            Console.WriteLine("The Petlovers have a " + userPet + "! List index: " + i);
                            validPet = true;
                        }
                }
                if (!validPet)
                {
                    Console.WriteLine("The Petowners do not have a " + userPet + ". Please try another species.");
                }
        }
        Console.ReadLine();

        // 11
        List<string> plays = new List<string>() { "Hamlet", "Romeo and Juliet", "Macbeth", "King Lear", "Hamlet", "Antony and Cleopatra", "As You Like It", "Twelfth Night", "King Lear", "Hamlet", "The Comedy of Errors", "Henry V", "Othello", "Henry V", "Richard III", "Richard III", "The Tempest", "Hamlet"};
        List<string> countedPlays = new List<string>();
        Console.WriteLine("Copies of Shakespeare plays owned by the Sharpstown library branch:");

        foreach (string play in plays)
        {
            Console.WriteLine(play);
            foreach (string countedPlay in countedPlays)
            {
                if (play == countedPlay)
                {
                    Console.WriteLine("(at least one copy of this play counted earlier!)");
                    break;
                }
            }
            countedPlays.Add(play);
        }
        Console.ReadLine();
    }
}

