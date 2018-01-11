using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter First Number");
            int firnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int secnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What opperation would you like to perform?");
            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Subtraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Divison");
            Console.WriteLine("5-Exit");
            Console.WriteLine("Please enter 1, 2, 3, 4, 5");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
            case 1:
            {
                Console.WriteLine(firnumber + secnumber);
                break;
            }
            case 2:
            {
                Console.WriteLine(firnumber - secnumber);
                        break;
            }
            case 3:
            {
                Console.WriteLine(firnumber * secnumber);
                        break;
            }
            case 4:
            {
                Console.WriteLine(firnumber % secnumber);
                        break;
            }
            case 5:
            {
                break;
            }
            default:
            {
                Console.WriteLine("Please use a valid Number");
                        break;
            }
        }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
            
           
        }

       }
    }

