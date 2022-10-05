using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days_OfTheWeekSwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            //Enter a Number
            Console.Write("Enter Number: ");
            int Day = Convert.ToInt32(Console.ReadLine());
    
            switch(Day)
            {
                default:
                    Console.WriteLine("Enter a Valid Number!");
                    break;
                    case 0:
                    Console.WriteLine("Sunday");
                    break;
                    case 1:
                    Console.WriteLine("Moday");
                    break;
                    Case2:
                        Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
            //Exit the program
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}
