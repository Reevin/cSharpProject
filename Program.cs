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
            List<string> menuSelections = new List<string> { "Begin", "Continue", "Print", "Quit" };

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
            }
        }
    }
}
