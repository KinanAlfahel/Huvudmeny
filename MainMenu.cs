﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huvudmeny
{
    class MainMenu
    {
        public int Selection;

        public void Start()
        {

            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("                  MAIN MENU                  ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("   Ungdom eller pensionär                 :1 ");
            Console.WriteLine("   Upprepa tio gånger                     :2 ");
            Console.WriteLine("   Det tredje ordet                       :3 ");
            Console.WriteLine("   Exit the Program                       :0 ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter Your Choice: ");

            string SelectionNumber;
            SelectionNumber = Console.ReadLine();
            if (SelectionNumber.GetType() == typeof(string))
            {
                Console.WriteLine(" ");
                Console.WriteLine("You entered invalid value, please enter a number!");
                Start();
            }
            Selection = int.Parse(SelectionNumber);



            while (Selection != 0)
            {
                if (Selection > 3 || Selection < 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("You entered invalid value, please enter a number!");
                    Start();
                }
                else
                {
                    Selections();
                }
            };

            Console.WriteLine("Good Bye and Hava a Nice Day! ");
            Console.ReadLine();

        }

        public void Selections()
        {

            switch (Selection)
            {
                case 1:
                    Selection1();
                    break;

                case 2:
                    Selection2();
                    break;
                case 3:
                    Selection3();
                    break;
            }

            Start();
        }

        private void Selection1()
        {
            string age = Console.ReadLine();

            int selectionx = int.Parse(age);
            string result;

            if (selectionx < 20)
            {
                result = "Ungdomspris: 80kr";
                Console.WriteLine(result);
            }
            else if (selectionx > 64)
            {
                result = "Pensionärspris: 90kr";
                Console.WriteLine(result);
            }
            else
            {
                result = "Standardpris: 120kr";
                Console.WriteLine(result);
            }
        }

        private void Selection2()
        {

        }

        private void Selection3()
        {

        }
    }
}
