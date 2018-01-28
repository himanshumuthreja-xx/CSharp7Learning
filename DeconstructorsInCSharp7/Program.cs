using System;

namespace DeconstructorsInCSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(3,4);
            (float width, float height) = rect;
            Console.WriteLine($"Width is {width}");
            Console.WriteLine($"Height is {height}");
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        public readonly float Width, Height;
        public Rectangle(float width,float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width,out float height) //Deconstructor.
        {
            width = Width;
            height = Height;
        }
    }
}
