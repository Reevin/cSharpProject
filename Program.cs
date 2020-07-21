using System;
using System.Collections.Generic;

namespace cSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Story first = new Story();

            char barCharacter = '=';
            int menuWidth = 30;
            string menuTitle = "TANDEM STORY";
            List<string> menuSelections = new List<string> { "Begin", "Continue", "Print", "Quit", "Test" };

            Menu mainMenu = new Menu(barCharacter, menuWidth, menuTitle, menuSelections);

            first.Sentence = "If you had made a story it would appear here.";

            while(true)
            {
                mainMenu.ShowMenu();
                string input = mainMenu.GetMenuOption();
                
                // Exit
                if(input.Equals("Quit"))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if(input.Equals("Begin"))
                {
                    Console.Write("Type a sentence to add to the story. ('stop' to complete.) ");
                    first.Sentence = Console.ReadLine();

                    while(true)
                    {
                        Console.Write("Continue... ('stop' to complete.) ");
                        input = Console.ReadLine();
                        
                        // Leave story building
                        if(input.ToLower().Equals("stop")) { break; }

                        first.AddSentence(input);
                    }
                }

                if(input.Equals("Continue"))
                {
                    System.Console.WriteLine("Not implemented...");
                    Console.ReadLine();
                }

                if(input.Equals("Print"))
                {
                    Console.WriteLine(first.Sentence);
                    System.Console.Write("-- Press enter to return to menu. --");
                    Console.ReadLine();
                }

                if(input.Equals("Test"))
                {
                    string text = System.IO.File.ReadAllText(@".\Stories\test.txt");

                    Console.WriteLine("Contents of test.txt = {0}", text);

                    string sourcePath = @".\Stories";
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        Console.WriteLine(System.IO.Path.GetFileName(s));
                    }
                    Console.WriteLine();

                    string[] lines = { "This is the third test file.", "And the third test sentence.", "Third redundant line." };
                    // WriteAllLines creates a file, writes a collection of strings to the file,
                    // and then closes the file.  You do NOT need to call Flush() or Close().
                    System.IO.File.WriteAllLines(@".\Stories\test3.txt", lines);

                    files = System.IO.Directory.GetFiles(sourcePath);

                    foreach (string s in files)
                    {
                        Console.WriteLine(System.IO.Path.GetFileName(s));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}