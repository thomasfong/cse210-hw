using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var scriptureFilePath = "scripture.txt";
        if (!File.Exists(scriptureFilePath))
        {
            Console.WriteLine("Scripture file not found.");
            return;
        }

        var scriptureLines = File.ReadAllLines(scriptureFilePath);
        var reference = new Reference("James", 1, 5);
        var scripture = new Scripture(reference, string.Join(" ", scriptureLines));

        while (!scripture.IsCompletelyHidden())
        {
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
        }

        Console.WriteLine("All words hidden. Program ended.");
    }
}