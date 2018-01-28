using System;

namespace LocalMethods
{
    class Program
    {
        public string name;
        public Program(string n) => name = n; 
        static void Main(string[] args)
        {
            Console.WriteLine("Writing cubes using local methods!");
            WriteCubes();
            Console.ReadLine();
        }

        static void WriteCubes()
        {
            Console.WriteLine($"Cube of 3 is {Cube(3)}");
            Console.WriteLine($"Cube of 4 is {Cube(4)}");
            Console.WriteLine($"Cube of 5 is {Cube(5)}");
            int Cube(int number) => number * number * number;
        }
    }
}
