using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("Enter String: ");
            String input = Console.ReadLine();
            String[] sp1 = input.Split(' ');

            foreach (String sp2 in sp1)
            {
                if (int.TryParse(sp2, out int number) && number > 1)
                {
                    counter++;
                    if (Checker(number))
                    {
                        Console.WriteLine($"{counter}. {number} Prime");
                    }
                    else
                    {
                        Console.WriteLine($"{counter}. {number} Composite");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            Console.ReadKey();
        }
        static bool Checker(int num)
        {
            if (num <= 1) return false;
                for(int i=2; i <= Math.Sqrt(num); i++)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
            return true;
        }
    }
}
