using System;
using System.Collections.Generic;

namespace cSharpProject
{
    class Menu
    {
        private string _menuTitle = "TANDEM STORY";
        private List<string> _menuItems = new List<string> { "Begin", "Continue", "Print", "Quit" };
        private int _menuWidth = 30;

        public Menu()
        {
            
        }
        public void ShowMenu()
        {
            PrintBlankMenuLine();

            // Dividing the width and title width to print the title center screen.
            Console.WriteLine( new String(' ', ( _menuWidth / 2 ) - ( _menuTitle.Length / 2 ) ) + _menuTitle);

            int number = 1;
            foreach( var item in _menuItems )
            {
                Console.WriteLine( number + ". " + item);
                number++;
            }
            PrintBlankMenuLine();
            Console.WriteLine();
            Console.Write( "Option: ");
        }

        private string PrintMenuLine(string item)
        {
            string output = "";

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