using System;

namespace RefLocalsandRefReturns
{
    class Program
    {
        static string X = "Old Value";

        static void Main(string[] args)
        {
            ref string xRef = ref GetX();
            xRef = "New Value"; // It also changes X to "New Value".
            Console.WriteLine($"Value of X is now {X}");
            Console.WriteLine("Hello World!");
        }

        static ref string GetX() => ref X; //ref Returns.
    }
}
