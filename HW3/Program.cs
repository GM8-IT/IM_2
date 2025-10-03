using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static int[] GetCF(string input)
        {
            int[] freq = new int[256];

            foreach (char c in input)
            {
                if (!char.IsWhiteSpace(c))
                {
                    freq[c]++;
                }
            }

            return freq;
        }

        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            int[] result = GetCF(input);

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] > 0)
                {
                    Console.WriteLine($"{(char)i} = {result[i]}");
                }
            }
            Console.ReadKey();
        }
    }


}
