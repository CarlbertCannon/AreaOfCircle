using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with the radius of {r} is {areaOfCircle}");
        }
    }
}
