using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huvudmeny
{
    class MainMenu
    {

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

            switch (Console.ReadLine())
            {
                case "1":
                    Selection1();
                    break;
                case "2":
                    Selection2();
                    break;
                case "3":
                    Selection3();
                    break;
                case "0":
                    Console.WriteLine("Good Bye and Hava a Nice Day! ");
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("You entered invalid value, please enter a number!");
                    Start();
                    break;
            }
        }

        private void Selection1()
        {

            Console.WriteLine("Enter Number of Guests");
            string num = Console.ReadLine();
            int Numberofguests;
            while (!int.TryParse(num, out Numberofguests))
            {
                Console.WriteLine("Enter valid value!");
                num = Console.ReadLine();
            }
            
            double totalcost=0;
            double costresult=0;
            

            for (int i = 0; i < Numberofguests; i++)
            {
                //AgeRange(cost);
                //calculations(totalcost,cost);
                totalcost = totalcost + AgeRange(costresult);

            }

            Console.WriteLine("Total cost = " + totalcost);
            Console.WriteLine("==========================");
            Console.WriteLine("==========================");
        }

        private void Selection2()
        {
            Console.WriteLine("Please enter any text: ");
            Console.WriteLine(" ");
            string x = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1) + "." + x + ", ");
            }
        }

        private void Selection3()
        {

        }

        public double AgeRange(double costresult)
        {
            Console.WriteLine("Please enter guest's age:");
            string age = Console.ReadLine();

            int selectionx = int.Parse(age);
            string result;

            if (selectionx < 20)
            {
                result = "Ungdomspris: 80kr";
                costresult = 80;
                Console.WriteLine(result);
            }
            else if (selectionx > 64)
            {
                result = "Pensionärspris: 90kr";
                costresult = 90;
                Console.WriteLine(result);
            }
            else
            {
                result = "Standardpris: 120kr";
                costresult = 120;
                Console.WriteLine(result);
            }

            return costresult;
        }
        //public double calculations(double totalcost, double cost)
        //{
        //    totalcost = totalcost + cost;
        //    return totalcost;
        //}    
        public double TotalCost()
        {



            return 0;
        }
    }
}
