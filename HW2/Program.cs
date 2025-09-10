using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row: ");
            double rows = double.Parse(Console.ReadLine());

            Console.Write("Enter column: ");
            double cols = double.Parse(Console.ReadLine());

            List<List<double>> numbers = new List<List<double>>();

            double sum = 0;
            int count = 0;


            for (int i=0; i < rows; i++)
            {
                Console.WriteLine("Rows: " + (i + 1));
                List<double> row = new List<double>();

                for(int j=0; j < cols; j++)
                {
                    Console.WriteLine("Enter a number " + (j + 1));
                    double num = double.Parse(Console.ReadLine());

                    row.Add(num);
                    sum += num;
                    count += 1;
                }
                numbers.Add(row);
            }
            double average = sum / count;
            Console.WriteLine("The numbers are: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers[i].Count; j++)
                {
                    Console.Write(numbers[i][j].ToString("0.0") + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.ReadLine();
        }

    }
}
