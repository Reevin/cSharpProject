using System;

namespace cSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Story first = new Story();
            Menu menu = new Menu();
            first.Sentence = "If you had made a story it would appear here.";

            while(true)
            {
                Console.Write("Tandem Story: ( 'quit' to exit. 'begin' to start a new story. 'print' to show story. ) ");
                string input = Console.ReadLine();
                
                // Exit
                if(input.ToLower().Equals("quit")) { break; }

                if(input.ToLower().Equals("begin"))
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

                if(input.ToLower().Equals("print"))
                {
                    Console.WriteLine(first.Sentence);
                    System.Console.WriteLine();
                    menu.ShowMenu();
                }
            }
        }
    }
}
