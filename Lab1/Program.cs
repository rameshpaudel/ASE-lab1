using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter your age : ");
            string rawAge = Console.ReadLine();
            int age = Convert.ToInt32(rawAge);

            Console.WriteLine("Hello {0}, you are {1} years old", name, age);

        }
    }
}
