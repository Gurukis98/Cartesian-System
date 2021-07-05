using System;

namespace Cartesian_System_UC_1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int x1 = 4;
            int x2 = 6;
            int y1 = 8;
            int y2 = 10;
            Console.WriteLine("Point One: " + (x1,y1));
            Console.WriteLine("Point Two: " + (x2, y2));
            Console.WriteLine("Length of a Line: " + Math.Sqrt((x2-x1)^2 + (y2-y1)^2));
        }
    }
}
