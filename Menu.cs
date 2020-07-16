using System;
using System.Collections.Generic;

namespace cSharpProject
{
    class Menu
    {
        private char _barCharacter;
        private int _menuWidth;
        private string _menuTitle;
        private List<string> _menuSelections;
        

        public Menu(char barCharacter, int menuWidth, string menuTitle, List<string> menuSelections)
        {
            _barCharacter = barCharacter;
            _menuWidth = menuWidth;
            _menuTitle = menuTitle;
            _menuSelections = menuSelections;
        }
        public void ShowMenu()
        {
            PrintBlankMenuLine();

            // Dividing the width and title width to print the title center screen.
            Console.WriteLine( new String(' ', ( _menuWidth / 2 ) - ( _menuTitle.Length / 2 ) ) + _menuTitle);

            int number = 1;
            foreach( var item in _menuSelections )
            {
                Console.WriteLine( number + ". " + item);
                number++;
            }
            PrintBlankMenuLine();
            Console.WriteLine();
            //Console.Write( "Option: ");
        }

        public string GetMenuOption()
        {
            string wrongInput = "Please enter a valid menu number";
            string output;
            int selection = 0;
            
            while(true)
            {
                Console.Write("Selection: ");
                string input = Console.ReadLine();

                try
                {
                    selection = Int16.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine(wrongInput);
                    continue;
                }

                if( selection > 0 && selection <= _menuSelections.Count )
                {
                    output = _menuSelections[selection - 1];
                    break;
                }
                else
                {
                    Console.WriteLine(wrongInput);
                }
            }

            return output;
        }

        private void PrintBlankMenuLine()
        {
            for(var num = 0; num < _menuWidth; num++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}