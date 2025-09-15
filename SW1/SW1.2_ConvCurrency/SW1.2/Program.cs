using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter currency in ($): ");
            String input = Console.ReadLine();
            String[] s1 = input.Split(',');

            Console.WriteLine();
            Console.WriteLine("Dollar($)       Phil Peso(P)     Jpn Yen (Y)");
            Console.WriteLine("--------------------------------------------");

            foreach (String s2 in s1)
            {
                if(int.TryParse(s2, out int num)) {
                    decimal peso = DtoP(num);
                    decimal yen = DtoY(num);

                    Console.WriteLine($"${num}          P{Math.Round(peso,2)}          ¥{Math.Floor(yen)}");
                }else{
                    Console.WriteLine($"Invalid input: '{num}'");
                }
            }
            Console.ReadKey();
        }
        static decimal DtoP(decimal num)
        {
            return num * 57.16m;
        }
        static decimal DtoY(decimal num)
        {
            return num * 147.67m;
        }
    }
}
