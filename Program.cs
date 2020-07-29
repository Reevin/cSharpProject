using System;

namespace cSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Story story = new Story();

            char barCharacter = '=';
            int menuWidth = 30;
            string menuTitle = "TANDEM STORY";
            string[] menuSelections = { "Begin", "Load", "Save", "Print", "Quit", "Test" };

            Menu mainMenu = new Menu(barCharacter, menuWidth, menuTitle, menuSelections);

            story.Sentence = "If you had made a story it would appear here.";

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
                    Console.Write("Type a sentence to add to the story. ");
                    story.Sentence = Console.ReadLine();

                    while(true)
                    {
                        Console.Write("Continue... ('stop' to complete.) ");
                        input = Console.ReadLine();
                        
                        // Leave story building
                        if(input.ToLower().Equals("stop")) { break; }

                        story.AddSentence(input);
                    }
                }

                if(input.Equals("Load"))
                {
                    char barCharacter2 = '-';
                    int menuWidth2 = 20;
                    string menuTitle2 = "Saved Stories";
                    string[] menuSelections2 = StoryFileManager.GetStoryNames();
                    Menu fileMenu = new Menu(barCharacter2, menuWidth2, menuTitle2, menuSelections2);

                    fileMenu.ShowMenu();
                    string input2 = fileMenu.GetMenuOption();
                
                    story.Sentence = StoryFileManager.GetStory(input2);
                }

                if(input.Equals("Save"))
                {
                    Console.WriteLine("Warning - if your story name matches an already existing storyname it will overwrite it!");
                    Console.Write("Enter a story name to save: (or 'exit' to leave without saving) ");
                    string input3 = Console.ReadLine();
                    
                    if( !(input3.Equals("exit")) )
                    {
                        //StoryFileManager.SaveStory(input3,);
                        Console.WriteLine("Correct filename, saving not implemented.");
                    }
                    else
                    {
                        Console.WriteLine("Exited without saving.");
                    }
                }

                if(input.Equals("Print"))
                {
                    Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- --");
                    Console.WriteLine();
                    Console.WriteLine(story.Sentence);
                    Console.Write("-- Press enter to return to menu. --");
                    Console.ReadLine();
                }

                if(input.Equals("Test"))
                {
                    //Console.WriteLine("Contents of test.txt = {0}", text);

                    //foreach (string s in files)
                    //{
                    //    Console.WriteLine(System.IO.Path.GetFileName(s));
                    //}
                    //Console.WriteLine();

                    //string[] lines = { "This is the third test file.", "And the third test sentence.", "Third redundant line." };
                    // WriteAllLines creates a file, writes a collection of strings to the file,
                    // and then closes the file.  You do NOT need to call Flush() or Close().
                    //System.IO.File.WriteAllLines(@".\Stories\test3.txt", lines);

                    //string[] files = StoryFileManager.GetStoryNames();

                    //foreach (string s in files)
                    //{
                    //    Console.WriteLine(System.IO.Path.GetFileName(s));
                    //}
                    Console.WriteLine("No tests implemented.");
                }
            }
        }
    }
}