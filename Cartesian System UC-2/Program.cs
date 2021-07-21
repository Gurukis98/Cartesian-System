using System;

namespace Cartesian_System_UC_2
{
   public class Program
    {
       public static void Main(string[] args)
        {
            //end points are not equal its print false 
            int x2 = 6;
            int y2 = 10;
            Console.WriteLine("End Points are: " + x2.Equals(y2));

            //end points are equal its print true
            int p2 = 6;
            int q2 = 6;
            Console.WriteLine("End Points are : " + p2.Equals(q2));
        }
    }
}
