using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 120;
            Console.WriteLine("Original number: " + n);
            Console.WriteLine("Next prime number: " + test(n));
        }
        public static int test(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) { n++; i = 2; }
            }
            return n;
        }
    }
}