using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Response (Day):");
            int day=Convert.ToInt32(Console.ReadLine());

            switch(day){
                case 1:{
                    Console.WriteLine("Shanbeh");
                    break;
                }
                case 2:{
                    Console.WriteLine("1Shanbeh");
                    break;
                }
                case 3:{
                    Console.WriteLine("2Shanbeh");
                    break;
                }
                case 4:{
                    Console.WriteLine("3Shanbeh");
                    break;
                }
                case 5:{
                    Console.WriteLine("4Shanbeh");
                    break;
                }
                case 6:{
                    Console.WriteLine("5Shanbeh");
                    break;
                }
                case 7:{
                    Console.WriteLine("Jomeh");
                    break;
                }
                default:{
                    Console.WriteLine("Invalid Day");
                    break;
                }

                Console.ReadKey();
            }

            Console.Clear();

            for (int f = 0; f <= 5; f++)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}
