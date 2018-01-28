using System;
using static System.Console;

namespace SwitchStatementWithPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TellMeTheType(27);
            TellMeTheType("Himanshu");
            TellMeTheType('H');
            TellMeTheType(true);
            ReadLine();
        }

        static void TellMeTheType(object x)
        {
            switch (x)
            {
                case int i:
                    WriteLine("It's and int!");
                    WriteLine($"The square of {i} is {i*i}");
                    break;
                case string s:
                    WriteLine("It's a string");
                    WriteLine($"The length of {s} is {s.Length}");
                    break;
                case bool b when b == false:
                    Write("It's a boolean");
                    WriteLine($" and it's {b}");
                    break;
                case bool b:
                    WriteLine($"It's a boolean with value {b}");
                    break;
                default:
                    WriteLine("I don't know what x is");
                    break;
            }
        }
    }
}
