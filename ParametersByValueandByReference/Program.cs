using System;
using System.Text;

namespace ParametersByValueandByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo(5);
            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString());
            int x = 8;
            Foo(ref x);
            Console.WriteLine($"x was changed by Foo() to {x}"); //x is now 9.
            Split("Himanshu Muthreja", out string firstName, out string lastName); /* In C# 7, we can declare a 
                                                                variable while passing it to a method.*/
            Console.WriteLine($"First Name is {firstName}");
            Console.WriteLine($"Last Name is {lastName}");
            Split("Himanshu Muthreja", out string first, out string _);//Discard Last Name
            Console.WriteLine(first);
            Console.WriteLine($"Sum is {Sum(1,2,3,4,5,6,7,8,9,10)}");// Can also be passed as new int[] {1,2,3,...}
            Console.ReadLine();
        }

        //Pass By Value
        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p); ;
        }

        //Pass By Reference
        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null; /*Because fooSB is a copy of reference, setting it null does not make sb null. (If, however,
                            fooSB was declared and called with ref modifier, sb would become null.)*/
        }

        //The ref modifier
        static void Foo(ref int p)
        {
            p += 1;
            Console.WriteLine($"x was 8, p changed it to {p}");
        }

        //The out modifier.
        static void Split(string name, out string firstName, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstName = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        //The params modifier.
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
