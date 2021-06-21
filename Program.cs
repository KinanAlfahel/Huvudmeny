using System;

namespace Huvudmeny
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Hi ... you have reached the main menu.  Please select your choice from the menu.!");

            MainMenu menu = new MainMenu(); //CALL NEW MENU
            menu.Start();
        }
    }
}

