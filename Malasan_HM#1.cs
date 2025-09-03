using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("\nEnter string: ");
            string input = Console.ReadLine();

            if (input == "*")
                break;

            string original = input;
            string lowerInput = input.ToLower();
            string reversed = "";

            for (int i = lowerInput.Length - 1; i >= 0; i--)
            {
                reversed += lowerInput[i];
            }

            string result = (lowerInput == reversed) ? "Yes" : "No";

            Console.WriteLine("\nOriginal String         Reversed String            Palindrome?");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine(original.PadRight(25) + reversed.PadRight(25) + result);
        }

        Console.WriteLine("\n\n//End execution");
    }
}