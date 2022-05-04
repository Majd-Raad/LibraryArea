using AreaLibraryTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "";
            while (res != "0")
            {
                Console.WriteLine("Enter 0 to  Exit\nEnter C for Circle\nEnter T for Triangle");
                res = Console.ReadLine();
                switch(res.ToLower())
                {
                    case "c":
                        {
                            try
                            {
                                Console.WriteLine("Enter Radius");
                                double radius = double.Parse(Console.ReadLine().Trim());
                                Console.WriteLine("Area of Circle  "+MathLibrary.ComputeArea(radius));
                            }
                            catch
                            {
                                Console.WriteLine("ERROR");
                            }
                            break;
                        }
                    case "t":
                        {
                            try
                            {
                                Console.WriteLine("Enter First Side");
                                double first = double.Parse(Console.ReadLine().Trim());
                                Console.WriteLine("Enter Second Side");
                                double second = double.Parse(Console.ReadLine().Trim());
                                Console.WriteLine("Enter Third Side");
                                double third = double.Parse(Console.ReadLine().Trim());
                                Console.WriteLine("Area of Triangle  " + MathLibrary.ComputeArea(first, second, third));
                            }
                            catch
                            {
                                Console.WriteLine("ERROR");
                            }
                            break;
                        }
                }
            }
        }
    }
}
