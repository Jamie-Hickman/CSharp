using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 5000;
            string iterable_input = Convert.ToString(input);
            int total = 0;

            foreach (char letter in iterable_input)
            {
                total = total + (letter -48);



            }


            Console.WriteLine(total);

        }
    }
}
