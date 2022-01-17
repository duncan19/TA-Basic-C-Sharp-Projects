using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick what to add to the words");
            string addWord = Console.ReadLine();
            string[] names = { "Luke", "Hayden", "Joe" };
             foreach (string name in names)
                {
                  Console.WriteLine(name+addWord);
              }
        Console.ReadLine();

        for (int j = 0; j < 1; j++)
        {
            Console.WriteLine("hello! from j");
        }
        for (int x = 0; x <= 6; x++)
        {
            Console.WriteLine("hello! from x");
        }
        Console.WriteLine("Guess a color");
        string userColor = Console.ReadLine();
        List<string> colors = new List<string>() { "blue", "red", "green"};
        foreach (string color in colors)
        {
            if (color != userColor)
            {
                Console.WriteLine("Your color is not on the list");
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("Guess a word");
        string userWord = Console.ReadLine();
        List<string> words = new List<string>() { "go", "listen", "drive", "go" };
        int z = 0;
        for (int r = 0; r < words.Count; r++)
        {
            if (words[r] == userWord)
            {
                Console.WriteLine(r);
                 z = 3;
            }

        }
        if (z != 0)
        {
            Console.WriteLine("your word was not on the list!");
        }
        List<string> words2 = new List<string>();
        foreach (string word in words)
        {
            Console.WriteLine(word);
            bool has = words2.Contains(word);
            words2.Add(word);
            if (has)
            {
                Console.WriteLine("This word has already apeared");
            }
        }

    }
}
