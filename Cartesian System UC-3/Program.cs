using System;

namespace Cartesian_System_UC_3
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int x1 = 4;
            int x2 = 6;
            int y1 = 8;
            int y2 = 6;
            //condition
            //5==5 is true (equal to)
            //6<3 is false (greater than)
            //8>4 is true (lesser than)

            Console.WriteLine("Line one: " + (x1 > y1));
            Console.WriteLine("Line Two: " + (x2 == y2));
        }
    }
}
