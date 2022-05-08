using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Ifesi", "Gideon", "Iruoma", "Victory" };
            Console.WriteLine("The reversed names are: ");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{names[i]}");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Normal order in the Array are: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
