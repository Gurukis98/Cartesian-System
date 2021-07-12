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
            double pow = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            Console.WriteLine("Power = " + pow);
            Console.WriteLine("Length of a Line: " + Math.Sqrt(pow));       
       }
    }
}
