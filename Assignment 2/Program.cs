using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Ifesi", "Vicky", "Nnadozie", "Giddy", "Iruoma", };
            for (int i = names.Length-1; i >= 0; i--)
            {
                Console.WriteLine(@"The Last name in the array is " + names[i]);
                Console.WriteLine($"The number of names in the array is " + (i));
                break;
            }
            Console.ReadLine();
        }
    }
}
