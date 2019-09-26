using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everybody");
        }

        public static bool IsOdd(int n)
        {
            if(n % 2 !=0)
            {
                return true;
            }
            return false;
        }
    }
}
